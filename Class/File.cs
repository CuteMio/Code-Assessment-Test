using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Persons;

public class File
{
    private string workingfolder = System.IO.Directory.GetCurrentDirectory() ;
    private string filepath = System.IO.Directory.GetCurrentDirectory() + @"\name-sorter\unsorted-names-list.txt";

    private List<Person> ListPerson =new List<Person> ();
    private List<string> ErrorList = new List<string> ();

    public List<Person> Read()
    {
        using (StreamReader sr = new StreamReader(filepath))
                {
                    string line;
                    // Read the from the file until the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //remove blank line
                        line = line.Trim();
                        if (line != "")                            
                            ListPerson.Add(new Person(line));
                    }
                }    

        return ListPerson;
    }

    public void Write(List<string> SortedName)
    {
        using(TextWriter tw = new StreamWriter("sorted-names-list.txt"))
        {
            foreach (String name in SortedName)
            tw.WriteLine(name);
        }
    }
    
    public List<string> FileCheck()
    {
        
        using (StreamReader sr = new StreamReader(filepath))
        {
            string line;
            // Read the from the file until the end of the file is reached.
            while ((line = sr.ReadLine()) != null)
            {
                //remove blank line
                line = line.Trim();
                
                if (line != "")
                {
                    string[] strings = Regex.Split(line, @"\W|_");

                    //check if the name doesn't have given name or have more than 3 given name
                    if (strings.Length<2 || strings.Length>4 )
                    {
                        ErrorList.Add(line);
                    }
                }
                
                         
            }

            
        }    

        return ErrorList;
    }
}