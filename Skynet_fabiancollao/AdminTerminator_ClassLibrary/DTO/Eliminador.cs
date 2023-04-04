using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynet_fabiancollao
{
    public class Eliminador
    {
        private string num_serie;
        private string tipo;
        private Int32 destino;
        private string objetivo;
        private int prioridad;

        public string Num_serie { get => num_serie; set => num_serie = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Destino { get => destino; set => destino = value; }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }

    }
}
