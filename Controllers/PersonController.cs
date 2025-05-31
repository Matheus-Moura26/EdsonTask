

using Microsoft.AspNetCore.Mvc;
using PersonManager.Models;

namespace Controller.Persons;

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PersonController : ControllerBase
    {
        public static List<Person> _persons = new List<Person>();

        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return Ok(_persons);
        }

        [HttpPost]
        public ActionResult<Person> Create([FromBody] Person person)
        {
            person.PersonId = _persons.Count + 1;
            _persons.Add(person);

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

    
