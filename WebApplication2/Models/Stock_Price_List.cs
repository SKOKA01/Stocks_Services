using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Stock_Price_List
    {
        [Key]
        public int Stock_Price_ID { get; set; }
        public int Company_Code { get; set; }
        public string Company_Name { get; set; }
        public int Stock_Price { get; set; }
        public DateTime Updated_On { get; set; }
        public string Updated_By { get; set; }

    }
}
