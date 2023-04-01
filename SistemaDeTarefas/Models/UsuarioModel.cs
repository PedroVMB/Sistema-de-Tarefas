namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; } // ? significa que a String pode vir nula

        public string? Email { get; set; }
    }
}
