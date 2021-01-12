using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shop.Application.Products;
using Shop.Domain.Models;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ProductsService _productsService;

        public IndexModel(ILogger<IndexModel> logger, ProductsService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        [BindProperty]
        public ProductGetModel Product { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await _productsService.Create(Product);

            return RedirectToAction(nameof(Index));
        }
    }
}
