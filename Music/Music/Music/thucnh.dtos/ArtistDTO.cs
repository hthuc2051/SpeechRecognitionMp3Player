using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.dtos
{
    class ArtistDTO
    {
        private int id;
        private string name;
        private string label,image;
     

        public ArtistDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public ArtistDTO(int id, string name, string label, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Label = label;
            this.Image = image;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Label { get => label; set => label = value; }
        public string Image { get => image; set => image = value; }
    }
}
