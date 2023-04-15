using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    public class Information
    {
        private static Information? Instance;

        private string Name;
        private string Carnet;
        private string Section;


        public static Information GetInformation()
        {
            if (Instance == null)
                Instance = new Information("Andrea Gabriela Iboy Casados", "1076623", "04"
                                           "Ana Lucía Chávez Penagaos", "1067423", "04" 
                                           "Eduardo David Hernández Girón", "1156823", "04");

            return Instance;
        }

        private Information(string Name, string Carnet, string Section)
        {
            this.Name = Name;
            this.Carnet = Carnet;
            this.Section = Section;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetCarnet()
        {
            return this.Carnet;
        }

        public string GetSection()
        {
            return this.Section;
        }
    }
}
