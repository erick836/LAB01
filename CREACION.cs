using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LABORATORIO_I
{
    class CREACION
    {
        static USUARIOS USER = new USUARIOS();

        static string RUTA = "USUARIOS.txt";
        static int Z, O;
        static StreamWriter ES;

        static string DATOS(string X)
        {
            Console.Clear();
            Console.WriteLine("INGRESE " + X + ":");
            return (Console.ReadLine());
        }
        static void USUARIOS(string USUARIO, string CONTRASEÑA)
        {
            Console.Clear();
            Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. ADMINISTRADOR \n 2. TRABAJADOR");
            O = int.Parse(Console.ReadLine());

            if (O == 1)
            {
                ES = File.AppendText(RUTA);
                ES.WriteLine("USUARIO: " + USUARIO + "\nCONTRASEÑA: " + CONTRASEÑA);
                USER.USER = USUARIO;
                USER.PASS = CONTRASEÑA;
                ES.Close();
            }
            if (O == 2)
            {
                ES = File.AppendText(RUTA);
                ES.WriteLine("USUARIO: " + USUARIO + "\nCONTRASEÑA: " + CONTRASEÑA);
                USER.US = USUARIO;
                USER.CON = CONTRASEÑA;
                ES.Close();
            }
        }
        public void CREAR()
        {
            char OP = 'S';
            while (OP != 'N')
            {
                USUARIOS(DATOS("USUARIO"), DATOS("CONTRASEÑA"));
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
        public void REGIS()
        {
            TextReader LEER;
            LEER = new StreamReader("USUARIOS.txt");
            Console.WriteLine(LEER.ReadToEnd());
        }


    }
}