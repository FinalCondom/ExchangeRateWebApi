
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CurrencyManager
    {
        private Model1Container context;

        public CurrencyManager()
        {
            context = new Model1Container();
        }

        //Return all Currencies of the database
        public List<Currency> getAllCurrencies()
        {
            List<Currency> res = new List<Currency>();

            var q = from currency in context.Currencies
                    select currency;

            foreach (Currency currency in q)
            {
                res.Add(currency);
            }

            return res;
        }

        //Return a currency according to its id
        public Currency getSingleCurrency(int id)
        {
            var q = from currency in context.Currencies
                    where currency.Id == id
                    select currency;

            return q.FirstOrDefault();
        }

        //add a new currency to the DB
        public void addCurrency (Currency currency)
        {
            context.Currencies.Add(currency);
        }

        //update a currency of the DB
        public void updateCurrency(Currency currency)
        {
            context.Currencies.Find(currency.Id).Name = currency.Name;
            context.Currencies.Find(currency.Id).Statut = currency.Statut;
            context.Currencies.Find(currency.Id).Value = currency.Value;

            context.SaveChanges();
        }

        //Delete a currency of the DB
        public void deleteCurrency(int id)
        {
            context.Currencies.Remove(context.Currencies.Find(id));
        }
    }
}
