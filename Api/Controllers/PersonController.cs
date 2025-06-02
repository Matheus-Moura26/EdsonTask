

using FinanceManager.Application.AppService;
using FinanceManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controller.Persons;

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
        public ActionResult<Person> Create([FromBody] Person person)
        {
           var result = personAppService.Create(person)

            return CreatedAtAction(nameof(GetAll), new { id = person.PersonId }, person);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var person = _persons.FirstOrDefault(p => p.PersonId == id);

            if (person == null)
            {
                return NotFound("Pessoa não encontrada");
            }

            _persons.Remove(person);
            return Ok("Pessoa deletada com sucesso");
        }
    }

    
