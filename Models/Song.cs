//runtime
//title

namespace SongLogic
{
  public class Song
  {
    public string Title { get; }
    public string RunTime { get; }
    public int Id {get;}
    public Song(string title, string runtime, int id)
    {
      Title = title;
      RunTime = runtime;
      Id = id;
    }
  }
}