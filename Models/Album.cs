using SongLogic;
using System.Collections.Generic;

namespace MusicSorter.Models
{
  public class Album
  {
    public static List<Album> albumList = new List<Album>{};
    public string AlbumName {get;}
    public string Artist {get;}
    public string LinerNotes {get;}
    public List<Song> SongList {get; set;}
    public int Id {get;}

    public Album(string albumName,string artist, string linerNotes)
    {
      AlbumName = albumName;
      Artist = artist;
      LinerNotes = linerNotes;
      SongList = new List<Song>{};
      Id = albumList.Count;
      albumList.Add(this);
    }
    public int GetNextId()
    {
      return SongList.Count;
    }
    public void AddSong(string title, string runtime)
    {
      SongList.Add(new Song(title, runtime,GetNextId()));
    }
    public List<Song> GetAllSongs()
    {
      return SongList;
    }
    public static Album findId(int id)
    {
      return albumList[id];
    }
  }

}