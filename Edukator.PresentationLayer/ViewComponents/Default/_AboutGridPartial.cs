using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _AboutGridPartial: ViewComponent
    {
        private readonly IAboutGridService _aboutGridService;

        public _AboutGridPartial(IAboutGridService aboutGridServices)
        {
            _aboutGridService = aboutGridServices;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutGridService.TGetList();
            return View();
        }
        
    }
}
