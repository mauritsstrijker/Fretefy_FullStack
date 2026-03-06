using Fretefy.Test.Domain.Constants;
using Fretefy.Test.Domain.Enums;
using Fretefy.Test.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        protected Regiao() { }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public ICollection<Cidade> Cidades { get; private set; } = new HashSet<Cidade>();
        public RegiaoStatus Status { get; private set; } = RegiaoStatus.Ativo;

        public static Regiao Criar(string nome, IEnumerable<Cidade> cidades)
        {
            if (cidades == null || !cidades.Any())
                throw new DomainException(DomainMessages.Regiao.MustContainAtLeastOneCity);

            return new Regiao
            {
                Nome = TratarNome(nome),
                Cidades = new HashSet<Cidade>(cidades),
                Status = RegiaoStatus.Ativo
            };
        }

        public void Atualizar(string nome, IEnumerable<Cidade> cidades)
        {
            if (cidades == null || !cidades.Any())
                throw new DomainException(DomainMessages.Regiao.MustContainAtLeastOneCity);

            Nome = TratarNome(nome);
            Cidades = new HashSet<Cidade>(cidades);
        }

        public void Ativar() => Status = RegiaoStatus.Ativo;
        public void Desativar() => Status = RegiaoStatus.Desativado;

        private static string TratarNome(string nome)
        {
            nome = nome?.Trim();

            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException(DomainMessages.Regiao.InvalidName);

            return nome;
        }
    }
}