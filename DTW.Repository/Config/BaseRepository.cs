using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using static DTW.Repository.Config.IBaseRepository;

namespace DTW.Repository.Config
{
    //Cette class va contenir les fonctions de connection à la BDD
    //On va pouvoir hériter de cette class
    public class BaseRepository : IBaseRepository.IBaseRepository
    {
        //J'ai besoin de ma chaine de connection
        public string ConectionString { get; set; }
        public BaseRepository(IConfiguration configuration)
		{
            ConectionString = configuration.GetConnectionString("DefaultConnection");
		}


        public MySqlConnection OpenConnexion()
		{
            //Je peux avoir ma chaine de connesion
            //ConectionString = "server=mysql-devtechwatch.alwaysdata.net;database=devtechwatch_dtw;uid=267041;pwd=NYV8e@6u4$j4Wc7Eh;"
            
            try
			{
                MySqlConnection cnn = new MySqlConnection(ConectionString);
                cnn.Open();
                return cnn;
            }
            catch(Exception ex)
			{
                throw new Exception("Impossible de se connecter à la base de données");
			}
        }
    }
}
