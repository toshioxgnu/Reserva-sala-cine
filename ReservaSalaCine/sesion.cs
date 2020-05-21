using System;
using System.Collections.Generic;

// Clase global que almacena dos datos que siemrpe se usan al guardar un nuevo log 
// el rut y el inicio de sesion, de esta forma son visibles para todo el programa y no se deben declarar nuevamente 

namespace ReservaSalaCine
{
    public class sesion
    {
        private static string _rut;
        private static DateTime _inicioSesion;

        public static string sessionRut
        {
            get{ return _rut; }
            set { _rut = value; }
        }

        public static DateTime sessionInicio
        {
            get { return _inicioSesion; }
            set { _inicioSesion = value; }
        }
    }
}