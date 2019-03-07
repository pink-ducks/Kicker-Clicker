using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App
{
    class Controller
    {
        private User _user = new User();

        public User User { get => _user; set => _user = value; }
    }
}
