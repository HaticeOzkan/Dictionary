using BLL;
using Entity;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiService.Controllers
{
    public class TranslateController : ApiController
    {
        //Bizim sozluğumuzden faydalansıznlar diye
        //
        UnitOfWork _uw = new UnitOfWork();
        public List<string> Get(int FromLangID,int ToLangID,string word)//id bilgisini vermemiz lazım
        {
            //webservice sozlukapi ikiside entityden referans alıyor bu çakışma yapabilir
            HomeViewModel hvm = new HomeViewModel();
            hvm.FromLang = FromLangID;
            hvm.ToLang = ToLangID;
            hvm.FromWord = word;
            var sonuc = _uw.TranslateManager.Translate(hvm);
            return sonuc;
        }
    }
}
