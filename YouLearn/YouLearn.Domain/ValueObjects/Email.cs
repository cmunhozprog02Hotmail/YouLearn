using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using YouLearn.Domain.Resourses;

namespace YouLearn.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;


            new AddNotifications<Email>(this)
                .IfNotEmail(x => x.Endereco, MSG.OBJETO_X0_E_INVALIDO.ToFormat("E-Mail"));
            
            
        }

        public string Endereco { get; private set; }

    }
}
