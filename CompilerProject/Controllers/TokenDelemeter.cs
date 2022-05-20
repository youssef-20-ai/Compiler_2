using Microsoft.AspNetCore.Mvc;

namespace CompilerProject.Controllers
{
    public class TokenDelemeter : Controller
    {
        List<char> TD = new List<char> {' ' ,'\r' ,'\n' ,'\t'};
    }
}
