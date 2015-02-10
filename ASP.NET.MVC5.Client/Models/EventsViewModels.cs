using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.MVC5.Client.Models
{
    public class EventsViewModels
    {
    }

    public class EventItemViewModel
    {

        public string Id { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

    }

    public class EventListItemViewModel 
    {

        public string Id { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

    }

    public class EventListViewModel
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
        public IEnumerable<RelatedNewsViewModel> NewsList { get; set; }
        public IEnumerable<EventListItemViewModel> List { get; set; } 


    }
}
           