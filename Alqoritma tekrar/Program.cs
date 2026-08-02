//for (int i = 1; i <=50; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"{i} cüt ededir");
//    }
//    else 
//    { 
//        Console.WriteLine($"{i} tək ededir"); 
//    }
//}
//int a = 5;
//int b = 10;
//int c = 15;
//if (a > b && a > c)
//{
//    Console.WriteLine($"{a} ən böyük ədəddir");
//}
//else if (b > a && b > c)
//{
//    Console.WriteLine($"{b} ən böyük ədəddir");
//}
//else
//{
//    Console.WriteLine($"{c} ən böyük ədəddir");
//}
//int count  = 0;
//int count1 = 0;
//int count2 = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 3 == 0)
//    {
//        count++;
//    }
//    if (i % 5 == 0)
//    {
//        count1++;
//    }
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        count2++;
//    }
//}
//Console.WriteLine($"3-ə bölünən ədədlərin sayı: {count}");
//Console.WriteLine($"5-ə bölünən ədədlərin sayı: {count1}");
//Console.WriteLine($"3 və 5-ə bölünən ədədlərin sayı: {count2}");
//int a = 524;
//int teklik = a % 10;
//int onluq = (a / 10) % 10;
//int yuzluk = (a / 100) % 10;
//int toplam = teklik + onluq + yuzluk;
//Console.WriteLine($"Ədədin rəqəmlərinin cəmi: {toplam}");
//int a = 55252;
//int sum = 0;
//while (a > 0)
//{
//    sum += a % 10;
//    a /= 10;
//}
//Console.WriteLine($"Ədədin rəqəmlərinin cəmi: {sum}");
//int a = 526;
//int ters = 0;

//while (a > 0)
//{
//    int reqem = a % 10;
//    ters = ters * 10 + reqem;
//    a /= 10;
//}

//Console.WriteLine(ters);
//int a = 555;
//int count = 0;

//while (a > 0)
//{
//    a = a / 10;
//    count++;
//}
//Console.WriteLine($"Ədədin rəqəmlərinin sayı: {count}");

//int a = 1211;
//int original = a;
//int ters = 0;

//while (a > 0)
//{
//    int reqem = a % 10;
//    ters = ters * 10 + reqem;
//    a /= 10;
//}
//if (original == ters)
//{
//    Console.WriteLine("palindiromdur");
//}
//else
//{
//    Console.WriteLine("palindrom deyil");
//}   

//int a = 555553515;
//int cout = 0;
//int reqem = 0;
//while (a > 0)
//{
//    reqem = a % 10;
//    if (reqem == 5)
//    {
//        cout++;
//    }
//    a = a / 10;
//}
//Console.WriteLine(cout);

//int a = 11111;

//int max = 0;
//int secondMax = 0;

//while (a > 0)
//{
//    int reqem = a % 10;

//    if (reqem > max)
//    {
//        secondMax = max;
//        max = reqem;
//    }
//    else if (reqem > secondMax && reqem < max)
//    {
//        secondMax = reqem;
//    }

//    a /= 10;
//}

//Console.WriteLine($"En boyuk reqem: {max}");
//Console.WriteLine($"Ikinci en boyuk reqem: {secondMax}");

using System.ComponentModel.DataAnnotations;

//int[] arr = { 10, 12, 31, 14, 5, 19, 70};
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i]; 
//    }
//}

//Console.WriteLine($"En boyuk reqem: {max}");    


//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}

//Console.WriteLine(sum);


int[] arr = { 10, 12, 31, 14, 5, 19, 70 };
int max = arr[0];
int min = arr[1];
int ferq = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
    ferq = max - min;
}
Console.WriteLine(ferq);





