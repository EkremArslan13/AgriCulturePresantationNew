using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresantationNew.ViewComponents
{
    public class _GalleryPartial: ViewComponent
    {

        private readonly IImageService _ımageService;

        public _GalleryPartial(IImageService ımageService)
        {
            _ımageService = ımageService;
        }

        public IViewComponentResult Invoke()
        {

            var values = _ımageService.GetListAll();
            return View(values);
        }
       
    }
}
