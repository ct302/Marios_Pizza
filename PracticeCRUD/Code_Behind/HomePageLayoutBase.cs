using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using PracticeCRUD.Data;

namespace PracticeCRUD.Code_Behind
{
    public class HomePageLayoutBase : LayoutComponentBase
    {

        [Inject]
        public AppDbIdentityContext db { get; set; }
        public HomePageLayoutBase(AppDbIdentityContext _db)
        {
            db = _db;

        }

        public string email;

        public string UserID;

        protected override void OnInitialized()
        {

            UserID = db.Users.Where(p => p.NormalizedEmail == email).FirstOrDefault().Id;

        }



    }
}
