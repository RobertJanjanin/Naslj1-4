using System;


namespace robertJanjaninNaslj1_4
{
   
    class Program
    {
        interface IControl
        {
            void Metoda();
            int Brojac { get; set; }

        }
        class ListBox : IControl
        {
            int brojac;
            public int Brojac
            {
                get { return brojac; }
                set { brojac = value; }
            }

            public void Metoda()
            {
                Console.WriteLine("Metoda List");
            }
        }

        static void Main(string[] args)
        {
            ListBox X = new ListBox();
            X.Metoda();
            Console.ReadKey();

        }
        class ComboBox : IControl {
            int brojac;
            public int Brojac
            {
                get { return brojac; }
                set { brojac = value; }
            }

            public void Metoda()
            {
                Console.WriteLine("Metoda");
            }
        }
 



    }
}
 

