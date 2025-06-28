// string a=Console.ReadLine();
// string b=Console.ReadLine();
// int newa=Int32.Parse(a);
// int newb=Int32.Parse(b);
// if (newa==newb){
//     int c=(newa+newb)*3;
//     Console.WriteLine(c);
// }
// else{
//     int d=newa+newb;
//     Console.WriteLine(d);
// }
// Random rd=new Random();
// int n=rd.Next(1, 100);
// Console.WriteLine(n);
// if  (n>51){
//     int absolutediffrence1=(n-51)*3;
//     Console.WriteLine(absolutediffrence1);
// }
// if (n<51){
//     int absolutedifference2=51-n;
//     Console.WriteLine(absolutedifference2);
// }
// int giveninteger=1001;
// if ((giveninteger>=90 && giveninteger<=110) || (giveninteger>=190 && giveninteger<=210)){
//     Console.WriteLine(true);
// }
// else{
//     Console.WriteLine(false);
// }
// String str = "GeeksforGeeks"; 
//         String substr1 = "for"; 
//         String substr2 = "For"; 
  
//         // using String.Contains() Method 
//         Console.WriteLine(str.Contains(substr1)); 
  
// string baw="else";
// string bow="else";
// string substr = "if";
// if ( (!bow.Contains(substr)) && (!baw.Contains(substr)) ){
//     Console.WriteLine("if"+baw);
//     Console.WriteLine("if"+bow);
// }

// if (baw.Contains(substr) && bow.Contains(substr)){
//     Console.WriteLine(baw);
//     Console.WriteLine(bow);
// }

// if (!baw.Contains(substr)){
//     Console.WriteLine("if"+baw);
//     Console.WriteLine(bow);
// }
// if (!bow.Contains(substr)){
//     Console.WriteLine(baw);
//     Console.WriteLine("if"+bow);
// }
// string s="Tigran";
// if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
// {
// Console.WriteLine(s);  // If the condition is true, return the original string 's'
// }
// Console.WriteLine("if " + s);  // If the condition is false, prepend "if " to the string 's' and return it

// string Python = Console.ReadLine();
// char [] Pythonarray=Python.ToCharArray();
// string NewPython="";
// string Input = Console.ReadLine();
// char inputaschar = Input[0];

// for (int i = 0; i < Pythonarray.Length; i++)
// {
//     if (Pythonarray[i]==inputaschar){
//         continue;
//     }
//     NewPython+=Pythonarray[i];
// }
// Console.WriteLine(NewPython);

// string MyInput = "abcdefg";
// char [] MyInputArray=MyInput.ToCharArray();
// char hi = MyInputArray[0];
// MyInputArray[0] = MyInputArray[MyInputArray.Length-1];
// MyInputArray[MyInputArray.Length-1] = hi;
// string MyWholeNewArray = new string(MyInputArray);
// Console.WriteLine(MyWholeNewArray);

// string UsersInput = "JSON";
// char [] UsersInputArray=UsersInput.ToCharArray();
// if (UsersInputArray.Length<2){
//     Console.WriteLine(UsersInput);
// }
// else {
//     Console.WriteLine(UsersInput.Substring(0, 2)+" "+UsersInput.Substring(0, 2)+" "+UsersInput.Substring(0, 2)+" "+UsersInput.Substring(0, 2));
// }

// #9
// string GDE="1";
// char charspecial;
// char [] GDEInputArray=GDE.ToCharArray();
// charspecial=GDEInputArray[GDEInputArray.Length-1];
// Console.WriteLine(charspecial+GDE+charspecial);

// #10
// int h=11;
// if (h%3==0){
//     Console.WriteLine("True");
// }
// else if (h%7==0){
//     Console.WriteLine("True");
// }
// else {
//     Console.WriteLine("False");
// }


// string UsersInput = "Code";
// char [] UsersInputArray=UsersInput.ToCharArray();
// if (UsersInputArray.Length<3){
//     Console.WriteLine(UsersInput+UsersInput+UsersInput);
// }
// else {
//     Console.WriteLine(UsersInput.Substring(0, 3)+UsersInput+UsersInput.Substring(0, 3));
// }

// string UsersInput = "C# Code";
// string mystery = UsersInput.Substring(0, 2);
// if (mystery=="C#"){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

// int temp1 = 203;
// int temp2 = -4;
// if (temp1>100 && temp2<0) {
//     Console.WriteLine("True");
// }

// int tempp1 = 134;
// int tempp2 = 657;

// if (tempp1>100 && tempp1<200 && tempp2>100 && tempp2<200) {
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

// int int1 = 16;
// int int2 = 68;
// int int3 = 25;
// if (int1>20 && int1<50 || int2>20 && int2<50 || int3>20 && int3<50){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

// int int1 = 25;
// int int2 = 34;
// if (int2>20 && int2>50 || int1<20 || int1>50){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

// string python = "Python"
// string newpythonn = ""
// char [] PythonCharArray=python.ToCharArray();
// if (PythonCharArray[1]="y" && PythonCharArray[2]="t"){
// newpythonn=PythonCharArray-PythonCharArray[1]-PythonCharArray[2];
// Console.WriteLine(newpythonn);
// }

// #18
// int a = 34;
// int b = 23;
// int c = 52;
// if (c>b && c>a){
//     Console.WriteLine(c);
// }
// if (a>b && a>c){
//     Console.WriteLine(a);
// }
// if (b>a && b>c){
//     Console.WriteLine(b);
// }

// #19
// int num1 = 101;
// int num2 = 98;
// int numm1 = 100-num1;
// int nummm1 = Math.Abs(numm1);
// int numm2 = 100-num2;
// int nummm2 = Math.Abs(numm2);
// if (nummm1<nummm2){
//     Console.WriteLine(num1);
// }
// if (nummm2<nummm1){
//     Console.WriteLine(num2);
// }

// #20
// int value1 = 56;
// int value2 = 45;
// if (value1>39 && value1<61 && value2>39 && value2<61){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

//#21
// int integer1 = 23;
// int integer2 = 27;
// if (integer1>19 && integer1<31 && integer2>19 && integer2<31){
//     if (integer1>integer2){
//         Console.WriteLine(integer1);
//     }
//     else if (integer2>integer1){
//         Console.WriteLine(integer2);
//     }
// }

//#22
// string zzz = "zane";
// int blank = 0;
// char [] zzzArray = zzz.ToCharArray();
// for (int i = 0; i < zzzArray.Length; i++)
// {
//     if (zzzArray[i]=='z'){
//         blank=blank+1;
//     }
// }
//  if (blank>2 && blank<4){
//     Console.WriteLine("True");
//  }
//  else{
//     Console.WriteLine("False");
//  }

//#23
// string intint1 = "456";
// string intint2 = "126";
// char [] intint1Array = intint1.ToCharArray();
// char [] intint2Array = intint2.ToCharArray();
// int intint1lastdigit = intint1Array.Length-1;
// int intint2lastdigit = intint2Array.Length-1;
// if (intint1lastdigit == intint2lastdigit){
//     Console.WriteLine("True");
// }
// else{
//     Console.WriteLine("False");
// }

// string str = "Tigran";
// string NewStr = str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
// Console.WriteLine(NewStr);

//#26
// string YourInput = "JS";
// int YourInput2 = 2;
// string emptystring = "";
// while (YourInput2>0)
// {
//     YourInput2=YourInput2-1;
//     emptystring=emptystring+YourInput;
// }
// Console.WriteLine(emptystring);

//#27
// int count = 0;
// string tbc = "Joshuaaa";
// char [] tbcArray = tbc.ToCharArray();
// for (int i = 0; i < tbcArray.Length-1; i++)
// {
//     if (tbcArray[i]=='a' && tbcArray[i+1]=='a') {
//     count++;
//     }
// }
// Console.WriteLine(count);

//#28
// Console.WriteLine(Test("caabb"));
// Console.WriteLine(Test("babaaba"));
// Console.WriteLine(Test("aaaaa"));
// Console.ReadLine();

// void Test(string str)
// {
//     var counter = 0;
//     for (var i = 0; i < str.Length - 1; i++)
//     {
//         if (str[i] == 'a') counter++;
//         if (str.Substring(i, 2) == "aa" && counter < 2) 
//         {
//             Console.WriteLine("True");
//             return;
//         }
//     }
//     Console.WriteLine("False");
// } 

//#29
// string input = "PHP";
// string result = "";
// for (int i = 0; i < input.Length; i=i+2)
// {
//  result=result+input[i];
// }
// Console.WriteLine(result);

//#30
//aababcabcdabcdeabcdefabcdefg; Output
// string str = "abcdefg";
// string empty2 = "";
// for (int i = 0; i<str.Length; i++){
//     empty2=empty2+str.Substring(0, i+1);
// }
// Console.WriteLine(empty2);

//#31
// string ctring = "gbabcgbdefghgbijklmnopqrstugbvwxyzgbabcdefghijgbklmnopqrstuvwxgbabcdefghijkljk";
// string sub = ctring.Substring(ctring.Length-2);
// int count = 0;
// for (int i=0; i<ctring.Length-4; i++){
//     string sub2 = ctring.Substring(i, 2);
//     if (sub2 == sub){
//         count=count+1;
//     }
//     Console.WriteLine(sub2);
// }
// Console.WriteLine(count);


//#32
// int [] ik = {1, 2, 5, 9};
// int id = 4;
// string truefalse = "Undefined";
// for (int im=0; im<ik.Length; im++){
//     if (id == ik[im]){
//         truefalse = "True";
//     }
//     else{
//         truefalse = "False";
//     }
// }
// Console.WriteLine(truefalse);

//#33
// int [] arr = {1, 3, 32, 6, 3, 20};
// int target = 32;
// string count = "Undefined";
// for(int i=0; i<4; i++){
//  if(target==arr[i]){
//     count = "True";
//     break;
//  }
//  else{
//     count = "False";
//  }
// }
// Console.WriteLine(count);

//#34
// int [] arr = {4, 1, 3, 3, 3, 20};
// for (int i=0; i<arr.Length-2; i++){
//  if (arr[i]==1 && arr[i+1]==2 && arr[i+2]==3){
//      Console.WriteLine("True");
//      break;
//  }
//  if (i==arr.Length-3){
//    Console.WriteLine("False");
//    break;
//  }
// }

//#35
// int Sub(string a, string b)
// {
//     int count = 0;
//     for (int i = 0; i < a.Length - 1 && i < b.Length - 1; i++)
//         if (a.Substring(i, 2) == b.Substring(i, 2)) count++;
//     return count;
// }
// Console.WriteLine(Sub("abcdefgh", "abijsklm"));

//#36
// static string StringX(string str1, string c)
//         {
//             // Iterate through the characters in the string 'str1' starting from the second last character
//             for (int i = str1.Length - 2; i > 0; i--)
//             {
//                 // Check if the current character is equal to the given character 'c'
//                 if (str1[i] == c[0])
//                 {
//                     // If so, remove that character from the string 'str1'
//                     str1 = str1.Remove(i, 1);
//                 }
//             }

//             return str1; // Return the modified string 'str1'
//         }
//     Console.WriteLine(StringX("XxFitxX", "x"));

//#37

string py = "Python";
for (int i=0; i<py.Length; i++){
    string store = "";
    if (py[i] == 0){
        store = store+py[i];
    }
        if (py[i] == 1){
        store = store+py[i];
    }
        if (py[i] == 4){
        store = store+py[i];
    }
        if (py[i] == 5){
        store = store+py[i];
    }
    return store;
}