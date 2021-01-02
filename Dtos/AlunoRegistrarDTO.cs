using System;
using System.Collections.Generic;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.Dtos
{
    public class AlunoRegistrarDTO
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
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