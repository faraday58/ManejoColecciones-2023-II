using System;
using System.Collections;

namespace ManejoColecciones_2023_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList coleccion = new ArrayList();

            coleccion.Add(1);
            coleccion.Add(2);
            coleccion.Add(3);
            Console.WriteLine("Capacity: {0} \n Count: {1}",coleccion.Capacity,coleccion.Count);

            coleccion.Remove(2);
            Console.WriteLine("Capacity: {0} \n Count: {1}", coleccion.Capacity, coleccion.Count);


            foreach (int numero in coleccion  )
            {
                Console.Write(" {0}",numero);
            }
            Console.WriteLine();

            coleccion.Insert(1,"dos");
            coleccion.Add("cuatro");
            coleccion.Add("cinco");
            coleccion.Remove("cuatro");
            coleccion.Add(5.25);
            coleccion.Remove(5.25);
            for(int i=0; i < coleccion.Count; i++  )
            {
                Console.Write(" {0}", coleccion[i]);
            }
            

            Console.WriteLine();
            Console.ReadLine();



        }


    }
}
