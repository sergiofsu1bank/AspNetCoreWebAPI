namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }
        public AlunoDisciplina(int alunoId,  int alunoDisciplinaId)
        {
            this.AlunoId = alunoId;
            this.AlunoDisciplinaId = alunoDisciplinaId;
        }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int AlunoDisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}