using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Modul10_103022400069.Models;

namespace Modul10_103022400069.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> game = new List<Game>
        {
           new Game { Id = 1,Name = "Valorant",Developer = "Riot Games",TahunRilis = 2020,Genre = "FPS",Rating = 8.5,Platform = new string[] { "Pc" },Mode = new string[] { "Multiplayer" },IsOnline = true,Harga = 0},
           new Game { Id = 2, Name = "GTA V", Developer = "Rockstar Games", TahunRilis = 2013, Genre = "Open World", Rating = 9.5, Platform = new string[] { "PC", "PS4", "PS5", "Xbox" }, Mode = new string[] { "SinglePlayer","Multiplayer" }, IsOnline = true, Harga = 300000 },
           new Game { Id = 3, Name = "The Withcer 3", Developer = "CD Projekt Red", TahunRilis = 2015, Genre = "RPG", Rating = 9.7, Platform = new string[] { "PC", "PS4", "PS5", "Xbox" ,"Switch" }, Mode = new string[] { "SinglePlayer" }, IsOnline = false, Harga = 250000 }
        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(game);
        }
        [HttpPost]
        public IActionResult Post(Game newGame)
        {
            game.Add(newGame);
            return Ok(newGame);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var findGame = game.Find(g => g.Id == id);
            if (findGame == null)
            {
                return NotFound();
            }
            return Ok(findGame);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Game updatedGame)
        {
            var findGame = game.Find(g => g.Id == id);
            if (findGame == null)
            {
                return NotFound();
            }
            findGame.Name = updatedGame.Name;
            findGame.Developer = updatedGame.Developer;
            findGame.TahunRilis = updatedGame.TahunRilis;
            findGame.Genre = updatedGame.Genre;
            findGame.Rating = updatedGame.Rating;
            findGame.Platform = updatedGame.Platform;
            findGame.Mode = updatedGame.Mode;
            findGame.IsOnline = updatedGame.IsOnline;
            findGame.Harga = updatedGame.Harga;
            return Ok(findGame);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            game.RemoveAt(id);
            return Ok();
        }
    }
}
