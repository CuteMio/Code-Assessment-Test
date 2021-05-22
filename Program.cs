using System;
using System.Collections.Generic;
using System.Linq;
using Persons;


namespace CodeAssessmentTest
{
    class Program
    {
        public static void Main()
        {
            try
            {                       
                File file = new File();
                List<string> ErrorList =file.FileCheck();                
                 
                //check if the file has a name that hasn't meet a criteria, if true print out the that name else continue
                if (ErrorList.Count>0)
                {
                    Console.WriteLine("Error Reading files!");
                    Console.WriteLine("A name must have at least 1 given name and may have up to 3 given names.\n");
                    Console.WriteLine("Error List : ");
                    
                    foreach (string list in ErrorList)
                    {
                         Console.WriteLine(list);
                    }
                }
                else
                {
                    
                    List<string> SortedName = new List<string> ();
                    List<Person> ListPerson =new List<Person> (); 
                
                    //get list of names from file
                    ListPerson = file.Read();   

                    //sorted the name                  
                    SortedName = Person.SortedName(ListPerson);

                    //create .txt output
                    file.Write(SortedName);

                    //showed the names on screen
                    foreach (string name in SortedName)
                    {
                        Console.WriteLine(name);
                    }
                                     
                    
                }
                  
            }
        
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}



