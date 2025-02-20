using ProjetoClienteServidor.Models.User;

namespace ProjetoClienteServidor.Data
{
    public class UserResponse
    {
        public UserResponse(User userModels)
        {
            Id = userModels.Id;
            Nome = userModels.Nome;
            Senha = "******";
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}