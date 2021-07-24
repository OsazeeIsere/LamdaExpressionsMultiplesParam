using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionsMultiplesParam
{
    class Program
    {
        static void Main(string[] args)
        {

            // Register with delegate as Lamda Expression
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((mesg, result) =>
            {
                Console.WriteLine("{0}, result: {1}",mesg,result);
            });

            //the following execute the Lamda Expression
            m.Add(10, 10);

            //trying to print "Enjoy your string"
            VerySimpleDelegate d = new VerySimpleDelegate(() => { return "Enjoy you String"; });
            Console.WriteLine(d());

            Console.ReadLine();

        }
        public delegate string VerySimpleDelegate();

    }
}
