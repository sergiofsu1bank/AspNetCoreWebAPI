using AutoMapper;
using SmartSchool.Dtos;
using SmartSchool.Helpers;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Helpers
{
    public class SmartSchoolProfile : Profile
    {
        public SmartSchoolProfile()
        {
            CreateMap<Aluno, AlunoDTO>()
                .ForMember(
                    dest => dest.Nome,
                    opt => opt.MapFrom(src => $"{src.Nome} {src.SobreNome}")
                )
                .ForMember(
                    dest => dest.Idade,
                    opt => opt.MapFrom(src => src.DataNascimento.GetCurrantAge())
                );
            CreateMap<AlunoDTO, Aluno>();
            CreateMap<Aluno, AlunoRegistrarDTO>().ReverseMap();
            //CreateMap<Aluno, AlunoPatchDto>().ReverseMap();
            
            /*CreateMap<Professor, ProfessorDto>()
                .ForMember(
                    dest => dest.Nome,
                    opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}")
                );
            */
            //CreateMap<ProfessorDto, Professor>();
            //CreateMap<Professor, ProfessorRegistrarDto>().ReverseMap();

            //CreateMap<DisciplinaDto, Disciplina>().ReverseMap();
            //CreateMap<CursoDto, Curso>().ReverseMap();
        }
    }
}