using AptitudeTestHandler.DesignPattern.Signalton;
using Models;
using System.Linq;

namespace AptitudeTestHandler
{
    public class User
    {
        UserSingelton userSingelton = null;
        public User()
        {
            userSingelton = UserSingelton.GetInstance();
        }

        public int GetUsersCount()
        {
            return userSingelton.UserList.Count();
        }

        public void Add(string userName)
        {
            userSingelton.UserList.Add(new UserModel()
            {
                UserName = userName,
                Id = new System.Guid()
            });
        }
    }
}
