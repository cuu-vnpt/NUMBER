﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine("Nhap mot so tu ban phim: ");
       int count = int.Parse(Console.ReadLine());
       Console.WriteLine(count);
       if(count<10)
       {
        switch(count)
        {
            case 0: Console.WriteLine("khong");
            break;
            case 1: Console.WriteLine("mot");
            break;
            case 2: Console.WriteLine("hai");
            break;
            case 3: Console.WriteLine("Ba");
            break;
            case 4: Console.WriteLine("Bon");
            break;
            case 5: Console.WriteLine("Nam");
            break;
            case 6: Console.WriteLine("Sau");
            break;
            case 7: Console.WriteLine("Bay");
            break;
            case 8: Console.WriteLine("Tam");
            break;
            case 9: Console.WriteLine("Chin");
            break;
        }
       } 
       else if(count<20)
       {
        int chuc = (int) count/10;
        int dv = (int) count%10;
        switch(chuc)
        {
            case 2: Console.Write("Hai");
            break;
            case 3: Console.Write("Ba");
            break;
            case 4: Console.Write("Bon");
            break;
            case 5: Console.Write("Nam");
            break;
            case 6: Console.Write("Sau");
            break;
            case 7: Console.Write("Bay");
            break;
            case 8: Console.Write("Tam");
            break;
            case 9: Console.Write("Chin");
            break;
        }
        Console.Write(" Muoi ");
        Write_Value(dv);
        }
    }
    private static void Write_Value(int temp)
    {
        switch(temp)
        {
            case 1: Console.WriteLine("mot");
            break;
            case 2: Console.WriteLine("hai");
            break;
            case 3: Console.WriteLine("Ba");
            break;
            case 4: Console.WriteLine("Bon");
            break;
            case 5: Console.WriteLine("Nam");
            break;
            case 6: Console.WriteLine("Sau");
            break;
            case 7: Console.WriteLine("Bay");
            break;
            case 8: Console.WriteLine("Tam");
            break;
            case 9: Console.WriteLine("Chin");
            break;
        }
    }
}