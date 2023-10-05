using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Mitch Tabaloc", StudentId = "2121", StudentAge = "20" },
            new StudentInfoModel { Name = "Michelle Tabaloc", StudentId = "2103", StudentAge = "22" },
            new StudentInfoModel { Name = "Raiden Tabaloc", StudentId = "2092", StudentAge = "21" }
        };

        return View(studentInfoArray);
    }
}
