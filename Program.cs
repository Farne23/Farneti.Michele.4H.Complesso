using System;

namespace Farneti.michele._4h.complesso
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opeazioni con numeri complessi: MICHELE FARNETI");

            complesso z1 = new complesso();
            complesso z2 = new complesso();
            complesso zr= new complesso();
            string input;
            

            Console.WriteLine("Inserire il primo Operando:");

            Console.WriteLine("Parte reale:");
            input=Console.ReadLine();
            double.TryParse(input, out z1.reale);
            Console.WriteLine("Parte immaginaria:");
            input=Console.ReadLine();
            double.TryParse(input, out z1.immaginaria);

            Console.WriteLine("Inserire il secondo Operando:");

            Console.WriteLine("Parte reale:");
            input=Console.ReadLine();
            double.TryParse(input, out z2.reale);
            Console.WriteLine("Parte immaginaria:");
            input=Console.ReadLine();
            double.TryParse(input, out z2.immaginaria);

            Console.WriteLine("Quale operazione intendi fare (+,-,*,/)");
            input = Console.ReadLine();


            if(input=="+")
            {
                zr.somma(z1, z2);
                Console.WriteLine("Il risultato dell'addizione è :");
            }

            if (input == "-")
            {
                zr.differenza(z1, z2);
                Console.WriteLine("Il risultato della sottrazione è :");
            }

            if (input == "*")
            {
                zr.moltiplicazione(z1, z2);
                Console.WriteLine("Il risultato della moltiplicazione è");
            }

            if (input == "/")
            {
                zr.divisone(z1, z2);
                Console.WriteLine("Il risultato della divisone è");
            }


            Console.Write("Parte reale:");
            Console.WriteLine(zr.reale);
            Console.Write("Parte immaginaria:");
            Console.WriteLine(zr.immaginaria);
            Console.WriteLine("{0}+{1}i", zr.reale,zr.immaginaria);



        }
    }

    class complesso
    {
        public double reale = 0;
        public double immaginaria = 0;

        public void somma(complesso w1, complesso w2)
        {
            reale = w1.reale + w2.reale;
            immaginaria = w1.immaginaria + w2.immaginaria;
        }

        public void differenza(complesso w1, complesso w2)
        {
            reale = w1.reale - w2.reale;
            immaginaria = w1.immaginaria - w2.immaginaria;
        }
        public void moltiplicazione(complesso w1, complesso w2)
        {
            reale = (w1.reale * w2.reale) - (w1.immaginaria * w2.immaginaria);
            immaginaria = w1.reale * w2.immaginaria + w1.immaginaria * w2.reale;
        }

        public void divisone(complesso w1, complesso w2)
        {
            reale = (w1.reale * w2.reale + w1.immaginaria * w2.immaginaria) / (Math.Pow(w2.reale, 2) + Math.Pow(w2.immaginaria, 2));
            immaginaria = (w1.immaginaria * w2.reale - w1.reale*w2.immaginaria) / (Math.Pow(w2.reale, 2) + Math.Pow(w2.immaginaria, 2));
        }

    }
}
