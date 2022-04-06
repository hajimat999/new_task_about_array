using System;

namespace newhomework05
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task--1

            //Task - 1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod -3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa
            //onu tapib return edir Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da yazin(method overloading)


            //    Console.WriteLine("deyer daxil edin");




            //    string a = Console.ReadLine();

            //    string b = Console.ReadLine();

            //    string c = Console.ReadLine();


            //    try
            //    {
            //        int aa = int.Parse(a);

            //        int bb = int.Parse(b);

            //        int cc = int.Parse(c);



            //        Sum(aa, bb, cc);

            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("tam ededler daxil edin");
            //    }


            //    int[] array2 = { 1, 2, 3, 4 };

            //    Sum(array2);

            //    int[] array3 = { 200, 56, 78, 90, 1000 };

            //    Sum(array3);

            //}

            //static int Sum(params int[] nums)
            //{
            //    int max = 0;

            //    for (int i = nums.Length - 1; i >= 0; i--)
            //    {

            //        if (max <= nums[i])
            //        {
            //            max = nums[i];
            //        }


            //    }
            //    Console.WriteLine(max);
            //    return max;

            //}




            //static int Sum(int[] nums, int a)
            //{

            //    int max = 0;

            //    for (int i = nums.Length - 1; i >= 0; i--)
            //    {

            //        if (max <= nums[i])
            //        {
            //            max = nums[i];
            //        }


            //    }
            //    Console.WriteLine(max);
            //    return max;





            //}

            //static int Sum(int[] nums, int b, int c)
            //{

            //    int max = 0;

            //    for (int i = nums.Length - 1; i >= 0; i--)
            //    {

            //        if (max <= nums[i])
            //        {
            //            max = nums[i];
            //        }


            //    }
            //    Console.WriteLine(max);
            //    return max;





            //}




































            #endregion

            #region Task--2

            //    Console.WriteLine("eded daxil et");
            //    string a = Console.ReadLine();

            //    try
            //    {
            //        int aa = int.Parse(a);
            //        sum(aa);

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("duzgun deyer daxil et");
            //            
            //      
            //    }





            //}

            //static int sum(int a)
            //{
            //    int mod = 0;
            //    int sum = 0;


            //    while(a >= 1)
            //    {
            //        mod = a % 10;
            //        a = a - mod;
            //        a = a / 10;
            //        sum += mod;

            //    }
            //    Console.WriteLine(sum);
            //    return sum;
            //}
            #endregion

            #region Task--3
            //Task - 3
            //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir, 
            //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək məbləği hesbalayan metod yazin -yəni metodunuz 3 doubel parameter
            //qebul edib en boyuk ikisinin cemini hesablayib qaytarmalidir

            //    Console.WriteLine("3 dene eded daxil edin");

            //    string a = Console.ReadLine();
            //    string b = Console.ReadLine();
            //    string c = Console.ReadLine();

            //    try
            //    {
            //        double aa = int.Parse(a);
            //        double bb = int.Parse(b);
            //        double cc = int.Parse(c);
            //        Sum(aa, bb, cc);

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("duzgun deyer daxil edin");


            //    }







            //}

            //static double Sum(params double[] arr)
            //{
            //    double max1 = 0;
            //    double max2 = 0;

            //    for (int i = arr.Length-1; i >= 0; i--)
            //    {
            //        if(max1 < arr[i])
            //        {
            //            max2 = max1;
            //            max1 = arr[i];
            //        }
            //        else if(arr[i] > max2)
            //        {
            //            max2 = arr[i];
            //        }

            //    }


            //    Console.WriteLine(max1 + max2);

            //    return 9;
            //}


            #endregion

            #region Task--4
            //static void Main(string[] args)
            //{
            //    int[] array = { 1, 3, 2, 6, 5 };

            //    Sum(array);








            //}
            //static int Sum(int [] arr)
            //{
            //    int a = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if(arr[i] > arr[j])
            //            {
            //                a = arr[j];
            //                arr[j] = arr[i];
            //                arr[i] = a;

            //            }

            //        }
            //        Console.WriteLine(arr[i]);

            //    }
            //    return 7;
            //}
            #endregion
        }
    }
