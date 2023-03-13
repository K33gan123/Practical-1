using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace keeganStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<Models.StudyGroup> members=new List<Models.StudyGroup>();
            members.Add(new Models.StudyGroup { StudentNumber = "22693760", name="Keegan",surname="Walker",emailAddress="u22693760@tuks.co.za"});
            members.Add(new Models.StudyGroup { StudentNumber = "22693761", name = "Owethu", surname = "Mtshali", emailAddress = "u22693761@tuks.co.za" });
            members.Add(new Models.StudyGroup { StudentNumber = "22693762", name = "Vlada", surname = "Yun", emailAddress = "u22693762@tuks.co.za" });
             members.Add(new Models.StudyGroup { StudentNumber = "22693763", name = "Liam", surname = "Garrett", emailAddress = "u22693763@tuks.co.za" });
            members.Add(new Models.StudyGroup { StudentNumber = "22693764", name = "Josh", surname = "Coetzee", emailAddress = "u22693764@tuks.co.za" });
            return View(members);
        }
    }
}