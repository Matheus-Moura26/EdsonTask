

using Microsoft.AspNetCore.Mvc;
using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FinanceManager.Application.AppService;

public class PersonAppService(PersonRepository personRepository)
{
    public async Task<Person?> Get(int id)
    {
        var _person = personRepository.GetByIdAsync(id);

        return await _person;
    }

    public async Task<List<Person>> GetAll()
    {
        return await personRepository.GetAllAsync();
    }

    public async Task<Person?> Delete(int id)
    {
        var person = await personRepository.GetByIdAsync(id);
        await personRepository.DeleteAsync(person);
        return person;
    }

    public async Task<Person> Create(Person person)
    {
        await personRepository.AddAsync(person);
        return await personRepository.GetByIdAsync(person.PersonId);
    }
    
    
    public async Task<Person?> Update(int id, Person updatedPerson)
    {
        var existingPerson = await personRepository.GetByIdAsync(id);
        if (existingPerson == null)
            return null;
        
        existingPerson.FirstName = updatedPerson.FirstName;
        existingPerson.LastName = updatedPerson.LastName;
        existingPerson.Email = updatedPerson.Email;
        existingPerson.Phone = updatedPerson.Phone;
        existingPerson.Password = updatedPerson.Password;

        await personRepository.UpdateAsync(existingPerson);
        return existingPerson;
    }

    
}


