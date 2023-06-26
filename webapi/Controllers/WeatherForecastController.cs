using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuItemsController : ControllerBase
{
    private readonly ILogger<MenuItemsController> _logger;

    public MenuItemsController(ILogger<MenuItemsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "main-menu-items")]
    public IEnumerable<MainMenuItem> GetMainMenuItems()
    {
        _logger.LogTrace("Получил запрос на список элементов главного меню.");
        return MainMenuItem.DefaultList();
    }
}
