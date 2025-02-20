using ProjetoClienteServidor.Data;
using ProjetoClienteServidor.Models.User;

namespace ProjetoClienteServidor.Repository
{
    public class Repositories : IUserRepository
    {
        private readonly UserServiceDBContext _dbContext;
        public Repositories(UserServiceDBContext trainServiceDBContext)
        {
            _dbContext = trainServiceDBContext;
        }

        public async Task<UserResponse> Cadastrar(UserCommand request)
        {
            User userModels = new()
            {
                Nome = request.UserName,
                Senha = request.UserPassword,
            };

            await _dbContext.Users.AddAsync(userModels);
            await _dbContext.SaveChangesAsync();

            return new UserResponse(userModels);
        }
    }
}