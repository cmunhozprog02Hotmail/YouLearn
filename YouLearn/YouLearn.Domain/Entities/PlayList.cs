using System;
using YouLearn.Domain.Enums;

namespace YouLearn.Domain.Entities
{
    public class PlayList
    {
        public Guid Id { get; set; }

        public Usuario Usuario { get; set; }

        // Em Analise, Aprovado ou Recusado

        public EnumStatus Status { get; set; }
    }
}
