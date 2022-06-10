using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class Program
    {
        struct Cheking
        {
            string name;
            double price;
            int quantity;
            

            public Cheking(double price, int quantity, string name)
            {
                this.price = price;
                this.quantity = quantity;
                this.name = name;
                
            }

            public void Show(Cheking[] cheking)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                double sums=0;
                int length = (Console.InputEncoding.ToString()).Length+10;
                int height = 3* cheking.Length+1;
                Console.SetWindowSize(length, height);
                Console.SetBufferSize(length, height);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t" + "\t" + "ALEX BAR " + "\t" + "\t");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine();
                for (int i = 0; i < cheking.Length; i++)
                {
                    sums += cheking[i].quantity * price;
                    Console.WriteLine(cheking[i].name + " \t" + cheking[i].quantity + "x\t" + " \t" + cheking[i].quantity * cheking[i].price + "$");
                    Console.WriteLine();
                   // sums += cheking[i].quantity * price;
                }
                Console.WriteLine("\t\t\t TOTAL :" + sums);
                Console.WriteLine("TEL. : +3800-000-00-00");
                Console.WriteLine("FAX. : +3800-000-00-00");
                Console.WriteLine("E-mail alexbar.@gmail.com");
                Console.ReadLine();
                Console.ReadLine();
                Console.ResetColor();
            }
        }

        

        static void Main(string[] args)
        {
            Cheking[] ch= new Cheking[7];
            ch[0] = new Cheking(5,1, "Some product  ");
            ch[1] = new Cheking(5, 1, "Some product");
            ch[2] = new Cheking(15, 2, "Some product");
            ch[3] = new Cheking(2, 5, "Some product");
            ch[4] = new Cheking(50, 2, "Some product");
            ch[5] = new Cheking(50, 1, "Product  ");
            ch[6] = new Cheking(50, 2, "Some product");

            ch[6].Show(ch);
        }
    }
}
