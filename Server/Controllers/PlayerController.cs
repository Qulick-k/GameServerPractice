using Microsoft.AspNetCore.Mvc;
using Server.Services;
using SharedLibrary;            //在Server項目中引用SharedLibrary

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private readonly IPlayerServices _playerServices;

    public PlayerController(IPlayerServices playerServices)
    {
        _playerServices = playerServices;
    }

    [HttpGet("{id}")]
    public Player Get([FromRoute] int id)
    {
        var player = new Player() { Id = id};

        _playerServices.DoSomething();

        return player;
    }

    [HttpPost]
    public Player Post(Player player)
    {
        Console.WriteLine("Player has been added to the DB");
        return player;
    }
}
