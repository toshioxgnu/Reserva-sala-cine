﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalaCine
{
    class SalaCine
    {
        private int numeroSala;
        private string pelicula;
        public Asiento[,] asientosSala = new Asiento[10,10];

        public SalaCine(int numeroSala, string pelicula)
        {
            this.numeroSala = numeroSala;
            this.pelicula = pelicula;
        }

        public int NumeroSala
        {
            get => numeroSala;
            set => numeroSala = value;
        }

        public string Pelicula
        {
            get => pelicula;
            set => pelicula = value;
        }

    }
}
