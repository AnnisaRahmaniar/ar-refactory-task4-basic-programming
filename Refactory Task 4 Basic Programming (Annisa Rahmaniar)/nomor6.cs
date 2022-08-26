using System;

public class nomor6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukkan batas awal anda");
        int batas_awal = int.Parse(Console.ReadLine());

        Console.WriteLine("Masukkan batas akhir anda");
        int batas_akhir = int.Parse(Console.ReadLine());

        for(int i = batas_awal; i<=batas_akhir; i++)
        {
            Console.WriteLine(i);
        }
        
     
    }
}