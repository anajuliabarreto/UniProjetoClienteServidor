namespace ProjetoClienteServidor.Models.User
{
    public class User()
    {
        //public User(
        //    short id,
        //    string nomeUsuario,
        //    string senhaUsuario)
        //{
        //    Id = id;
        //    Nome = nomeUsuario;
        //    Senha = senhaUsuario;
        //}

        public virtual short Id { get; set; }
        public required string Nome { get; set; }
        public required string Senha { get; set; }
    }
}