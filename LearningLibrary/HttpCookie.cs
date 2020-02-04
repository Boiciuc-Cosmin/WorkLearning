using System;
using System.Collections.Generic;
using System.Text;

namespace LearningLibrary
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _disctionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _disctionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _disctionary[key];}
            set { _disctionary[key] = value; }
        }
    }
}
