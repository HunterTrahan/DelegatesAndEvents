using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new list
            ListWithChangeEvent list = new ListWithChangeEvent();

            //Create a class that listens for when the list is chnaged.
            EventListener listener = new EventListener(list);

            list.Add("hello");
            list.Add("world");
            list.Clear();
            listener.Detatch();

            void Default( char key)
            {
                if (key == 'e')
                {
                    Console.Beep();
                }

                else if (key == 'r')
                {
                    Console.Beep();
                }
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
