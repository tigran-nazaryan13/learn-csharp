//#51
// static void myfunction(int ing1, int ing2, int ing3){
//     if (ing1-ing2>19 || ing1-ing3>19 || ing2-ing1>19 || ing2-ing3>19 || ing3-ing2>19 || ing3-ing1>19){
//     Console.WriteLine("True");
//     }
//     else{
//         Console.WriteLine("False");
//     }
// }
// myfunction(11, 22, 25);

//#52
// static void my2ndfunction(int integer1, int integer2){
// if (integer1%7==integer2%7 && integer1<integer2){
//     Console.WriteLine(integer1);
// }
// if (integer1%7==integer2%7 && integer2<integer1){
//     Console.WriteLine(integer2);
// }
// if (integer1%7!=integer2%7 && integer1>integer2){
//     Console.WriteLine(integer1);
// }
// if (integer1%7!=integer2%7 && integer2>integer1){
//     Console.WriteLine(integer1);
// }
// if (integer1==integer2){
//     Console.WriteLine(0);
// }
// }
// my2ndfunction(1,1);

//#53
// char thedigit = '3';
// string digit1 = "13";
// string digit2 = "24";
// if (digit1.Contains(thedigit) && digit2.Contains(thedigit)){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

//#54
// int x = 4;
// string xstring = x.ToString();
// int y = 6;
// int xy = x+y;
// string xystring = xy.ToString();
// if (xystring.Length>xstring.Length){
//     Console.WriteLine(x);
// }
// else{
//     Console.WriteLine(xy);
// }

//#55
// int num1 = 10;
// int num2 = 12;
// int num3 = 14;
// if (num1==num2 || num1==num3 || num2==num3){
//     Console.WriteLine(num3);
// }
// else{
//     Console.WriteLine(num1+num2+num3);
// }

//#56
// int number1 = 13;
// int number2 = 14;
// int number3 = 15;
// if (number1==13){
//     Console.WriteLine(number3);
// }
// else if (number2==13){
//     Console.WriteLine(number1+number3);
// }
// else if (number3==13){
//     Console.WriteLine(number1+number2);
// }

//#57
// static int myfunction3(){
// int numm1 = 10;
// int numm2 = 12;
// int numm3 = 17;
// int totalsum = 0;
// if (numm1<21 && numm1>9 && numm1!=13 && numm1!=17){
//     totalsum=totalsum+0;
// }
// if (numm1==13 || numm1==17 || numm1<10 || numm1>20){
//     totalsum=totalsum+numm1;
// }
// if (numm2<21 && numm2>9 && numm2!=13 && numm2!=17){
//     totalsum=totalsum+0;
// }
// if (numm2==13 || numm2==17 || numm2<10 || numm2>20){
//     totalsum=totalsum+numm2;
// }
// if (numm3<21 && numm3>9 && numm3!=13 && numm3!=17){
//     totalsum=totalsum+0;
// }
// if (numm3==13 || numm3==17 || numm3<10 || numm3>20){
//     totalsum=totalsum+numm3;
// }
// return totalsum;
// }
// Console.WriteLine(myfunction3());

//#58
// static int myfunction4(){
// int numbe1 = 6;
// int numbe2 = 12;
// int thenumber = 13;
// int test1 = thenumber-numbe1;
// int test2 = thenumber-numbe2;
// int theone = 0;
// if (test1<test2){
//     theone=numbe1;
// }
// else{
//     theone=numbe2;
// }
// return theone;
// }
// Console.WriteLine(myfunction4());

//#59
// static void myfunction5(){
// int in1 = 4;
// int in2 = 5;
// int in3 = 6;
// if (in2-in1==in3-in2){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }
// }
// myfunction5();

// //#60
// static string myfunction6(string s1, string s2){
// string s1s2s2s1 = s1+s2+s2+s1;
// return s1s2s2s1;
// }
// Console.WriteLine(myfunction6("Why","Hi"));

// static int myfunc1(){
// int in1 = Convert.ToInt32(Console.ReadLine());
// int in2 = Convert.ToInt32(Console.ReadLine());
// int sum = in1+in2;
// return sum;
// }
// Console.WriteLine(myfunc1());

//#61
// string a = "[[]]";
// string b = "(())";
// string c = "Hello";
// string d = "Hi";
// static string test(string s1, string word)
//         {
//             // Concatenates a substring of s1 (from index 0 to index 2 exclusive) with the 'word' and then concatenates the rest of s1 (from index 2 onwards)
//             return s1.Substring(0, 2) + word + s1.Substring(2);
//         }
// Console.WriteLine(test("[[]]", "Hello"));

//#62
// static string test1(string word)
//         {
//             return word.Substring(3, 2)+word.Substring(3, 2)+word.Substring(3, 2);
//         }
// Console.WriteLine(test1("Hello"));

//#63
// static string test2(string word)
//         {
//             if (word.Length>1){
//             return word.Substring(0, 2);
//             }
//             else{
//                 return word;
//             }
//         }
// Console.WriteLine(test2("H"));

//#64
// string s1 = "Python";
// Console.WriteLine(s1.Substring(1).Substring(0, s1.Length - 2));

//#65
//-------------
//-------------
//-------------
//-------------

//#66
// string str1 = "Python";
// string str2 = "Java";
// if (str1.Length>str2.Length){
//      Console.WriteLine(str1+str2+str1);
// }

// if (str2.Length>str1.Length){
//     Console.WriteLine(str2+str1+str2);
// }

//#67
// string s1 = "Python";
// string s2 = "Java";
// Console.WriteLine(s1.Substring(1).Substring(0, s1.Length - 1)+s2.Substring(1).Substring(0, s2.Length - 1));

//#68
// string s1 = "Python";
// if (s1.Length>1){
//     Console.WriteLine(s1.Substring(1).Substring(1, s1.Length -2)+s1.Substring(0, 2));
// }


//#69
// string s1 = "Python";
// if (s1.Length>1){
//     Console.WriteLine(s1.Substring(4, 2)+s1.Substring(0).Substring(0, s1.Length -2));
// }


//#70
// string s1 = "Python";
// Console.WriteLine(s1.Substring(1).Substring(0, s1.Length -2));

//#71
// string s1 = "Hell";
// if (s1.Length>1){
//     Console.WriteLine(s1.Substring(1).Substring(0, s1.Length -2));
// }

//#72
// string s1 = "Hellon";
// if (s1.EndsWith("on")){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

//#73
// string input = "Miscommunication";
// int n = 4;
// string result = "";
// string subinput = input.Substring(0, n);
// result=subinput;
// Console.WriteLine(result);

//#74
// string text = "Programiz";
// string result = text.Substring(1);
// Console.WriteLine(result);
// string text = "Programiz is for programmers";
// string result = text.Substring(0, 9);
// Console.WriteLine(result);
// string text = "C#. Programiz";
// string result = text.Substring(0, text.IndexOf('.'));
// Console.WriteLine(result);

//#75
// string text = "Bananas";
// string SubText = text.Substring((text.Length/2)-1, 3);
// Console.WriteLine(SubText);

//#76
// string text = "A";
// string tag = "#";
// string tagnum = "";
// if (text.Length>=2){
// text = text.Substring(0, 2);
// Console.WriteLine(text);
// }
// else if (text.Length>0){
//     text = text.Substring(0, 1)+tag;
//     Console.WriteLine(text);
// }
// else{
//     Console.WriteLine(tag+tag);
// }

//#77
// static string myfunc1(string s1, string s2){
//     if (s1.Length>0){
//     string subs1 = s1.Substring(0, 1);
//     }
//     else if (s1.Length<1){
//     string subs1 = "#";
//     }
//     if (s2.Length>0){
//     string subs2 = s2.Substring(s2.Length-1, 1);
//     }
//     else if (s2.Length<1){
//     string subs2 = "#";
//     }
//     return subs1+subs2;
// }
// Console.WriteLine(myfunc1("Csharp", ""));