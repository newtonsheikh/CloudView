using Microsoft.AspNetCore.Mvc;

namespace Newton.CloudView.WebUI.Controllers
{
    /// <summary>
    /// This is the base Controller. IF YOU DONT UNDERSTAND anything here, NEVER MIND, NEITHER DO I UNDSERTAND!! 
    /// </summary>
    public class CloudViewController : Controller
    {
        public CloudViewController()
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {

            }

            base.Dispose(disposing);
        }
    }
}