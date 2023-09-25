﻿using DesignPatterns.Builder.BuilderInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.FacetedBuilder
{
    public class PersonBuilder // facade 
    {
        // the object we're going to build
        protected Person person = new Person(); // this is a reference!

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}
