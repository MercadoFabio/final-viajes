using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesFinal.Entidades;

namespace ViajesFinal.Acceso_a_Datos.Interfaces
{
     interface IViajesDao
    {
        List<Transporte> ObtenerTransporte();
        DataTable ObtenerListaViajes();
        Viaje ObtenerViajeId(int nroIdViaje);
        bool InsertarNuevoViaje(Viaje oViaje);
        bool EditarViaje(Viaje oViaje);
        bool BorrarViaje(int nroViaje);
    }
}
