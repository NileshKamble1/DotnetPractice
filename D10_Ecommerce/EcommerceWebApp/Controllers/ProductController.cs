using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommerceWebApp.Models;

using BOL;
using BLL;

namespace EcommerceWebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager manager=new CatalogManager();
        List<Product>allProducts=manager.GetAllProduct();
        this.ViewData["product"]=allProducts;
        return View();
    }

    public IActionResult Details(int Id)
    {
        return View();
    }

public IActionResult Insert()
    {
        return View();
    }
    public IActionResult Delete()
    {
        //return View();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
