namespace Penitenciaria.Funcionalidades.ConsultaEstadoReclusosNs.Modelos
{
    public class EnfermedadModel
    {
        public string Enfermedad { get; set; }
        public DateTime FechaDiagnostico { get; set; }
        public DateTime? FechaCuracion { get; set; }
        public string Medico { get; set; }
    }
}
