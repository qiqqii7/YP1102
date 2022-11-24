using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Instances
    {
        private static up_11_02Entities2 _db = null;
        public static up_11_02Entities2 db
        {
            get
            {
                if (_db == null)
                    _db = new up_11_02Entities2();
                return _db;
            }
        }
    }
}
