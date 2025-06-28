// // using System;
// // using System.Runtime.InteropServices;
// // using System.Runtime.Intrinsics.X86;

// // namespace lesson3
// // {
// //   class Program
// //   {
// //     static void Main(string[] args)
// //     {
// //      int testvle=3;
// //      int testvle2=4;
// //      if (testvle>testvle2)
// //      {
// //     testvle2=testvle2+1;
// //      }
// //      else if (testvle==testvle2)
// //      {
// //     Console.WriteLine("They are equal");
// //      }
// //      else
// //      {
// //     testvle2=testvle2-1;
// //      }
// //      int time = 20;
// //      string result = (time < 18) ? "Good Day.": "Good Evening.";
// //      Console.WriteLine(result);
// //      int day=1;
// //      while (day!=8)
// //      {
// //      switch(day)
// //      {
// //       case 1:
// //       Console.WriteLine("Its Monday!");
// //       day=day+1;
// //         break;

// //       case 2:
// //       Console.WriteLine("Its Tuesday!");
// //       day=day+1;
// //         break;

// //       case 3:
// //       Console.WriteLine("Its Wednesday!");
// //       day=day+1;
// //         break;

// //       case 4:
// //       Console.WriteLine("Its Thursday!");
// //       day=day+1;
// //         break;

// //       case 5:
// //       Console.WriteLine("Its Friday!");
// //       day=day+1;
// //         break;

// //       case 6:
// //       Console.WriteLine("Its Saturday!");
// //       day=day+1;
// //         break;

// //       case 7:
// //       Console.WriteLine("Its Sunday!");
// //       day=day+1;
// //         break;
// //      }
// //      }

// //     for (int i=0; i < 5; i++)
// //      {
// //         Console.WriteLine(i);
// //      }

// //     string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// //     foreach (string i in cars)
// //     {
// //     Console.WriteLine(i);
// //     }

// //     string[] cars2 = {"Volvo", "BMW", "Ford", "Mazda"};
// //     for (int i = 0; i < cars.Lenght; i++)
// //     {
// //     Console.WriteLine(cars2[i]);
// //     }

// //      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// //     for (int i = 0; i < cars.Lenght; i++)
// //     {
// //     Console.WriteLine(cars[i]);
// //     }

// //     string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// //     Array.Sort(cars);
// //     foreach (string i in cars)
// //     {
// //     Console.WriteLine(i);
// //     }

// //     int[] MyNumbers= {5, 1 , 8, 9};
// //     Array.Sort(MyNumbers);
// //     foreach (int i in MyNumbers)
// //     {
// //     Console.WriteLine(i);
// //     }



// //     for (int i = 0; i < 10; i++)
// //     {
// //      if (i==4)
// //     {
// //     continue;
// //     }
// //     Console.WriteLine(i);
// //     }
// //     }
// //   }
// // }

// // int thenumber = -8;
// // if (thenumber>0)
// // {
// //  Console.WriteLine("The number -8 is positive");
// // }
// // else if (thenumber<0)
// // {
// //  Console.WriteLine("The number -8 is negative");
// // }
// // else
// // {
// //  Console.WriteLine("The number -8 is zero");
// // }

// Console.WriteLine("Please enter your age:");
// int age = int.TryParse(Console.ReadLine());
// if (age<13)
// {
//  Console.WriteLine("You are a child");
// }
// else if (age>13 && age<55)
// {
//  Console.WriteLine("You are a teenager");
// }
// else
// {
//  Console.WriteLine("You are a senior");
// }3÷≥