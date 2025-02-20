using ProjetoClienteServidor.Data;

namespace ProjetoClienteServidor.Repository
{
    public interface IUserRepository
    {
        Task<UserResponse> Cadastrar(UserCommand request);
    }
}