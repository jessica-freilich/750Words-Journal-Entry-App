using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _750Words.Models
{
    public class Entry
    {
    
        public int Id {get;set;}
        public string Text {get;set;}
        public int WordCount {get;set;}
        public Emotion Emotion { get; set; }
        
        [ForeignKey("Emotion")]
        // public Emotion Emotion {get;set;}
        public int EmotionId { get; set; }
        
        // Potentially you could use an API that analyzes some input - who knows how... 
        // public Sentiment Sentiment {get;set;}
    }
}