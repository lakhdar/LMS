

namespace ASP.NET.MVC5.Client.Extensions
{
    using Application.DTOs;
    using ASP.NET.MVC5.Client.Models;
    using Domain.BoundedContext.BlogingModule;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class EventsExtensions
    {
        public static EventItemViewModel ToViewModel(this Event dto)
        {
            EventItemViewModel viewModel = null;
            if (dto != null)
            {
                viewModel = new EventItemViewModel()
                {
                    Id = dto.Id.ToString(),
                };
            }

            return viewModel;
        }

        public static IEnumerable<EventItemViewModel> ToViewModel(this IEnumerable<Event> dto)
        {
            IEnumerable<EventItemViewModel> viewModel = null;
            if (dto != null)
            {
                viewModel = dto.Select(x => new EventItemViewModel()
                {
                    Id = x.Id.ToString(),
                    DateStart = x.DateStart.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"),
                    DateEnd = x.DateEnd.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"),
                    Location = x.Location,
                    Title = x.Title

                });
            }

            return viewModel;
        }

        public static EventListViewModel ToEventsListViewModel(this ListWithTotalDTO dto)
        {
            EventListViewModel model = null;
            if (dto != null)
            {
                IEnumerable<EventListItemViewModel> list = new List<EventListItemViewModel>();
                if (dto.List != null)
                {
                    list = dto.List.Cast<Event>().Select(x => new EventListItemViewModel()
                    {
                        Id = x.Id.ToString(),
                        DateStart = x.DateStart.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"),
                        DateEnd = x.DateEnd.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"),
                        Location = x.Location,
                        Title = x.Title,
                        Description = x.Description
                    });
                }

                model = new EventListViewModel()
                {
                    Total = dto.Total,
                    List = list
                };
            }


            return model;

        }
    }
}
