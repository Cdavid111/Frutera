/*
 Nombre del estudiante : IVAN DAVID SALGADO TORRES
 Codigo: 1007389814
 Grupo : 
 Programa : Ingenieria de Sistemas
 Código Fuente: autoría propia
 */

using System;

namespace Proyecto_Ivan
{
    public class Frutas
    {
        static void Main(string[] args)
        {
            //AQUI VOY A CREAR MIS VARIBLES
            int fruta = 0;
            int cantidad = 0;
            double precioNeto = 0;
            double precioBruto = 0;
            double descuento = 0;
            bool estado = true;
            int opcion = 0;
            int maximoIntentos = 6;

            int contador = 0;

            //Costo Frutas
            int pera = 450;
            int manzana = 560;
            int ciruela = 30;
            int banano = 80;
            int piña = 1000;


            while (estado)
            {
                //MOSTRAR MENSAJES
                Console.WriteLine("BIENVENIDOS A LA FRUTERA");
                Console.WriteLine("");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("");
                Console.WriteLine("1. - Peras"); ;
                Console.WriteLine("2. - Manzanas");
                Console.WriteLine("3. - Ciruelas");
                Console.WriteLine("4. - Bananos");
                Console.WriteLine("5. - Piñas");
                Console.WriteLine("");

                //AQUI VOY A PEDIRLE LA CANTIDAD DE FRUTAS AL USUARIO
                Console.Write("Seleccione una opción del menú: ");
                int.TryParse(Console.ReadLine(), out fruta);

                while (fruta < 1 || fruta > 5)
                {
                    contador += 1;

                    if (contador < maximoIntentos)
                    {
                        Console.WriteLine("Tiene : " + (maximoIntentos-contador) + " intentos permitidos");
                        Console.Write("¿Seleccione una opcion correcta del menú: ");
                        int.TryParse(Console.ReadLine(), out fruta);

                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Haz superado el maximo de intentos permitidos, vuelve a intentarlo mas tarde");
                        break;
                    }
                }

                if(contador == maximoIntentos)
                {
                    estado = false;
                    break;
                }
                else
                {
                    contador = 0;
                }

                Console.Write("¿cuantas unidades de fruta va llevar?: ");
                int.TryParse(Console.ReadLine(), out cantidad);

                while (cantidad <= 0)
                {
                    contador += 1;
                    
                    if (contador < maximoIntentos)
                    {
                        Console.WriteLine("Tiene : " + (maximoIntentos - contador) + " intentos permitidos");
                        Console.WriteLine("Ha ocurrido un error : La cantidad debe ser un numero valido");
                        Console.Write("¿cuantas unidades de fruta va llevar?: ");
                        int.TryParse(Console.ReadLine(), out cantidad);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Haz superado el maximo de intentos permitidos, vuelve a intentarlo mas tarde");
                        break;
                    }
                    
                }

                if (contador == maximoIntentos)
                {
                    estado = false;
                    break;
                }
                else
                {
                    contador = 0;
                }

                if (fruta == 1)//Peras
                {
                    precioBruto = (pera * cantidad);

                }
                else if (fruta == 2)//Manzanas
                {
                    precioBruto = (manzana * cantidad);
                }
                else if (fruta == 3)//Ciruelas
                {
                    precioBruto = (ciruela * cantidad);

                }
                else if (fruta == 4)//Bananos
                {
                    precioBruto = (banano * cantidad);
                }
                else //Piñas
                {
                    precioBruto = (piña * cantidad);
                }

                if (precioBruto > 20000)
                {
                    descuento = precioBruto * 0.1;
                    precioNeto = precioBruto - descuento;
                }
                else
                {
                    precioNeto = precioBruto;
                }

                //ESTA ES LA SALIDA DE LOS DATOS
                Console.WriteLine("");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Precio bruto: {0}", precioBruto);
                Console.WriteLine("Descuento: {0}", descuento);
                Console.WriteLine("Precio neto: {0}", precioNeto);
                Console.WriteLine("-------------------------------");

                Console.WriteLine("");
                Console.WriteLine("MENU");
                Console.WriteLine("");
                Console.WriteLine("1. Volver al menu principal");
                Console.WriteLine("2. Salir de la aplicación");
                Console.WriteLine("");

                Console.Write("Seleccione una opción del menú: ");
                int.TryParse(Console.ReadLine(), out opcion);

                while (opcion < 1 || opcion > 2)
                {
                    contador++;

                    if (contador < maximoIntentos)
                    {
                        Console.WriteLine("Tiene : " + (maximoIntentos - contador) + " intentos permitidos");
                        Console.Write("¿Seleccione una opcion correcta del menú: ");
                        int.TryParse(Console.ReadLine(), out opcion);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Haz superado el maximo de intentos permitidos, vuelve a intentarlo mas tarde");
                        break;
                    }
                }

                if (contador == maximoIntentos)
                {
                    estado = false;
                    break;
                }
                else
                {
                    contador = 0;
                }

                if (opcion == 1)
                {
                    Console.Clear(); 
                    estado = true;
                }
                else
                {
                    estado = false;
                }   
            }

            Console.WriteLine("");
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();

        }
    }
}
