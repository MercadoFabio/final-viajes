using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViajesFinal.Acceso_a_Datos.Interfaces;

namespace ViajesFinal.Acceso_a_Datos.Implementaciones
{
    class DaoFactory : AbstractDaoFactory
    {
        public override IViajesDao CrearViajeDao()
        {
            return new ViajeDao();
        }
    }
}
