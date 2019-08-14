using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[Controller]/[action]")]
    public class AboutController
    {   
        public string Phone()
        {
            return "45+1111+1111";
        }

        public string Address()
        {
            return "Denmark";
        }
    }
}
