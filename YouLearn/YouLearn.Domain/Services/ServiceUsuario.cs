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

            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            //nome.PrimeiroNome = ;
            //nome.UltimoNome = ;

            Email email = new Email(request.Email);
            //email.Endereco = ;

            

            Usuario usuario = new Usuario();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = request.Senha;

            AddNotifications(nome, email, usuario);

            if (usuario.Senha.Length < 3)
            {
                throw new Exception("Senha deve conter no mínimo 3 caracteres");
            }

            //Persiste no Banco de Dados
            //AdicionarUsuarioResponse response = new RepositoryUsuario(usuario);
            //return response;

            if(this.IsInvalid() == true)
            {
                return null;
            }
            return new AdicionarUsuarioResponse(Guid.NewGuid());



            
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
