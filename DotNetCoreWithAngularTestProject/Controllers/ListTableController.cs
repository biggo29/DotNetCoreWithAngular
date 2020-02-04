using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWithAngularTestProject.Interface;
using DotNetCoreWithAngularTestProject.Model;
using DotNetCoreWithAngularTestProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWithAngularTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListTableController : ControllerBase
    {
        private IListTableService _listTableService;
        public ListTableController(IListTableService listTableService)
        {
            _listTableService = listTableService;
        }
        // GET: api/ListTable
        [HttpGet]
        public IEnumerable<ListTable> Get()
        {
            return _listTableService.GetList();
        }

        // GET: api/ListTable/GetTradeList
        [HttpGet, Route("GetTradeList")]
        public IEnumerable<Trade> GetTradeList()
        {
            return _listTableService.GetTradeList();
        }

        // GET: api/ListTable/GetLevelListByTradeId/1
        [HttpGet, Route("GetLevelListByTradeId/{id}")]
        public IEnumerable<Level> GetLevelListByTradeId(int Id)
        {
            return _listTableService.GetLevelListByTradeId(Id);
        }

        // GET: api/ListTable/GetListTableById/1
        [HttpGet, Route("GetListTableById/{id}")]
        public ListTable GetListTableById(int id)
        {
            return _listTableService.GetById(id);
        }
        // POST: api/ListTable
        [HttpPost, DisableRequestSizeLimit]
        public ActionResult Post()
        {
            //var fileObject = listTableFileUpload.file;
            
            if (Request.Form.Files["fSyllabus"] !=null) 
            {
                var file = Request.Form.Files["fileName"]; 
     
            }

            return Ok();
            //return Ok(_listTableService.Save());
        }

        //// PUT: api/ListTable/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _listTableService.Delete(id);
        }
    }
}
