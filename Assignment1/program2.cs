﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            double sum = 0;
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / 5;

            Console.WriteLine("Average is :" + avg);
            Console.ReadLine();
        }
    }
}



