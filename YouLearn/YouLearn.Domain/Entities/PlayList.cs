﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YouLearn.Domain.Entities
{
    public class PlayList
    {
        public Guid Id { get; set; }

        public Usuario Usuario { get; set; }

        // Em Analise, Aprovado ou Recusado

        public string Status { get; set; }
    }
}
