using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EStockServices.Models
{
    public class Stock_Company
    {
        [Key]
        public int Stock_CompanyId { get; set; }

        public int CompanyCode { get; set; }

        public string CompanyName { get; set; }

        public string CompanyCEO { get; set; }

        public int CompanyTurnOver { get; set; }

        public string CompanyWebsite { get; set; }

        public string StockExchange { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime Update_TS { get; set; }

        public string status { get; set; }

    }
}
