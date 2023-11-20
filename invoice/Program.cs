using invoi;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Account 
{
    class Programm
    {
        static void Main()
        {


            invoice Invoice = new invoice();
            Invoice.data = new string("12-04-2023");
            Invoice.number_invoice = new string("365");
            Invoice.adress_client = new string("Ул.Алтайская, д. 114");
            Invoice.name_organization = new string("маг.Гараж");
            Invoice.Print();
            Console.WriteLine("_________________");
            bottle Bootle = new bottle();
            Bootle.volume = new string[6] { "0.5л", "1л", "1.5л", "2л", "3л", "4л" };
            Bootle.quantity = new int[3] { 50, 100, 500 };
            Bootle.price = new int[6] { 7, 10, 11, 13, 16, 25 };
            var _summ1 = Bootle.quantity[2] * Bootle.price[0];
            var _summ2 = Bootle.quantity[2] * Bootle.price[2];
            var _summ3 = Bootle.quantity[0] * Bootle.price[3];

            var c = (_summ1 + _summ2 + _summ3);
            add ADD = new add();
            ADD.price = new int[] { 1800 };
            ADD.quantity = new int[3] { 0, 2, 3 };
            var B = ADD.price[0] * ADD.quantity[2];
            var S = c + B;
            Bootle.Print_2();
             ADD.Print_3();
            Console.WriteLine("Цена:" +S);
           
        }

       
    
    }




}