using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
{
    public class PlayList : EntityBase
    {
        
        public Usuario Usuario { get; set; }

        // Em Analise, Aprovado ou Recusado

        public EnumStatus Status { get; set; }
    }
}
