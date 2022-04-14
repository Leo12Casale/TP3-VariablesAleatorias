﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_VariablesAleatorias.Distribuciones
{
    public abstract class Distribucion
    {
        private double[] serieGenerada;

        protected double[] SerieGenerada { get => serieGenerada; set => serieGenerada = value; }

        protected double[] generarRNDs(int cantidadRNDsNecesarios)
        {
            double[] RNDs = new double[cantidadRNDsNecesarios];

            Random randNum = new Random();
            for (int i = 0; i < RNDs.Length; i++)
            {
                RNDs[i] = randNum.NextDouble();
            }
            return RNDs;
        }

         //La necesitamos si o si, porque la tabla es diferente (una columna [x;y;...] en lugar de Desde y Hasta)
        public virtual bool esPoisson(){
            return false;
        }

        //Metodo de marcado
        public abstract double[] generarSerie(int cantidadNumerosAGenerar);

        //Poisson no tiene desde y hasta, pero que el desde y el hasta retornen el mismo numero. Ej: => [7;7]
        public abstract double[] getIntervalosDesde();
        public abstract double[] getIntervalosHasta();

        // Especializado para cada distribución con el uso de la probabilidad que corresponda
        public abstract double[] getFrecuenciasEsperadas();
        public abstract double[] getFrecuenciasObservadas();

        // Getter de la variable con la cantidad de datos empíricos de cada distribución
        public abstract int getCantDatosEmpiricos();

       

        public abstract int getNMuestras();

        // Necesitamos esta columan para el k-s, es distinto en cada distribución
        public abstract double[] getProbabilidadEsperada();
        
    }
}
