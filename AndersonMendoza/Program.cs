using System;

namespace AndersonMendoza
{
    class Program
    {
        static void Main(string[] args)
        {

            Program pgr = new Program();

            try
            {
              pgr.PrimerPunto();
                Console.WriteLine("\n");
              pgr.SegundoPunto();
                Console.WriteLine("\n");
              string result = pgr.TercerPunto();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error en el envio");
            };
        }

        void PrimerPunto()
        {
            /*1: Tiene un arreglo (llamado myArray) con 5 elementos (enteros en el rango de 1 a 100).
           Escriba un programa en C# que imprima el número más alto del arreglo (Si se repite, solo
           imprimir una vez). El programa solo debe imprimir el número, sin ningún texto.*/
            int[] myArray = { 2, 45, 35, 45, 45 };

            int acum = 0;

            for (var i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= acum)
                {
                    acum = myArray[i];
                }
            }

            Console.WriteLine(acum);
        }
    
        void SegundoPunto()
        {
            /*2: Escriba un programa en C# que recorra un arreglo y genere un histograma en base a los
                números de este. El arreglo se llama myArray y contiene 10 elementos que corresponden
                a números enteros del 1 al 5.*/

            int[] myArray2 = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };

            string cont1 = "";
            string cont2 = "";
            string cont3 = "";
            string cont4 = "";
            string cont5 = "";

            for (var k = 0; k < myArray2.Length; k++)
            {
                switch (myArray2[k])
                {
                    case 1:
                        cont1 = cont1 + "*";
                        break;
                    case 2:
                        cont2 = cont2 + "*";
                        break;
                    case 3:
                        cont3 = cont3 + "*";
                        break;
                    case 4:
                        cont4 = cont4 + "*";
                        break;
                    case 5:
                        cont5 = cont5 + "*";
                        break;
                }
            }

            Console.WriteLine("1:" + cont1);
            Console.WriteLine("2:" + cont2);
            Console.WriteLine("3:" + cont3);
            Console.WriteLine("4:" + cont4);
            Console.WriteLine("5:" + cont5);
        }
    
        string TercerPunto()
        {
            /*3: Dado el siguiente arreglo [1,8,6,7,2,5] Escribir un programa utilizando CSharp que
            encuentre los dos elementos del arreglo que sumados dan 10. Se deben imprimir ambos
            números como resultado separados por un espacio*/

            int[] myArray = { 1, 3, 6, 2, 2, 4 };
            int acum = 0;
            int acum2 = 0;
            for(var i = 0;i < myArray.Length; i++)
            {
                acum = myArray[i];

                for(var k = 1;k < myArray.Length; k++)
                {
                    if(acum + myArray[k] == 10)
                    {
                        acum2 = myArray[k];
                        return acum + " " + acum2;
                    }
                }
            }
            return "Ninguna suma de numeros cumple con la condicion.";
        }
    }
}
