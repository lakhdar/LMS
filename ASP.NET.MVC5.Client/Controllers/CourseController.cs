using ASP.NET.MVC5.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.MVC5.Client.Controllers
{
    public class CourseController : Controller
    {


        #region Fields
        //private INewsManagementServices _newsManagementServices;
        //private IEventManagementServices _eventsManagementServices;
        private int _pageSize;


        #endregion

        #region Properties
        public int PageSize
        {
            get
            {
                this._pageSize = 6;
                return this._pageSize;
            }
        }

        #endregion
        // GET: Course
        public ActionResult Index(int? id)
        {
            int pageStart = 0;
            int currentPage = 1;
            if (id.HasValue)
            {
                pageStart = id.Value < 1 ? 0 : id.Value - 1;
                currentPage = id.Value < 1 ? 1 : id.Value;
            }
            var data = new List<List<string>>()
                {
                    new List<string>(){"2","Web Design Foundation", "10 Sep 2014", "1 year", "Beginner", "Remote (Online)", "New"},
                    new List<string>(){"3", "Web Design Advanced", "20 Sep 2014", "2 year", "Advanced", "College Green Campus", "New"},
                    new List<string>(){"22", "Web Development Foundation", "10 Sep 2014", "1 year", "Intermediate", "Remote (Online)", ""},
                    new List<string>(){"222", "Web Development Advanced", "10 Sep 2014", "1 year", "Intermediate", "Remote (Online)", ""},
                    new List<string>(){"25", "Digital Marketing Foundation", "25 Sep 2014", "1 year", "Intermediate", "Queen Square Campus", "Full"},
                    new List<string>(){"24", "Digital Marketing Foundation", "25 Sep 2014", "1 year", "Intermediate", "Queen Square Campus", ""},
                    new List<string>(){"21", "Digital Marketing Advanced", "25 Sep 2014", "1 year", "Advanced", "Queen Square Campus", ""},
                    new List<string>(){"214", "Accounting Foundation", "25 Sep 2014", "1 year", "Intermediate", "Queen Square Campus", ""},
                    new List<string>(){"2111", "Accounting Foundation", "25 Sep 2014", "1 year", "Intermediate", "Queen Square Campus", ""},
                    new List<string>(){"214", "Applied Mathematics", "25 Sep 2014", "2 year", "Advanced", "College Green Campus", ""},
                    new List<string>(){"124", "Applied Physics", "25 Sep 2014", "2 year", "Advanced", "College Green Campus", ""},
                };

            CourseListViewModel model = new CourseListViewModel()
            {
                Total = 11,
                CurrentPage = currentPage,
                PageSize = this.PageSize,
                Columns = new List<CourseColumnViewModel>()
                {
                    new CourseColumnViewModel(){ Id= "1", Text= "Course name", Span= "3", TemplateId= "header-tmpl" } ,
                    new CourseColumnViewModel(){ Id= "2", Text= "Start date", Span= "3", TemplateId= "column-tmpl" },
                    new CourseColumnViewModel() { Id= "3", Text= "Duration", Span= "2", TemplateId= "column-tmpl" },
                    new CourseColumnViewModel(){ Id= "4", Text= "Level", Span= "3", TemplateId= "column-tmpl" },
                    new CourseColumnViewModel(){ Id= "5", Text= "Location", Span= "4", TemplateId= "column-tmpl" },
                },

                Data = data.Skip(pageStart * this.PageSize).Take(this.PageSize)
            };

            return View(model);
        }

        // GET: Course
        public ActionResult Catalog()
        {
            return View();
        }


        // GET: Course/Details/5
        public ActionResult Details(string id)
        {
            CourseDetailsViewModel model = new CourseDetailsViewModel()
            {
                Id = id,
                Name = "Web Design Foundation",
                StartDate = new DateTime(2014, 08, 20).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"),
                Duration = "2 years",
                Level = "Advanced",
                Location = "Remote(Online)",
                Desciption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vestibulum pellentesque urna. Phasellus adipiscing et massa et aliquam. Ut odio magna, interdum quis dolor non, tristique vestibulum nisi. Nam accumsan convallis venenatis. Nullam posuere risus odio, in interdum felis venenatis sagittis.,Donec a turpis non lorem pulvinar posuere.",

                Tabs = new List<CourseTabViewModel>()
            {
                new CourseTabViewModel()
                {
                     Name= "Course structure",
                     Description = "Duis ut ornare dui. Ut dapibus porta mattis. Ut eget enim sed nisl tristique lobortis non et dolor. Phasellus et venenatis metus. Duis nisl est, dictum id lacus consequat, tristique placerat orci. Sed porta leo sed lorem rhoncus, et ullamcorper lectus malesuada. ",
                     TemplateType= "table",
                     Columns=new List<string>(){"id", "Nullam consequat", "Commodo metus", "Dapibus porta", "Sed porta"},
                     Data=new List<object>() 
                     {
                         new List<string>(){"ccsd", "Faucibus purus convallis", "Aliquam sit amet", "Sed porta leo", "Duis ut ornare dui"},
                         new List<string>(){"cd", "Faucibus purus convallis", "Aliquam sit amet", "Sed porta leo", "Duis ut ornare dui"},
                        new List<string>(){"vfg", "Faucibus purus convallis", "Aliquam sit amet", "Sed porta leo", "Duis ut ornare dui"}
                     }
                },
                new CourseTabViewModel()
                {
                     Name= "Fees",
                     Description = "Duis ut ornare dui. Ut dapibus porta mattis. Ut eget enim sed nisl tristique lobortis non et dolor. Phasellus et venenatis metus. Duis nisl est, dictum id lacus consequat, tristique placerat orci. Sed porta leo sed lorem rhoncus, et ullamcorper lectus malesuada. ",
                     TemplateType= "ul",
                     Data=new List<object>() 
                     {
                         new  { Id= "ccsd", Text= "Vitae pretium purus" },
                         new{ Id= "dre", Text= "Eget sagittis turpis" },
                            new{ Id= "azer",Text= "Curabitur tempus" },
                           new { Id= "azsssser", Text= "Fusce vehicula" },
                     }
                },
                 new CourseTabViewModel()
                {
                     Name= "Entry requirements",
                     Description = "Duis ut ornare dui. Ut dapibus porta mattis. Ut eget enim sed nisl tristique lobortis non et dolor. Phasellus et venenatis metus. Duis nisl est, dictum id lacus consequat, tristique placerat orci. Sed porta leo sed lorem rhoncus, et ullamcorper lectus malesuada. ",
                     TemplateType= "ol",
                     Data=new List<object>() 
                     {
                       "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", "Aliquam tincidunt mauris eu risus.", "Aliquam sit amet"
                     }
                }
            },
                RelatedCourses = new List<RelatedCourseViewModel>()
            {
               new RelatedCourseViewModel() { Id= "14ss78", Name= " Ut enim ad minim veniam" },
               new RelatedCourseViewModel() { Id= "14d78", Name= " Lorem ipsum dolor sit amet" },
               new RelatedCourseViewModel() { Id= "147q8", Name= " Praesent ut turpis feugiat" },
               new RelatedCourseViewModel() { Id= "14s7d8", Name= " Aenean interdum iaculis odio" },
               new RelatedCourseViewModel() { Id= "1478", Name= "Morbi in malesuada nibh" },
               new RelatedCourseViewModel() { Id= "14d78", Name= "Fusce a ligula in velit" },
               new RelatedCourseViewModel() { Id= "14sd78", Name= " Cras et sapien rhoncus" } 
            }

            };


            return View(model);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
