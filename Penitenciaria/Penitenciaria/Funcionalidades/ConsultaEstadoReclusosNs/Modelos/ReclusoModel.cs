using System.ComponentModel;

namespace Penitenciaria.Funcionalidades.ConsultaEstadoReclusosNs.Modelos
{
    public class ReclusoModel
    {
        public int IdRecluso { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public List<EnfermedadModel> Enfermedades { get; set; }
        public List<VisitaModel> Visitantes { get; set; }
        public List<LlamadaModel> Llamadas { get; set; }
        public AbogadoModel Abogado { get; set; }
        public SentenciaModel Sentencia { get; set; }
        public string UbicacionActual { get; set; }
        public string Pabellon { get; set; }
        public string CeldaNro { get; set; }
        public DateTime FechaEncarcelacion { get; set; }
        public DateTime? FechaLiberacion { get; set; }
    }
}
