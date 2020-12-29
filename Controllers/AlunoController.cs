using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<WebAPI.Models.Aluno> Alunos = new List<Aluno>() {
            new Aluno() {
                Id = 1,
                Nome = "Marcos",
                SobreNome = "Vinicius",
                Telefone = "1197113-0311"
            },
            new Aluno() {
                Id = 2,
                Nome = "Marta",
                SobreNome = "Kent",
                Telefone = "1194486-1812"
            },
            new Aluno() {
                Id = 3,
                Nome = "Lucas",
                SobreNome = "Salgado",
                Telefone = "1195555-0000"
            }
            
        };

        public AlunoController() { }
 
        //http://localhost:5000/api/aluno
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        //http://localhost:5000/api/aluno/1
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        //http://localhost:5000/api/aluno/Marta
        [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        //http://localhost:5000/api/aluno/ByName?nome=Lucas&Sobrenome=Salgado
        [HttpGet("ByName")]
        public IActionResult GetByNameAndSobreNome(string nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => 
                a.Nome.Contains(nome) && a.SobreNome.Contains(Sobrenome)
            );
          
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        //http://localhost:5000/api/aluno/byId?id=1
        [HttpGet("byId")]
        public IActionResult GetByIdQueryString(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}