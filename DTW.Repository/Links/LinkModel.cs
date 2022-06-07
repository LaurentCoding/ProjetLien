using DTW.Repository.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTW.Repository.Links
{
    public class LinkModel
    {
       

        public LinkModel()
        {

        }

        public LinkModel(int idLink, string title, string description, string url, UserModel auteur)
        {
            IdLink = idLink;
            Title = title;
            Description = description;
            URL = url;
            Auteur = auteur;
        }

        public int IdLink { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }

        public UserModel Auteur { get; set; }
       

        //TODO : auteur -> Ajouter en objet... a voir plus tard

    }
}
