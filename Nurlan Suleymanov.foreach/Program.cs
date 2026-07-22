#region task1
// Ədədlər massivindəki bütün elementləri faktorialına yüksəldin (məs: {5, 4, 6} -> {120, 24, 720 })
//int[] arr = { 3, 4, 5, 6 };
//for (int i = 0; i < arr.Length; i++)
//{
//    int factorial = 1;
//    for (int j = 1; j <= arr[i]; j++)
//    {
//        factorial *= j;
//    }
//    arr[i] = factorial;
//}
//foreach (int arr2 in arr)
//{
//    Console.WriteLine(arr2);
//}
#endregion
#region task2
// Ədədlər massivində massivdə olan ən kiçik ədədi çıxardın (məs: {7, 12, 5, 8} -> {7, 12, 8})
//int[] arr = { 6, 8, 2, 7, 6, 1 };
//int min = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (min > arr[i])
//    {
//        min = arr[i];
//    }
//}
//int[] num = new int[arr.Length - 1];
//int j = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (min != arr[i])
//    {
//        num [j] = arr[i];
//        j++;
//    }
//}
//foreach (var item in num)
//{
//    Console.WriteLine(item);
//}
#endregion
#region task3
//Verilmiş stringdə yalnız 1 dəfə işlənmiş ilk simvolu çıxışa ver. (məs: "kərtənkələ" -> 'r')
//string metin = "sensasiyonale";

//for (int i = 0; i < metin.Length; i++)
//{
//    int say = 0;

//    for (int j = 0; j < metin.Length; j++)
//    {
//        if (metin[i] == metin[j])
//        {
//            say++;
//        }
//    }

//    if (say == 1)
//    {
//        Console.WriteLine(metin[i]);
//        break;
//    }
//}
#endregion
#region task 4
//N və M ədədi veriləcək. o aralıqda olan polindrom ədədləri tapıb çıxışa verən proqram 
//(tərsinə və düzünə oxunuşu eyni olan ədədlərə polindrom deyilir. məs: 121, 343, 77, 2552)
//int n = 2;
//int m = 200;
//for (int i = n; i <  m; i++)
//{
//    int eded = i;
//    int tersi = 0;
//    while (eded > 0)
//    {
//        int qaliq = eded % 10;
//        tersi = tersi * 10 + qaliq;
//        eded /= 10;
//    }
//    if (tersi == i)
//    {
//        Console.WriteLine(i);
//    }
//}
#endregion
#region task5
//Verilmiş stringdə ən çox təkrarlanan simvolu və neçə dəfə təkrarlandığını çıxışa verən proqram.
//string text = "kertenkele";

//char enCoxSimvol = text[0];
//int maxSay = 0;

//for (int i = 0; i < text.Length; i++)
//{
//    int say = 0;

//    for (int j = 0; j < text.Length; j++)
//    {
//        if (text[i] == text[j])
//        {
//            say++;
//        }
//    }

//    if (say > maxSay)
//    {
//        maxSay = say;
//        enCoxSimvol = text[i];
//    }
//}

//Console.WriteLine(enCoxSimvol);
//Console.WriteLine(maxSay);
#endregion
#region task6
//Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 
//string text = "Salam Nurlan necesen";
//string yeniText = "";

//foreach (char herf in text)
//{
//    if (herf != ' ')
//    {
//        yeniText += herf;
//    }
//}

//Console.WriteLine(yeniText);
#endregion
#region task8
//Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
//string[] sozler = { "Nurlan", "Kamal", "Fidan" };
//char herf = 'a';

//int say = 0;

//foreach (string soz in sozler)
//{
//    foreach (char simvol in soz)
//    {
//        if (simvol == herf)
//        {
//            say++;
//        }
//    }
//}

//Console.WriteLine(say);
#endregion
#region task9
//Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram 
//(Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır
//string text = "   salam necesen?   ";
//string yeniText = "";

//int basla = 0;

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] != ' ')
//    {
//        basla = i;
//        break;
//    }
//}

//for (int i = basla; i < text.Length; i++)
//{
//    yeniText += text[i];
//}

//Console.WriteLine(yeniText);
#endregion
#region task10
//Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. 
//Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.
//(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)
//int a = 10;
//int b = 5;

//char emel;

//Console.Write("Simvol daxil et (+, -, *, /): ");
//emel = Convert.ToChar(Console.ReadLine());

//while (emel != '+' && emel != '-' && emel != '*' && emel != '/')
//{
//    Console.Write("Yanlış simvol! Yenidən daxil et: ");
//    emel = Convert.ToChar(Console.ReadLine());
//}

//switch (emel)
//{
//    case '+':
//        Console.WriteLine(a + b);
//        break;

//    case '-':
//        Console.WriteLine(a - b);
//        break;

//    case '*':
//        Console.WriteLine(a * b);
//        break;

//    case '/':
//        Console.WriteLine(a / b);
//        break;
//}
#endregion
#region task 11
//Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
//string text = "Salam Azer";
//bool tapildi = false;

//foreach (char herf in text)
//{
//    if (herf == 'A')
//    {
//        tapildi = true;
//        break;
//    }
//}

//if (tapildi)
//{
//    Console.WriteLine("A herfi var");
//}
//else
//{
//    Console.WriteLine("A herfi yoxdur");
//}
#endregion
#region task 12
//Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
//string text = "SALAM AZER";
//int say = 0;

//foreach (char herf in text)
//{
//    if (herf == 'A')
//    {
//        say++;
//    }
//}

//Console.WriteLine(say);
#endregion
#region task13
//int n = -16;

//while (n <= 0 || n % 2 != 0)
//{
//    Console.WriteLine("Eded musbet ve cut deyil");

//    }

//Console.WriteLine(n * n);
#endregion
#region task14
//Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
//Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.
//string tehsil = "programming";

//switch (tehsil)
//{
//    case "programming":
//        Console.WriteLine("400 saat");
//        break;

//    case "design":
//        Console.WriteLine("250 saat");
//        break;

//    case "system":
//        Console.WriteLine("200 saat");
//        break;

//    default:
//        Console.WriteLine("tehsil novu yanlisdir");
//        break;
//}
#endregion



