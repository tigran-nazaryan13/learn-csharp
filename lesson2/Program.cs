// using System;
// using System.Runtime.InteropServices;
// using System.Runtime.Intrinsics.X86;

// namespace lesson2
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//     //   Console.WriteLine("Enter Username:");
//     //   string userName = Console.ReadLine();
//     //   Console.WriteLine("Username is:" + userName);
//     //   Console.WriteLine("This is a spacer");
//     //   Console.WriteLine("This is a spacer");
//     //   Console.WriteLine("This is a spacer");
//     //   int x = 100+50;
//     //   int y = 10;
//     //   y += 5;
//     //   Console.WriteLine(x > y);
//     //   if(x>5 && x<4){
//     //     Console.WriteLine("True");
//     //   }
//     //   else{
//     //     Console.WriteLine("False");
//     //   }
//     //   Math.Max(5, 10); //finds the maximum
//     //   Math.Min(5, 10); //finds the minimum
//     //   Math.Sqrt(64); //finds the square root
//     //   Math.Round(9.99); //rounds the number
//     //   Math.Abs(-4.7); //turns negative to positive
//     //   string txt = "ABIEHFNIFUEFNIFKHIRUJ";
//     //   Console.WriteLine(txt);
//     //   Console.WriteLine("The lenght of the string is:" + txt.Length);
//     //   Console.WriteLine(txt.ToUpper());
//     //   Console.WriteLine(txt.ToLower()); 
//     //   string firstName = "Bob";
//     //   string lastName = "Johnson";
//     //   string name = string.Concat(firstName, lastName);
//     //   Console.WriteLine(name);
//     //   string name1 = $"My full name is: {firstName} {lastName}";
//     //   Console.WriteLine(name1);
//     //   Console.WriteLine(firstName[0]);
//     //   Console.WriteLine(firstName.IndexOf("o"));
//     //   int charPos = firstName.IndexOf("B");
//     //   string firsttName = name.Substring(charPos);
//     //   Console.WriteLine(firsttName);
//       string str01 = "abcdefgjkh";
//       string substr01 = str01.Substring(3, 5);
//       Console.WriteLine(substr01);
//       string test = "We are so called \"Vikings\" from the north";
//       Console.WriteLine(test);
//       Math.Floor(9.99);
//       Math.Ceiling(9.99);
//     }
//   }
// }

// See https://aka.ms/new-console-template for more information

int readline = Console.ReadLine();
int readint = Convert.ToInt32(readline);
Console.WriteLine("Square Root:");
Console.WriteLine(readline*readline);
Console.WriteLine("Cube Root:");
Console.WriteLine(readline*readline*readline);