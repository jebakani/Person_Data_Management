﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class DataManagement
    {
        List<PersonDetails> personList = new List<PersonDetails>();
        //creating the list of person with name age address and id 
        public void CreateList()
        {
            personList.Add(new PersonDetails(1, "ram", "madurai", 15));
            personList.Add(new PersonDetails(2, "dev", "chennai", 29));
            personList.Add(new PersonDetails(6, "ajay", "trichy", 20));
            personList.Add(new PersonDetails(9, "jenni", "madurai", 38));
            personList.Add(new PersonDetails(5, "arun", "chennai", 19));
            personList.Add(new PersonDetails(4, "kai", "madurai", 28));
            personList.Add(new PersonDetails(7, "abc", "chennai", 64));
            DisplayList(personList);
        }
        //method to display the list
        public void DisplayList(List<PersonDetails> list)
        {
            foreach(var i in list)
            {
                Console.WriteLine("SSN:{0}  Name:{1}  Address:{2}  Age:{3}",i.SSN,i.name,i.address,i.age);
            }
        }
    }
}