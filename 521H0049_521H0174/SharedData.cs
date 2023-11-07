using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _521H0049_521H0174
{
    public class SharedData
    {
        private static SharedData instance;

        public string username { get; set; }

        private SharedData()
        {

        }

        public static SharedData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SharedData();
                }
                return instance;
            }
        }
    }
}
