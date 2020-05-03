using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_I
{
    class USUARIOS
    {
        static INVENTARIO RES = new INVENTARIO();
        static CREACION CREAR = new CREACION();
        static FACTURA F = new FACTURA();

        public int A, B, C, Z, T, O;
        public string USER = "ERICK", PASS = "123", US = "AMILCAR", CON = "456", U, P, UR, PS;
        public void USE()
        {
            Console.WriteLine("EMPRESA LOS PATOS");
            Console.WriteLine("INICIE SESIÓN: \n 1. ADMINISTRADOR \n 2. TRABAJADOR \n 3.SALIR");
            A = int.Parse(Console.ReadLine());

            if (A == 1)
            {
                Console.Clear();
                Console.Write("INGRESE SU NOMBRE:");
                U = Console.ReadLine();

                if (USER == U)
                {
                    Console.Write("INGRESE SU CONTRASEÑA: ");
                    P = Console.ReadLine();

                    if (PASS == P)
                    {
                        Console.Clear();
                        Console.WriteLine("BIENVENIDO \n ELIJA UNA OPCIÓN: \n 1. INVENTARIO \n 2. USUARIOS \n 3. FACTURAS \n 4. SALIR");
                        B = int.Parse(Console.ReadLine());
                        if (B == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. VER INVENTARIO \n 2. AGREGAR PRODUCTO");
                            T = int.Parse(Console.ReadLine());
                            if (T == 1)
                            {
                                Console.Clear();
                                RES.INV();
                            }
                            if (T == 2)
                            {
                                Console.Clear();
                                RES.IN();
                            }
                        }
                        if (B == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("ELIJA UNA OPCIÓN: \n 1. CREAR USUARIO \n 2. VER USUARIOS");
                            O = int.Parse(Console.ReadLine());
                            if (O == 1)
                            {
                                Console.Clear();
                                CREAR.CREAR();
                            }
                            if (O == 2)
                            {
                                Console.Clear();
                                CREAR.REGIS();
                            }
                        }
                        if (B == 3)
                        {
                            Console.Clear();
                            F.FACTU();
                        }
                        if (B == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("DESEA IR AL INICIO? \n 1. SI \n 2. NO");
                            Z = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (Z == 1)
                            {
                                USE();
                            }
                            if (Z == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("TENGA BUEN DIA");

                            }
                        }
                    }
                }
            }
            if (A == 2)
            {
                Console.Clear();
                Console.Write("INGRESE SU NOMBRE: ");
                UR = Console.ReadLine();

                if (US == UR)
                {
                    Console.Write("INGRESE SU CONTRASEÑA: ");
                    PS = Console.ReadLine();

                    if (CON == PS)
                    {
                        Console.Clear();
                        Console.WriteLine("BIENVENIDO, ELIJA UNA OPCIÓN: \n 1.  CARGAR INVENTARIO \n 2. FACTURAR \n 3. SALIR ");
                        C = int.Parse(Console.ReadLine());
                        if (C == 1)
                        {
                            Console.Clear();
                            RES.IN();
                        }
                        if (C == 2)
                        {
                            Console.Clear();
                            F.FAC();
                        }
                        if (C == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("DESEA IR AL INICIO? \n 1. SI \n 2. NO");
                            Z = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (Z == 1)
                            {
                                USE();
                            }
                            if (Z == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("TENGA BUEN DIA");

                            }
                        }
                    }
                }
            }
            if (A == 3)
            {
                Console.Clear();
                Console.WriteLine("TENGA BUEN DIA");
            }
            Console.ReadKey();
        }
    }
}
