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

using CvStudio.Core.Models;

namespace CvStudio.Adapters
{
    public class CvAdapter : ListAdapter<Cv>
    {
        private readonly Activity _activity;

        public CvAdapter(Activity activity, IEnumerable<Cv> items)
            : base(items)
        {
            _activity = activity;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ??
                       _activity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            var cv = this[position];

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = cv.Name;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = cv.PhotoUrl;

            return view;
        }

        protected override long GetItemId(Cv item)
        {
            return item.Id;
        }
    }
}