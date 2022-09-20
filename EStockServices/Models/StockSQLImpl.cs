using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStockServices.Models
{

    public class StockSQLImpl : IStocksRegistry
    {
        private readonly StockDbContext _context;
        public StockSQLImpl(StockDbContext context)
        {
            _context = context;
        }
        public Stock_Company AddCompany(Stock_Company CompanyInfo)
        {
            _context.Stock_Company.Add(CompanyInfo);
            _context.SaveChanges();
            return CompanyInfo;
        }
        public void DeleteCompany(int CompanyCode)
        {
            Stock_Company company = GetCompanyInfo(CompanyCode);
            _context.Stock_Company.Remove(company);
            _context.SaveChanges();
        }
        public List<Stock_Company> GetAllCompany()
        {
            return _context.Stock_Company.ToList();
        }
        public Stock_Company GetCompanyInfo(int CompanyCode)
        {
            return _context.Stock_Company.FirstOrDefault(emp => emp.CompanyCode == CompanyCode);
        }
        public void UpdateCompany(Stock_Company CompanyInfo)
        {
            throw new NotImplementedException();
        }
    }


}
