namespace Fretefy.Test.Domain.Constants
{
    public static class DomainMessages
    {
        public static class Geral
        {
            public const string NotFound = "Registro não encontrado.";
        }
        public static class Regiao
        {
            public const string InvalidName = "Nome inválido.";
            public const string NameAlreadyExists = "Já existe uma região cadastrada com este nome.";
            public const string MustContainAtLeastOneCity = "A região deve ter pelo menos uma cidade.";
        }
    }
}