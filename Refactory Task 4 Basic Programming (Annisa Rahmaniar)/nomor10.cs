using System;
using System.Collections.Generic;
using System.Linq;

public class nomor6
{
    public static void Main(string[] args)
    {
        
        string [] kata = {"Meja", "Buku", "Topi", "Baju", "Kayu"};

        List <string> kata_list = kata.ToList();

        string kata_1 = "Handuk";

        kata_list.Insert(0, kata_1);

        string insert_1 = string.Join(", ", kata_list);

        string kata_2 = "Celana";

        kata_list.Insert(6, kata_2);

        string insert_2 = string.Join(", ", kata_list);

        Console.WriteLine(String.Join(insert_1, insert_2));
        
     
    }
}