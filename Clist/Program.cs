using System;
using System.Collections.Generic;

namespace Clist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de animais");

            List<string> lista = new List<string>();

            lista.Add("Macaco");
            lista.Add("Tigre");
            lista.Add("Leão");
            lista.Add("Girafa");

            lista.Insert(1, "Elefante");

            lista.Remove("Girafa");

            lista.RemoveAt(2);

            foreach (string nome in lista)
            {
                Console.WriteLine($"Aqui esta a Animal: {nome}");
            }
        }
    }
}