using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Article
{
    public string nameOfArticle { get; set; }
    public int CharacterCount { get; set; }
    public DateTime ArticleAnnouncement { get; set; }

    public Article() { }
    public Article(string nameOfArticle, int CharacterCount, DateTime ArticleAnnouncement)
    {
        this.nameOfArticle = nameOfArticle;
        this.CharacterCount = CharacterCount;
        this.ArticleAnnouncement = ArticleAnnouncement;
    }
}

public class Task2
{
    public string nameOfJournal { get; set; }

    public string Publisher { get; set; }
    public DateTime PublicationDate { get; set; }
    public int PageCount { get; set; }
    public List<Article> Article {  get; set; }

    public Task2() { }
    public Task2(string nameOfJournal, string publisher, DateTime publicationDate, int pageCount)
    {
        this.nameOfJournal = nameOfJournal;
        Publisher = publisher;
        PublicationDate = publicationDate;
        PageCount = pageCount;
        Article = new List<Article>();
    }

    public void AddArticle(Article аrticle)
    {
        Article.Add(аrticle);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"NameOfJournal: {nameOfJournal}");
        Console.WriteLine($"Publisher: {Publisher}");
        Console.WriteLine($"PublicationDate: {PublicationDate}");
        Console.WriteLine($"PageCount: {PageCount}");
        Console.WriteLine("Article:");
        foreach (var article in Article)
        {
            Console.WriteLine($"NameOfArticle - {article.nameOfArticle}, CharacterCount - {article.CharacterCount}, ArticleAnnouncement - {article.ArticleAnnouncement}");
        }
    }
}