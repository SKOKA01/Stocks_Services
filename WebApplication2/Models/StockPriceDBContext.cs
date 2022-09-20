using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication2.Models
{
    public class StockPriceDBContext :DbContext
    {
        public StockPriceDBContext(DbContextOptions<StockPriceDBContext> options) :base(options)
        {

        }

        public DbSet<Stock_Price_List> Stock_Price_List { get; set; }

    }
}
