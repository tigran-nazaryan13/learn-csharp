//#78
// string string1 = "water";
// string string2 = "rook";
// string string3 = "";
// if (string1[string1.Length-1] == string2[0]){
//     string newstr2 = string2.Substring(1, string2.Length-1);
//     string3=string1+newstr2;
//     Console.WriteLine(string3);
// }

//#79
// string string1 = "Python";
// string string2 = "Nohtyp";
// string newstr = string1.Substring(string1.Length-2)+string1
// Console.WriteLine

//#80
// string str = "abcxyz";
// if (str.StartsWith("abc")){
//     Console.WriteLine("abc");
// }
// if (str.StartsWith("xyz")){
//     Console.WriteLine("xyz");
// }

//#81
// string str = "bcaabc";
// string str1 = str.Substring(0, 2);
// if (str.StartsWith(str1) && str.EndsWith(str1)){
//     System.Console.WriteLine("True");
// }

//#82
// string str1 = "abc";
// string str2 = "abcd";
// string str3 = str1+str2.Substring(1, str1.Length);
// System.Console.WriteLine(str3);

//#83
// string str1 = "Python";
// string str2 = str1.Substring(0, 2);
// System.Console.WriteLine(str2+str2+str2);

//#84
// string str1 = "abcab";
// string str2 = str1;
// string str3 = str1.Substring(0, 2);
// if (str1.StartsWith(str3) && str1.EndsWith(str3)){
//     string str4 = str2.Substring(2, str1.Length-2);
//     System.Console.WriteLine(str4);
// }

//#85
// static string ProcessString(string str)
//     {
//         string result = "";

//         if (str.Length >= 1 && str[0] == 'p')
//             result += str[0];

//         if (str.Length >= 2 && str[1] == 'y')
//             result += str[1];

//         if (str.Length > 2)
//             result += str.Substring(2);

//         return result;
//     }
//     Console.WriteLine(ProcessString("python"));

//#86
// static string ProcessString(string str)
//     {
//        if (str.StartsWith('a') && str.EndsWith('a')){
//         return str;
//        }
//        else{
//         str = str.Remove(0, 1);
//        }
//        return str;
//     }
// Console.WriteLine(ProcessString("bcbcbc"));