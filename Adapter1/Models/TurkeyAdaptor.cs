using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adapter1.Models
{
    public class TurkeyAdaptor : IDuck
    {
        private ITurkey aTurkey = null;

        public TurkeyAdaptor(ITurkey anITurkey)
        {
            this.aTurkey = anITurkey;
        }

        public string quack()
        {
            return this.aTurkey.gobble();
        }
        public string fly()
        {
            return this.aTurkey.kindOfFly();
        }
    }
}