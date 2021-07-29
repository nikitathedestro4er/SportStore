using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}