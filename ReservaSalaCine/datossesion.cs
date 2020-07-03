using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalaCine
{
    class datossesion
    {
        // se crea una nueva clase para el almacenamiento de datos//
        private static string _rut;
        private static DateTime _inicioSesion;

        public static string datossesionRut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public static DateTime datossesionInicio
        {
            get { return _inicioSesion; }
            set { _inicioSesion = value; }
        }
    }
}

    
    
    
    
    
    
    
    
    
    
    
    
    
    

