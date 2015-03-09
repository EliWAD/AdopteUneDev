using AdopteUneDev.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdopteUneDev.Models
{
    public class HomeModel
    {
        public List<Categories> lstCategs
        {
            get;
            set;
        }

        public List<ITLang> lstLangs
        {
            get;
            set;
        }

        public List<Developer> lstDevs
        {
            get;
            set;
        }
    }
}