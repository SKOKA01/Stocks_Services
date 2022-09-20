using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStockServices.Models
{
    public interface IStocksRegistry
    {
        List<Stock_Company> GetAllCompany();
        Stock_Company GetCompanyInfo(int CompanyCode);
        Stock_Company AddCompany(Stock_Company CompanyInfo);
        void UpdateCompany(Stock_Company CompanyInfo);
        void DeleteCompany(int CompanyCode);


    }
}
