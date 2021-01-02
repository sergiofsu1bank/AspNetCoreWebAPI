using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
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

        //http://localhost:5000/api/aluno
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = _repo.GetAllAlunos(true);
            //Vinculo do Mapper
            return Ok(_mapper.Map<IEnumerable<AlunoDTO>>(alunos));
        }

        //http://localhost:5000/api/aluno/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repo.GetAlunoById(id, false);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            var alunoDTO = _mapper.Map<AlunoDTO>(aluno);

            return Ok(aluno);
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

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, AlunoRegistrarDTO model)
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