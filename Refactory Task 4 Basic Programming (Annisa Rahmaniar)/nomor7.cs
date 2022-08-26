using System;

public class nomor7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukkan batas Anda");
        int batas = int.Parse(Console.ReadLine());
        
        for(int i = 1; i<=batas; i++)
        {
            if(i%2!=0)
            {
                Console.WriteLine(i +" Bilangan Ganjil");
            }
        }
     
    }
}