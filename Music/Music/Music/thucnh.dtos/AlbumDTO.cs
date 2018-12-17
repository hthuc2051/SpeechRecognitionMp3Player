using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.dtos
{
    class AlbumDTO
    {
        private int id;
        private string name,image;

        public AlbumDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public AlbumDTO(int id, string name, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Image = image;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Image { get => image; set => image = value; }
    }
}
