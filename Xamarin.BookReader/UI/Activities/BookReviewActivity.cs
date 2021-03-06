﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.BookReader.Bases;
using Xamarin.BookReader.Views;
using Android.Content.PM;

namespace Xamarin.BookReader.UI.Activities
{
    /// <summary>
    /// 书评区
    /// </summary>
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class BookReviewActivity : BaseCommunitActivity
    {
        public static void startActivity(Context context) {
            context.StartActivity(new Intent(context, typeof(BookReviewActivity)));
        }

        public override int getLayoutId()
        {
            return Resource.Layout.activity_community_book_review;
        }

        public override void initToolBar()
        {
            mCommonToolbar.Title = ("书评区");
            mCommonToolbar.SetNavigationIcon(Resource.Drawable.ab_back);
        }
        public override void configViews()
        {
        }

        protected override List<List<string>> getTabList()
        {
            return list2;
        }
    }
}