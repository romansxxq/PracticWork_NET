using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork_NET
{
    class Artist
    {
        public int Id { get; set; }
        public string FName{ get; set; }
        public string LName { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<Album> Albums { get; set; }

    }
    class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        //Relationship type : Many to Many (*...*)
        public ICollection<Artist> Artists { get; set; }
    }
    class Album {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public DateTime DateTime { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; } 
        
        public ICollection<Track> Tracks { get; set; }

    }
    class Genre { 
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
    class Track { 
        public int Id { get; set; }
        public string Name { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        public string Duration { get; set; }
        public Playlist Playlists { get; set; }
        public int PlaylistId { get; set; }
    }
    
    class Playlist
    {
        public int Id { get; set; }
        public string PlaylistsName { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}