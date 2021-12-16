using Microsoft.AspNetCore.Mvc;
using MusicSorter.Models;
using System.Collections.Generic;
using System;

namespace MusicSorter.Controllers
{
    public class AlbumController : Controller
    {

      [HttpGet("/album")]
      public ActionResult Index()
      {
        List<Album> outputList = Album.albumList;
        return View(outputList);
      }

      [HttpGet("/album/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpPost("/album")]
      public ActionResult Create(string albumName,string artist, string linerNotes)
      {
        Album newAlbum = new Album(albumName, artist, linerNotes);
        return RedirectToAction("Index");        
      }
      [HttpGet ("/album/{id}")]
      public ActionResult Show(int id)
      {
        Album target = Album.findId(id);
        return View(target);
      }
      [HttpPost ("/album/{id}")]
      public ActionResult NewSong(int id, string title, string runtime)
      {
        Album.albumList[id].AddSong(title, runtime);
        return View("Show",Album.findId(id));
      }
    }
} 