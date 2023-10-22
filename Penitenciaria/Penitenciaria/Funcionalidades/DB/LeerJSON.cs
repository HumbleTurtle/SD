using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Penitenciaria.Funcionalidades.ConsultaEstadoReclusosNs.Modelos;

namespace Penitenciaria.Funcionalidades.LeerJSONNs
{
    public class LeerJSON
    {
        public static List<ReclusoModel> ConsultaEstadoReclusos()
        {

            string path = "reclusos_ficticios_1000_completo.json";
            string jsonString = File.ReadAllText(path);

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            List<ReclusoModel> reclusos = JsonConvert.DeserializeObject<List<ReclusoModel>>(jsonString, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });

            return reclusos;
        }
    }
}
