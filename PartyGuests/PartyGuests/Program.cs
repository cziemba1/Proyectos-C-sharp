using System;
using System.Collections.Generic;
using System.Xml;

namespace PartyGuests
{
    class Program
    {
        private static List<string> fiestas = new List<string>();
        private static int totalInvitados = 0;
        static void Main(string[] args)
        {
            cargaDeInvitados();
            mostrarInvitados();
            mostrarTotalInvitados();    
            Console.ReadLine();
        }

        private static void mostrarTotalInvitados()
        {
            Console.WriteLine();
            Console.WriteLine($"Total de invitados: {totalInvitados}");
        }

        private static void mostrarInvitados()
        {
            Console.WriteLine();
            Console.WriteLine("Invitados en la fiesta: ");

            foreach (string nombre in fiestas)
            {
                Console.WriteLine(nombre);
            }
        }

        private static void cargaDeInvitados()
        {
            string masInvitadosPorLlegar = "";
            do
            {
                string nombreFiesta = RespuestasDeConsola("Cual es el nombre de tu fiesta?");

                fiestas.Add(nombreFiesta);

                totalInvitados += ObtenerTamañoFiesta();

                mostrarTotalInvitados();

                masInvitadosPorLlegar = RespuestasDeConsola("Quieres agregar otro invitado ? Si / No");
            } while (masInvitadosPorLlegar.ToLower() == "si");
        }

        private static int ObtenerTamañoFiesta()
        {
            bool esNumeroValido = false;
            int output = 0;
            do
            { 
                string tamañoFiestaTexto = RespuestasDeConsola("Cuanta personas van a tu fiesta?");

                esNumeroValido = int.TryParse(tamañoFiestaTexto, out output);

                
            } while (esNumeroValido == false);
            return output;
        }
        private static string RespuestasDeConsola(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();

            return output;
             
        }
    }
}
