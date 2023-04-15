using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Equipo
    {
        private string Nombre;
        private int PartidoGanados;
        private int PartidoEmpatados;
        private int PartidoPerdidos;
        private int GolesFavor;
        private int GolesContra;
        public Equipo(string nombre, int partidosGanados, int partidosEmpatados, int partidosPerdidos, int golesFavor, int golesContra)
        {
            if (partidosEmpatados + partidosGanados + partidosPerdidos != 3 ||
                golesFavor <0 || golesContra < 0)
                    {
                throw new Exception("Revise el equipo. La sumatoria de partidos debe ser " +
                    "igual a 3 y los goles anotados y a favor deben ser mayores o iguales a " +
                    "cero.");
                    }
            this.Nombre = nombre;
            this.PartidoGanados= partidosGanados;
            this.PartidoEmpatados= partidosEmpatados;
            this.PartidoPerdidos= partidosPerdidos;
            this.GolesFavor= golesFavor;
            this.GolesContra = golesContra;
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public int GetPartidosGanados()
        {
            return this.PartidoGanados;
        }

        public int GetPartidosEmpatados()
        {
            return this.PartidoEmpatados;
        }

        public int GetPartidosPerdidos()
        {
            return this.PartidoPerdidos;
        }

        public int GetGolesFavor()
        {
            return this.GolesFavor;
        }

        public int GetGolesContra()
        {
            return this.GolesContra;
        }
    }
}
