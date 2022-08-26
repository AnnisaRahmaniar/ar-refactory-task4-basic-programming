using System;
using System.Collections.Generic;
using System.Linq;

public class nomor6
{
    public static void Main(string[] args)
    {
        
        string [] kata = {"Jeruk", "Pepaya", "Jambu", "Anggur", "Melon"};

        List <string> kata_list = kata.ToList();

        kata_list.RemoveAt(2);

        Console.WriteLine(String. Join(", ", kata_list));
        
     
    }
}