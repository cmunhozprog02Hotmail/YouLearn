using System;

namespace YouLearn.Domain.Entities
{
    public class Video
    {
       
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public int TiOrdemNaPlayList { get; set; }
        public string IdVideoToutube { get; set; }
        public string Status { get; set; }

        public Guid Id { get; set; }

        public Canal Canal { get; set; }

        public PlayList PlayList { get; set; }

        public Usuario UsuarioSurgiu { get; set; }



    }
}
