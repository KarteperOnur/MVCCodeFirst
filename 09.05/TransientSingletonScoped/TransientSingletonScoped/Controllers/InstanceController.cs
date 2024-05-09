using Microsoft.AspNetCore.Mvc;
using TransientSingletonScoped.Repositories;

namespace TransientSingletonScoped.Controllers
{
    public class InstanceController : Controller
    {
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;
        private readonly IScopeService _scopeService1;
        private readonly IScopeService _scopeService2;
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        public InstanceController(ISingletonService singletonService1, ISingletonService singletonService2,IScopeService scopeService1,IScopeService scopeService2,ITransientService transientService1,ITransientService transientService2)
        {
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopeService1 = scopeService1;
            _scopeService2 = scopeService2;
            _transientService1 = transientService1;
            _transientService2 = transientService2;
        }


        public IActionResult Index()
        {
            ViewBag.Singleton1 = _singletonService1.GetOperation();
            ViewBag.Singleton2 = _singletonService2.GetOperation();

            ViewBag.Scope1= _scopeService1.GetOperation();
            ViewBag.Scope2= _scopeService2.GetOperation();

            ViewBag.Transient1=_transientService1.GetOperation();
            ViewBag.Transient2= _transientService2.GetOperation();


            return View();
        }
    }
}
