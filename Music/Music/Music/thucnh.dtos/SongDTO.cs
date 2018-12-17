using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.dtos
{
    class SongDTO
    {
        private int id,time;
        private string title, lyrics, dateRelease, linkOpen, linkDownLoad,image;
        private ArtistDTO artis;
        private AlbumDTO album;

        public SongDTO(int id, string title, string linkDownLoad, string image)
        {
            this.id = id;
            this.title = title;
            this.linkDownLoad = linkDownLoad;
            this.image = image;
        }

        public SongDTO(int id, string title, string lyrics, string dateRelease, string linkOpen, string linkDownLoad, string image)
        {
            this.id = id;
            this.title = title;
            this.lyrics = lyrics;
            this.dateRelease = dateRelease;
            this.linkOpen = linkOpen;
            this.linkDownLoad = linkDownLoad;
            this.image = image;
        }

        public SongDTO(int id, string title, string lyrics, string dateRelease, string linkOpen, string linkDownLoad, string image,int time, ArtistDTO artis)
        {
            this.id = id;
            this.title = title;
            this.lyrics = lyrics;
            this.dateRelease = dateRelease;
            this.linkOpen = linkOpen;
            this.linkDownLoad = linkDownLoad;
            this.image = image;
            this.time = time;
            this.artis = artis;
        }

        public SongDTO(int id, string title, string lyrics, string dateRelease, string linkOpen, string linkDownLoad, string image, ArtistDTO artis, AlbumDTO album)
        {
            this.id = id;
            this.title = title;
            this.lyrics = lyrics;
            this.dateRelease = dateRelease;
            this.linkOpen = linkOpen;
            this.linkDownLoad = linkDownLoad;
            this.Image = image;
            this.artis = artis;
            this.album = album;
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Lyrics
        {
            get
            {
                return lyrics;
            }
            set
            {
                lyrics = value;
            }
        }
        public string DateRelease
        {
            get
            {
                return dateRelease;
            }
            set
            {
                dateRelease = value;
            }
        }
        public string LinkOpen
        {
            get
            {
                return linkOpen;
            }
            set
            {
                linkOpen = value;
            }
        }
        public string LinkDownLoad
        {
            get
            {
                return linkDownLoad;
            }
            set
            {
                linkDownLoad = value;
            }
        }

        public string Image { get => image; set => image = value; }
        public int Time { get => time; set => time = value; }
        internal ArtistDTO Artis { get => artis; set => artis = value; }
        internal AlbumDTO Album { get => album; set => album = value; }
    }
}
