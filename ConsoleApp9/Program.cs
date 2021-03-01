using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06Lib2;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer[] arrPrinters;
            Console.Write("Введiть кiлькiсть принтерів: ");
            int cntPrinters = int.Parse(Console.ReadLine());
            arrPrinters = new Printer[cntPrinters];
            for (int i = 0; i < cntPrinters; i++)
            {
                Console.Write("Введiть назву принтера: ");
                string sName = Console.ReadLine();
                Console.Write("Введiть призначення: ");
                string sAppointment = Console.ReadLine();
                Console.Write("Введiть технологію друку: ");
                string sPrinting_technology = Console.ReadLine();
                Console.Write("Введiть кiлькiсть покупців: ");
                string sBuyers = Console.ReadLine();
                Console.Write("Введiть рiчний дохiд з продажу даного принтеру: ");
                string sYearIncome = Console.ReadLine();
                Console.Write("Введiть площу, м^2: ");
                string sSquare = Console.ReadLine();
                Console.Write("Чи є фотодрук? (y-так, n-нi): ");
                ConsoleKeyInfo keyHasPhotoprinting = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Чи є двусторонній друк? (y-так, n-нi): ");
                ConsoleKeyInfo keyHasTwo_sided_printing = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                Printer thePrinter = new Printer();
                thePrinter.Name = sName;
                thePrinter.Appointment = sAppointment;
                thePrinter.Printing_technology = sPrinting_technology;
                thePrinter.Buyers = int.Parse(sBuyers);
                thePrinter.YearIncome = double.Parse(sYearIncome);
                thePrinter.Square = double.Parse(sSquare);
                thePrinter.HasPhotoprinting = keyHasPhotoprinting.Key == ConsoleKey.Y ? true : false;
                thePrinter.HasTwo_sided_printing =
                keyHasTwo_sided_printing.Key == ConsoleKey.Y ? true : false;
                arrPrinters[i] = thePrinter;
            }
            foreach (Printer t in arrPrinters)
            {
                Console.WriteLine();
                Console.WriteLine("------------");
                Console.WriteLine("Данi про принтер {0}", t.Name);
                Console.WriteLine("------------");
                Console.WriteLine("Призначення: " + t.Appointment);
                Console.WriteLine("Технологія друку: " + t.Printing_technology);
                Console.WriteLine("Кiлькiсть покупців: " +
                t.Buyers.ToString());
                Console.WriteLine("Рiчний дохiд: " +
                t.YearIncome.ToString("0.00"));
                Console.WriteLine("Площа: " + t.Square.ToString("0.000"));
                Console.WriteLine(t.HasPhotoprinting ? "Принтер має фотодрук" :
                "Принтер не має фотодруку");
                Console.WriteLine(t.HasTwo_sided_printing ? "Принтер має двусторонній друк" :
                "Принтер не має двустороннього друку");
                Console.WriteLine();
                Console.WriteLine("Середня річна витрата одного покупця: " +
                t.yearIncomePerBuyer.ToString("0.00"));

            }
            Console.ReadKey();
        }
    }
 }

