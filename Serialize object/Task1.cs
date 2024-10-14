using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Song
{
    public string nameOfSong { get; set; }

    public Song () { }
    public Song(string nameOfSong)
    {
        this.nameOfSong = nameOfSong;
    }
}

[Serializable]
public class Task1
{
    public string Album { get; set; }
    public string Performer { get; set; }
    public int ReleaseYear { get; set; }
    public TimeSpan Duration { get; set; }
    public string RecordingStudio { get; set; }
    public List<Song> Songs { get; set; }

    public Task1() { }

    public Task1(string album, string performer, int year, TimeSpan totalDuration, string recording)
    {
        Album = album;
        Performer = performer;
        ReleaseYear = year;
        Duration = totalDuration;
        RecordingStudio = recording;
        Songs = new List<Song>();
    }
    public void AddSong(Song song)
    {
        Songs.Add(song);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Album: {Album}");
        Console.WriteLine($"Artist: {Performer}");
        Console.WriteLine($"Release Year: {ReleaseYear}");
        Console.WriteLine($"Total Duration: {Duration}");
        Console.WriteLine($"Recording Studio: {RecordingStudio}");
        Console.Write("Songs:");
        foreach (var song in Songs)
        {
            Console.WriteLine($" {song.nameOfSong}");
        }
    }
}