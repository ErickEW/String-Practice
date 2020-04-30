using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           string helloWorld = "Hello World!";
           System.Console.WriteLine(helloWorld.Substring(6));
           System.Console.WriteLine(helloWorld.Substring(6, 5));

           string a = "AAA";
           string b = "BBB";

           a += b;
           System.Console.WriteLine(a);

           string ave = "ave ";
           string banco = "banco ";
           string comida = "comida ";
           string duda = "duda ";
           string ejercisio = "ejercisio ";
           string fuente = "fuente ";
           string girasol = "girasol ";

           System.Console.WriteLine(ave + banco + comida + duda + ejercisio + fuente + girasol);

           System.Console.WriteLine("\n\nReplace");
           fuente = fuente.Replace("fuente", "Fuente");
           ejercisio = ejercisio.Replace("ejercisio", "EJERCISIO");
           duda = ejercisio.Replace("ejercisio", "EJERCISIO");
           comida = comida.Replace("comida", "COMIDA");
           banco = banco.Replace("banco", "BANCO");
           System.Console.WriteLine("\n\nSplit");
           string cosas = "ave, banco, comida, comida, duda, ejercisio, fuente, girasol";

           string[] cosasArray = cosas.Split(",");
           foreach ( string cosa in cosasArray)
           {
               System.Console.WriteLine($"cosas => {cosa}");
           }
           {
               
           }

           Console.WriteLine((ave + banco + comida + duda + ejercisio + fuente + girasol));
        }
    }
}
