using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class PersonService {
    private readonly IPersonRepository _personRepository;
    public PersonService(IPersonRepository personRepository) {
        _personRepository = personRepository;
    }

    public PersonGetByIdResponse GetById(Guid guid) {
        var person = _personRepository.GetById(guid);
        //TODO: Map one entity to another (AutoMapper)
    }
}