using System;

namespace Homework_for_3thDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Verilmiş yazıda rəqəm olub olmadığını tapan metod
            //Console.WriteLine(IsDigit("Salam777"));
            #endregion

            #region Task2
            //Verilmiş yazının fullname olub olmadığını tapan metod
            //Console.WriteLine(IsFullName("Elvin Bayramov"));
            #endregion

            #region Task3
            //Verilmiş ədədlər siyahısından yeni bir array düzəldib
            //qaytaran metod.Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.

            //int[] array = { 1, 4, 6, 8, 9, 11, 13 };
            //var result = MakeNewArr(array);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            #endregion

            #region Task4
            //Verilmiş email-lər siyahısından domainlər siyahısı düzəldən
            //metod.Domainlər arrayondə təkrarlanmamlıdır domainlər!


            //string[] mails = { "ceyhun@mail.com", "elvin@edu.com", "xaliq123@gmail.ru", "rasimm23@yandex.com" };
            //var result = MakeDomain(mails);
            //for (int i = 0; i < mails.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            #endregion

            #region Dersde etdiklerimiz
            //Verilmis yazini bas herfi boyuk digerleri kicik halda qaytaran metod
            //string studentname = "ReHIm";
            //CorrectedName(ref studentname);
            //Console.WriteLine(studentname);



            //cosole-da email deyeri istenilsin. Eger deyerde @ xarakteri yoxdursa yeniden istenilsin
            //string mail;
            //do
            //{
            //    Console.WriteLine("mail daxil edin :");
            //    mail = Console.ReadLine();

            //} while (!mail.Contains('@'));



            //string nameInput;
            //do
            //{
            //    Console.WriteLine("Adinizi daxil edin:");
            //    nameInput = Console.ReadLine();

            //} while (IsName(nameInput) == false);
            #endregion

        }

        //static bool IsName(string name)
        //{
        //    if (!char.IsUpper(name[0]))
        //    {
        //        return false;
        //    }
        //    for (int i = 1; i < name.Length; i++)
        //    {
        //        if (!char.IsLower(name[i]))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        #region Task1
        //static bool IsDigit(string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (char.IsDigit(str[i])){
        //            return true;
        //        }

        //    }
        //    return false;
        //}
        #endregion

        #region Task2
        //static bool IsFullName(string str)
        //{
        //    int count = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            count++;
        //        }
        //        if (count < 2)
        //        {
        //            var words = str.Split(' ');
        //            if (IsName(words[0]) && IsName(words[1]))
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Task3

        //static int[] MakeNewArr(int[] array)
        //{
        //    int[] newArr = new int[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (Array.IndexOf(newArr, array[i]) == -1)
        //        {
        //            Array.Resize(ref newArr, newArr.Length + 1);
        //            newArr[newArr.Length - 1] = array[i];
        //        }
        //    }
        //    return newArr;
        //}
        #endregion

        #region Task4
        //static string[] MakeDomain(string[] mails)
        //{
        //    for (int i = 0; i < mails.Length; i++)
        //    {
        //        mails[i] = mails[i].Substring(mails[i].IndexOf('@') + 1);
        //    }
        //    var result = new string[0];
        //    for (int i = 0; i < mails.Length; i++)
        //    {
        //        if (Array.IndexOf(result, mails[i]) == -1)
        //        {
        //            Array.Resize(ref result,result.Length +1 );
        //            result[result.Length - 1] = mails[i];
        //        }
        //    }
        //    return result;
        #endregion

        #region Dersde etdiklerimiz
        //static void CorrectedName(ref string str)
        //{
        //    str = char.ToUpper(str[0]) + str.Substring(1).ToLower();
        //}



        //static bool IsName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //        return false;

        //    if (!char.IsUpper(name[0]))
        //        return false;

        //    for (var i = 1; i < name.Length; i++)
        //    {
        //        if (!char.IsLower(name[i]))
        //            return false;
        //    }
        //    return true;
        //}
        #endregion




    }









}

