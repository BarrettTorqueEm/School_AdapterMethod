using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adapter1.Models
{
    public class Turkey: ITurkey
    {
        public string gobble()
        {
            return "gobble gobble gobble";
        }
        public string kindOfFly()
        {
            return "The Turkey is kinda flying";
        }
    }
}