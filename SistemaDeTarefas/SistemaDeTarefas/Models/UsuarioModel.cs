﻿
namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set;}

        public static implicit operator UsuarioModel(TarefaModel v)
        {
            throw new NotImplementedException();
        }
    }
}
