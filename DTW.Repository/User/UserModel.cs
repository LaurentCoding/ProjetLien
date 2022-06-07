using System;
using System.Collections.Generic;
using System.Text;

namespace DTW.Repository.User
{
    public class UserModel
    {
        public UserModel(int idUser, string userForename, string userSurname, string userEmail)
        {
            IdUser = idUser;
            UserForeName = UserForeName;
            UserSurName = UserSurName;
            UserEmail = UserEmail;
        }
        public int IdUser { get; }
        public int UserForeName { get; }
        public int UserSurName { get; }
       
        public int UserEmail { get; }

    }
}
    