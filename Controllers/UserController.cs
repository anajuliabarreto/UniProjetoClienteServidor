using Microsoft.AspNetCore.Mvc;
using ProjetoClienteServidor.Data;
using ProjetoClienteServidor.Repository;

namespace ProjetoClienteServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepositorio;

        public UserController(IUserRepository userRepositorio)
        {
            _userRepositorio = userRepositorio;
        }

        /// <summary>
        /// Crei seu login de usuário.
        /// </summary>
        /// <returns></returns>
        [HttpPost("usuario")]
        public async Task<ActionResult<UserResponse>> Cadastrar(
            [FromBody] UserCommand userRequest)
        {

            UserResponse userResponseList = await _userRepositorio.Cadastrar(userRequest);

            return Ok(userResponseList);
        }
    }
}