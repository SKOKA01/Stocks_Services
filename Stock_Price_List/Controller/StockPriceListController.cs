using Microsoft.AspNetCore.Mvc;
using Stock_Price_List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Price_List.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class StockPriceListController : ControllerBase
    {
        private IStockPriceRegistry _repository;

        public StockPriceListController(IStockPriceRegistry repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllStockPrice();
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{code}/{startdate}/{enddate}")]
        public IActionResult Get(int code, string startdate, string enddate)
        {
            DateTime start_date = Convert.ToDateTime(startdate);
            DateTime end_date = Convert.ToDateTime(enddate);
            var data = _repository.GetStockPriceByCompany(code, start_date, end_date);
            if (data == null)
                return NotFound("no record found with id = " + code);
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{code}")]
        public IActionResult Get(int code)
        {

            var data = _repository.GetCurrentStockPriceByCompany(code);
            if (data == null)
                return NotFound("no record found with id = " + code);
            return Ok(data);
        }


        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(Stock_Price_List.Models.Stock_Price_List Company)
        {
            var data = _repository.AddStockPrice(Company);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host
                + "/" + HttpContext.Request.Path + "/" + Company.Company_Code, data);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int code)
        {
            _repository.DeleteStockPrice(code);
            return Ok("record deleted successfully");
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(Stock_Price_List.Models.Stock_Price_List company)
        {
            _repository.AddStockPrice(company);
            return Ok("record updated successfully");
        }
    }
}
