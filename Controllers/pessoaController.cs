using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{

    
    [ApiController]
    [Route("pessoas")]
    public class pessoaController : ControllerBase
    {
        private readonly PessoaRepository repository;

        public pessoaController(){
            repository = new PessoaRepository();
        }

        [HttpGet]

        public IEnumerable<Pessoa> GetPessoas(){
            var pessoa = repository.GetPessoas();
            return pessoa;
        }


        [HttpGet("{uf}")]
        public ActionResult<Pessoa> GetPessoa(string uf){
            var pessoa = repository.GetPessoa(uf);

            if(pessoa is null){
                return NotFound();

            }
            return pessoa;
        }
    }
}