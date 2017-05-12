using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExchangeRate.Models;

namespace ExchangeRate.Controllers
{
    public class CurrencyController : ApiController
    {
        private static List<Currency> currencies = new List<Currency>{
            new Currency { Id = 1, Name = "USD", Value = 1.000000, Statut = "Stable"},
            new Currency { Id = 2, Name = "EUR", Value = 0.915573, Statut = "Decreasing"},
            new Currency { Id = 3, Name = "CHF", Value = 0.994461, Statut = "Increasing"}
        };

        public IEnumerable<Currency> getAllCurrencies()
        {
            return currencies;
        }

        public IHttpActionResult GetCurrency(int id)
        {
            var currency = currencies.FirstOrDefault((c) => c.Id == id);
            if (currency == null)
            {
                return NotFound();
            }
            return Ok(currency);
        }

        [HttpPost]
        public void postCurrency([FromBody] Currency c)
        {
            currencies.Add(c);
        }

        [HttpPut]
        public void putCurrency([FromBody] Currency c)
        {
            currencies[currencies.FindIndex(ind => ind.Id == c.Id)] = c;
        }   

        [HttpDelete]
        public void deleteCurrency(int id)
        {
            currencies.RemoveAt(id);
        }
    }
}
