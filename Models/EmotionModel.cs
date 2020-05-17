using System;
using SentimentAnalyzer;
using System.Collections.Generic;

namespace _750Words.Models
{
    public class Emotion{
        public int Id {get;set;}
        public string Name {get;set;}

        public List<Entry> Entries {get;set;}
    }

}