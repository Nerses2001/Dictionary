
using System.Drawing;

namespace Dictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        private readonly HashSet<TKey> _keys;
        private readonly List<TValue> _values;

        public MyDictionary()
        {
            _keys = new HashSet<TKey>();
            _values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                throw new ArgumentException("An element with the same key already exists in the dictionary.");
            }
            _keys.Add(key);
            _values.Add(value);
        }
        public bool ContainsKey(TKey key)
        {
            return _keys.Contains(key);
        }

        public bool Remove(TKey key)
        {
            if (_keys.Remove(key))
            {
                int index = _values.FindIndex(value => key!.Equals(value));
                if (index != -1)
                {
                    _values.RemoveAt(index);
                    return true;
                }
            }

            return false;
        }




    }
}
