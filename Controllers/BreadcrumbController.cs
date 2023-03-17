using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TAC.Business;

namespace TAC.Controllers
{
    public class BreadcrumbController : Controller
    {
        private readonly BreadcrumbBuilder _builder;
        public BreadcrumbController() : this(new BreadcrumbBuilder()) { }
        public BreadcrumbController(BreadcrumbBuilder builder)
        {
            _builder = builder;
        }
        public ActionResult Index()
        {
            return View(_builder.Build());
        }
    }
}