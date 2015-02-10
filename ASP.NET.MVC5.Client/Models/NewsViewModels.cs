namespace ASP.NET.MVC5.Client.Models
{
    using Domain.BoundedContext.BlogingModule;
    using System.Collections.Generic;

    public class NewsViewModels
    {

    }

    public class NewsItemViewModels
    {

        public string Id { get; set; }
        public string Img { get; set; }
        public string Tilte { get; set; }
        public string Text { get; set; }
        public string PublishDate { get; set; }
        
    }

    public class NewsDetailViewModel
    {
        public string Id { get; set; }
        public string Tilte { get; set; }
        public string Text { get; set; }
        public string PublishDate { get; set; }
        public IEnumerable<EventItemViewModel> EventsList { get; set; }
        public IEnumerable<RelatedNewsViewModel> OtherNewsList { get; set; }  

    }

    public class NewsListViewModels
    {
        public int Total { get; set; }
        public int CurrentPage { get; set; }
        public int PagesCount 
        {
            get
            {
                double temp = (double)this.Total / (double)this.PageSize;
                return (int)System.Math.Ceiling(temp);
            }  
        }
        public int PageSize { get; set; }
        public IEnumerable<NewsItemViewModels> List { get; set; }
        public IEnumerable<EventItemViewModel> eventsList { get; set; }  

        
    }

    public class RelatedNewsViewModel
    {
        public string Id { get; set; }
        public string Img { get; set; }
        public string Tilte { get; set; }

    }
}