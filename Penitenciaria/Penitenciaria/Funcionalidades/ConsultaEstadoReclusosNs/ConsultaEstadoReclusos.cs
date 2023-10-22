using Penitenciaria.Funcionalidades.ConsultaEstadoReclusosNs.Modelos;
using Penitenciaria.Funcionalidades.LeerJSONNs;

namespace Penitenciaria.Funcionalidades.ConsultaEstadoReclusosNs
{
    public class ConsultaEstadoReclusos
    {
        public List<ReclusoModel> ConsultarEstadoBase(int offset, int cantidad)
        {
            var lista = LeerJSON.ConsultaEstadoReclusos();
            return lista.Skip(offset).Take(cantidad).ToList();
        }

        public ReclusoModel? ConsultarRecluso(long idRecluso)
        {
            var lista = LeerJSON.ConsultaEstadoReclusos();
            return lista.Where( p => p.IdRecluso == idRecluso).SingleOrDefault();
        }
    }
}
