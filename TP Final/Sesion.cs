using System;

namespace TP_Final
{
    internal class Sesion
    {
        private Usuario iUsuario;
        private int iPuntaje;
        private int iTiempo;
        private DateTime iFecha;

        public Sesion(Usuario pUsuario)
        {
            iUsuario = pUsuario;
            iFecha = new DateTime();
        }

        public Usuario Usuario { get { return iUsuario; } }
        public int Puntaje { get { return iPuntaje; } set { iPuntaje = value; } }
        public int Tiempo { get { return iTiempo; } set { iTiempo = value; } }
        public DateTime Fecha { get { return iFecha; } }
    }
}