using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MisClases;

namespace ProbarClases
{
    class Program
    {
        static void escribeDatosVuelo(FlightPlan v)
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Compañia: {0}", v.compañia);
            Console.WriteLine("Velocidad: {0}", v.velocidad);
            Console.WriteLine("Posición actual: ({0},{1})", v.IX, v.IY);
            Console.WriteLine("El destino es: ({0},{1})", v.FX, v.FY);
            Console.WriteLine("******************************");
        }
        static double distancia(FlightPlan a, FlightPlan b)
        // retorna la distancia entre los dos planes de vuelo
        {
            return Math.Sqrt((a.IX - b.IX) * (a.IX - b.IX) + (a.IY - b.IY) * (a.IY - b.IY));
        }


        static void MoverVuelo(FlightPlan plan, double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Comprobar que no me paso

            //Calculamos la distancia recorrida en el tiempo dado
            double D = tiempo * plan.velocidad / 60;

            //Calculamos las razones trigonométricas
            double H = Math.Sqrt((plan.FX - plan.IX) * (plan.FX - plan.IX) + (plan.FY - plan.IY) * (plan.FY - plan.IY));

            if (H < D)
            {
                //me paso
                plan.IX = plan.FX;
                plan.IY = plan.FY;
            }
            else
            {
                double C = (plan.FX - plan.IX) / H;
                double S = (plan.FY - plan.IY) / H;

                //Caculamos la nueva posición del vuelo
                plan.IX = plan.IX + D * C;
                plan.IY = plan.IY + D * S;
            }
        }

        static FlightPlan LeerPlanDeConsola()
        {
            FlightPlan plan = new FlightPlan();

            Console.WriteLine("Escribe el nombre de la compañia");
            //   string nombre = Console.ReadLine();
            plan.compañia = Console.ReadLine(); ;

            Console.WriteLine("Escribe la velocidad");
            plan.velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
            string linea = Console.ReadLine();
            string[] trozos = linea.Split(' ');
            plan.IX = Convert.ToInt32(trozos[0]);
            plan.IY = Convert.ToInt32(trozos[1]);

            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            linea = Console.ReadLine();
            trozos = linea.Split(' ');
            plan.FX = Convert.ToInt32(trozos[0]);
            plan.FY = Convert.ToInt32(trozos[1]);

            return plan;
        }

        static void Main(string[] args)
        {
            try
            {
                FlightPlan a = LeerPlanDeConsola();
                escribeDatosVuelo(a);

                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en el formato");
                Console.ReadLine();
            }
        }
    }
}