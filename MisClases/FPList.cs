using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClases
{
    public class FPList
    {
        FlightPlan[] vuelos = new FlightPlan[100];
        int num = 0;

        public void Pon(FlightPlan p)
        {
            this.vuelos[this.num] = p;
            this.num = this.num + 1;
        }
        public FlightPlan Dame(int i)
        {
            return this.vuelos[i];
        }

        public void Mover(int incX, int incY)
        {
            for (int i = 0; i < this.num; i++)
                this.vuelos[i].Mover(incX, incY);
        }
        public int NumFPs()
        {
            return this.num;
        }
        public FlightPlan numLista(int i)
        {
            if (i < 0 || i >= this.num)
                return null;
            
            return this.vuelos[i];
        }
    }   
}
