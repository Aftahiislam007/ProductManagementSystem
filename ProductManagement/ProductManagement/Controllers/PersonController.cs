using Domain.Interfaces;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PersonController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return unitOfWork.Person.GetAll();
        }

        [Route("[action]")]
        [HttpGet]
        public IEnumerable<Person> GetAdultPersons()
        {
            return unitOfWork.Person.GetAdultPersons();
        }
    }
}
