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
        static USUARIOS USER = new USUARIOS();
        static string RUTA = "FACTURA.txt";
        public double Y, X, Z;
        static StreamWriter ES;

        static string DATOS(string X)
        {
            Console.Clear();
            Console.WriteLine("INGRESE " + X + ":");
            return (Console.ReadLine());
        }
        static double VALOR(double Y)
        {
            Console.Clear();
            Console.WriteLine("INGRESE PRECIO: ");
            Y = double.Parse(Console.ReadLine());
            return Y;
        }
        static double CANT(double X)
        {
            Console.Clear();
            Console.WriteLine("INGRESE CANTIDAD:");
            X = double.Parse(Console.ReadLine());
            return X;
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
            ES.WriteLine("PRODUCTO: " + PRODUC);
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
            double TOT = 0, T;

            while (OP != 'N')
            {
                Console.Clear();
                VENTA(DATOS("PRODUCTO"));

                T = RESULTADO(VALOR(Y), CANT(X));
                ES = File.AppendText(RUTA);
                ES.WriteLine("SUBTOTAL: " + T);
                ES.WriteLine("---------------------------");
                ES.Close();
                Console.Clear();
                Console.WriteLine("SUBTOTAL: " + T);
                Console.WriteLine("DESEA INGRESAR OTRA COMPRA? [S/N]:");
                OP = char.Parse(Console.ReadLine());
                TOT = TOT + T;
            }
            Console.Clear();
            ES = File.AppendText(RUTA);
            ES.WriteLine("TOTAL: " + TOT);
            ES.WriteLine("---------------------------\n---------------------------");
            ES.Close();

            Console.Clear();
            Console.WriteLine("TOTAL: " + TOT);
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
            Console.ReadKey();
        }
        public void FACTU()
        {
            TextReader LEER;
            LEER = new StreamReader("FACTURA.txt");
            Console.WriteLine(LEER.ReadToEnd());
        }
    }
}