using Application.Core.BlogingModule;
using ASP.NET.MVC5.Client.Extensions;
using ASP.NET.MVC5.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.MVC5.Client.Controllers
{
    public class EventsController : Controller
    {
         #region Fields
        private INewsManagementServices _newsManagementServices;
        private IEventManagementServices _eventsManagementServices;
        private int _pageSize;

       
        #endregion

        #region Properties 
        public int PageSize
        {
            get {
                this._pageSize = 4;
                return this._pageSize; 
            }
        }

        #endregion
        #region Ctor
        public EventsController(INewsManagementServices newsManagementServices, IEventManagementServices eventsManagementServices)
        {
            if (newsManagementServices == null)
                throw new ArgumentNullException("newsManagementServices");
            if (eventsManagementServices == null)
                throw new ArgumentNullException("eventsManagementServices");

            this._newsManagementServices = newsManagementServices;
            this._eventsManagementServices = eventsManagementServices;
             
        }

        #endregion
         #region Actions

        public async Task<ActionResult> Index(int? id)
        {
            try
            {
                int pageStart = 0;
                int currentPage = 1;
                if (id.HasValue)
                {
                    pageStart = id.Value < 1 ? 0 : id.Value - 1;
                    currentPage = id.Value < 1 ? 1 : id.Value;
                }

                var newsResult = await _eventsManagementServices.GetPagedEventsWithTotalAsync(pageStart * this.PageSize, this.PageSize);
                var otheNewsResult = await _newsManagementServices.GetLatestNewsAsync(4);
                var viewModel = newsResult.ToEventsListViewModel();
                viewModel.PageSize = this.PageSize;
                viewModel.CurrentPage = currentPage;
                viewModel.NewsList = otheNewsResult.ToRelatedNewsViewModel();
                return View(viewModel);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }

        }

        // GET: News
        public ActionResult Details(string id)
        {
            return View();
        }

         #endregion
    }
}