using EStockServices.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStockServices.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private IStocksRegistry _repository;
        public StocksController(IStocksRegistry repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllCompany();
            return Ok(data);
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int code)
        {
            var data = _repository.GetCompanyInfo(code);
            if (data == null)
                return NotFound("no record found with id = " + code);
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(Stock_Company Company)
        {
            var data = _repository.AddCompany(Company);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host
              + "/" + HttpContext.Request.Path + "/" + Company.CompanyCode, data);
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int code)
        {
            _repository.DeleteCompany(code);
            return Ok("record deleted successfully");
        }
        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(Stock_Company company)
        {
            _repository.AddCompany(company);
            return Ok("record updated successfully");
        }
    }


}
