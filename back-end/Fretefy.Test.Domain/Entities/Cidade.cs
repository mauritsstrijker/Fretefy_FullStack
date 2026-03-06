using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class Cidade : IEntity
    {
        public Cidade()
        {

        }

        public Cidade(string nome, string uf, double? latitude = null, double? longitude = null)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            UF = uf;
            Latitude = latitude;
            Longitude = longitude;
        }

        public Guid Id { get; set; }

        public string Nome { get; private set; }

        public string UF { get; private set; }

        public double? Latitude { get; private set; }

        public double? Longitude { get; private set; }

        public ICollection<Regiao> Regioes { get; private set; }

        public void AtualizarCoordenadas(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}