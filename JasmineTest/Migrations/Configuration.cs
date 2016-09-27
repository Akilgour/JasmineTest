namespace JasmineTest.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JasmineTest.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JasmineTest.Models.ApplicationDbContext context)
        {
            context.SaleHeaders.AddOrUpdate(x => x.SaleHeaderId,

            new SaleHeader() { SaleHeaderId = 1, Address = "1 Aye Ave", CustomerFirstName = "Arther", CustomerSecondName = "Artherson" },

            new SaleHeader() { SaleHeaderId = 2, Address = "2 Bee Boulevard", CustomerFirstName = "Bert", CustomerSecondName = "Bertson" },

            new SaleHeader() { SaleHeaderId = 3, Address = "3 Sea Crescent", CustomerFirstName = "Carl", CustomerSecondName = "Carlson" }

            );



            context.SaleItems.AddOrUpdate(x => x.SaleItemId,

            new SaleItem() { SaleItemId = 1, Title = "Item A", Quantity = 1, CostPerItem = 2, SaleHeaderId = 1 },

            new SaleItem() { SaleItemId = 2, Title = "Item B", Quantity = 3, CostPerItem = 4, SaleHeaderId = 1 },

            new SaleItem() { SaleItemId = 3, Title = "Item C", Quantity = 5, CostPerItem = 6, SaleHeaderId = 1 },

            new SaleItem() { SaleItemId = 4, Title = "Item D", Quantity = 7, CostPerItem = 8, SaleHeaderId = 2 }

            );
        }
    }
}
