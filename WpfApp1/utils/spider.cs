using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace WpfApp1.utils
{
    class dospider
    {
        private string url;

        public string Url { get => url;
            set{
                string Pattern = @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$";
                Regex r = new Regex(Pattern);
                Match m = r.Match(value);
                if (m.Success)
                {
                    url = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("请检查URL是否输入有误");
                }
            }
        }
        public string Headers { get => headers; set => headers = value; }

        private string headers;
        public string crawler() {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.MaximumAutomaticRedirections = 4;
            //留白  报头
            req.Timeout = 50;
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream datastream = resp.GetResponseStream();
                Encoding ec = Encoding.UTF8;
                StreamReader reader = new StreamReader(datastream, ec);
                string htmlstr = reader.ReadToEnd();
                reader.Close();
                datastream.Close();
                resp.Close();
                return htmlstr;
            }
            catch (System.Net.WebException) {
                return "timeout 超时！";
            }
        }
        private string cookies;
        public string Cookies { get => cookies;set=>cookies = value; }
    }
}
