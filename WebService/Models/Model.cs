using System.ComponentModel.DataAnnotations;

namespace WebService.Models
{
    public class Model
    {
        [Key]
        public int Numero { get; set; }
        public string Mensaje { get; set; }
    }
}