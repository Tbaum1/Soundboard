using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Soundboard
{
    [Activity(Label = "SpaceyActivity")]
    public class SpaceyActivity : Android.App.Activity
    {
        Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btnMain;
        protected MediaPlayer player;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_spacey);
            // Create your application here
            btn1 = FindViewById<Button>(Resource.Id.btn1);
            btn2 = FindViewById<Button>(Resource.Id.btn2);
            btn3 = FindViewById<Button>(Resource.Id.btn3);
            btn4 = FindViewById<Button>(Resource.Id.btn4);
            btn5 = FindViewById<Button>(Resource.Id.btn5);
            btn6 = FindViewById<Button>(Resource.Id.btn6);
            btn7 = FindViewById<Button>(Resource.Id.btn7);
            btn8 = FindViewById<Button>(Resource.Id.btn8);
            btn9 = FindViewById<Button>(Resource.Id.btn9);
            btn10 = FindViewById<Button>(Resource.Id.btn10);
            btn11 = FindViewById<Button>(Resource.Id.btn11);
            btn12 = FindViewById<Button>(Resource.Id.btn12);
            btnMain = FindViewById<Button>(Resource.Id.btnMain);
            Intent mainActivity = new Intent(this, typeof(MainActivity));

            btnMain.Click += delegate
            {
                player.Reset();
                Finish();
            };

            btn1.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Evidence_Seven);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Evidence_Seven);
                    player.Start();
                }
            };
            btn2.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Favor_Swimming_With_Sharks);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Favor_Swimming_With_Sharks);
                    player.Start();
                }
            };
            btn3.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Gone_Usual_Suspects);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Gone_Usual_Suspects);
                    player.Start();
                }
            };
            btn4.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Kevin_Spacey_doing_Walken_as_Han_Solo);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Kevin_Spacey_doing_Walken_as_Han_Solo);
                    player.Start();
                }
            };
            btn5.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Lunch_Glengarry_Glen_Ross);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Lunch_Glengarry_Glen_Ross);
                    player.Start();
                }
            };
            btn6.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.My_Life_American_Beauty);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.My_Life_American_Beauty);
                    player.Start();
                }
            };
            btn7.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Pontiac_Firebird_American_Beauty);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Pontiac_Firebird_American_Beauty);
                    player.Start();
                }
            };
            btn8.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.So_Much_Beauty_American_Beauty);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.So_Much_Beauty_American_Beauty);
                    player.Start();
                }
            };
            btn9.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Stupid_A_Bugs_Life);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Stupid_A_Bugs_Life);
                    player.Start();
                }
            };
            btn10.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Tense_The_Usual_Suspects);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Tense_The_Usual_Suspects);
                    player.Start();
                }
            };
            btn11.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Trick_The_Usual_Suspects);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Trick_The_Usual_Suspects);
                    player.Start();
                }
            };
            btn12.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Shut_up_The_Ref);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Shut_up_The_Ref);
                    player.Start();
                }
            };
        }
    }
}