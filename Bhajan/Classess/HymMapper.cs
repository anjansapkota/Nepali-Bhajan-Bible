using Bhajan.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Bhajan.Classess
{
    public class HymMapper
    {
        public static Hym activehym = new Hym();
        public static int last_slide = 0;
        public static Stanza active_stanza = new Stanza();
        public static Dictionary<string, List<Hym>> AllHymnalsCollection = new Dictionary<string, List<Hym>>();
        public static List<Hym> ActiveHymnal = new List<Hym>();
        public static List<string> BhajanCollectionNames = new List<string>() { "NepaliKristyaBhajan", "NKB_Chorus", "NKB_BaalGeet", "SDA_NP_Bhajan", "SDA_NP_Chorus", "SDA_Eng_Hymnal" }; public static string ACtiveBhajanCollectionName = "";
        internal static string DBFolder = "";
        internal Hym FindHymByNumber(int Number)
        {
            var hym = (from h in ActiveHymnal
                       where h.Number == Number
                       select h).FirstOrDefault();
            activehym = hym;
            last_slide = 0;
            return hym;
        }
        internal static string StartHym(string lang)
        {
            string Hym_Text;
            last_slide = 0;
            if (lang == "भजन")
            {
                Hym_Text = activehym.Number.ToString() + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Title + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Description;

            }
            else if (lang == "Bhajan")
            {

                Hym_Text = activehym.Number.ToString() + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.TitleRomanized + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Description;
            }
            else
            {
                Hym_Text = activehym.Number.ToString() + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Title + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.TitleRomanized + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Description;
            }
            var words = Hym_Text.Split(' ');
            if (words.Count() >= 5)
            {
                string newline = "";
                for (int i = 0; i < words.Length / 2; i++)
                {
                    newline += words[i] + " ";
                }
                Hym_Text = Hym_Text.Replace(newline, newline + '\n');
            }
            return Hym_Text;
        }

        internal static string NextVerse(string language_selected)
        {
            string txt = "";
            int next_stanza = last_slide + 1;
            if (next_stanza > 0 && next_stanza <= activehym.TotalNumOfSlides)
            {
                last_slide = next_stanza;

                if (language_selected == "भजन")
                {
                    txt = (from stanza in activehym.stanzas
                           where stanza.SlideNumbers.Contains(next_stanza)
                           select stanza).FirstOrDefault().StanzaText;

                }
                else if (language_selected == "Bhajan")
                {
                    txt = (from stanza in activehym.stanzas
                           where stanza.SlideNumbers.Contains(next_stanza)
                           select stanza).FirstOrDefault().StanzaTextRomanized;
                }
                else if (language_selected == "दुबै/Both")
                {
                    var _stanza_temp = (from stanza in activehym.stanzas
                                        where stanza.SlideNumbers.Contains(next_stanza)
                                        select stanza).FirstOrDefault();
                    txt = _stanza_temp.StanzaText + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + _stanza_temp.StanzaTextRomanized;
                }
            }
            else
            {
                string Hym_Text = "";
                if (language_selected == "भजन")
                {
                    Hym_Text = activehym.Number.ToString() + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Title + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Description;

                }
                else if (language_selected == "Bhajan")
                {

                    Hym_Text = activehym.Number.ToString() + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.TitleRomanized + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Description;
                }
                else
                {
                    Hym_Text = activehym.Number.ToString() + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Title + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.TitleRomanized + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + activehym.Description;
                }
                var words = Hym_Text.Split(' ');
                if (words.Count() >= 5)
                {
                    string newline = "";
                    for (int i = 0; i < words.Length / 2; i++)
                    {
                        newline += words[i] + " ";
                    }
                    Hym_Text = Hym_Text.Replace(newline, newline + '\n');
                }
                last_slide = activehym.TotalNumOfSlides + 1;
                return Hym_Text;
            }
            txt = AddSpaceAfterWords(txt, 8);
            return txt;
        }

        internal static string PreviousVerse(string language_selected)
        {
            string txt = "";
            int prev_stanza = last_slide - 1;
            if (prev_stanza > 0 && prev_stanza <= activehym.TotalNumOfSlides)
            {
                last_slide = prev_stanza;
                if (language_selected == "भजन")
                {
                    txt = (from stanza in activehym.stanzas
                           where stanza.SlideNumbers.Contains(prev_stanza)
                           select stanza).FirstOrDefault().StanzaText;
                }
                else if (language_selected == "Bhajan")
                {
                    txt = (from stanza in activehym.stanzas
                           where stanza.SlideNumbers.Contains(prev_stanza)
                           select stanza).FirstOrDefault().StanzaTextRomanized;
                }
                else if (language_selected == "दुबै/Both")
                {
                    var _stanza_temp = (from stanza in activehym.stanzas
                                        where stanza.SlideNumbers.Contains(prev_stanza)
                                        select stanza).FirstOrDefault();
                    txt = _stanza_temp.StanzaText + System.Environment.NewLine + "-----------------------------------------------" + System.Environment.NewLine + _stanza_temp.StanzaTextRomanized;
                }
            }
            else if (prev_stanza == 0)
            {
                txt = StartHym(language_selected);
                last_slide = 0;
            }
            else
            {
                return null;
            }
            txt = AddSpaceAfterWords(txt, 8);
            return txt;
        }

        internal static void ChooseHymnal(int hymnal_id)
        {
            hymnal_id--;
            if (AllHymnalsCollection.Count() == 0)
            {
                LoadAllHymnalsFromOneFile();
            }
            string hymnalname = BhajanCollectionNames[hymnal_id];
            ActiveHymnal = AllHymnalsCollection[hymnalname];
            ACtiveBhajanCollectionName = hymnalname;
        }

        internal static bool LoadAllHymnalsFromOneFile()
        {
            try
            {
                if (AppDomain.CurrentDomain.BaseDirectory.ToUpper().Contains("RELEASE"))
                {
                    DBFolder = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Release\\", "");
                }
                else
                {
                    DBFolder = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "");
                }
                string myrawhymalscollection = GetFileText(DBFolder + "29e77222-451d-4eed-aab5-85aeb562fa57.json");
                AllHymnalsCollection = JsonConvert.DeserializeObject<Dictionary<string, List<Hym>>>(myrawhymalscollection);
                return true;
            }
            catch
            {
                return false;
            }
        }



        internal Hym FindHymByTitle(string txt)
        {
            var hym = (from h in ActiveHymnal
                       where h.TitleRomanized == txt
                       select h).FirstOrDefault();
            activehym = hym;
            last_slide = 0;
            return hym;
        }

        internal static List<Hym> ArrangeNKBHyms(string path)
        {
            try
            {
                string myrawhymnal = GetFileText(path);
                List<Hym> Temp_Hymnal = JsonConvert.DeserializeObject<List<Hym>>(myrawhymnal);

                return Temp_Hymnal;
            }
            catch
            {
                return null;
            }
        }
        public static void ArrangeHymnals(string editor)
        {
            for (int i = 0; i < BhajanCollectionNames.Count; i++)
            {
                if (AllHymnalsCollection.ContainsKey(BhajanCollectionNames[i]))
                    AllHymnalsCollection[BhajanCollectionNames[i]] = AllHymnalsCollection[BhajanCollectionNames[i]].OrderBy(o => o.Number).ToList();
            }

            string myrawhymnal = JsonConvert.SerializeObject(AllHymnalsCollection);
            var path = DBFolder + "29e77222-451d-4eed-aab5-85aeb562fa57" + ".json";
            SaveFile(path, myrawhymnal);
        }


        private static string GetFileText(string path)
        {
            AES aes = new AES();
            var bytes = aes.GetFileText(path);
            return bytes;
        }
        private static bool SaveFile(string path, string textToSave)
        {
            AES aes = new AES();
            return aes.SaveFile(path, textToSave);
        }
        
        private static string AddSpaceAfterWords(string text, int howmany)
        {
            var lines = text.Split(new string[] {System.Environment.NewLine, "\n" }, StringSplitOptions.None).ToList();
            var newlines = new List<string>();
            if (lines.Count() > 0)
            {
                foreach(string line in lines)
                {
                    var words = line.Split(' ').ToList();
                    if (words.Count() >= 8)
                    {
                        if (line.IndexOf(',') > line.Length * 40 / 100 && line.IndexOf(',') < line.Length * 60 / 100)
                        {
                            newlines.Add(line.Substring(0, line.IndexOf(',') + 1));
                            newlines.Add(line.Substring(line.IndexOf(',') + 1, line.Length - newlines.LastOrDefault().Length));
                        }
                        else if (line.IndexOf(')') > line.Length * 40 / 100 && line.IndexOf(')') < line.Length * 60 / 100)
                        {
                            newlines.Add(line.Substring(0, line.IndexOf(')') + 1));
                            newlines.Add(line.Substring(line.IndexOf(')') + 1, line.Length - newlines.LastOrDefault().Length));
                        }
                        else if (line.IndexOf(';') > line.Length * 40 / 100 && line.IndexOf(';') < line.Length * 60 / 100)
                        {
                            newlines.Add(line.Substring(0, line.IndexOf(';') + 1));
                            newlines.Add(line.Substring(line.IndexOf(';') + 1, line.Length - newlines.LastOrDefault().Length));
                        }
                        else if (line.IndexOf('.') > line.Length * 40 / 100 && line.IndexOf('.') < line.Length * 60 / 100)
                        {
                            newlines.Add(line.Substring(0, line.IndexOf('.') + 1));
                            newlines.Add(line.Substring(line.IndexOf('.') + 1, line.Length - newlines.LastOrDefault().Length));
                        }
                        else if (line.IndexOf('!') > line.Length * 40 / 100 && line.IndexOf('!') < line.Length * 60 / 100)
                        {
                            newlines.Add(line.Substring(0, line.IndexOf('!') + 1));
                            newlines.Add(line.Substring(line.IndexOf('!') + 1, line.Length - newlines.LastOrDefault().Length));
                        }
                        else
                        {
                            int middle = line.Length / 2;
                            if (middle > 1 && !line.Contains("----------"))
                            {
                                string new_split = "";
                                int i = 0;
                                while (new_split.Length < middle)
                                {
                                    new_split += new_split.Length > 0 ? " " + words[i] : words[i];
                                    i++;
                                }
                                newlines.Add(new_split);
                                new_split = "";
                                while (i < words.Count())
                                {
                                    new_split += new_split.Length > 0 ? " " + words[i] : words[i];
                                    i++;
                                }
                                newlines.Add(new_split);
                            }
                            else
                            {
                                newlines.Add(line);
                            }
                        }
                    }
                    else
                    {
                        newlines.Add(line);
                    }
                }
            }
            else
            {
                return text;
            }
            text = String.Join(System.Environment.NewLine, newlines);
            return text;
        }
    }

    public class Diwakar
    {
        public static Dictionary<string, List<Hym>> AllHymnalsCollection = new Dictionary<string, List<Hym>>();
        public List<Hym> LoadTextFilesToHyms()
        {
            var romanized = File.ReadAllText(@"C:\Users\AnjanS\Desktop\Bhajan images\Songs Collection\Diwakar\English Hymns.txt");
            var nepali = File.ReadAllText(@"C:\Users\AnjanS\Desktop\Bhajan images\Songs Collection\Diwakar\Nepali Hymns.txt");
            var hymnalEng = ArrangeTxtToModels(romanized, 752);
            var hymnalNep = ArrangeTxtToModelsNep(nepali, 752);
            var hymnal = MergeTwoLangHyms(hymnalEng, hymnalNep);
            return hymnal;
        }
        
        public List<Hym> LoadTextFilesToChoruses()
        {
            var romanized = File.ReadAllText(@"C:\Users\AnjanS\Desktop\Bhajan images\Songs Collection\Diwakar\English Chorus.txt");
            var nepali = File.ReadAllText(@"C:\Users\AnjanS\Desktop\Bhajan images\Songs Collection\Diwakar\Nepali Chorus.txt");
            var hymnalEng = ArrangeTxtToModels(romanized, 329);
            var hymnalNep = ArrangeTxtToModelsNep(nepali, 329);
            var hymnal = MergeTwoLangHyms(hymnalEng, hymnalNep);
            return hymnal;
        }        
        public List<Hym> LoadTextFilesToBaalGeets()
        {
            var romanized = File.ReadAllText(@"C:\Users\AnjanS\Desktop\Bhajan images\Songs Collection\Diwakar\English Baal Chorus.txt");
            var nepali = File.ReadAllText(@"C:\Users\AnjanS\Desktop\Bhajan images\Songs Collection\Diwakar\Nepali Baal Chorus.txt");
            var hymnalEng = ArrangeTxtToModels(romanized, 70);
            var hymnalNep = ArrangeTxtToModelsNep(nepali, 70);
            var hymnal = MergeTwoLangHyms(hymnalEng, hymnalNep);
            return hymnal;
        }

        public List<Hym> ArrangeTxtToModels(string text_raw, int total)
        {
            MappingFunctions mf = new MappingFunctions();
            var lines = MappingFunctions.PurifyStringIntoLinesArray(text_raw);
            int working_line = 0;
            var hymnal = new List<Hym>();
            int lasthymfound = 0;
            int now_working = 0;
            for (int num = 0; num <= total; num++)
            {
                num = lasthymfound;
                var hym = new Hym();
                var stanza = new Stanza();
                bool newhymfound = false;
                while (!newhymfound && working_line < lines.Count())
                {
                    var l = lines[working_line];
                    if (l.Contains(@"\c"))
                    {
                        lasthymfound = Convert.ToInt32(MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l.Replace(@"\c", "")));
                        newhymfound = true;
                        working_line++;
                        break;
                    }
                    else
                    {
                        hym.Number = lasthymfound;
                        if (l.Contains(@"\s"))
                        {
                            l = l.Replace(@"\s", "");

                            string[] info = MappingFunctions.RemoveEngNamesFromTitles(l);
                            if (!string.IsNullOrEmpty(info[1]))
                            {
                                hym.TitleRomanized = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(info[0]);
                                hym.Description = (string.IsNullOrEmpty(info[1]) ? "" : info[1] + System.Environment.NewLine) + hym.Description;
                            }
                            else
                            {
                                hym.TitleRomanized = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                            }
                            working_line++;
                        }
                        else if (l.Contains(@"\qr"))
                        {
                            l = l.Replace(@"\qr", "");
                            l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                            hym.Description = string.IsNullOrEmpty(hym.Description) ? hym.Description + System.Environment.NewLine + l : l;
                            working_line++;
                            now_working++;
                        }
                        else if (l.Contains(@"\q1"))
                        {
                            now_working = 0;
                            if (l.Contains(@"\bd"))
                            {
                                l = l.Replace(@"\q1", "").Replace(@"\bd*", "").Replace(@"\bd", "");

                                l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                stanza = new Stanza();
                                stanza.IsChorus = true;
                                while (!l.Contains(@"\q1 1") && !l.Contains(@"\q1 2") && !l.Contains(@"\q1 3") && !l.Contains(@"\q1 4") && !l.Contains(@"\q1 5") && !l.Contains(@"\q1 6"))
                                {
                                    if (l.Contains(@"\c"))
                                    {
                                        lasthymfound = Convert.ToInt32(MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l.Replace(@"\c", "")));
                                        newhymfound = true;
                                        break;
                                    }
                                    else if (string.IsNullOrWhiteSpace(l))
                                    {
                                        break;
                                    }
                                    l = l.Replace(@"\q1", "").Replace(@"\bd*", "").Replace(@"\bd", "");

                                    l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                    stanza.StanzaTextRomanized += string.IsNullOrEmpty(stanza.StanzaTextRomanized) ? l : System.Environment.NewLine + l;
                                    working_line++;
                                    now_working++;
                                    l = lines[working_line];
                                }
                                hym.stanzas.Add(stanza);
                            }
                            else
                            {
                                stanza = new Stanza();
                                stanza.IsChorus = false;
                                l = l.Replace(@"\q1", "");

                                l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                stanza.StanzaTextRomanized += string.IsNullOrEmpty(stanza.StanzaTextRomanized) ? l : System.Environment.NewLine + l;
                                working_line++;
                                now_working++;
                                l = lines[working_line];
                                while (!l.Contains(@"\q1 1") && !l.Contains(@"\q1 2") && !l.Contains(@"\q1 3") && !l.Contains(@"\q1 4") && !l.Contains(@"\q1 5") && !l.Contains(@"\q1 6") && !l.Contains(@"\q1 7") && !l.Contains(@"\q1 8") && !l.Contains(@"\q1 9") && !l.Contains(@"\q1 10") && !l.Contains(@"\q1 11") && !l.Contains(@"\q1 12") && !l.Contains(@"\q1 13") && !l.Contains(@"\q1 14"))
                                {
                                    if (l.Contains(@"\c"))
                                    {
                                        lasthymfound = Convert.ToInt32(MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l.Replace(@"\c", "")));
                                        newhymfound = true;
                                        break;
                                    }
                                    if (l.Contains(@"\bd") || string.IsNullOrWhiteSpace(l))
                                    {
                                        break;
                                    }
                                    l = l.Replace(@"\q1", "");
                                    l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                    stanza.StanzaTextRomanized += string.IsNullOrEmpty(stanza.StanzaTextRomanized) ? l : System.Environment.NewLine + l;
                                    working_line++;
                                    now_working++;
                                    l = lines[working_line];
                                }
                                stanza.StanzaNumber = hym.stanzas.Count() + 1;
                                hym.stanzas.Add(stanza);
                            }
                            if (now_working > 10)
                            {

                            }
                        }
                        else
                        {
                            working_line++;
                        }
                    }
                }
                if (hym.Number > 0)
                {
                    hymnal.Add(hym);
                }
            }
            return hymnal;
        }
        
        public List<Hym> ArrangeTxtToModelsNep(string text_raw, int total)
        {
            MappingFunctions mf = new MappingFunctions();
            var lines = MappingFunctions.PurifyStringIntoLinesArray(text_raw);
            int working_line = 0;
            var hymnal = new List<Hym>();
            int lasthymfound = 0;
            int now_working = 0;
            for (int num = 0; num <= total; num++)
            {
                num = lasthymfound;
                var hym = new Hym();
                var stanza = new Stanza();
                bool newhymfound = false;
                while (!newhymfound && working_line < lines.Count())
                {
                    var l = lines[working_line];
                    if (l.Contains(@"\c"))
                    {
                        lasthymfound = Convert.ToInt32(MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l.Replace(@"\c", "")));
                        newhymfound = true;
                        working_line++;
                        break;
                    }
                    else
                    {
                        hym.Number = lasthymfound;
                        if (l.Contains(@"\s"))
                        {
                            l = l.Replace(@"\s", "");

                            string[] info = MappingFunctions.RemoveEngNamesFromTitles(l);
                            if (!string.IsNullOrEmpty(info[1]))
                            {
                                hym.Title = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(info[0]);
                                hym.Description = (string.IsNullOrEmpty(info[1]) ? "" : info[1] + System.Environment.NewLine) + hym.Description;
                            }
                            else
                            {
                                hym.Title = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                            }
                            working_line++;
                        }
                        else if (l.Contains(@"\qr"))
                        {
                            l = l.Replace(@"\qr", "");
                            l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                            hym.Description = string.IsNullOrEmpty(hym.Description) ? hym.Description + System.Environment.NewLine + l : l;
                            working_line++;
                            now_working++;
                        }
                        else if (l.Contains(@"\q1"))
                        {
                            now_working = 0;
                            if (l.Contains(@"\bd"))
                            {
                                l = l.Replace(@"\q1", "").Replace(@"\bd*", "").Replace(@"\bd", "");

                                l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                stanza = new Stanza();
                                stanza.IsChorus = true;
                                while (!l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(1)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(2)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(3)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(4)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(5)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(6)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(7)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(8)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(9)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(10)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(11)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(12)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(13)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(14)))
                                {
                                    if (l.Contains(@"\c"))
                                    {
                                        lasthymfound = Convert.ToInt32(MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l.Replace(@"\c", "")));
                                        newhymfound = true;
                                        break;
                                    }
                                    else if (string.IsNullOrWhiteSpace(l))
                                    {
                                        break;
                                    }
                                    l = l.Replace(@"\q1", "").Replace(@"\bd*", "").Replace(@"\bd", "");

                                    l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                    stanza.StanzaText += string.IsNullOrEmpty(stanza.StanzaText) ? l : System.Environment.NewLine + l;
                                    working_line++;
                                    now_working++;
                                    l = lines[working_line];
                                }
                                hym.stanzas.Add(stanza);
                            }
                            else
                            {
                                stanza = new Stanza();
                                stanza.IsChorus = false;
                                l = l.Replace(@"\q1", "");

                                l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                stanza.StanzaText += string.IsNullOrEmpty(stanza.StanzaText) ? l : System.Environment.NewLine + l;
                                working_line++;
                                now_working++;
                                l = lines[working_line];
                                while (!l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(1)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(2)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(3)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(4)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(5)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(6)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(7)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(8)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(9)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(10)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(11)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(12)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(13)) && !l.Contains(@"\q1 " + MappingFunctions.ConvertNumberEnglishToNepali(14)))
                                {
                                    if (l.Contains(@"\c"))
                                    {
                                        lasthymfound = Convert.ToInt32(MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l.Replace(@"\c", "")));
                                        newhymfound = true;
                                        break;
                                    }
                                    if (l.Contains(@"\bd") || string.IsNullOrWhiteSpace(l))
                                    {
                                        break;
                                    }
                                    l = l.Replace(@"\q1", "");
                                    l = MappingFunctions.RemoveAllBlankSpacesStartAndEndOFTitles(l);
                                    stanza.StanzaText += string.IsNullOrEmpty(stanza.StanzaText) ? l : System.Environment.NewLine + l;
                                    working_line++;
                                    now_working++;
                                    l = lines[working_line];
                                }
                                stanza.StanzaNumber = hym.stanzas.Count() + 1;
                                hym.stanzas.Add(stanza);
                            }
                            if (now_working > 10)
                            {

                            }
                        }
                        else
                        {
                            working_line++;
                        }
                    }
                }
                if (hym.Number > 0)
                {
                    hymnal.Add(hym);
                }
            }
            return hymnal;
        }

        public List<Hym> MergeTwoLangHyms(List<Hym> English,List<Hym> Nepali)
        {
            for (int i = 0; i< English.Count(); i++)
            {
                Hym hymEng = English[i]; 
                Hym hymNep = Nepali[i]; 
                int numberEng = hymEng.Number;
                int numberNep = hymNep.Number;
                if (numberEng == numberNep && hymEng.stanzas.Count() == hymNep.stanzas.Count())
                {
                    hymEng.Title = hymNep.Title;
                    for (int ii = 0; ii < hymEng.stanzas.Count(); ii++)
                    {
                        Stanza stE = hymEng.stanzas[ii];
                        Stanza stN = hymNep.stanzas[ii];
                        stE.StanzaText = stN.StanzaText;
                    }
                }
                else
                {

                }
            }
            List<Hym> hymnal = English;
            for(int iii = 0; iii < hymnal.Count(); iii++)
            {
                hymnal[iii] = MappingFunctions.ReArrangeHymSlidesAndStanzas("भजन", hymnal[iii]);
            }
            return hymnal;
        }
    }
}
