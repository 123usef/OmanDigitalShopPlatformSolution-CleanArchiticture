using System.Diagnostics;
using BLL.OmanDigitalShop.Repositories;
using DAL.OmanDigitalShop.Models.Products;
using Microsoft.AspNetCore.Mvc;
using PLL.MVC.OmanDigitalShop.Models;

namespace PLL.MVC.OmanDigitalShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly GenericRepository<Product> _productRepository;
    private readonly GenericRepository<Category> _categoryRepository;

    public HomeController(GenericRepository<Product> productRepository , GenericRepository<Category> CategoryRepository)
    {
        
        _productRepository = productRepository;
        _categoryRepository = CategoryRepository;
    }

    public IActionResult Index()
    {
        return View(_productRepository.GetAllAsync());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
