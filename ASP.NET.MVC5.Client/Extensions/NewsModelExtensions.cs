
namespace ASP.NET.MVC5.Client.Extensions
{
    using Application.DTOs;
    using ASP.NET.MVC5.Client.Models;
    using Domain.BoundedContext.BlogingModule;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class NewsModelExtensions
    {

        public static NewsDetailViewModel ToViewModel(this News dto)
        {
            NewsDetailViewModel viewModel = null;
            if (dto != null)
            {
                viewModel = new NewsDetailViewModel()
                {
                    Id = dto.Id.ToString(),
                    Tilte = dto.Title,
                    PublishDate=dto.CreationDate.ToString("dd MMM yyyy"),
                    Text=dto.Body
                   
                } ;
            }

            return viewModel;
        }


        public static NewsListViewModels ToViewModel(this ListWithTotalDTO dto)
        {
            NewsListViewModels model = null;
            if (dto != null)
            {
                IEnumerable<NewsItemViewModels> list = new List<NewsItemViewModels>();
                if (dto.List != null)
                {
                    list = dto.List.Cast<News>().Select(x => new NewsItemViewModels()
                    {
                        Id = x.Id.ToString(),
                        Img = x.ImagePath,
                        Tilte = x.Title,
                        Text = x.Summary
                    });
                }

                model = new NewsListViewModels()
                {
                    Total = dto.Total,
                    List = list
                };
            }


            return model;

        }


        public static IEnumerable<RelatedNewsViewModel> ToRelatedNewsViewModel(this IEnumerable<News> dto) 
        {
            IEnumerable<RelatedNewsViewModel> viewModel = null;
            if (dto != null)
            {
                viewModel =dto.Select(x=> new RelatedNewsViewModel()
                {
                    Id = x.Id.ToString(),
                    Tilte = x.Title,
                    Img = x.ImagePath
                });
            }

            return viewModel;
        }
    }
}