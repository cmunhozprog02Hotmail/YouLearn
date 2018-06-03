using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using YouLearn.Domain.Arguments.Usuario;
using YouLearn.Domain.Entities;
using YouLearn.Domain.Interfaces.Services;
using YouLearn.Domain.Resourses;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if(request == null)
            {
                AddNotification("AdicionarUsuarioRequest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("AdicionarUsuarioRequest"));
                return null;
            }


            //Cria entitade

            Nome nome = new Nome();
            nome.PrimeiroNome = request.PrimeiroNome;
            nome.UltimoNome = request.UltimoNome;

            Usuario usuario = new Usuario();
            usuario.Nome = nome;
            usuario.Nome.UltimoNome = request.UltimoNome;
            usuario.Email.Endereco = request.Email;
            usuario.Senha = request.Senha;

            //Persiste no Banco de Dados
            AdicionarUsuarioResponse response = new RepositoryUsuario(usuario);
            return response;



            
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
