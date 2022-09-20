using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Price_List.Models
{
    public class StockPriceSQLImp : IStockPriceRegistry
    {
        private readonly StockPriceDBContext _context;

        public StockPriceSQLImp(StockPriceDBContext context)
        {
            _context = context;
        }

        public Stock_Price_List AddStockPrice(Stock_Price_List StockDetail)
        {
            try
            {
                _context.Stock_Price_Details.Add(StockDetail);
                _context.SaveChanges();
                return StockDetail;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public void DeleteStockPrice(int CompanyCode)
        {
            try
            {
                List<Stock_Price_List> stock_price = GetStockPriceByCompany(CompanyCode, default(DateTime), default(DateTime));
                for (int i = 0; i < stock_price.Count; i++)
                {
                    _context.Stock_Price_Details.Remove(stock_price[i]);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Stock_Price_List> GetAllStockPrice()
        {
            return _context.Stock_Price_Details.ToList();
        }

        public Stock_Price_List GetCurrentStockPriceByCompany(int CompanyCode)
        {
            Stock_Price_List stockprice = _context.Stock_Price_Details.OrderByDescending(x => x.Updated_On).Where(stock => stock.Company_Code == CompanyCode).FirstOrDefault();
            return stockprice;
        }

        public List<Stock_Price_List> GetStockPriceByCompany(int CompanyCode, DateTime Startdate, DateTime enddate)
        {
            List<Stock_Price_List> Stock_Price_details;
            if(Startdate ==default(DateTime) && enddate==default(DateTime))
            {
                Stock_Price_details = _context.Stock_Price_Details.Where(x => x.Company_Code == CompanyCode).ToList();
            }
            else
            {
                Stock_Price_details = _context.Stock_Price_Details.Where(x => x.Company_Code == CompanyCode && x.Updated_On >=Startdate && x.Updated_On <=enddate).ToList();
            }
            return Stock_Price_details;
        }

        public void UpdateStockPrice(Stock_Price_List UpdateDetail)
        {
            throw new NotImplementedException();
        }
    }
}
