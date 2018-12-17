using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.dtos
{
    class PlaylistDTO
    {
        private int id;
        private string playlistName, dateCreate, image;

        public PlaylistDTO(int id, string playlistName, string dateCreate, string image)
        {
            this.Id = id;
            this.PlaylistName = playlistName;
            this.DateCreate = dateCreate;
            this.Image = image;
        }

        public int Id { get => id; set => id = value; }
        public string PlaylistName { get => playlistName; set => playlistName = value; }
        public string DateCreate { get => dateCreate; set => dateCreate = value; }
        public string Image { get => image; set => image = value; }
    }
}
