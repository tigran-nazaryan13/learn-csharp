
// //For
// for ( int integ = 0; integ < 101; integ=integ+5)
// {
//     Console.WriteLine(integ);
// }

// //While
// int integ2=0;
// while(integ2<101){
//     if (integ2%5==0){
//         Console.WriteLine(integ2);
//     }
//     integ2++;
// }

// //Array
// int[] numbers={847, 63, 54, 12, 281};
// foreach(int item in numbers){
//     Console.WriteLine(item);
// }

// string[] pizzas={"Cheese", "Peperoni", "Half'n'Half"};
// foreach(string item in pizzas){
//     Console.WriteLine(item);
// }

// for (int i = 0; i < pizzas.Length; i++)
// {
//     Console.WriteLine(pizzas[i]);
// }

// int b=0;
// while (b < pizzas.Length)
// {
//     Console.WriteLine(pizzas[b]);
//     b++;
// }

// Console.WriteLine(pizzas[pizzas.Length-1]);

// int example=0;

// while (example < 101)
// {
//     if (example%6==0)
//     {
//         example++;
//         continue;
//     }
//     Console.WriteLine(example);
//     example++;
// }

// int[] examplearray={3, 54, 32, 31, 598};
// foreach(int item2 in examplearray){
//     Console.WriteLine(item2);
// }

// for(int item3=0; item3<598; item3++){

// }

// int[] integerarray={3, 53, 24, 653, 68};
// string[] stringarray={"hello", "hi", "greetings"};
// foreach (int item in integerarray){
//     if (item>100){
//         Console.WriteLine(item);
//     }
// }

// foreach (string item2 in stringarray){
//     Console.WriteLine(item2.ToUpper());
// }

// int max=0;
// foreach (int biggest in integerarray){
//     if (biggest>max){
//         max=biggest;
//     }
// }
// Console.WriteLine(max);


// int min=integerarray[1];
// foreach (int smallest in integerarray){
//     if (smallest<min){
//         min=smallest;
//     }
// }
// Console.WriteLine(min);


// for (int i = 0; i < integerarray.Length; i++){
// int square=integerarray[i]*integerarray[i];
// Console.WriteLine(square);
// }

// int intvariable=0;
// while(intvariable<101){
//     if (intvariable%3==0){
//         intvariable++;
//         continue;
//     }
//     else{
//         Console.WriteLine(intvariable);
//     }
//     intvariable++;
// }
// int[] integerarray2={3, 54, 565, 292, 98};
// Console.WriteLine(integerarray2[0]);
//our task is to find the last element of the array.

// int intfizz=0;
// while (intfizz!=100){ 
//         if (intfizz%3==0 & intfizz%5==0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (intfizz%3==0)
//     {
//         Console.WriteLine("Fizz");
//     }
//         else if (intfizz%5==0)
//     {
//         Console.WriteLine("Buzz");
//     }
//         else{
//             Console.WriteLine(intfizz);
//         }
//     intfizz++;
// }

// int[]arr={3, 53, 75, 93, 21};
// for (int j=0; j<arr.Length/2; j++)
// {
// int t=arr[j];
// arr[j]=arr[arr.Length-1-j];
// arr[arr.Length-1-j]=t;
// }
// for (int i = 0; i < arr.Length; i++)
// {
//    Console.WriteLine(arr[i]);
// }

//Solve reverse array problem.

// string input="hellothere";
// char [] arrray=input.ToCharArray();
// char lastfirst=arrray[arrray.Length-1];
// char firstlast=arrray[0];
// arrray[0]=lastfirst;
// arrray[arrray.Length-1]=firstlast;
// string result = new string(arrray);
// Console.WriteLine(result);
//Goal: swap the first character with the last 
//143: We create a string caled "input"
//144: We convert that string to a char array
//145: We create the first NEW char
//146: We create the last NEW char
//147: We make the first character of the array the char variable that we made
//148: We make the last character of the array the char variable that we made
//149: We convert the int to a string
//150: We print it all out
//151-160: Explanation

// string text = "C# is a fun programming language.";
// // string[] result=text.Split(" ");

// // Console.WriteLine("Result: ");
// // foreach(string str in result ){
// //    Console.WriteLine(str + ", ");
// // }
// // Console.ReadLine();

// // string text = "C# is fun";

// // Console.WriteLine(text.Substring(6, 3));
// // Console.ReadLine();

// // string str1 = "C#";
// // string str2 = "Programiz";

// // int result = string.Compare(str1, str2);
// // Console.WriteLine(result);

// // string str = "Programming is fun!";

// // string result = str.Replace("Programming", "C#");
// // Console.WriteLine(result);

// // string str = "I love icecream";
// // bool check = str.Contains("icecream");

// // Console.WriteLine(check);

// string a=Console.ReadLine();
// string b=Console.ReadLine();
// int newa= Int32.Parse(a);
// int newb= Int32.Parse(b);
// int newnewa=100-newa;
// int newnewb=100-newb;
// if (newnewa<0){
//     newnewa=newnewa*(-1);
// }
// if (newnewb<0){
//     newnewb=newnewb*(-1);
// }
// if (newnewa<newnewb){
//     Console.WriteLine("Integer #a is closer to 100");
//     Console.WriteLine(a);
// }
// else if (newnewb<newnewa){
//     Console.WriteLine("Integer #b is closer to 100");
//     Console.WriteLine(b);
// }
// else{
//     Console.WriteLine(0);
// } //105, 98 100-105=-5 100-98=2
// string hi=Console.ReadLine();
// string bye=Console.ReadLine();

// int hi1 = Int32.Parse(hi);
// int bye1 = Int32.Parse(bye);

// if (hi1>39 && hi1<61){
//     Console.WriteLine("True");
// }
// if (bye1>39 && bye1<61){
//     Console.WriteLine("True");
// }

// if (hi1<39 || hi1>61){
//     Console.WriteLine("False");
// }
// if (bye1<39 || bye1>61){
//     Console.WriteLine("False");
// }

Random rd=new Random();
int rand1=rd.Next(10, 200);
int rand2=rd.Next(10, 200);

if (rand1>39 && rand1<61){
    Console.WriteLine("True");
    Console.WriteLine(rand1);
}
if (rand2>39 && rand2<61){
    Console.WriteLine("True");
    Console.WriteLine(rand2);
}

if (rand1<39 || rand1>61){
    Console.WriteLine("False");
    Console.WriteLine(rand1);
}
if (rand2<39 || rand2>61){
    Console.WriteLine("False");
    Console.WriteLine(rand2);
}
