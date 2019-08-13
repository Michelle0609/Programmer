
using System;
using System.Collections.Generic;

public class Programmer
{
    public List<string> Languages = new List<string>();
     
    public void AddLanguage(string language)
    {
        if(!Languages.Contains(language))
        {
            Languages.Add(language);
        }
       
    }

}

public class ProgrammerTeacher : Programmer
{
    public bool Teach(Programmer programmer,string language)
    {
        if(Languages.Contains(language))
        {
            programmer.Languages.Add(language);
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ProgrammerTeacher teacher = new ProgrammerTeacher();
        teacher.AddLanguage("C#");

        Programmer programmer = new Programmer();
        teacher.Teach(programmer, "C#");

        foreach (var language in programmer.Languages)
            Console.WriteLine(language);
    }

}

