using prmToolkit.NotificationPattern;
using System;
using YouLearn.Domain.Arguments.Usuario;
using YouLearn.Domain.Entities;
using YouLearn.Domain.Interfaces.Services;

namespace YouLearn.Domain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if(request == null)
            {
                AddNotification("AdicionarUsuarioRequest", "Objeto AdicionarUsuarioRequest é obrigatório.");
                return null;
            }

            Usuario usuario = new Usuario();
            usuario.Nome.PrimeiroNome = "Paulo Rogèrio";
            usuario.Nome.UltimoNome = "Martins Marques";
            usuario.Email.Endereco = "paulo.analista@outlook.com";
            usuario.Senha = "123456";

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
