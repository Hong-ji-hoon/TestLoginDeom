using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    public class Control
    {
        public bool ID(string id)
        {
            if(id == "rorze") return true;
            else return false;
        }

        public bool PW(string pw)
        {
            if(pw == "123") return true;
            else return false;
        }
    }
}
