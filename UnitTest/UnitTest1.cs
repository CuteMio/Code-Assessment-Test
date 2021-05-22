using System;
using Xunit;
using System.Collections.Generic;
using Persons;

namespace UnitTest
{
    public class UnitTest1
    {
        
        private List<Person> Person =new List<Person> ();
        private string result;

        [Fact]
        public void Test_GetGivenName1()
        {           
            Person.Add(new Person("Leonerd Adda Mitchell Monaghan"));
            
            foreach (var item in Person)
            {
                result = item.GivenName1;
            }
                
            Assert.Equal("Leonerd", result); 
        }

        [Fact]
        public void Test_GetGivenName2()
        {           
            Person.Add(new Person("Leonerd Adda Mitchell Monaghan"));
            
            foreach (var item in Person)
            {
                result = item.GivenName2;
            }
                
            Assert.Equal("Adda", result); 
        }

        [Fact]
        public void Test_GetGivenName3()
        {           
            Person.Add(new Person("Leonerd Adda Mitchell Monaghan"));
            
            foreach (var item in Person)
            {
                result = item.GivenName3;
            }
                
            Assert.Equal("Mitchell", result); 
        }

        [Fact]
        public void Test_GetLastName()
        {           
            Person.Add(new Person("Leonerd Adda Mitchell Monaghan"));
            
            foreach (var item in Person)
            {
                result = item.LastName;
            }
                
            Assert.Equal("Monaghan", result); 
        }

        
    }
}
