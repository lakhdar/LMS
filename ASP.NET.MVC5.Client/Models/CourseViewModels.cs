using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.MVC5.Client.Models
{
    public class CourseViewModels
    {
    }
    public class CourseColumnViewModel 
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Span { get; set; }
        public string TemplateId { get; set; }
    
    }
 
    public class CourseListViewModel
    {
        public int Total { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int PagesCount
        {
            get
            {
                double temp = (double)this.Total / (double)this.PageSize;
                return (int)System.Math.Ceiling(temp);
            }
        }

        
        public IEnumerable<CourseColumnViewModel> Columns { get; set; }
        public IEnumerable<IEnumerable<string>> Data { get; set; }
    }

    public class CourseDetailsViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string Duration { get; set; }
        public string Level { get; set; }
        public string Location { get; set; }
        public string Desciption { get; set; }
        public IEnumerable<CourseTabViewModel> Tabs { get; set; }
        public IEnumerable<RelatedCourseViewModel> RelatedCourses { get; set; }

    }


    public class CourseTabViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TemplateType { get; set; }
        public IEnumerable<string> Columns { get; set; }
        public IEnumerable<object> Data { get; set; }
    }

    public class RelatedCourseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

}