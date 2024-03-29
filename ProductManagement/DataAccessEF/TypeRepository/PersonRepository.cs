﻿using Domain.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.TypeRepository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(PeopleContext context) : base(context) { }
        IEnumerable<Person> IPersonRepository.GetAdultPersons()
        {
            return context.Person.Where(pers => pers.Age >= 18).ToList();
        }
    }
}
