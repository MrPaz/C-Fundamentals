using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key] // Indexer; if working with a class that has semantics of a collection, an indexer is an easier way to access elements in the collection
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
