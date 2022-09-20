using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Price_List.Models
{
    public interface IStockPriceRegistry
    {
        List<Stock_Price_List> GetAllStockPrice();
        List<Stock_Price_List> GetStockPriceByCompany(int CompanyCode,DateTime Startdate, DateTime enddate);
        Stock_Price_List GetCurrentStockPriceByCompany(int CompanyCode);
        Stock_Price_List AddStockPrice(Stock_Price_List StockDetail);

        void UpdateStockPrice(Stock_Price_List UpdateDetail);
        void DeleteStockPrice(int CompanyCode);




    }
}
