using System.Diagnostics;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers;

public class HomeController : Controller
{
    private readonly ISliderService _sliderService;
    private readonly IBlogService _blogService;
    private readonly IExpertService _expertService;

    public HomeController(ISliderService sliderService,
        IBlogService blogService,
        IExpertService expertService)
    {
        _sliderService = sliderService;
        _blogService = blogService;
        _expertService = expertService;
        
    }

    public async Task<IActionResult> Index()
    {
        HomeVM model = new()
        {
            Sliders = await _sliderService.GetAllAsync(),
            SliderInfo = await _sliderService.GetSliderInfoAsync(),
            Blogs = await _blogService.GetAllAsync(),
            Experts=await _expertService.GetAllAsync(),
        };

        return View(model);
    }
}

