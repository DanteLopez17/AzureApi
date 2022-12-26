using System.ComponentModel.DataAnnotations;

namespace AzureApi.Models
{
    public class ClienteNuevo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Apellido { get; set; } = string.Empty;
        [Required]
        public int NroDocumento { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public bool EsNuevo { get; set; } = true;
    }
}
