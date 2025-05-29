

using Microsoft.AspNetCore.Mvc;
using FinanceManager.Models;

namespace FinanceManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private static List<Person> _persons = new List<Person>();
        
        [HttpGet]
        private ActionResult<IEnumerable<Person>> GetAll()
        {
            return Ok(_persons);
        }

        [HttpPost]
        private ActionResult<Person> Create([FromBody] Person person)
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
}