using System;

namespace SmartSchool.WebAPI.v1.Dtos
{
    public class AlunoDTO
    {
        /// <sumary>
        /// Identificador e chave do Banco
        /// </sumary>
        public int Id { get; set; }
        /// <sumary>
        /// Chave do ALuno, para outros negõcios na Instituição
        /// </sumary>
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public DateTime? DataFim { get; set; }
        public bool Ativo { get; set; }  
    }
}