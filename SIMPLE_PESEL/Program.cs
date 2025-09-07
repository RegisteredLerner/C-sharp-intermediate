using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prosty generator numeru PESEL");
        Console.WriteLine("Podaj rok urodzenia");
        int age = Convert.ToInt32(Console.ReadLine());
        
        while (age > 2099 || age < 1800)
        {   
            Console.WriteLine("Podaj poprawny rok urodzenia");
            age = Convert.ToInt32(Console.ReadLine());
        }
        bool luty = false; ;
        if ((age % 4 == 0 && age % 100 != 0) || age % 400 == 0)
        {
            luty = true;
        }
        Console.WriteLine("Podaj miesiac urodzenia");
        int month = Convert.ToInt32(Console.ReadLine());
        while (month > 12 || month < 0)
        {
            Console.WriteLine("Podaj poprawny numer miesiąca");
            month = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Podaj dzien urodzenia");
        int day = Convert.ToInt32(Console.ReadLine());
        while (day > 32 || day < 0)
        {
            Console.WriteLine("Podaj poprawny dzień miesiąca");
            day = Convert.ToInt32(Console.ReadLine());
        }
        while(day == 29 && month == 2 && luty == false)
        {
            Console.WriteLine("Rok nie jest przestepny wiec nie ma 29 dni w lutym");
            day = Convert.ToInt32(Console.ReadLine());
        }
        while((day == 30 || day == 31) && month == 2)
        {
            Console.WriteLine("Podaj poprawny dzień miesiąca");
            day = Convert.ToInt32(Console.ReadLine());
        }
        while((day == 31) && month == 4)
        {
            Console.WriteLine("Podaj poprawny dzień miesiąca");
            day = Convert.ToInt32(Console.ReadLine());
        }
        while((day == 31) && month == 6)
        {
            Console.WriteLine("Podaj poprawny dzień miesiąca");
            day = Convert.ToInt32(Console.ReadLine());
        }
        while((day == 31) && month == 9)
        {
            Console.WriteLine("Podaj poprawny dzień miesiąca");
            day = Convert.ToInt32(Console.ReadLine());
        }
        while((day == 31) && month == 11)
        {
            Console.WriteLine("Podaj poprawny dzień miesiąca");
            day = Convert.ToInt32(Console.ReadLine());
        }

        string aged = age.ToString();
        char[] pesel = new char[11];
        pesel[0] = aged[2];
        pesel[1] = aged[3];
        string control = "";
        switch (age)
        {
            case >= 1800 and <= 1899:
                switch (month)
                {
                    case 1:
                        control = "81";
                        break;
                    case 2:
                        control = "82";
                        break;
                    case 3:
                        control = "83";
                        break;
                    case 4:
                        control = "84";
                        break;
                    case 5:
                        control = "85";
                        break;
                    case 6:
                        control = "86";
                        break;
                    case 7:
                        control = "87";
                        break;
                    case 8:
                        control = "88";
                        break;
                    case 9:
                        control = "89";
                        break;
                    case 10:
                        control = "90";
                        break;
                    case 11:
                        control = "91";
                        break;
                    case 12:
                        control = "92";
                        break;

                }
                break;
            case >= 1900 and <= 1999:
                switch (month)
                {
                    case 1:
                        control = "01";
                        break;
                    case 2:
                        control = "02";
                        break;
                    case 3:
                        control = "03";
                        break;
                    case 4:
                        control = "04";
                        break;
                    case 5:
                        control = "05";
                        break;
                    case 6:
                        control = "06";
                        break;
                    case 7:
                        control = "07";
                        break;
                    case 8:
                        control = "08";
                        break;
                    case 9:
                        control = "09";
                        break;
                    case 10:
                        control = "10";
                        break;
                    case 11:
                        control = "11";
                        break;
                    case 12:
                        control = "12";
                        break;

                }
                break;
            case >= 2000 and <= 2099:
                switch (month)
                {
                    case 1:
                        control = "21";
                        break;
                    case 2:
                        control = "22";
                        break;
                    case 3:
                        control = "23";
                        break;
                    case 4:
                        control = "24";
                        break;
                    case 5:
                        control = "25";
                        break;
                    case 6:
                        control = "26";
                        break;
                    case 7:
                        control = "27";
                        break;
                    case 8:
                        control = "28";
                        break;
                    case 9:
                        control = "29";
                        break;
                    case 10:
                        control = "30";
                        break;
                    case 11:
                        control = "31";
                        break;
                    case 12:
                        control = "32";
                        break;

                }
                break;

        }
        pesel[2] = control[0];
        pesel[3] = control[1];
        string dayday = day.ToString();
        if (day < 10)
        {
            pesel[4] = '0';
            pesel[5] = dayday[0];
        }
        else
        {
            pesel[4] = dayday[0];
            pesel[5] = dayday[1];
        }
        Random rnd = new Random();
        int randomized1 = rnd.Next(1, 10);
        int randomized2 = rnd.Next(1, 10);
        int randomized3 = rnd.Next(1, 10);
        string rand1 = randomized1.ToString();
        pesel[6] = rand1[0];
        string rand2 = randomized2.ToString();
        pesel[7] = rand2[0];
        string rand3 = randomized3.ToString();
        pesel[8] = rand3[0];
        Console.WriteLine("Podaj plec (WPISZ K LUB M)");
        string gender = Console.ReadLine();
        gender = gender.ToLower();
        while(gender != "k" && gender != "m")
        {
            Console.WriteLine("WPISZ K LUB M");
            gender = Console.ReadLine();
            gender.ToLower();
        }
        if (gender == "k")
        {
            int min = 0;
            int max = 10;
            Random random = new Random();

            int nextnum = random.Next(min / 2, max / 2) * 2;
            string gendered = nextnum.ToString();
            pesel[9] = gendered[0];
        }
        else
        {
            int min = 0;
            int max = 10;
            Random random = new Random();

            int nextnum = random.Next(min / 2, max / 2) * 2;
            nextnum += 1;
            string gendered = nextnum.ToString();
            pesel[9] = gendered[0];

        }
        int[] Aint = Array.ConvertAll(pesel, c => (int)Char.GetNumericValue(c));
        int[] kontrola = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        int suma = 0;
        for (int i = 0; i < Aint.Length - 1; i++)
        {
            suma += kontrola[i] * Aint[i];
        }
        int wynik = suma % 10;
        int m = 10 - wynik;
        int ostatecznywnynik = suma + m;
        
        string kontrolna = m.ToString();
        pesel[10] = kontrolna[0];
        string peselzchara = new string(pesel);
        Console.WriteLine("Twoj wygenerowany numer pesel:"+peselzchara);
        Console.WriteLine("Jeżeli ostatnia cyfra tego numeru jest zerem to pesel jest poprawny\n"+ostatecznywnynik);

        
        

        

        
   }
}