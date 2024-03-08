using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region do while, Arrays, Switch Case


            //Task-1

            //int[] nums = { 41, 22, 13, 54, 35, };
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (n < nums[i])
            //    {
            //        Console.WriteLine(true);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(false);
            //        break;
            //    }
            //}
            //Console.ReadLine();


            //tapsiriq 4

            //int[] arr = { 1, 2, 5, 18, 15, 23 };
            //int son = arr.Length - 1;

            //for (int i = son; i > 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadLine();




            //Task - 5

            //int[] nums = {1, 23, 543, 23};
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i].ToString().Length);
            //}



            //Task - 6

            //int[]nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = nums[0];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (max < nums[i])
            //    {
            //        max= nums[i];


            //    }

            //}
            //Console.WriteLine("Arrayin en boyuk ededi:" + max);



            //Task - 7

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int min = nums[0];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (min > nums[i])
            //    {
            //        min = nums[i];


            //    }

            //}
            //Console.WriteLine("Arrayin en kicik ededi:" + min);





            //Task - 2

            //Console.Write("Bir eded daxil edin: ");
            //int eded = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while (eded>0)
            //{
            //    Console.WriteLine(eded%10);
            //    if(eded%2==0)
            //    {
            //        Console.WriteLine("reqem cutdur");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Cut reqem deyil");
            //    }
            //    eded=eded/10;



            //}


            //Console.ReadLine();



            //Task - 3


            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            //int sum = 0;
            //int count=0;
            //int average = 0;
            //for (int i = 0; i < nums.Length; i += 2)
            //{
            //    sum += nums[i];
            //    count++;
            //}
            //average = sum / count;

            //Console.WriteLine("Cut idenksde olan ededlerin cemi:" + sum);
            //Console.WriteLine("Cut indeksde olan ededlerin ededi ortasi:" + average);
            //Console.ReadLine();

            #endregion

            #region  Arrays - Lab tasks #5


            //int[] ededler = { 1, 32, 45, 5, 7, 23, 0, -4, 245, -10, -100 };

            //int min = ededler[0];

            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    if (min > ededler[i])
            //    {
            //        min = ededler[i-1];


            //    }

            //}
            //Console.WriteLine(min);



            //string[] adlar = { "Veli", "Sevinc", "Ayxan", "Kamil", "Mirdamet", "Eli" };
            //for (int i = 0; i < adlar.Length; i++)
            //{

            //    if (adlar[i].Length >= 5  )
            //    {
            //        Console.WriteLine(adlar[i]);
            //    }
            //}
            #endregion


            #region MyRegion
            //int rows = 5;

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();
            #endregion

            #region MyRegion
            //int[] arr = { 0, 5, 5, 12, 11,12, 13, 8, 8, 6, 10 ,8};
            //int count = 0;
            //int value = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (value != arr[i] || value == 0)
            //    {
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;

            //            }
            //        }
            //        Console.WriteLine("Say " + count);
            //        Console.WriteLine("Tekrar edilenler" + arr[i]);
            //        count = 0;
            //        value = arr[i];
            //    }
            //}
            #endregion




            //int[] arr1 = { 211, -6, 32, 9, 19, 5 };
            //int[] arr2 = { 211,19,5,32,8};

            //bool check = true;
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (arr1[j] == arr2[i])
            //        {

            //            Console.WriteLine(check);
            //            break;
            //        }
            //    }
            //}

            //if (check != false)
            //{
            //    Console.WriteLine(check == false);

            //}
        }
    }
}
