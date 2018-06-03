using prmToolkit.NotificationPattern;

namespace YouLearn.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this);
            
            
        }

        public string Endereco { get; set; }

    }
}
