﻿using Microsoft.AspNetCore.Mvc;

namespace Yummy.WebUI.ViewComponents
{
    public class _GalleryDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
