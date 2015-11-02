using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CvStudio.Adapters
{
    public abstract class ListAdapter<T> : BaseAdapter<T>
    {
        private readonly List<T> _items;

        protected ListAdapter(IEnumerable<T> items)
        {
            this._items = new List<T>(items);
        }

        public override long GetItemId(int position)
        {
            return GetItemId(_items[position]);
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }

        public override int Count => _items.Count;

        public override T this[int position] => _items[position];

        protected abstract long GetItemId(T item);
    }
}