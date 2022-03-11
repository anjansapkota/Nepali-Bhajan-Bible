using Bhajan.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Bhajan.Classess
{
    internal class BibleMapper
    {
        internal static int ForNext_ActiveBook_Pos = -1;
        internal static int ForNext_ActiveChapter_Pos = -1;
        internal static int ForNext_ActiveVerse_Pos = -1;
        internal static int ForPrev_ActiveBook_Pos = -1;
        internal static int ForPrev_ActiveChapter_Pos = -1;
        internal static int ForPrev_ActiveVerse_Pos = -1;
        //the position of the first verse being displayed on the screen
        internal static Bible_W_AllChapters NepaliBible = new Bible_W_AllChapters();
        internal static Bible_W_AllChapters EnglishBible = new Bible_W_AllChapters();
        internal static string DBFolder = "";

        public static List<string> BooksNepali = new List<string>() { "उत्पत्ति", "प्रस्थान ", "लेवी", "गन्ती", "व्यवस्था", "यहोशू", "न्यायकर्ता", "रूथ",
            "1 शमूएल", "2 शमूएल", "1 राजा", "2 राजा", "1 इतिहास", "2 इतिहास", "एज्रा",
            "नहेम्याह", "एस्तर", "अय्यूब", "भजनसंग्रह", "हितोपदेश", "उपदेशक", "श्रेष्ठगीत",
            "यशैया", "यर्मिया", "विलाप", "इजकिएल", "दानियल", "होशे", "योएल", "आमोस",
            "ओबदिया", "योना", "मीका", "नहूम", "हबकूक", "सपन्याह", "हाग्गै", "जकरिया",
            "मलाकी", "मत्ती", "मर्कूस", "लूका", "यूहन्ना", "प्रेरित", "रोमी", "1 कोरिन्थी",
            "2 कोरिन्थी", "गलाती", "एफिसी", "फिलिप्पी", "कलस्सी", "1 थिस्सलोनिकी",
            "2 थिस्सलोनिकी", "1 तिमोथी", "2 तिमोथी", "तीतस", "फिलेमोन", "हिब्रू", "याकूब",
            "1 पत्रुस", "2 पत्रुस", "1 यूहन्ना", "2 यूहन्ना", "3 यूहन्ना", "यहूदा", "प्रकाश"};
        public static List<string> BooksEnglish = new List<string>() { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel", "1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalm", "Proverbs", "Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter", "2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation" };
        public static void MapBibles()
        {
            string NepaliFile = "88feb452-4df2-4a88-827d-9e42e6851d29.json";
            string EnglishFile = "f29f466b-10ae-452e-8d05-796ca68d0af9.json";
            if (AppDomain.CurrentDomain.BaseDirectory.ToUpper().Contains("RELEASE"))
            {
                DBFolder = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Release\\", "");
            }
            else
            {
                DBFolder = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "");
            }

            AES aes = new AES();
            if(NepaliBible.Book.Count() <= 0)
            {
                var json =  aes.GetFileText(DBFolder + NepaliFile);
                NepaliBible = JsonConvert.DeserializeObject<Bible_W_AllChapters>(json);
            }
            if (EnglishBible.Book.Count() <= 0)
            {
                var json = aes.GetFileText(DBFolder + EnglishFile);
                EnglishBible = JsonConvert.DeserializeObject<Bible_W_AllChapters>(json);
            }
        }

        internal static string NextVerses(int howmany, string lang)
        {
            if (lang == "EN")
            {
                return GiveMeNextVerses(howmany, EnglishBible, BooksEnglish, lang);
            }
            else if(lang == "NP")
            {
                return GiveMeNextVerses(howmany, NepaliBible, BooksNepali, lang);
            }else if(lang == "BOTH")
            {
                int Original_ForNext_ActiveBook_Pos = ForNext_ActiveBook_Pos;
                int Original_ForNext_ActiveChapter_Pos = ForNext_ActiveChapter_Pos;
                int Original_ForNext_ActiveVerse_Pos = ForNext_ActiveVerse_Pos;
                int Original_ForPrev_ActiveBook_Pos = ForPrev_ActiveBook_Pos;
                int Original_ForPrev_ActiveChapter_Pos = ForPrev_ActiveChapter_Pos;
                int Original_ForPrev_ActiveVerse_Pos = ForPrev_ActiveVerse_Pos;
                string NepaliText = GiveMeNextVerses(howmany, NepaliBible, BooksNepali, "NP");
                ForNext_ActiveBook_Pos = Original_ForNext_ActiveBook_Pos;
                ForNext_ActiveChapter_Pos = Original_ForNext_ActiveChapter_Pos;
                ForNext_ActiveVerse_Pos = Original_ForNext_ActiveVerse_Pos;
                ForPrev_ActiveBook_Pos = Original_ForPrev_ActiveBook_Pos;
                ForPrev_ActiveChapter_Pos = Original_ForPrev_ActiveChapter_Pos;
                ForPrev_ActiveVerse_Pos = Original_ForPrev_ActiveVerse_Pos;
                string EnglishText = GiveMeNextVerses(howmany, EnglishBible, BooksEnglish, "EN");
                return NepaliText + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + EnglishText;
            }
            return "";
        }
        
        internal static string PreviousVerses(int howmany, string lang)
        {
            if(lang == "EN")
            {
                return GiveMePreviousVerses(howmany, EnglishBible, BooksEnglish, lang);
            }
            else if(lang == "NP")
            {
                return GiveMePreviousVerses(howmany, NepaliBible, BooksNepali, lang);
            }else if(lang == "BOTH")
            {
                int Original_ForNext_ActiveBook_Pos = ForNext_ActiveBook_Pos;
                int Original_ForNext_ActiveChapter_Pos = ForNext_ActiveChapter_Pos;
                int Original_ForNext_ActiveVerse_Pos = ForNext_ActiveVerse_Pos;
                int Original_ForPrev_ActiveBook_Pos = ForPrev_ActiveBook_Pos;
                int Original_ForPrev_ActiveChapter_Pos = ForPrev_ActiveChapter_Pos;
                int Original_ForPrev_ActiveVerse_Pos = ForPrev_ActiveVerse_Pos;
                string NepaliText = GiveMePreviousVerses(howmany, NepaliBible, BooksNepali, "NP");
                ForNext_ActiveBook_Pos = Original_ForNext_ActiveBook_Pos;
                ForNext_ActiveChapter_Pos = Original_ForNext_ActiveChapter_Pos;
                ForNext_ActiveVerse_Pos = Original_ForNext_ActiveVerse_Pos;
                ForPrev_ActiveBook_Pos = Original_ForPrev_ActiveBook_Pos;
                ForPrev_ActiveChapter_Pos = Original_ForPrev_ActiveChapter_Pos;
                ForPrev_ActiveVerse_Pos = Original_ForPrev_ActiveVerse_Pos;
                string EnglishText = GiveMePreviousVerses(howmany, EnglishBible, BooksEnglish, "EN");
                return NepaliText + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + EnglishText;
            }
            return "";
        }


        internal static string GiveMeNextVerses(int howmany, Bible_W_AllChapters temp_bible, List<string> Books, string lang)
        {
            int temp_ActiveBook_Pos = ForNext_ActiveBook_Pos;
            int temp_ActiveChapter_Pos = ForNext_ActiveChapter_Pos;
            int temp_ActiveVerse_Pos = ForNext_ActiveVerse_Pos;
            ForPrev_ActiveBook_Pos = temp_ActiveBook_Pos;
            ForPrev_ActiveChapter_Pos = temp_ActiveChapter_Pos;
            ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos - 1;
            List<string> VersesIncluded = new List<string>();
            if (temp_ActiveVerse_Pos < temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count())
            {
                VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], (lang == "NP" ? ConvertNumberToNepali(temp_ActiveChapter_Pos + 1) : (temp_ActiveChapter_Pos + 1).ToString())));
            }
            for (int i = 0; i < howmany; i++)
            {
                bool IsVerseValid = temp_ActiveVerse_Pos < temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count();
                bool IsChapterValid = temp_ActiveChapter_Pos + 1 < temp_bible.Book[temp_ActiveBook_Pos].Chapter.Count();
                bool IsBookValid = temp_ActiveBook_Pos + 1 < temp_bible.Book.Count();


                if (IsVerseValid)
                {
                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;
                    VersesIncluded.Add((lang == "NP" ? ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) : (temp_ActiveVerse_Pos + 1).ToString()) + ". " + AddSpaceAfterWords((temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
                    temp_ActiveVerse_Pos++;
                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;
                }
                else if (IsChapterValid && !IsVerseValid)
                {
                    temp_ActiveVerse_Pos = 0;
                    temp_ActiveChapter_Pos++;
                    if (i < howmany)
                    {
                        VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], (lang == "NP" ? ConvertNumberToNepali(temp_ActiveChapter_Pos + 1) : (temp_ActiveChapter_Pos + 1).ToString())));
                    }
                    VersesIncluded.Add((lang == "NP" ? ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) : (temp_ActiveVerse_Pos + 1).ToString()) + ". " + AddSpaceAfterWords((temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
                    temp_ActiveVerse_Pos++;
                    ForNext_ActiveChapter_Pos = temp_ActiveChapter_Pos;
                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;

                }
                else if (IsBookValid && !IsChapterValid && !IsVerseValid)
                {
                    temp_ActiveVerse_Pos = 0;
                    temp_ActiveChapter_Pos = 0;
                    temp_ActiveBook_Pos++;
                    if (i < howmany)
                    {
                        ForNext_ActiveChapter_Pos = 0;
                        VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], (lang == "NP" ? ConvertNumberToNepali(temp_ActiveChapter_Pos + 1) : (temp_ActiveChapter_Pos + 1).ToString())));
                    }
                    VersesIncluded.Add((lang == "NP" ? ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) : (temp_ActiveVerse_Pos + 1).ToString()) + ". " + AddSpaceAfterWords((temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
                    temp_ActiveVerse_Pos++;
                    ForNext_ActiveBook_Pos = temp_ActiveBook_Pos;
                    ForNext_ActiveChapter_Pos = temp_ActiveChapter_Pos;
                    ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos;
                }
            }
            return string.Join(System.Environment.NewLine, VersesIncluded);
        }

        internal static string GiveMePreviousVerses(int howmany, Bible_W_AllChapters temp_bible, List<string> Books, string lang)
        {
            int temp_ActiveBook_Pos = ForPrev_ActiveBook_Pos;
            int temp_ActiveChapter_Pos = ForPrev_ActiveChapter_Pos;
            int temp_ActiveVerse_Pos = ForPrev_ActiveVerse_Pos;
            ForNext_ActiveBook_Pos = temp_ActiveBook_Pos;
            ForNext_ActiveChapter_Pos = temp_ActiveChapter_Pos;
            ForNext_ActiveVerse_Pos = temp_ActiveVerse_Pos + 1;
            string initial_chapter_book = "";
            List<string> VersesIncluded = new List<string>();
            if (temp_ActiveVerse_Pos >= 0 && temp_ActiveVerse_Pos < temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count())
            {
                initial_chapter_book = "📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], lang == "NP" ? ConvertNumberToNepali(temp_ActiveChapter_Pos + 1) : (temp_ActiveChapter_Pos + 1).ToString());
            }

            for (int i = 0; i < howmany; i++)
            {
                bool IsVerseValid = temp_ActiveVerse_Pos >= 0;
                bool IsChapterValid = temp_ActiveChapter_Pos - 1 >= 0;
                bool IsBookValid = temp_ActiveBook_Pos - 1 >= 0;

                if (IsVerseValid)
                {
                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;
                    VersesIncluded.Add((lang == "NP" ? ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) : (temp_ActiveVerse_Pos + 1).ToString()) + ". " + AddSpaceAfterWords((temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
                    temp_ActiveVerse_Pos--;
                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;
                }
                else if (IsChapterValid && !IsVerseValid)
                {
                    VersesIncluded.Add(initial_chapter_book);
                    temp_ActiveChapter_Pos--;
                    temp_ActiveVerse_Pos = temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count() - 1;
                    VersesIncluded.Add((lang == "NP" ? ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) : (temp_ActiveVerse_Pos + 1).ToString()) + ". " + AddSpaceAfterWords((temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
                    temp_ActiveVerse_Pos--;
                    ForPrev_ActiveChapter_Pos = temp_ActiveChapter_Pos;
                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;

                }
                else if (IsBookValid && !IsChapterValid && !IsVerseValid)
                {
                    VersesIncluded.Add(initial_chapter_book);
                    temp_ActiveBook_Pos--;
                    temp_ActiveVerse_Pos = temp_bible.Book[temp_ActiveBook_Pos].Chapter.Count() - 1;
                    temp_ActiveChapter_Pos = temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse.Count() - 1;
                    VersesIncluded.Add((lang == "NP" ? ConvertNumberToNepali(temp_ActiveVerse_Pos + 1) : (temp_ActiveVerse_Pos + 1).ToString()) + ". " + AddSpaceAfterWords((temp_bible.Book[temp_ActiveBook_Pos].Chapter[temp_ActiveChapter_Pos].Verse[temp_ActiveVerse_Pos].Verse), 8));
                    temp_ActiveVerse_Pos--;
                    ForPrev_ActiveBook_Pos = temp_ActiveBook_Pos;
                    ForPrev_ActiveChapter_Pos = temp_ActiveChapter_Pos;
                    ForPrev_ActiveVerse_Pos = temp_ActiveVerse_Pos;
                }
            }
            VersesIncluded.Add("📖" + String.Format("{0}: {1}", Books[temp_ActiveBook_Pos], (lang == "NP" ? ConvertNumberToNepali(temp_ActiveChapter_Pos + 1) : (temp_ActiveChapter_Pos + 1).ToString())));
            VersesIncluded.Reverse();
            return string.Join(System.Environment.NewLine, VersesIncluded);
        }

        internal static string ConvertNumberToNepali(int num)
        {
            List<string> NepaliNumbersList = new List<string>() { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९" };
            string number = num.ToString();
            string final_num = "";
            foreach (char n in number)
            {
                string nn = n.ToString();
                int aa = Convert.ToInt32(nn);
                final_num += NepaliNumbersList[aa];
            }
            return final_num;
        }

        internal static string AddSpaceAfterWords(string text, int howmany)
        {
            var words = text.Split(' ').ToList();
            if (words.Count() > howmany)
            {
                for (int i = 1; i <= words.Count / howmany; i++)
                {
                    int _pos = i * howmany;
                    if (_pos < words.Count)
                    {
                        words[(_pos - 1)] = words[(_pos - 1)] + System.Environment.NewLine;
                    }
                }
            }
            text = String.Join(" ", words);
            return text;
        }

        internal static string PurifyEngNumbers(string originaltext)
        {
            string text = originaltext;
            string[] ss = Regex.Split(text.Trim(), @"[0-9]+");
            if (ss.Count() > 1)
            {
                foreach (string s in ss)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        text = text.Replace(s, "$");
                    }
                }
                text = text.Replace("$$", "$");
                var numbers = text.Split('$');
                foreach (string s in numbers)
                {
                    try
                    {
                        int num = Convert.ToInt32(s);
                        if (num >= 0)
                        {
                            originaltext = originaltext.Replace(num.ToString(), ConvertNumberToNepali(num));
                        }
                    }
                    catch { }
                }
            }
            return originaltext;
        }
        internal static string PurifyEngNumbersComparingWithEnglishVerse(string originaltext, _Verse EnglishVersen, int b,int c,int vv)
        {
            string text = originaltext;
            string[] ss = Regex.Split(text.Trim(), @"[0-9]+");
            if (ss.Count() > 1)
            {
                foreach (string s in ss)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        text = text.Replace(s, "$");
                    }
                }
                text = text.Replace("$$", "$");
                var numbers = text.Split('$');
                foreach (string s in numbers)
                {
                    try
                    {
                        int num = Convert.ToInt32(s);
                        if (num >= 0)
                        {
                            string aaaaa = BooksEnglish[b] + ": " + (c + 1).ToString() + " : " + (vv + 1).ToString();
                            var aaa = EnglishBibleMapper.NewNepaliVerseFormOtherBible(b, c, vv);
                            if (num == 186 || num == 187) 
                            {
                            }
                            if (EnglishVersen.Verse.Contains(num.ToString()) || EnglishVersen.Verse.Contains(NumberToWords(num)))
                            {
                                originaltext = originaltext.Replace(num.ToString(), ConvertNumberToNepali(num));
                            }
                            else
                            {
                                
                                originaltext = aaa;
                                return originaltext;
                            }
                        }
                    }
                    catch { }
                }
            }
            return originaltext;
        }

        internal static void ReplaceNepaliNumbersToEngFromTheWholeBlible()
        {
            //string NepaliFile = "NepaliBible.json";
            AES aes = new AES();
            List<string> misinformation = new List<string>();
            foreach (var book in NepaliBible.Book)
            {
                foreach (var chapter in book.Chapter)
                {
                    foreach (var v in chapter.Verse)
                    {
                        int b = NepaliBible.Book.IndexOf(book);
                        int c = book.Chapter.IndexOf(chapter);
                        int vv = chapter.Verse.IndexOf(v);
                        var text = PurifyEngNumbersComparingWithEnglishVerse(v.Verse, EnglishBible.Book[b].Chapter[c].Verse[vv], b, c, vv);
                        if (text != "MisInformationProvided" && text != v.Verse)
                        {
                            v.Verse = text;
                        }
                        else if(text == "MisInformationProvided")
                        {
                            misinformation.Add(BooksNepali[b] + " " + c.ToString() + ": " + vv.ToString() + " \r\n " + v.Verse + " \r\n " + EnglishBible.Book[b].Chapter[c].Verse[vv].Verse);
                        }
                    }
                }
            }
            var jjson = JsonConvert.SerializeObject(misinformation);
            File.WriteAllText("Misinformation.json", jjson);
            //aes.SaveFile(DBFolder + NepaliFile, jjson);
        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
