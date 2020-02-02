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
    public class LevelController : Controller
    {
        private ILevelService _service;
        public LevelController(ILevelService service)
        {
            _service = service;
        }
        // GET: api/Level
        [HttpGet]
        public IEnumerable<Level> Get()
        {
            return _service.GetList();
        }
        // GET: api/Level/GetListByTradeId
        [HttpGet, Route("GetListByTradeId/{id}")]
        public IEnumerable<Level> GetListByTradeId(int Id)
        {
            return _service.GetListByTradeId(Id);
        }

        // GET: api/Level/5
        [HttpGet, Route("getLevelById/{id}")]
        public Level Get(int id)
        {
            return _service.GetById(id);
        }

        // POST: api/Level
        [HttpPost]
        public ActionResult Post([FromBody] Level level)
        {
            return Ok(_service.Save(level));
        }

        //// PUT: api/Level/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
