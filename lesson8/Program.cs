//#38
// int [] array1 = {5, 5, 3, 5, 6, 2};
// int count = 0;
// for (int i=0; i<array1.Length-1; i++){
//     if (array1[i]==5 && array1[i+1]==5){
//     count=count+1;
//     }
//     if (array1[i]==5 && array1[i+1]==6){
//      count=count+1;
//     }e
// }
// Console.WriteLine(count);

//#39
// int [] array2 = {1, 2, 2, 2, 6, 1};
// int giveninteger = 2;
// bool count = false;
// for (int i=0; i<array2.Length-2; i++){
//     if (array2[i]==giveninteger && array2[i+1]==giveninteger && array2[i+2]==giveninteger){
//     count=true;
//     break;
//     }
//     if (array2[i]!=giveninteger || array2[i+1]!=giveninteger || array2[i+2]!=giveninteger){
//      count=false;
//     }
// }
// Console.WriteLine(count);

//#40
// int integer1 = 14;
// int integer2 = 12;
// if (integer1<21 && integer1>9 && integer2<21 && integer2>9){
//     Console.WriteLine(integer1+integer2);
// }
// else if (integer1>21 || integer1<9 || integer2>21 || integer2<9){
//     Console.WriteLine(30);
// }

//#41
// int integ1 = 2;
// int integ2 = 3;
// if (integ1==5 || integ2==5 || integ1+integ2==5 || integ2-integ1==5 || integ1-integ2==5){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

//#42
// int giveninteg = 40;
// if (giveninteg%13==0 || giveninteg%13==1){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

//#43
// static void MyProgram(){
// int givenint = 21;
// if (givenint%21!=0 && (givenint%7==0 || givenint%3==0)){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }
// }
// MyProgram();

//#44
// static bool test(int n)
// {
// return n%10 <=2 || n%10 >=8;
// }
// Console.WriteLine(test(3));

//#45
// static void hi(){
// int integer1 = 98;
// int integer2 = 4;
// if (integer1<21 && integer1>9 && integer2<21 && integer2>9){
//     Console.WriteLine(18);
// }
// else if (integer1>21 || integer1<9 && integer2>21 || integer2<9){
//     Console.WriteLine(integer1+integer2);
// }
// }
// hi();

//#46
// static string function1(string str1){
// if (str1.StartsWith('F') && str1.EndsWith('B')){
//     return "FizzBuzz";
// }
// else if (str1.StartsWith('F')){
//     return "Fizz";
// }
// else if (str1.EndsWith('B')){
//     return "Buzz";
// }
// else{
//     return str1;
// }
// }
// Console.WriteLine(function1("FizzBuzB"));

//#47
// static string function2(int str2, int str3, int str4){
// if (str2+str3==str4){
//     return "True";
// }
// else{
//     return "False";
// }
// }
// Console.WriteLine(function2(1, 2, 3));

// #48
// static string function2(int str5, int str6, int str7){
// if (str5<str6 && str6<str7){
//     return "True";
// }
// else{
//     return "False";
// }
// }
// Console.WriteLine(function2(4, 5, 6));

//#49
// static string function2(int str5, int str6, int str7){
// if (str5<str6 && str6<str7){
//     return "True";
// }
// else{
//     return "False";
// }
// }
// Console.WriteLine(function2(4, 5, 6));

//#50
// bool HasSameRightmostDigit(int a, int b, int c)
// {
//     int aLast = a % 10;
//     int bLast = b % 10;
//     int cLast = c % 10;

//     return (aLast == bLast) || (aLast == cLast) || (bLast == cLast);
// }

// Console.WriteLine(HasSameRightmostDigit(11, 21, 31));
// Console.WriteLine(HasSameRightmostDigit(11, 22, 31));
// Console.WriteLine(HasSameRightmostDigit(11, 22, 33));  // False




