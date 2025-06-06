

using FinanceManager.Application.AppService;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers.Persons;

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PersonController(PersonAppService personAppService) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<Person>> Get(int id)
        {
            var person = await personAppService.Get(id);

            if (person == null)
            {
                return NoContent();
            }
            return Ok(person);
        }


        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAll()
        {
        var people = await personAppService.GetAll();

        if (people == null)
        {
            return NoContent();
        }
        return Ok(people);
        }

        
        [HttpPost]
        public async Task<ActionResult<Person>> Create([FromBody] Person person)
        {
            var result = await personAppService.Create(person);

            return CreatedAtAction(nameof(GetAll), new { id = person.PersonId }, person);
        }

        
        [HttpDelete]
        public async Task<ActionResult<Person>> Delete(int id)
        {
            var person = await personAppService.Get(id);

            if (person == null)
            {
                return NotFound("Pessoa não encontrada");
            }

            personAppService.Delete(person.PersonId);
            return Ok("Pessoa deletada com sucesso");
        }

    [HttpPut]
    public async Task<ActionResult<Person>> Update(int id, [FromBody] Person person)
    {
        var updatingPerson = personAppService.Get(id);

        if (updatingPerson == null)
            return NoContent();

        await personAppService.Update(id, person);
        return Ok();
    }
    }
