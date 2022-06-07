using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace PelanggaranSantri.MasterData.Pages
{

    [PageAuthorize(typeof(SiswaRow))]
    public class SiswaController : Controller
    {
        [Route("MasterData/Siswa")]
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/Siswa/SiswaIndex.cshtml");
        }
    }
}