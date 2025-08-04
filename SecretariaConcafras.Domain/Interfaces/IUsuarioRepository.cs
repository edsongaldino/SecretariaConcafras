using SecretariaConcafras.Domain.Entities;

namespace SecretariaConcafras.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        // Aqui ficam apenas m�todos espec�ficos de usu�rio
        Task<Usuario?> ObterPorEmailSenhaAsync(string email, string senha);
    }
}
