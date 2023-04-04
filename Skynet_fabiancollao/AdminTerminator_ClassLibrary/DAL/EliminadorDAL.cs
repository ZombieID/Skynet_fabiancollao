using Skynet_fabiancollao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTerminator_ClassLibrary.DAL
{
    public class EliminadorDAL
    {
        private static List<Eliminador> eliminadores=new List<Eliminador>();
        public void AgregarEliminador(Eliminador e)
        {
            eliminadores.Add(e);
        }
        public List<Eliminador> ObtenerEliminadores()
        {
            return eliminadores;
        }
        public List<Eliminador> FiltrarEliminadores(string tipo, Int32 destino)
        {
            return eliminadores.FindAll(e=> e.Tipo == tipo && e.Destino == destino);
        }

    }
}
