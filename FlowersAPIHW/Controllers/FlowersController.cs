using FlowersAPIHW.Controllers.Model;
using FlowersAPIHW.DB.Models;
using FlowersAPIHW.DB.Repositories;
using FlowersAPIHW.Extensions.cs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlowersAPIHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        private readonly FlowersRepository repo;

        public FlowersController(FlowersRepository repo)
        {
            this.repo = repo;
        }

        [HttpPost("")]
        public async Task<ActionResult<FlowerModel>> Post([FromBody]FlowerModel flower)
        {
            return Ok((await repo.Add(flower.ToFlowerItem())).ToFlowerModel());
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<FlowerModel>> Get()
        {
            return Ok(repo.GetAll().ToFlowerModelList());
        }
        [HttpGet("{id:int}")]
        public ActionResult<IEnumerable<FlowerModel>> Get(int id)
        {
            return Ok(repo.GetFlowerById(id).ToFlowerModel());
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<FlowerModel>> Put(int id, [FromBody] FlowerModel flower)
        {
            await repo.Update(flower.ToFlowerItem(), id);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<FlowerModel>> Delete(int id)
        {   
            return Ok((await repo.Remove(id)).ToFlowerModel());
        }

    }
}
