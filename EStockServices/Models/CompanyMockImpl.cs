using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStockServices.Models
{
    public class CompanyMockImpl : IStocksRegistry
    {

        private static List<Stock_Company> Companies;
        private int count = 3;

        public CompanyMockImpl()
        {
            Companies = new List<Stock_Company>();
            Companies.Add(new Stock_Company() { CompanyCode = 1, CompanyName = "Mark", CompanyWebsite = "m@gmail.com" });
            Companies.Add(new Stock_Company() { CompanyCode = 2, CompanyName = "Paul", CompanyWebsite = "p@gmail.com" });
            Companies.Add(new Stock_Company() { CompanyCode = 3, CompanyName = "Watson", CompanyWebsite = "w@gmail.com" });
        }
        public Stock_Company AddCompany(Stock_Company CompanyInfo)
        {
            CompanyInfo.CompanyCode = ++count;
            Companies.Add(CompanyInfo);
            return CompanyInfo;
        }

        public void DeleteCompany(int CompanyCode)
        {
            Stock_Company Company = GetCompanyInfo(CompanyCode);
            Companies.Remove(Company);
        }

        public List<Stock_Company> GetAllCompany()
        {
            return Companies;
        }

        public Stock_Company GetCompanyInfo(int CompanyCode)
        {
            return Companies.FirstOrDefault(comp => comp.CompanyCode == CompanyCode);
        }

        public void UpdateCompany(Stock_Company CompanyInfo)
        {
            throw new NotImplementedException();
        }
    }
}
