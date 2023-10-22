using Newtonsoft.Json;
using Penitenciaria.Funcionalidades.ConsultaEstadoReclusosNs.Modelos;

namespace Penitenciaria.Funcionalidades.Helper
{
    public class RespuestaJSON
    {
        public string SerializarJSON(Object obj, string[] camposExcluidos)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new DynamicContractResolverExclude(camposExcluidos),
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(obj, settings);
            return json;
        }
    }
}
