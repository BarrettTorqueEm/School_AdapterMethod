using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adapter1.Models
{
    public class Duck: IDuck
    {
        public string quack()
        {
            return "Quack Quack Quack";
        }
        public string fly()
        {
            return "The duck is flying";
        }
    }
}