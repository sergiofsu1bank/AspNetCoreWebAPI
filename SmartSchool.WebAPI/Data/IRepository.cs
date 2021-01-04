using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSchool.WebAPI.Helpers;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

       Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor);
        Aluno[] GetAllAlunos(bool includeProfessor);
        Aluno[] GetAllAlunosByDisciplinaId(int alunoId, bool includeProfessor);
        Aluno GetAlunoById(int disciplinaId, bool includeProfessor);
        

        Professor[] GetAllProfessores(bool includeAlunos);
        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos);
        Professor GetProfessorById(int professorId, bool includeAlunos);
        Professor GetProfessoresByAlunoId(int alunoId, bool includeAlunos);

    }
}