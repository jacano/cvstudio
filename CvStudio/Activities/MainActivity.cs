using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Views;
using CvStudio.Fragments;

namespace CvStudio.Activities
{
    [Activity(Label = "CV Studio", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {
        DrawerLayout _drawerLayout;
        NavigationView _navigationView;

        protected override int LayoutResource => Resource.Layout.MainView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            _navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            _navigationView.NavigationItemSelected += (sender, e) => 
            {
                e.MenuItem.SetChecked(true);

                switch (e.MenuItem.ItemId)
                {
                    case Resource.Id.AddCV:
                        NavigateToFragment(new AddCvFragment());
                        break;
                    case Resource.Id.BrowseCV:
                        NavigateToFragment(new CvSelectorFragment());
                        break;
                    case Resource.Id.Reset:
                        NavigateToFragment(new ResetCvFragment());
                        break;
                }

                _drawerLayout.CloseDrawers();
            };

            if (bundle == null)
            {
                NavigateToFragment(new AddCvFragment());
            }
        }

        public void NavigateToFragment(BaseFragment fragment)
        {
            SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.content_frame, fragment)
                .Commit();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    _drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}