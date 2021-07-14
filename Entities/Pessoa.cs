using System;

namespace Catalog.Entities
{
    public record Pessoa
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string cpf { get; init; }
        public string uf { get; init; }

        public string nascimento { get; init; }



    }

}