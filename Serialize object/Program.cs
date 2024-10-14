using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

class Program
{
    public static async Task Main(string[] args)
    {
        //Task1

        Task1 album = new Task1("Album", "Permomer", 1999, new TimeSpan(1, 0, 0), "RecordingStudio");
        album.AddSong(new Song("Song"));
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Task1));

        using (FileStream fs = new FileStream("Task1.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, album);

            Console.WriteLine("Object has been serialized");
        }

        using (FileStream fs = new FileStream("Task1.xml", FileMode.OpenOrCreate))
        {
            Task1? task = xmlSerializer.Deserialize(fs) as Task1;
            task.DisplayInfo();
        }

        //Task2
        DateTime PublishDate = DateTime.Parse("2024-10-11");
        DateTime ArticleAnnouncement = DateTime.Parse("2025-10-11");
        Task2 journal = new Task2("NameOfJournal", "Publisher", PublishDate, 51);
        //Article article = new Article("Article", 10000, ArticleAnnouncement);

        journal.AddArticle(new Article("Article", 10000, ArticleAnnouncement));

        //using (FileStream fs = new FileStream("Task2.json", FileMode.OpenOrCreate))
        //{
        //    await JsonSerializer.SerializeAsync(fs, article);
        //    Console.WriteLine("Data has been saved to file");
        //}
        using (FileStream fs = new FileStream("Task2.json", FileMode.OpenOrCreate))
        {
            await JsonSerializer.SerializeAsync(fs, journal);
            Console.WriteLine("Data has been saved to file");
        }
        using (FileStream fs = new FileStream("Task2.json", FileMode.OpenOrCreate))
        {
            Task2? jour = await JsonSerializer.DeserializeAsync<Task2>(fs);
            jour.DisplayInfo();
        }
    }
}