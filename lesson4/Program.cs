Console.WriteLine("Please enter your degree:");
string input = Console.ReadLine();
int degree;
if (int.TryParse(input, out degree)){
    int fahrenheit = (degree * 9/5) + 32;
    Console.WriteLine(fahrenheit);
}
Console.WriteLine("Now enter a number");
string input1 = Console.ReadLine();
Console.WriteLine("Now enter a number once again:");
string input2 = Console.ReadLine();
Console.WriteLine("And the last time:");
string input3 = Console.ReadLine();
int greatest1;
int greatest2;
int greatest3;
int greatest;
if (int.TryParse(input1, out greatest1)){
    Console.WriteLine("Collected value1");
}
if (int.TryParse(input2, out greatest2)){
    Console.WriteLine("Collected value2");
}
if (int.TryParse(input3, out greatest3)){
    Console.WriteLine("Collected value1");
}

if (greatest1>greatest2 && greatest1>greatest3){
    greatest=greatest1;
    Console.WriteLine(greatest);
}
if (greatest2>greatest3 && greatest2>greatest1){
    greatest=greatest2;
    Console.WriteLine(greatest);
}
if (greatest3>greatest2 && greatest3>greatest1){
    greatest=greatest3;
    Console.WriteLine(greatest);
}
else{
    Console.WriteLine("ERROR: Some of the numbers in the input may be equal to each other/invalid. This could also be caused if the number you inputted is a string. Avoid inputting 2 same numbers or math expressions/equations.");
}
int intup=0;
while(intup!=11){
    Console.WriteLine(intup);
    intup=intup+1;
}
for (intup = 0; intup < 11; intup++)
{
    Console.WriteLine(intup);
}
