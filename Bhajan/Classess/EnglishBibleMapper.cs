//using Bhajan.Models;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bhajan.Classess
//{
//    internal class EnglishBibleMapper
//    {
//        internal static int ForNext_ActiveBook_Pos = -1;
//        internal static int ForNext_ActiveChapter_Pos = -1;
//        internal static int ForNext_ActiveVerse_Pos = -1;
//        internal static int ForPrev_ActiveBook_Pos = -1;
//        internal static int ForPrev_ActiveChapter_Pos = -1;
//        internal static int ForPrev_ActiveVerse_Pos = -1;
//        //the position of the first verse being displayed on the screen
//        internal static Bible_W_AllChapters EnglishBible = new Bible_W_AllChapters();
//        internal static List<string> Books = new List<string>() { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel", "1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalm", "Proverbs", "Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter", "2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation" };
//        public static void MapEnglishBible()
//        {
//            var json = File.ReadAllText("C:\\Users\\AnjanS\\source\\repos\\Bhajan\\Bhajan\\BibleJsons\\EnglishBibleNIV_NPFormat.json");
//            EnglishBible = JsonConvert.DeserializeObject<Bible_W_AllChapters>(json);
//        }

//        internal static string GiveMeNextVerses(int howmany)
//        {
//            int temp_ActiveBook_Pos = ForNext_ActiveBook_Pos;
//            int temp_ActiveChapter_Pos = ForNext_ActiveChapter_Pos;
//            int temp_ActiveVerse_Pos = ForNext_ActiveVerse_Pos;
//            ForPrev_ActiveBook_Pos = temp_ActiveBook_Pos;
//            ForPrev_ActiveChapter_Pos = temp_ActiveChapter_Pos;
//            ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos - 1;
//            List<string> VersesIncluded = new List<string>();
//            if (temp_ActiveVerse_Pos < EnglishBibleMapper.EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count())
//            {
//                VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], ConvertNumberToNepali(temp_ActiveChapter_Pos + 1)));
//            }
//            for (int i = 0; i < howmany; i++)
//            {
//                bool IsVerseValid = temp_ActiveVerse_Pos < EnglishBibleMapper.EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count();
//                bool IsChapterValid = temp_ActiveChapter_Pos + 1 < EnglishBibleMapper.EnglishBible.Book[temp_ActiveBook_Pos].Chapter.Count();
//                bool IsBookValid = temp_ActiveBook_Pos + 1 < EnglishBibleMapper.EnglishBible.Book.Count();


//                if (IsVerseValid)
//                {
//                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;
//                    VersesIncluded.Add(ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) + ". " + AddSpaceAfterWords((EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
//                    temp_ActiveVerse_Pos++;
//                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;
//                }
//                else if (IsChapterValid && !IsVerseValid)
//                {
//                    temp_ActiveVerse_Pos = 0;
//                    temp_ActiveChapter_Pos++;
//                    if (i < howmany)
//                    {
//                        VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], ConvertNumberToNepali(temp_ActiveChapter_Pos + 1)));
//                    }
//                    VersesIncluded.Add(ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) + ". " + AddSpaceAfterWords((EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
//                    temp_ActiveVerse_Pos++;
//                    ForNext_ActiveChapter_Pos = temp_ActiveChapter_Pos;
//                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;

//                }
//                else if (IsBookValid && !IsChapterValid && !IsVerseValid)
//                {
//                    temp_ActiveVerse_Pos = 0;
//                    temp_ActiveChapter_Pos = 0;
//                    temp_ActiveBook_Pos++;
//                    if (i < howmany)
//                    {
//                        ForNext_ActiveChapter_Pos = 0;
//                        VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], ConvertNumberToNepali(temp_ActiveChapter_Pos + 1)));
//                    }
//                    VersesIncluded.Add(ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) + ". " + AddSpaceAfterWords((EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
//                    temp_ActiveVerse_Pos++;
//                    ForNext_ActiveBook_Pos = temp_ActiveBook_Pos;
//                    ForNext_ActiveChapter_Pos = temp_ActiveChapter_Pos;
//                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;
//                }
//            }
//            return string.Join(System.Environment.NewLine, VersesIncluded.ToArray());
//        }

//        internal static string GiveMePreviousVerses(int howmany)
//        {
//            int temp_ActiveBook_Pos = ForPrev_ActiveBook_Pos;
//            int temp_ActiveChapter_Pos = ForPrev_ActiveChapter_Pos;
//            int temp_ActiveVerse_Pos = ForPrev_ActiveVerse_Pos;
//            ForNext_ActiveBook_Pos = temp_ActiveBook_Pos;
//            ForNext_ActiveChapter_Pos = temp_ActiveChapter_Pos;
//            ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos + 1;
//            string initial_chapter_book = "";
//            List<string> VersesIncluded = new List<string>();
//            if (temp_ActiveVerse_Pos >= 0 && temp_ActiveVerse_Pos < EnglishBibleMapper.EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count())
//            {
//                initial_chapter_book = "📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], ConvertNumberToNepali(temp_ActiveChapter_Pos + 1));
//            }

//            for (int i = 0; i < howmany; i++)
//            {
//                bool IsVerseValid = temp_ActiveVerse_Pos >= 0;
//                bool IsChapterValid = temp_ActiveChapter_Pos - 1 >= 0;
//                bool IsBookValid = temp_ActiveBook_Pos - 1 >= 0;

//                if (IsVerseValid)
//                {
//                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;
//                    VersesIncluded.Add(ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) + ". " + AddSpaceAfterWords((EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
//                    temp_ActiveVerse_Pos--;
//                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;
//                }
//                else if (IsChapterValid && !IsVerseValid)
//                {
//                    VersesIncluded.Add(initial_chapter_book);
//                    temp_ActiveChapter_Pos--;
//                    temp_ActiveVerse_Pos = EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count() - 1;
//                    VersesIncluded.Add(ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) + ". " + AddSpaceAfterWords((EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
//                    temp_ActiveVerse_Pos--;
//                    ForPrev_ActiveChapter_Pos = temp_ActiveChapter_Pos;
//                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;

//                }
//                else if (IsBookValid && !IsChapterValid && !IsVerseValid)
//                {
//                    VersesIncluded.Add(initial_chapter_book);
//                    temp_ActiveBook_Pos--;
//                    temp_ActiveVerse_Pos = EnglishBible.Book[temp_ActiveBook_Pos].Chapter.Count() - 1;
//                    temp_ActiveChapter_Pos = EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count() - 1;
//                    VersesIncluded.Add(ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) + ". " + AddSpaceAfterWords((EnglishBible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
//                    temp_ActiveVerse_Pos--;
//                    ForPrev_ActiveBook_Pos = temp_ActiveBook_Pos;
//                    ForPrev_ActiveChapter_Pos = temp_ActiveChapter_Pos;
//                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;
//                }
//            }
//            VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], ConvertNumberToNepali(temp_ActiveChapter_Pos + 1)));
//            VersesIncluded.Reverse();
//            return string.Join(System.Environment.NewLine, VersesIncluded.ToArray());
//        }

//        internal static string ConvertNumberToNepali(int num)
//        {
//            List<string> NepaliNumbersList = new List<string>() { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९" };
//            string number = num.ToString();
//            string final_num = "";
//            foreach (char n in number)
//            {
//                string nn = n.ToString();
//                int aa = Convert.ToInt32(nn);
//                final_num += NepaliNumbersList[aa];
//            }
//            return final_num;
//        }

//        internal static string AddSpaceAfterWords(string text, int howmany)
//        {
//            var words = text.Split(' ').ToList();
//            if (words.Count() > howmany)
//            {
//                for (int i = 1; i <= words.Count / howmany; i++)
//                {
//                    int _pos = i * howmany;
//                    if (_pos < words.Count)
//                    {
//                        words[(_pos - 1)] = words[(_pos - 1)] + System.Environment.NewLine;
//                    }
//                }
//            }
//            text = String.Join(" ", words.ToArray());
//            return text;
//        }

//        //internal static Bible_W_AllChapters convertEngBibleToNepFormat(NepRawBible tempbible)
//        //{
//        //    //List<Book> books = new List<Book>();

//        //    //List<Chapter> chapters = new List<Chapter>();
//        //    //List<_Verse> Verses = new List<_Verse>();

//        //    //int i = 0;
//        //    //int current_chapter = 1;
//        //    //int current_book = 1;
//        //    //foreach (var verse in tempbible.Verses)
//        //    //{
//        //    //    if (current_book != verse.Book)
//        //    //    {
//        //    //        Chapter chapter = new Chapter();
//        //    //        chapter.Verse.AddRange(Verses);
//        //    //        chapters.Add(chapter);
//        //    //        Book book = new Book();
//        //    //        book.Chapter.AddRange(chapters);
//        //    //        books.Add(book);
//        //    //        Verses.Clear();
//        //    //        chapters.Clear();
//        //    //    }
//        //    //    else if (current_chapter != verse.Chapter)
//        //    //    {
//        //    //        Chapter chapter = new Chapter();
//        //    //        chapter.Verse.AddRange(Verses);
//        //    //        chapters.Add(chapter);
//        //    //        Verses.Clear();
//        //    //    }
//        //    //    _Verse nep_style_verse = new _Verse();
//        //    //    nep_style_verse.Verseid = (Verses.Count() + 1).ToString();
//        //    //    nep_style_verse.Verse = verse.Scripture;
//        //    //    Verses.Add(nep_style_verse);
//        //    //    current_chapter = verse.Chapter;
//        //    //    current_book = verse.Book;
//        //    //}

//        //    //Chapter _chapter = new Chapter();
//        //    //_chapter.Verse.AddRange(Verses);
//        //    //chapters.Add(_chapter);
//        //    //Book _book = new Book();
//        //    //_book.Chapter.AddRange(chapters);
//        //    //books.Add(_book);
//        //    //Verses.Clear();
//        //    //chapters.Clear();
//        //    //Bible_W_AllChapters newb = new Bible_W_AllChapters();
//        //    //newb.Book.AddRange(books);
//        //    //return newb;
//        //}

//        public static NepRawBible NBS = new NepRawBible();
//        public static string NewNepaliVerseFormOtherBible(int book, int chapter, int verse)
//        {
//            //if(NBS.Verses.Count == 0) { 
//            //    string j = File.ReadAllText("C:\\Users\\AnjanS\\Desktop\\Bhajan images\\Bible\\NNRVBible.json");
//            //    NBS.Verses = JsonConvert.DeserializeObject<List<NepRawVerse>>(j);
//            //}
//            //var x = convertEngBibleToNepFormat(NBS);
//            //File.WriteAllText("C:\\Users\\AnjanS\\Desktop\\Bhajan images\\Bible\\NewheramKastoAAYO.json", JsonConvert.SerializeObject(x));
//            //var engformat = from v in NBS.Verses select new v;
//            //book += 1;
//            //chapter += 1;
//            //verse += 1;
//            //int current_chapter = chapter;
//            //int current_book = book;
//            //var text  = (from v in NBS.Verses
//            //                    where v.Book == current_book && v.Chapter == current_chapter && v.Verse == verse
//            //                    select v.Scripture).FirstOrDefault();
//            return "";
//        }

//    }
//}