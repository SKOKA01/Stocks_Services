using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Stock_Price_List.Models
{
    public class StockPriceDBContext :DbContext
    {
        public StockPriceDBContext(DbContextOptions<StockPriceDBContext> options) :base(options)
        {

        }

        public DbSet<Stock_Price_List> Stock_Price_Details { get; set; }

    }
}
