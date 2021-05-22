using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Persons
{
    public class Person
    {
        private string givenname1, givenname2, givenname3, lastname;

        public  Person (string Name)
        {

        //split the sentence into word
            string[] strings = Regex.Split(Name, @"\W|_");

            //assign given and last name per person
            if (strings.Length==2)
            {
                this.givenname1 = strings[0];
                this.givenname2 = "";
                this.givenname3 = "";
                this.lastname = strings[1];
            }           
            else  if (strings.Length==3)
            {
                this.givenname1 = strings[0];
                this.givenname2 = strings[1];
                this.givenname3 = "";
                this.lastname = strings[2];
            }
            else
            {                
                this.givenname1 = strings[0];
                this.givenname2 = strings[1];
                this.givenname3 = strings[2];
                this.lastname = strings[3];
            }
      
            
        }

        public static List<string> SortedName (List<Person> ListPerson)
        {     
            List<string> SortedName =new List<string> ();

            //sorting name using LINQ
            ListPerson = ListPerson.OrderBy(x => x.LastName).ThenBy(x => x.GivenName1).
                        ThenBy(x => x.GivenName2).ThenBy(x => x.GivenName3).ToList();

            foreach (var item in ListPerson)
            {
                string FullName;

                if (item.GivenName2=="")
                {
                    FullName = item.GivenName1 + " " + item.LastName;
                }
                else if (item.GivenName3=="")
                {
                    FullName = item.GivenName1 + " " + item.GivenName2  + " " + item.LastName;
                }
                else
                {
                    FullName = item.GivenName1 + " " + item.GivenName2 + " " + item.GivenName3 + " " + item.LastName;
                }

                SortedName.Add(FullName);
            }
            return SortedName;
                          
        }

    public string GivenName1
    {
        get { return givenname1; }
        set { givenname1 = value;}
    }

     public string GivenName2
    {
        get { return givenname2; }
        set { givenname2 = value; }
    }

    public string GivenName3
    {
        get { return givenname3; }
        set { givenname3 = value; }
    }

    public string LastName
    {
        get { return lastname; }
        set { lastname = value; }
    }

       
    
}   




}
