using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalaCine
{
        public class CLASEEVALUA2cristianmoralesa
    {

        private string rut;
        private DateTime inicioSesion;
        private DateTime FinSesion;
        private string accion;
        private DateTime accionF;

        public CLASEEVALUA2cristianmoralesa(string rut, DateTime inicioSesion, DateTime finSesion, string accion, DateTime accionF)
        {
            this.rut = rut;
            this.inicioSesion = inicioSesion;
            this.FinSesion = finSesion;
            this.accion = accion;
            this.accionF = accionF;
        }

        public CLASEEVALUA2cristianmoralesa()
        {

        }

        public string Rut
        {
            set { rut = value; }
            get { return rut; }
        }

        public DateTime InicioSesion
        {
            set { inicioSesion = value; }
            get { return inicioSesion; }
        }

        public DateTime finSesion
        {
            set { FinSesion = value; }
            get { return FinSesion; }
        }

        public string Accion
        {
            set { accion = value; }
            get { return accion; }
        }

        public DateTime AccionF
        {
            set { accionF = value; }
            get { return accionF; }
        }

    }
}

    
    
    
    
    
    
    
    
    
    
    
    





