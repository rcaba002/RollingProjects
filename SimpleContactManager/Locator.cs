using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleContactManager
{
    public class Locator
    {
        public static MainViewModel Main
        {
            get
            {
                return new MainViewModel();
            }
        }
    }
}
