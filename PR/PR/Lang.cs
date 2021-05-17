using DevExpress.DataProcessing;
using PR.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PR
{
    public class Lang
    {
        private string _lang ;
            public void SetLang(string lang)
            {
            _lang = lang;
            }
        public string GetLang()
        {
            return _lang;
        }
    }
}