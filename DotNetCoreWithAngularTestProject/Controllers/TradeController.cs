using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWithAngularTestProject.Interface;
using DotNetCoreWithAngularTestProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWithAngularTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : Controller
    {
        private ITradeService _service;
        public TradeController(ITradeService service)
        {
            _service = service;
        }
        // GET: api/Trade
        [HttpGet]
        public IEnumerable<Trade> Get()
        {
            return _service.GetList();
        }

        // GET: api/Trade/5
        [HttpGet, Route("getTradeById/{id}")]
        public Trade Get(int id)
        {
            return _service.GetById(id);
        }

        // POST: api/Trade
        [HttpPost]
        public ActionResult Post([FromBody] Trade trade)
        {
            return Ok(_service.Save(trade));
        }

        // PUT: api/Trade/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
