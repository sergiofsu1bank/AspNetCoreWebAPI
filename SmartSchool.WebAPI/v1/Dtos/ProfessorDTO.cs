using System;
using System.Collections.Generic;

namespace SmartSchool.WebAPI.v1.Dtos
{
    public class ProfessorDTO
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; } = true;
        public IEnumerable<DisciplinaDTO> Disciplinas { get; set; }
    }
}