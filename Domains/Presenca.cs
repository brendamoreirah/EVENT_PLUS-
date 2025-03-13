using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Event_Plus.Domains;
using ProjectEventsPlus.Domain;

namespace ProjectEventsPlus.Domain
{
    [Table("Presenca")]
    public class Presenca
    {
        [Key]
        public Guid PresencaId { get; set; }
        [Column(TypeName = ("BIT"))]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool? Situacao { get; set; }

        [Required(ErrorMessage = "Usuário obrigatório")]
        public Guid UsuarioId { get; set; }
        [ForeignKey("UsuarioID")]
        public Usuario? Usuario { get; set; }

        [Required(ErrorMessage = "O evento é obrigatório")]
        public Guid EventoId { get; set; }
        [ForeignKey("EventoID")]
        public Evento? Evento { get; set; }
    }
}
