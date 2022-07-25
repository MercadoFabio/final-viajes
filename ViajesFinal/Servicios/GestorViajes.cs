using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesFinal.Acceso_a_Datos.Implementaciones;
using ViajesFinal.Acceso_a_Datos.Interfaces;
using ViajesFinal.Entidades;

namespace ViajesFinal.Servicios
{
    class GestorViajes
    {
        private IViajesDao dao;

        public GestorViajes(AbstractDaoFactory factory) 
        {

            dao = factory.CrearViajeDao();
            
        }

        public List<Transporte> ObtenerTransportes()
        {
            return dao.ObtenerTransporte();
        }

        public DataTable ObtenerListaViajes()
        {
            return dao.ObtenerListaViajes();
        }

        public Viaje ObtenerViajePorId(int nroIdViaje)
        {
            return dao.ObtenerViajeId(nroIdViaje);
        }

        public bool NuevoViaje(Viaje oViaje)
        {
            return dao.InsertarNuevoViaje(oViaje);
        }

        public bool EditarViaje(Viaje oViaje)
        {
            return dao.EditarViaje(oViaje);
        }

        public bool BorrarViaje(int nroViaje)
        {
            return dao.BorrarViaje(nroViaje);
        }
    }
}
