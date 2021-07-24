using System;
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

        public void RetrivePersonAgeLessThan60()
        {
            //retrive the top two person detail from the list whose age is less tha 10;
            List<PersonDetails> list = personList.FindAll(person => person.age < 60).OrderBy(x=>x.age).Take(2).ToList();
            Console.WriteLine("\nRetriving the top 2 person from list whose age less than 60 ");
            DisplayList(list);
        }
        public void RetrivePersonAgeBetween13And18()
        {
            //retrive the top two person detail from the list whose age is between 13 and 18
            List<PersonDetails> list = personList.FindAll(person => person.age > 13 && person.age < 18);
            Console.WriteLine("\nRetriving the top 2 person from list whose age between 13 and 18: ");
            DisplayList(list);
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
