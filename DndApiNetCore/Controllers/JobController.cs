using Businness.Services.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        readonly IJobService _service;
        public JobController(IJobService service)
        {
            _service = service;
        }

        #region Crud

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.GetSingle(id));
        }

        [HttpGet]
        public IActionResult Get(string order)
        {
            return Ok(_service.GetOrderBy(order));
        }

        [HttpGet]

        public IActionResult Get(string order, int pag, int elements)
        {
            return Ok(_service.GetPaginate(order, pag, elements));
        }

        [HttpPost]
        public IActionResult Insert(JobDto entity)
        {
            return Ok(_service.Insert(entity));
        }
        [HttpPost]
        public IActionResult Insert(IEnumerable<JobDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IActionResult Update(JobDto entity)
        {
            return Ok(_service.Update(entity));
        }
        [HttpPut]
        public IActionResult Update(IEnumerable<JobDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Delete(id));
        }
        [HttpDelete]
        public IActionResult Delete(IEnumerable<int> ids)
        {
            return Ok(_service.Delete(ids));
        }

        #endregion
    }
}
