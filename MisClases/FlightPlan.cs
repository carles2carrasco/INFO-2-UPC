using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisClases
{
    public class FlightPlan
    {
        public string ID; // identificador de vuelo
        public string compañia;
        public double velocidad; // En nudos (millas nauticas por hora)
        public double IX; // Coordenadas del punto inicial en un espacio cartesiano. El punto (0,0) es la coordenada NordOeste
        public double IY; // Aumentar X corresponde a moverse hacia el Este y aumentar Y es moverse al Sur
        // cada unidad es una milla nautica
        public double FX; // Coordenadas del punto de destino
        public double FY;
        
        public double GetIX()
        {
            return this.IX;
        }

        public double GetIY()
        {
            return this.IY;
        }

        public void Mover(int incX, int incY)
        {
            this.IX = this.IX + incX;
            this.IY = this.IY + incY;
        }
    }
}


