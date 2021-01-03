using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.v2.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.v2.Controllers
{
    /// <summary>
    /// Aplicação de estudo dotnet
    /// </summary>

    /// <param name="repo"></param>
    /// <param name="mapper"></param>

    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;
        public readonly IMapper _mapper;

        public AlunoController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            //Injecao do Mapper
            _mapper = mapper;
        }

        /// <summary>
        /// Método responsavel para retornar todos os alunos
        /// </summary>

        //http://localhost:5000/api/aluno
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = _repo.GetAllAlunos(true);
            //Vinculo do Mapper
            return Ok(_mapper.Map<IEnumerable<AlunoDTO>>(alunos));
        }

        [HttpPost]
        public IActionResult Post(AlunoRegistrarDTO model)
        {

            var aluno = _mapper.Map<Aluno>(model);

            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDTO>(aluno));
            }
            return BadRequest("Aluno não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoRegistrarDTO model)
        {
            var aluno = _repo.GetAlunoById(id, false);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            _mapper.Map(model, aluno);

           _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDTO>(aluno));
            };
            return BadRequest("Aluno não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAlunoById(id, false);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            _repo.Delete(aluno);
            if (_repo.SaveChanges())
            {
                return Ok("Aluno deletado");
            }

            return BadRequest("Aluno não deletado");
        }
    }
}