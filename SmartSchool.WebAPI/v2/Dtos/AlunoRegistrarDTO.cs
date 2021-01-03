using System;
using System.Collections.Generic;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.v2.Dtos

{

    /// <sumary>
    /// DTO de Aluno para registrar
    /// </sumary>

    public class AlunoRegistrarDTO
    {
         /// <sumary>
        /// Identificador e chave do Banco
        /// </sumary>
        public int Id { get; set; }
        
        /// <sumary>
        /// Chave do ALuno, para outros negõcios na Instituição
        /// </sumary>
        public int Matricula { get; set; }

        /// <sumary>
        /// Nome do ALuno
        /// </sumary>
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInicio{ get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool Ativo { get; set; } = true;
        public IEnumerable <AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}