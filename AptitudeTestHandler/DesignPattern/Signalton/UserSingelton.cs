using Models;
using System.Collections.Generic;

namespace AptitudeTestHandler.DesignPattern.Signalton
{
    public sealed class UserSingelton
    {
        IList<UserModel> userList = null;
        static bool isInitialized = false;
        private UserSingelton()
        {
        }

        private static UserSingelton _instance;

        public static UserSingelton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserSingelton();
            }
            return _instance;
        }

        public IList<UserModel> UserList
        {
            get
            {
                if (isInitialized == false)
                {
                    userList = new List<UserModel>();
                    isInitialized = true;
                }
                return userList;
            }
        }
    }
}
