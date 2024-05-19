using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HelloController
    {
        [HttpGet]
        [Route("/Say")] // The endpoint here is reached by calling `/Say` route
        public String SayHello()
        {
            return "Hello !";
        }
        [HttpGet]
        [Route("/Yell")] // The endpoint here is reached by calling `/Yell` route
        public String YellHello()
        {
            return "HELLO !";
        }
    }
    
}
