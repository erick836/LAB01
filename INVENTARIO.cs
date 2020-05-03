using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LABORATORIO_I
{
    class INVENTARIO
    {
        USUARIOS USER = new USUARIOS();
        static string RUTA = "INVENTARIO.txt";
        static int Z;
        static StreamWriter ES;

        static string DATOS(string X)
        {
            Console.Clear();
            Console.WriteLine("INGRESE " + X + ":");
            return (Console.ReadLine());
        }
        static void PRODUCTO(string NOMBRE, string CANTIDAD, string PRECIO)
        {
            Console.Clear();
            ES = File.AppendText(RUTA);
            ES.WriteLine("PRODUCTO: " + NOMBRE + "\nCANTIDAD: " + CANTIDAD + "\nPRECIO: " + PRECIO);
            ES.Close();
        }
        public void IN()
        {
            char OP = 'S';
            while (OP != 'N')
            {
                PRODUCTO(DATOS("PRODUCTO"), DATOS("CANTIDAD"), DATOS("PRECIO"));
                ES = File.AppendText(RUTA);
                ES.WriteLine("---------------------------");
                ES.Close();
                Console.Clear();
                Console.WriteLine("DESEA INGRESAR OTRO PRODUCTO? [S/N]:");
                OP = char.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("DESEA IR AL INICIO? \n 1. SI \n 2. NO");
                Z = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Z == 1)
                {
                    USER.USE();
                }
                if (Z == 2)
                {
                    Console.Clear();
                    Console.WriteLine("TENGA BUEN DIA");

                }
            }
            Console.Clear();
            ES = File.AppendText(RUTA);
            ES.WriteLine("---------------------------");
            ES.Close();
            Console.Clear();
            Console.WriteLine("TENGA BUEN DIA");
            Console.ReadLine();



        }
        public void INV()
        {
            TextReader LEER;
            LEER = new StreamReader("INVENTARIO.txt");
            Console.WriteLine(LEER.ReadToEnd());
        }
    }
}