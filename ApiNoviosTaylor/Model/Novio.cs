using System.ComponentModel.DataAnnotations;

namespace ApiNoviosTaylor.Model
{
    public class Novio
    {
        [Key]
        public int Novio_ID { get; set; }
        public string? Nombre{ get; set; }
        public string? Cancion { get; set; }
        public string? Profesion { get; set; }
        public string? Foto { get; set; }
    }
}
