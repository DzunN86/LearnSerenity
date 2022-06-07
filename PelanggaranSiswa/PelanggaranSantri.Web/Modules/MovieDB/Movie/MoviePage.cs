using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace PelanggaranSantri.MovieDB.Pages
{

    [PageAuthorize(typeof(MovieRow))]
    public class MovieController : Controller
    {
        [Route("MovieDB/Movie")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/Movie/MovieIndex.cshtml");
        }
    }
}