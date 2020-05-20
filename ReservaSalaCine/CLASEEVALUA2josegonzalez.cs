using System;

namespace ReservaSalaCine
{
    public class CLASEEVALUA2josegonzalez
    {
        private string rut;
        private DateTime inicioSesion;
        private DateTime FinSesion;
        private string accion;
        private DateTime accionF;

        public CLASEEVALUA2josegonzalez(string rut, DateTime inicioSesion, DateTime finSesion, string accion, DateTime accionF)
        {
            this.rut = rut;
            this.inicioSesion = inicioSesion;
            FinSesion = finSesion;
            this.accion = accion;
            this.accionF = accionF;
        }

        public CLASEEVALUA2josegonzalez()
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
            get { return finSesion; }
        }

        public string Accion
        {
            set { accion = value; }
            get { return accion; }
        }

        public DateTime AccionF
        {
            set { AccionF = value; }
            get { return accionF; }
        }


    }
}