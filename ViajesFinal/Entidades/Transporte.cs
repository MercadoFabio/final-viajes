using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesFinal.Acceso_a_Datos.Interfaces
{
    class Transporte
    {
        public int IdTransporte { get; set; }
        public string NombreTransporte { get; set; }

        public Transporte(int idTransporte, string nombreTransporte)
        {
            IdTransporte = idTransporte;
            NombreTransporte = nombreTransporte;
        }

        public Transporte()
        {
            IdTransporte = 0;
            NombreTransporte = "";
        }
    }
}
