using DTW.Repository.Links;
using Microsoft.AspNetCore.Mvc;
using ProjetLien.Models;
using System.Collections.Generic;

namespace ProjetLien.Controllers
{
    public class LinksController : Controller
    {
        public IActionResult Index()
        {
            //TODO : Récupérer le model depuis le Repository...
            var vm = new ListLinksViewModel()
            {
                LstLinks = new List<LinkModel>()
                {
                    new LinkModel()
                    {
                        IdLink = 1,
                        Title = "test1",
                        URL = "https://google.com",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galle"
                    },
                     new LinkModel()
                    {
                        IdLink = 2,
                        Title = "test2",
                        URL = "https://google.com",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galle"
                    },
                      new LinkModel()
                    {
                        IdLink = 3,
                        Title = "test3",
                        URL = "https://google.com",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galle"
                    },
                       new LinkModel()
                    {
                        IdLink = 4,
                        Title = "test4",
                        URL = "https://google.com",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galle"
                    },
                }
            };
            return View(vm);
        }
    }
}
