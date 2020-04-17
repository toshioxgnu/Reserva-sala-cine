namespace ReservaSalaCine
{
    public class Asiento
    {
        private int fila;
        private int columna;
        private bool ocupado;

        public Asiento(int fila, int columna, bool ocupado)
        {
            this.fila = fila;
            this.columna = columna;
            this.ocupado = ocupado;
        }

        public int Fila
        {
            get => fila;
            set => fila = value;
        }

        public bool Ocupado
        {
            get => ocupado;
            set => ocupado = value;
        }

        public int Columna
        {
            get => columna;
            set => columna = value;
        }
    }
}