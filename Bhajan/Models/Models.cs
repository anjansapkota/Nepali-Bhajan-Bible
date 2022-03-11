using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bhajan.Models
{
    public class Models
    {
    }

    public class Hym
    {
        public int Number { get; set; }
        public string Type { get; set; } //"Running" "W_Chorus"
        public int GroupNumber { get; set; }
        public string Title { get; set; } = "";
        public string TitleRomanized { get; set; } = "";
        public string Description { get; set; } = "";
        public string Writer { get; set; } = "";
        public string Composer { get; set; } = "";
        public int TotalNumOfSlides { get; set; }
        public List<Stanza> stanzas { get; set; } = new List<Stanza>();
    }

    public class Stanza
    {
        public int StanzaNumber { get; set; }
        public string StanzaText { get; set; } = "";
        public string StanzaTextRomanized { get; set; } = "";
        public List<int> SlideNumbers { get; set; } = new List<int>();
        public bool IsChorus { get; set; }
        public bool IsExtendedToPrevoius { get; set; } = false;
    }


    public class RippedHym
    {
        public string Title { get; set; }
        public string raw_number { get; set; }
        public int position { get; set; }
        public string Lyrics { get; set; }
    }
    
    public class RippedHymSDA
    {
        public int number { get; set; }
        public string title { get; set; }
        public string verse1 { get; set; }
        public string refrain { get; set; }
        public string refrain2 { get; set; }
        public string verse2 { get; set; }
        public string verse3 { get; set; }
        public string verse4 { get; set; }
        public string verse5 { get; set; }
        public string verse6 { get; set; }
        public string verse7 { get; set; }
        public int section { get; set; }
        public int subsection { get; set; }
    }

    public class RippedHymSDACAT
    {
        public int section { get; set; }
        public string name { get; set; }
    }

    public class _Verse
    {
        public string Verseid { get; set; }
        public string Verse { get; set; }
    }

    public class Chapter
    {
        public List<_Verse> Verse { get; set; } = new List<_Verse>();
    }

    public class Book
    {
        public List<Chapter> Chapter { get; set; } = new List<Chapter>();
    }

    public class Bible_W_AllChapters
    {
        public List<Book> Book { get; set; } = new List<Book>();    
    }

    public class EnglishBible
    {
        public List<EnglishVerse> Verses { get; set; } = new List<EnglishVerse>();
    }
    public class EnglishVerse
    {
        public string Book { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }
    }

    public class NepRawBible
    {
        public List<NepRawVerse> Verses { get; set; } = new List<NepRawVerse>();
    }
    public class NepRawVerse
    {
        public int Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Scripture { get; set; }
    }
}
