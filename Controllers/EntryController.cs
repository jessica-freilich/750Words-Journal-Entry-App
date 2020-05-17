using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _750Words.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _750Words.Controllers
{
    public class EntryController : Controller
    {
        private Db db; // _context

        public EntryController(Db globalDb) // DerpDb context
        {
            db = globalDb;
            // _context = contex;
        }

        // Page that shows all entries + a graph
        public IActionResult Show()
        {
            return View(db.Entries.Include(entry => entry.Emotion).ToList());
        }

        // Add an entry
        public IActionResult Add()
        {
            return View(db.Emotions.ToList());
        }
        
        // Wordcount

        public static int CountWords(string s){ 
            MatchCollection collection = Regex.Matches(s, @"[\S]+"); return collection.Count; 
            }
        // Save to Db from Add page

        public IActionResult Save( [Bind("Id,Text,EmotionId,WordCount")] Entry newEntry) 
        {
            //CREATE WORD COUNT
            
            // Entry newEntry = new Entry();
            newEntry.WordCount = CountWords(newEntry.Text); // this is going to change to use a function

            db.Entries.Add(newEntry);
            db.SaveChanges(); // saves all of the database stuff
            return Redirect("/Entry/Show");
        }
    }
}