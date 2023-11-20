using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace invoi
{
     class invoice
    {
        public string data;
        public string number_invoice;
        public string adress_client;
        public string name_organization;

       public void Print() {

            Console.WriteLine($"Дата: {data}");
            Console.WriteLine($"Номер фактуры: {number_invoice}");
            Console.WriteLine($"Адрес клиента: {adress_client}");
            Console.WriteLine($"Наименование оранизации: {name_organization}");

        }
    }
    class bottle
    {
        public string[] volume; //объем 
        public int[] quantity; // количество 
        public int[] price; // цена
        public int[] summ;// сумма
                     
             
        public void Print_2()
        {
            Console.WriteLine($"Объем: {volume[0]} Количество: {quantity[2]} ");
            Console.WriteLine($"Объем: {volume[2]} Количество: {quantity[2]} ");
            Console.WriteLine($"Объем: {volume[3]} Количество: {quantity[0]} ");
            
        }
       
    }
    class add:bottle
       
    { 
    
    public int[] ballon; // баллон
    public int[] package; //пакет
    public int[] packing; // фасовка

        public void Print_3()
        {
            Console.WriteLine($"Количество баллонов: {quantity[2]} ");
        }


    }
  
}
    

