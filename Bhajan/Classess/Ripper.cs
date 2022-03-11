//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bhajan.Classess
//{
//    internal class Ripper
//    {
//        private static List<string> links = new List<string>() { "https://www.nepalichristiansongs.com/aa.php", "https://www.nepalichristiansongs.com/i.php", "https://www.nepalichristiansongs.com/ii.php", "https://www.nepalichristiansongs.com/u.php", "https://www.nepalichristiansongs.com/uu.php", "https://www.nepalichristiansongs.com/R_.php", "https://www.nepalichristiansongs.com/e.php", "https://www.nepalichristiansongs.com/ai.php", "https://www.nepalichristiansongs.com/o.php", "https://www.nepalichristiansongs.com/au.php", "https://www.nepalichristiansongs.com/k.php", "https://www.nepalichristiansongs.com/kh.php", "https://www.nepalichristiansongs.com/g.php", "https://www.nepalichristiansongs.com/gh.php", "https://www.nepalichristiansongs.com/Ng.php", "https://www.nepalichristiansongs.com/ch.php", "https://www.nepalichristiansongs.com/chh.php", "https://www.nepalichristiansongs.com/j.php", "https://www.nepalichristiansongs.com/jh.php", "https://www.nepalichristiansongs.com/Nj.php", "https://www.nepalichristiansongs.com/T_.php", "https://www.nepalichristiansongs.com/T_h.php", "https://www.nepalichristiansongs.com/D_.php", "https://www.nepalichristiansongs.com/D_h.php", "https://www.nepalichristiansongs.com/N_.php", "https://www.nepalichristiansongs.com/t.php", "https://www.nepalichristiansongs.com/th.php", "https://www.nepalichristiansongs.com/d.php", "https://www.nepalichristiansongs.com/dh.php", "https://www.nepalichristiansongs.com/n.php", "https://www.nepalichristiansongs.com/p.php", "https://www.nepalichristiansongs.com/ph.php", "https://www.nepalichristiansongs.com/b.php", "https://www.nepalichristiansongs.com/bh.php", "https://www.nepalichristiansongs.com/m.php", "https://www.nepalichristiansongs.com/y.php", "https://www.nepalichristiansongs.com/r.php", "https://www.nepalichristiansongs.com/l.php", "https://www.nepalichristiansongs.com/w.php", "https://www.nepalichristiansongs.com/sh.php", "https://www.nepalichristiansongs.com/S_h.php", "https://www.nepalichristiansongs.com/s.php", "https://www.nepalichristiansongs.com/h.php", "https://www.nepalichristiansongs.com/kSh.php", "https://www.nepalichristiansongs.com/tr.php", "https://www.nepalichristiansongs.com/Gy.php" };
//        public static Dictionary<string, HymTitleFormat> ListHyms = new Dictionary<string, HymTitleFormat>();
//        public static Dictionary<string, HymTitleFormat> ListChorus = new Dictionary<string, HymTitleFormat>();
//        public async void Rip()
//        {
//            foreach (var link in links)
//            {
//                var client = new RestClient(link);
//                var request = new RestRequest("GET");
//                var response = await client.ExecuteGetAsync(request);
//                var aa = (response.Content);
//                var lines = PurifyStringIntoLinesArray(aa);
//                foreach (var line in lines)
//                {
//                    string title = "";
//                    string _rawnumber = "";
//                    int number = 0;
//                    string detailes = "";
//                    if (line.Contains("songDetails"))
//                    {
//                        try
//                        {
//                            var ln = line;//.Split(new String[] { "class=\"nepali\"" }, StringSplitOptions.None)[1];
//                            if (ln.Contains("javascript:void(0)"))
//                            {
//                                title = getCharactersBeforeAndAfter(ln, "\\')\">", "</a> <span").Split(new String[] { "\\')\">" }, StringSplitOptions.None)[1];
//                                detailes = getCharactersBeforeAndAfter(ln, "\"songDetails\">", "</span>").Split(new String[] { "\"songDetails\">" }, StringSplitOptions.None)[1];

//                            }
//                            else
//                            {
//                                title = getCharactersBeforeAndAfter(ln, "class=\"nepali\"", "<span").Split(new String[] { "class=\"nepali\"" }, StringSplitOptions.None)[1];
//                                detailes = getCharactersBeforeAndAfter(ln, "\"songDetails\">", "</span>").Split(new String[] { "\"songDetails\">" }, StringSplitOptions.None)[1];
//                            }

//                            if (detailes.Contains("kb"))
//                            {
//                                _rawnumber = getCharactersBeforeAndAfter(detailes, "kb", ",");
//                                number = Convert.ToInt32(new String(_rawnumber.Where(Char.IsDigit).ToArray()));

//                                HymTitleFormat t = new HymTitleFormat()
//                                {
//                                    title = title,
//                                    number = number,
//                                    raw_number = _rawnumber,
//                                    details = detailes
//                                };

//                                if (_rawnumber.Contains("s"))
//                                {
//                                    if (!ListHyms.ContainsKey(_rawnumber))
//                                    {
//                                        ListHyms.Add(_rawnumber, t);
//                                    }
//                                }
//                                else if(_rawnumber.Contains("c"))
//                                {
//                                    if (!ListChorus.ContainsKey(_rawnumber))
//                                    {
//                                        ListChorus.Add(_rawnumber, t);
//                                    }
//                                }
                                
//                            }
//                        }
//                        catch { }
//                    }
//                }
//            }
//            var jsonhyms = JsonConvert.SerializeObject(ListHyms);
//            System.IO.File.WriteAllText("C:\\Users\\AnjanS\\Desktop\\Bhajan images\\Songs Collection\\Only Names\\hym list another website.json", jsonhyms);
//            jsonhyms = JsonConvert.SerializeObject(ListChorus);
//            System.IO.File.WriteAllText("C:\\Users\\AnjanS\\Desktop\\Bhajan images\\Songs Collection\\Only Names\\chorus list another website.json", jsonhyms);
//        }

//        private string[] PurifyStringIntoLinesArray(String text)
//        {
//            text = text.Replace("\u001a", string.Empty);
//            string[] lines = text.Split(
//                new[] { "\r\n", "\r", "\n", },
//                StringSplitOptions.None
//            );
//            return lines;
//        }

//        private static String getCharacters(String txt, int initial, int final)
//        {
//            String filtered_text = "";
//            if (!txt.Equals(""))
//            {
//                for (int i = initial; i <= final; i++)
//                {
//                    char c = txt[i - 1];
//                    filtered_text = filtered_text + c;
//                }
//            }
//            return filtered_text;
//        }

//        private String getCharactersBeforeAndAfter(String txt, string initial_txt, string final_txt)
//        {
//            int initial = txt.IndexOf(initial_txt) + 1;
//            int final = txt.IndexOf(final_txt);
//            String filtered_text = "";
//            if (!txt.Equals(""))
//            {
//                for (int i = initial; i <= final; i++)
//                {
//                    char c = txt[i - 1];
//                    filtered_text = filtered_text + c;
//                }
//            }
//            return filtered_text;
//        }
//    }

//    internal class HymTitleFormat
//    {
//        public string title { get; set; }
//        public string raw_number { get; set; }
//        public string details { get; set; }
//        public int number { get; set; }
//    }
//}
