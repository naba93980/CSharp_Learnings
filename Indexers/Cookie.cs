namespace Indexers
{
    internal class Cookie
    {
        private Dictionary<string, string> _items = new Dictionary<string, string>();

        // indexer
        public string this[string item] {
            get { return _items[item]; } 
            set { _items[item] = value;}
        }

        // you cant have multiple indexers with same parameter type
    }
}
