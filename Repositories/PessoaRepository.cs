using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class PessoaRepository
    {
        private readonly List<Pessoa> pessoas = new(){

            new Pessoa{Id = Guid.NewGuid(), Name = "Iago", cpf ="123456789-00", uf = "GO", 
            nascimento ="28/02/1993"},

            new Pessoa{Id = Guid.NewGuid(), Name = "João", cpf ="123456789-00", uf = "SP", 
            nascimento ="01/01/1985"},

            new Pessoa{Id = Guid.NewGuid(), Name = "Maria", cpf ="123456789-00", uf = "SC", 
            nascimento ="20/03/1997"},

            new Pessoa{Id = Guid.NewGuid(), Name = "Pedro", cpf ="123456789-00", uf = "RJ", 
            nascimento ="05/07/2000"}
            
        };

        public IEnumerable<Pessoa> GetPessoas(){
            return pessoas;
        }

        public Pessoa GetPessoa(string uf){
            return pessoas.Where(pessoas => pessoas.uf == uf).SingleOrDefault();
        }

        
    }
}