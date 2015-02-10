using Application.Core.BlogingModule;
using ASP.NET.MVC5.Client.Models;
using ASP.NET.MVC5.Client.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.MVC5.Client.Controllers
{
    public class NewsController : Controller
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
        public NewsController(INewsManagementServices newsManagementServices, IEventManagementServices eventsManagementServices)
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

        // GET: News
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

                var newsResult = await _newsManagementServices.GetPagedNewsWithTotalAsync(pageStart * this.PageSize, this.PageSize);
                var eventsResult = await _eventsManagementServices.GetLatestEventsAsync(3);
                var viewModel = newsResult.ToViewModel();
                viewModel.PageSize = this.PageSize;
                viewModel.CurrentPage = currentPage;
                viewModel.eventsList = eventsResult.ToViewModel();
                return View(viewModel);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }

        }

        // GET: News
        public async Task<ActionResult> Details(string id)
        {

            try
            {
                Guid newsId=new Guid(id);
                var newsResult = await _newsManagementServices.GetByIdAsync(newsId);
                var eventsResult = await _eventsManagementServices.GetLatestEventsAsync(3);
                var otheNewsResult = await _newsManagementServices.GetLatestNewsAsync(4);

                var viewModel=newsResult.ToViewModel();
                viewModel.OtherNewsList = otheNewsResult.ToRelatedNewsViewModel();
                viewModel.EventsList = eventsResult.ToViewModel();

                 return View(viewModel);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        #endregion

    }
}