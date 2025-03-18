using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Event_Plus.Domains;
using Microsoft.EntityFrameworkCore;


namespace Event_Plus.Domain
{
    [Table("Comentario")]
    [Index(nameof(EXibirComentario), IsUnique = true)]
    public class Comentario
    {
        [Key]
        public Guid ComentarioEventoId { get; set; }
        [Column(TypeName = ("TEXT"))]
        [Required(ErrorMessage = "O comentário é obrigatório")]
        public string? ComentarioEvento { get; set; }

        [Column(TypeName = ("BIT"))]
        [Required(ErrorMessage = "A resposta é necessária!")]
        public bool? EXibirComentario { get; set; }

        [Required(ErrorMessage = "Usuário obrigatório")]
        public Guid UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }

        [Required(ErrorMessage = "O evento é obrigatório")]
        public Guid EventoId { get; set; }
        [ForeignKey("EventoId")]
        public Evento? Evento { get; set; }
    }
}
