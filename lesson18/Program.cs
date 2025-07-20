
// // // void myfunction(){
// // // Random rnd = new Random();
// // // int month  = rnd.Next(1, 11);
// // // int readline = int.Parse(Console.ReadLine());
// // // if (readline == month){
// // //     Console.WriteLine("Correct");
// // // }
// // // else{
// // //     Console.WriteLine("Incorrect");
// // // }
// // // }
// // // myfunction();

// // int myfunction(string ctring)
// // {
// //     string sub = ctring.Substring(ctring.Length - 2);
// //     int count = 0;
// //     for (int i = 0; i < ctring.Length - 4; i++)
// //     {
// //         string sub2 = ctring.Substring(i, 2);
// //         if (sub2 == sub)
// //         {
// //             count = count + 1;
// //         }
// //     }
// //     return count;
// // }

// // // Console.WriteLine(myfunction("Textghjuikgholsdghiejgh"));

// // bool goodfunction(int[] arr, int number)
// // {
// //     foreach (int i in arr)
// //     {
// //         if (i == number)
// //         {
// //             // Console.WriteLine(i);
// //             return true;
// //         }

// //     }
// //     return false;
// // }
// // int[] myarr = { 2, 5, 0, 3, 2 };
// // Console.WriteLine(goodfunction(myarr, 1));

// int[] arr = { 1, 4, 9, 3, 2 };
// int number = 8;
// int i = 0;
// while (i < 4)
// {
//     if (arr[i] == number)
//     {
//         Console.WriteLine("True");
//         break;
//     }

//     i++;
//     if (i == 4){
//     Console.WriteLine("False");
//     }
// }

int[] arr = { 4, 5, 1, 2 };
int i = 0;
while (i < arr.Length-2)
{
    if (arr[i] == 1 && arr[i+1] == 2 && arr[i+2] == 3)
    {
        Console.WriteLine("True");
        break;
    }

    i++;

}

