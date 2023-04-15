using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Partido
    {
        private Equipo equipo1;
        private Equipo equipo2;

        private Equipo ganador;

        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }

        public Equipo GetEquipo1()
        {
            return equipo1;
        }

        public Equipo GetEquipo2()
        {
            return equipo2;
        }

        public Equipo SeleccionarEquipoGanador()
        {
            Random random = new Random();
            int probabilidadEquipo1 = random.Next(100);
            int probabilidadEquipo2 = random.Next(100);

            if (probabilidadEquipo1 > probabilidadEquipo2)
            {
                ganador = equipo1;
            }
            else if (probabilidadEquipo2 > probabilidadEquipo1)
            {
                ganador = equipo2;
            }
            else
            {
                ganador = null;
            }
            return ganador;
        }

        public string ObtenerResultado()
        {
            if (ganador == null)
            {
                return "Empate";
            }
            else
            {
                return "Ganador: " + ganador.GetNombre() + " (" + ganador.GetPuntuacion() + " puntos)";
            }
        }
    }
}
