using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _521H0049_521H0174
{
    public class SharedData
    {
        private static SharedData _instance;

        public static SharedData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SharedData();
                }
                return _instance;
            }
        }

        public string Username { get; private set; }
        public string Role { get; private set; }
        public int Id { get; private set; }

        private SharedData()
        {

        }

        public void SetUser(int id, string username, string role)
        {
            Id = id;
            Username = username;
            Role = role;
        }

        public void ClearUser()
        {
            Id = 0;
            Username = null;
            Role = null;
        }
    }
}
