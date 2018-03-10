using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemBolagetJson.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SystemBolagetJson.Controllers
{
    [ResponseCache(Duration = Program.CacheDuration)]
    public abstract class BaseController : Controller
    {

    }
}