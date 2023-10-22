using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Penitenciaria.Funcionalidades.Helper
{
    public class DynamicContractResolverExclude : DefaultContractResolver
    {
        private readonly HashSet<string> _propertiesToExclude;

        public DynamicContractResolverExclude(IEnumerable<string> propertiesToInclude)
        {
            _propertiesToExclude = new HashSet<string>(propertiesToInclude);
        }

        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            IList<JsonProperty> properties = base.CreateProperties(type, memberSerialization);
            return properties.Where(p => !_propertiesToExclude.Contains(p.PropertyName)).ToList();
        }
    }

}