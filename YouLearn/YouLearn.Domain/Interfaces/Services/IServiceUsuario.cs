using YouLearn.Domain.Arguments.Usuario;

namespace YouLearn.Domain.Interfaces.Services
{
    public interface IServiceUsuario
    {
        AdicionarUsuarioResponse AdicionarUsusario(AdicionarUsuarioRequest request);

        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
    }
}
