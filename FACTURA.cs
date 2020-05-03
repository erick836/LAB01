using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LABORATORIO_I
{
    class FACTURA
    {
        static string RUTA = "FACTURA.txt";
        static double X, Y, T;
        static StreamWriter ES;

        static string DATOS(string X)
        {
            Console.Clear();
            Console.WriteLine("INGRESE " + X + ":");
            return (Console.ReadLine());
        }
        static double VALOR(double X)
        {
            Console.Clear();
            Console.WriteLine("INGRESE PRECIO" + X + ":");
            return double.Parse(Console.ReadLine());
        }
        static double CANT(double X)
        {
            Console.Clear();
            Console.WriteLine("INGRESE CANTIDAD" + X + ":");
            return double.Parse(Console.ReadLine());
        }
        static void CLIENTE(string CORRELATIVO, string NOMBRE, string NIT, string FECHA)
        {
            Console.Clear();
            ES = File.AppendText(RUTA);
            ES.WriteLine("CORRELATIVO: " + CORRELATIVO + "\nCLINTE: " + NOMBRE + "\nNIT: " + NIT + "\nFECHA: " + FECHA);
            ES.Close();
        }
        static void VENTA(string PRODUC)
        {
            ES = File.AppendText(RUTA);
            ES.WriteLine("PRODUCTO:" + PRODUC);
            ES.Close();
        }

        static double RESULTADO(double V, double P)
        {
            double RESUL;
            RESUL = V * P;
            return RESUL;
        }
        public void FAC()
        {
            char OP = 'S';
            CLIENTE(DATOS("COORELATIVO"), DATOS("NOMBRE"), DATOS("NIT"), DATOS("FECHA"));
            double TOT = 0;

            while (OP != 'N')
            {
                Console.Clear();
                VENTA(DATOS("PRODUCTO"));

                T = RESULTADO(VALOR(Y), CANT(X));
                ES = File.AppendText(RUTA);
                ES.WriteLine("SUBTOTAL:" + T);
                ES.Close();
                Console.Clear();
                Console.WriteLine("SUBTOTAL:" + T);
                Console.WriteLine("DESEA INGRESAR OTRA COMPRA? [S/N]:");

                OP = char.Parse(Console.ReadLine());

                TOT = TOT + T;
            }
            Console.Clear();
            ES = File.AppendText(RUTA);
            ES.WriteLine("TOTAL:" + TOT);
            ES.WriteLine("---------------------------");
            ES.Close();

            Console.WriteLine("TOTAL:" + TOT);
            Console.Clear();
            Console.WriteLine("TENGA BUEN DIA");
            Console.ReadLine();



        }
        public void FACTU()
        {
            TextReader LEER;
            LEER = new StreamReader("FACTURA.txt");
            Console.WriteLine(LEER.ReadToEnd());
        }
    }
}