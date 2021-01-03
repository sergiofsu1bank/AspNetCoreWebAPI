using System;
using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor() { }
        public Professor(int id, 
                         int registro, 
                         string nome, 
                         String sobreNome)
        {
            this.Id = id;
            this.Registro = registro;
            this.Nome = nome;
            this.SobreNome = sobreNome;
            

        }
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataInicio{ get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool Ativo { get; set; } = false;
        public IEnumerable<Disciplina> Disciplinas { get; set; }

    }
}