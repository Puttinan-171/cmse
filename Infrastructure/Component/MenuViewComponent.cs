using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMSECommerce.Infrastructure.Component
{
    public class MenuViewComponent(Datacontext context):ViewComponent
    {
        private readonly Datacontext _context = context;

        public async Task<IViewComponentResult> InvokeAsync()
        {
              return View(await _context.Pages.ToListAsync());
            
        } 
    }
}
