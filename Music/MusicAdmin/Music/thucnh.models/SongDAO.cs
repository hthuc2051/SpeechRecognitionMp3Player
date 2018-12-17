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
            int songID;
            string title, lyrics, dateRelease, linkOpen, linkDownLoad,image;
            ArtistDTO artis;
            int artisID;
            string artisName;
            AlbumDTO album;
            int albumID;
            string albumName;
            SongDTO song = null;
            List<SongDTO> result = new List<SongDTO>();

            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("" +
                        "Select Songs.ID, Songs.title,Songs.lyrics,Songs.dateRelease,Songs.linkOpen,Songs.linkDownLoad,Songs.image,Artists.ID,Artists.name,Albums.ID,Albums.name " +
                        "From Songs, Artists, Albums, Song_Album_Artist " +
                        "Where Song_Album_Artist.albumID = Albums.ID AND Song_Album_Artist.songID = Songs.ID AND Song_Album_Artist.artistID = Artists.ID",
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
                            //artis
                            artisID = reader.GetInt32(7);
                            artisName = reader.GetString(8);
                            artis = new ArtistDTO(artisID, artisName);
                            //album
                            albumID = reader.GetInt32(9);
                            albumName = reader.GetString(10);
                            album = new AlbumDTO(albumID, albumName);

                            song = new SongDTO(songID, title, lyrics, dateRelease, linkOpen, linkDownLoad, image,artis, album);
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
        public List<SongDTO> searchSong(string searchValue)
        {
            int songID;
            string title, lyrics, dateRelease, linkOpen, linkDownLoad,image;
            ArtistDTO artis;
            int artisID;
            string artisName;
            AlbumDTO album;
            int albumID;
            string albumName;
            SongDTO song = null;
            List<SongDTO> result = new List<SongDTO>();

            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("" +
                        "Select Songs.ID, Songs.title,Songs.lyrics,Songs.dateRelease,Songs.linkOpen,Songs.linkDownLoad,Songs.image,Artists.ID,Artists.name,Albums.ID,Albums.name " +
                        "From Songs, Artists, Albums, Song_Album_Artist " +
                        "Where Song_Album_Artist.albumID = Albums.ID AND Song_Album_Artist.songID = Songs.ID AND Song_Album_Artist.artistID = Artists.ID " +
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
                            //artis
                            artisID = reader.GetInt32(7);
                            artisName = reader.GetString(8);
                            artis = new ArtistDTO(artisID, artisName);
                            //album
                            albumID = reader.GetInt32(9);
                            albumName = reader.GetString(10);
                            album = new AlbumDTO(albumID, albumName);
                            song = new SongDTO(songID, title, lyrics, dateRelease, linkOpen, linkDownLoad, image, artis, album);
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


        public Boolean checkDuplicatedHS(string id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    using (command = new SqlCommand("select ID from Songs where ID = @id ", sqlConnection))
                        command.Parameters.AddWithValue("@id", id);
                    using (reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            check = true;

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
            return check;
        }

        public Boolean addSong(SongDTO dto,int time)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("Insert into " +
                        " Songs(ID,title,lyrics,dateRelease,linkOpen,linkDownLoad,image,time) " +
                        " Values (@ID, @title, @lyrics, @dateRelease, @linkOpen, @linkDownLoad,@image,@time)", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@ID", dto.ID);
                        command.Parameters.AddWithValue("@title", dto.Title);
                        command.Parameters.AddWithValue("@lyrics", dto.Lyrics);
                        command.Parameters.AddWithValue("@dateRelease", dto.DateRelease);
                        command.Parameters.AddWithValue("@linkOpen", dto.LinkOpen);
                        command.Parameters.AddWithValue("@linkDownLoad", dto.LinkDownLoad);
                        command.Parameters.AddWithValue("@image", dto.Image);
                        command.Parameters.AddWithValue("@time", time);
                        check = command.ExecuteNonQuery() > 0;
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
            return check;
        }
        public Boolean addSongArtistAndAlbum(SongDTO dto)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (command = new SqlCommand("Insert into " +
                        "Song_Album_Artist(songID,albumID,artistID) " +
                        "Values (@songID, @albumID, @artistID)", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@songID", dto.ID);
                        command.Parameters.AddWithValue("@albumID", dto.Album.Id);
                        command.Parameters.AddWithValue("@artistID", dto.Artis.Id);
                        check = command.ExecuteNonQuery() > 0;
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
            return check;
        }

        public Boolean updateSongs(SongDTO dto)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("UPDATE Songs SET title = @title, lyrics = @lyrics, dateRelease = @dateRelease, " +
                        "linkDownLoad = @linkDownLoad " +
                        "WHERE ID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", dto.ID);
                    command.Parameters.AddWithValue("@title", dto.Title);
                    command.Parameters.AddWithValue("@lyrics", dto.Lyrics);
                    command.Parameters.AddWithValue("@dateRelease", dto.DateRelease);
                    command.Parameters.AddWithValue("@linkDownLoad", dto.LinkDownLoad);
                    check = command.ExecuteNonQuery() > 0;
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
            return check;
        }
        public Boolean updateImg(string imgName,int ID)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("UPDATE Songs SET image = @image WHERE ID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@image", imgName);
                    check = command.ExecuteNonQuery() > 0;
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
            return check;
        }
        public Boolean updateSongAlbumArtist(SongDTO dto)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("UPDATE Song_Album_Artist SET albumID = @albumID, artistID = @artistID " +
                        "WHERE songID= @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", dto.ID);
                    command.Parameters.AddWithValue("@albumID", dto.Album.Id);
                    command.Parameters.AddWithValue("@artistID", dto.Artis.Id);
                    check = command.ExecuteNonQuery() > 0;
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
            return check;
        }

        public Boolean deleteSong(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("Delete Songs where ID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", id);
                    check = command.ExecuteNonQuery() > 0;
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
            return check;
        }
        public Boolean deleteSongAlbumArtisBySongID(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("Delete Song_Album_Artist where songID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", id);
                    check = command.ExecuteNonQuery() > 0;
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
            return check;
        }
        public Boolean deleteSongPlayListBySongID(int id)
        {
            Boolean check = false;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    command = new SqlCommand("Delete Playlist_Songs where songID = @id", sqlConnection);
                    command.Parameters.AddWithValue("@id", id);
                    check = command.ExecuteNonQuery() > 0;
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
            return check;
        }
    }
}
