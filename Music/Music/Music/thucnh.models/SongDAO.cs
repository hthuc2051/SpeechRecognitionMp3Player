using Music.thucnh.dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.thucnh.models
{
    class SongDAO
    {
        const string connectionString = "Data Source=DATBCSE63154\\SQLEXPRESS;Initial Catalog=MusicPlayer;Persist Security Info=True;User ID =sa; Password=123456";
        SqlConnection sqlConnection;
        SqlCommand command;
        SqlDataReader reader;

        private void closeConnect()
        {
            reader.Close();
            sqlConnection.Close();
        }
        public List<SongDTO> loadAllSongs()
        {
            int songID,time;
            string title, lyrics, dateRelease, linkOpen, linkDownLoad,image;
            ArtistDTO artis;
            int artisID;
            string artisName;

            SongDTO song = null;
            List<SongDTO> result = new List<SongDTO>();

            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("" +
                        "Select Songs.ID, Songs.title,Songs.lyrics,Songs.dateRelease,Songs.linkOpen,Songs.linkDownLoad,Songs.image,Songs.time,Artists.ID,Artists.name " +
                        "From Songs, Artists, Song_Album_Artist " +
                        "Where Song_Album_Artist.songID = Songs.ID AND Song_Album_Artist.artistID = Artists.ID ",
                        sqlConnection))
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //songs
                            songID = reader.GetInt32(0);
                            title = reader.GetString(1);
                            lyrics = reader.GetString(2);
                            dateRelease = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            linkOpen = reader.GetString(4);
                            linkDownLoad = reader.GetString(5);
                            image = reader.GetString(6);
                            time = reader.GetInt32(7);
                            //artis
                            artisID = reader.GetInt32(8);
                            artisName = reader.GetString(9);
                            artis = new ArtistDTO(artisID, artisName);
                           
                            song = new SongDTO(songID, title, lyrics, dateRelease, linkOpen, linkDownLoad, image,time,artis);
                            result.Add(song);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return result;
        }

        public SongDTO getSongByID(int songID)
        {
          
            string title, lyrics, dateRelease, linkOpen, linkDownLoad, image;
            ArtistDTO artis;
            int artisID,time;
            string artisName;

            SongDTO song = null;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("" +
                        "Select Songs.ID, Songs.title,Songs.lyrics,Songs.dateRelease,Songs.linkOpen,Songs.linkDownLoad,Songs.image,Songs.time,Artists.ID,Artists.name " +
                        "From Songs, Artists, Song_Album_Artist " +
                        "Where Song_Album_Artist.songID = Songs.ID AND Song_Album_Artist.artistID = Artists.ID " +
                        "AND Songs.ID=@songID",
                        sqlConnection))
                        command.Parameters.AddWithValue("@songID", songID);
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //songs
                            songID = reader.GetInt32(0);
                            title = reader.GetString(1);
                            lyrics = reader.GetString(2);
                            dateRelease = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            linkOpen = reader.GetString(4);
                            linkDownLoad = reader.GetString(5);
                            image = reader.GetString(6);
                            time = reader.GetInt32(7);
                            //artis
                            artisID = reader.GetInt32(8);
                            artisName = reader.GetString(9);
                            artis = new ArtistDTO(artisID, artisName);

                            song = new SongDTO(songID, title, lyrics, dateRelease, linkOpen, linkDownLoad, image, time, artis);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return song;
        }

        public List<SongDTO> searchSong(string searchValue)
        {
            int songID,time;
            string title, lyrics, dateRelease, linkOpen, linkDownLoad,image;
            ArtistDTO artis;
            int artisID;
            string artisName;
            SongDTO song = null;
            List<SongDTO> result = new List<SongDTO>();

            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("" +
                        "Select Songs.ID, Songs.title,Songs.lyrics,Songs.dateRelease,Songs.linkOpen,Songs.linkDownLoad,Songs.image,Songs.time,Artists.ID,Artists.name " +
                        "From Songs, Artists, Song_Album_Artist " +
                        "Where Song_Album_Artist.songID = Songs.ID AND Song_Album_Artist.artistID = Artists.ID " +
                        "AND Songs.title Like @searchValue",
                        sqlConnection))
                        command.Parameters.AddWithValue("@searchValue", "%"+searchValue+"%");
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //songs
                            songID = reader.GetInt32(0);
                            title = reader.GetString(1);
                            lyrics = reader.GetString(2);
                            dateRelease = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            linkOpen = reader.GetString(4);
                            linkDownLoad = reader.GetString(5);
                            image = reader.GetString(6);
                            time = reader.GetInt32(7);
                            //artis
                            artisID = reader.GetInt32(8);
                            artisName = reader.GetString(9);
                            artis = new ArtistDTO(artisID, artisName);

                            song = new SongDTO(songID, title, lyrics, dateRelease, linkOpen, linkDownLoad, image, time, artis);
                            result.Add(song);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return result;
        }
        public List<SongDTO> getSongsByAlbumID(int albumID)
        {
            int songID,time;
            string title, lyrics, dateRelease, linkOpen, linkDownLoad, image;
            ArtistDTO artis;
            int artisID;
            string artisName;
            SongDTO song = null;
            List<SongDTO> result = new List<SongDTO>();

            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("" +
                        "Select Songs.ID, Songs.title,Songs.lyrics,Songs.dateRelease,Songs.linkOpen,Songs.linkDownLoad,Songs.image,Songs.time,Artists.ID,Artists.name " +
                        "From Songs,Albums, Artists, Song_Album_Artist " +
                        "Where Song_Album_Artist.albumID = Albums.ID AND Song_Album_Artist.songID = Songs.ID AND Song_Album_Artist.artistID = Artists.ID " +
                        "AND Albums.ID = @albumID",
                        sqlConnection))
                        command.Parameters.AddWithValue("@albumID", albumID);
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //songs
                            songID = reader.GetInt32(0);
                            title = reader.GetString(1);
                            lyrics = reader.GetString(2);
                            dateRelease = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            linkOpen = reader.GetString(4);
                            linkDownLoad = reader.GetString(5);
                            image = reader.GetString(6);
                            time = reader.GetInt32(7);
                            //artis
                            artisID = reader.GetInt32(8);
                            artisName = reader.GetString(9);
                            artis = new ArtistDTO(artisID, artisName);

                            song = new SongDTO(songID, title, lyrics, dateRelease, linkOpen, linkDownLoad, image, time, artis);
                            result.Add(song);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return result;
        }

        public List<SongDTO> getSongsOfPlayList(int playListID)
        {
            int songID,time;
            string title, lyrics, dateRelease, linkOpen, linkDownLoad, image;
            ArtistDTO artis;
            int artisID;
            string artisName;
            SongDTO song = null;
            List<SongDTO> result = new List<SongDTO>();

            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("" +
                         "Select distinct Songs.ID, Songs.title,Songs.lyrics,Songs.dateRelease,Songs.linkOpen,Songs.linkDownLoad,Songs.image,Songs.time,Artists.ID,Artists.name " +
                         "From Songs, Playlist_Songs, Playlists, Artists, Song_Album_Artist " +
                         "Where Songs.ID = Playlist_Songs.songID AND Playlist_Songs.PlaylistID = Playlists.ID " +
                         "AND Songs.ID = Song_Album_Artist.songID AND Song_Album_Artist.artistID = Artists.ID " +
                         "AND Playlists.ID = @playListID",
                         sqlConnection))
                        command.Parameters.AddWithValue("@playListID", playListID);
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //songs
                            songID = reader.GetInt32(0);
                            title = reader.GetString(1);
                            lyrics = reader.GetString(2);
                            dateRelease = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            linkOpen = reader.GetString(4);
                            linkDownLoad = reader.GetString(5);
                            image = reader.GetString(6);
                            time = reader.GetInt32(7);
                            //artis
                            artisID = reader.GetInt32(8);
                            artisName = reader.GetString(9);
                            artis = new ArtistDTO(artisID, artisName);

                            song = new SongDTO(songID, title, lyrics, dateRelease, linkOpen, linkDownLoad, image, time, artis);
                            result.Add(song);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return result;
        }
        public List<String> getaAllLyrics()
        {
            List<String> result = null;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    result = new List<string>();
                    sqlConnection.Open();
                    using (command = new SqlCommand("SELECT lyrics FROM Songs", sqlConnection))
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    closeConnect();
                }
            }
            return result;
        }

    }
}
