using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using YouLearn.Domain.Arguments.Usuario;
using YouLearn.Domain.Entities;
using YouLearn.Domain.Interfaces.Services;
using YouLearn.Domain.Resourses;

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

            // Cria Entidade
            Usuario usuario = new Usuario();
            usuario.Nome.PrimeiroNome = request.PrimeiroNome;
            usuario.Nome.UltimoNome = request.UltimoNome;
            usuario.Email.Endereco = request.Email;
            usuario.Senha = request.Senha;
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
