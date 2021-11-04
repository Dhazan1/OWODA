using System;

namespace OWODA
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket customer = new Ticket();
           // double totalMoney;
            int a = 5;  
            while (a<10)
            {
              customer.GenTicket();
            //  customer.GenTicketId();
             //   Console.WriteLine(totalMoney);
               a++;
            }
        }
    }

     class Ticket
    {

        int totalTicket = 0;
       double totalAmount = 0;
        Random rmd = new Random();
        int[] ticketId = { };
        public void GenTicket()
        {
           
            Console.WriteLine("Enter type of ticket you wish to buy");
          string ticketType = Console.ReadLine();
           switch (ticketType)
           { case "month":totalAmount = totalAmount + 1000; break;
            case "day": totalAmount = totalAmount + 500;  break;
            default :totalAmount = totalAmount + 0;break;
           }
            Console.WriteLine("Total amount is now\n",totalAmount);
           // return totalAmount; 

        }
     /* public void GenTicketId()
         {
           int newId = rmd.Next(1, 100);
           for(int i=0; i<totalTicket;i++){
                while (newId == ticketId[i])
           { newId = rmd.Next(1, 100); }
        }
            ticketId[totalTicket + 1] = newId;
       }          
   */





    }





}
