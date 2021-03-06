﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace CoursesAndroid
{
    [Activity(Label = "CoursesAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        TextView textDescription;
        ImageView imageCourse;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);
            textDescription = FindViewById<TextView>(Resource.Id.textDescription);
            imageCourse = FindViewById<ImageView>(Resource.Id.imageCourse);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;
        }

        private void ButtonNext_Click(object sender, System.EventArgs e)
        {
            textTitle.Text = "Next Click";
            textDescription.Text = "The description that appears when Next is clicked";
            imageCourse.SetImageResource(Resource.Drawable.ps_top_card_01);
        }

        private void ButtonPrev_Click(object sender, System.EventArgs e)
        {
            textTitle.Text = "Prev Clicked";
            textDescription.Text = "The description that appears when Prev is clicked";
            imageCourse.SetImageResource(Resource.Drawable.ps_top_card_02);
        }
    }
}

