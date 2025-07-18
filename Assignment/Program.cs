using Assignment.Enums;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Part 02
            //Enum


            #region Q01
            //1 - Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members.Then, write a C# program that 
            //prints out all the days of the week using this enum.


            //string[] weekdayNames=Enum.GetNames(typeof(WeekDays));
            //Console.WriteLine("Days of Week:");
            //foreach (string day in weekdayNames )
            //{
            //    Console.Write($"   {day} ");
            //}


            #endregion


            #region Q02
            //  2.Create an enum called "Season" with the four seasons(Spring,
            //Summer, Autumn, Winter) as its members.Write a C# program that 
            //takes a season name as input from the user and displays the
            //corresponding month range for that season. Note range for seasons (
            //spring march to may , summer june to august, autumn September to
            //November, winter December to February)


            //object? season = null;
            //bool isParsed = false;
            //do
            //{
            //    Console.WriteLine("Enter a season name:");

            //    string input = Console.ReadLine();
            //    if (int.TryParse(input, out _))
            //    {
            //        isParsed = false;

            //        Console.WriteLine("Invalid Input");

            //        continue;
            //    }
            //    isParsed = Enum.TryParse(typeof(Season), input, true, out season);

            //    if (!isParsed || season == null)
            //    {
            //        isParsed = false;
            //        Console.WriteLine("Invalid Input");
            //        continue;

            //    }





            //} while (!isParsed);

            //Season selectedSeason = (Season)season;
            //string result = selectedSeason switch
            //{
            //    Season.Spring => "spring is march to may",
            //    Season.Winter => "winter is December to February",
            //    Season.Summer => "summer is june to august",
            //    Season.Autumn => "autumn is September to November"
            //};
            //Console.WriteLine($"The corresponding month range for {result}");


            #endregion


            #region Q04
            //4 - Assign the following Permissions(Read, write, Delete, Execute) in a
            //form of Enum. 
            //● Create Variable from previous Enum to Add multible
            //Permission

            //Permissions permission =Permissions.Write;//write
            //permission = Permissions.Execute | permission;//write, Excute
            //Console.WriteLine(permission);
            //permission = Permissions.Execute & Permissions.Delete^Permissions.Execute;//excute
            //Console.WriteLine(permission);

            #endregion


            #region Q05
            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            //as its members.Write a C# program that takes a color name as input from 
            //the user and displays a message indicating whether the input color is a
            //primary color or not.



            //without check if it's  a color
            //string input;
            //do
            //{
            //    Console.WriteLine("Enter a Color");

            //    input = Console.ReadLine().Trim();
                
            //} while (string.IsNullOrWhiteSpace(input));
            //object selected;
            //bool isPrimary = Enum.TryParse(typeof(Colors), input, true, out selected) &&
            //      Enum.IsDefined(typeof(Colors), selected);
            //if (isPrimary)
            //{
            //    Console.WriteLine("Input color is a primary color");

            //}
            //else
            //    Console.WriteLine("Input isn't a primary color");




            ////////////////////anotherWay/////////////////with check if it a color


         //   string input;
         //   do {
         //       Console.WriteLine("Enter a Color");

         //       input = Console.ReadLine().Trim();
         //       Color c=Color.FromName(input);//Check if it's a color
         //       if (!c.IsKnownColor|| string.IsNullOrWhiteSpace(input))
         //           continue;
         //       break;
         //   } while (true);
         //   object selected;
         //bool  isPrimary = Enum.TryParse(typeof(Colors), input, true, out selected ) &&
         //      Enum.IsDefined(typeof(Colors), selected);
         //   if (isPrimary) 
         //   {
         //       Console.WriteLine("Input color is a primary color");

         //   }
         //   else
         //       Console.WriteLine("Input color isn't a primary color");

            //
            

            #endregion


            



        }
    }
}
