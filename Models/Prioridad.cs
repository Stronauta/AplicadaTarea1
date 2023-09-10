using System.ComponentModel.DataAnnotations;

namespace RegistroPrioridad2.Models
{
    public class Prioridad
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required(ErrorMessage = "La descripción es requeridaaaaa")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Los días compromiso son requeridos")]
        public int DiasCompromiso { get; set; }

        public string NivelPrioridad => ObtenerNivelPrioridad(PrioridadId);

        private string ObtenerNivelPrioridad(int id)
        {
            if (id >= 1 && id <= 15)
                return "Alta";
            else if (id >= 16 && id <= 24)
                return "Media";
            else
                return "Baja";
        }
    }
}
