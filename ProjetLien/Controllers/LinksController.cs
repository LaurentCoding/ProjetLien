﻿using DTW.Repository.Links;
using Microsoft.AspNetCore.Mvc;
using ProjetLien.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ProjetLien.Controllers
{
    public class LinksController : Controller
    {
      
       private readonly ILinkRepository _linkRepository;

       public LinksController(ILinkRepository linkRepository)
       {
           _linkRepository = linkRepository;
       }

        public IActionResult Index(int perPage = 12, int nbPage = 1, string search = "")
        {
            //Je récupère la totalité de mes liens en BDD
            var allLinks = _linkRepository.GetAllLinks();
            if(string.IsNullOrWhiteSpace(search) == false)
            {
                allLinks = allLinks.Where(link =>
                link.Title.Contains(search, StringComparison.InvariantCultureIgnoreCase) ||
                link.Description.Contains(search, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
            }
          

            int nbLinkTotal = allLinks.Count();

            // Faire ma pagination
            // LINQ : Take pour prendre un certain nombre d'éléments
            // LINQ : Skip pour passer un certain nombre d'éléments
            allLinks = allLinks.Skip(perPage * (nbPage - 1))
                               .Take(perPage)
                               .ToList();

            var vm = new ListLinksViewModel()
            {
                LstLinks = allLinks,
                NbLinksTotalBdd = nbLinkTotal,
                NbPage = nbPage,
                PerPage = perPage,
                Recherche = search
            };

            return View(vm);
        }
    }
}
