namespace ExchangeRate.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    internal sealed class Configuration : DbMigrationsConfiguration<ExchangeRate.Models.ExchangeRateEFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExchangeRate.Models.ExchangeRateEFContext context)
        {
            context.Currencies.AddOrUpdate(
                c => c.Id,
                new Models.Currency { Id = 1, Name ="YEN", Statut ="Decreasing", Value = 115.00 },
                new Models.Currency { Id = 2, Name = "Crown", Statut = "Decreasing", Value = 113.00 },
                new Models.Currency { Id = 3, Name = "rouble", Statut = "Decreasing", Value = 0.95 },
                new Models.Currency { Id = 4, Name = "CAD", Statut = "Decreasing", Value = 0.25 }
            );
        }
    }
}
