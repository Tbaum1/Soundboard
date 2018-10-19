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
    [Activity(Label = "SamuelActivity")]
    public class SamuelActivity : Android.App.Activity
    {
        Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btnMain;
        protected MediaPlayer player;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_samuel);
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
            btn13 = FindViewById<Button>(Resource.Id.btn13);
            btn14 = FindViewById<Button>(Resource.Id.btn14);
            btn15 = FindViewById<Button>(Resource.Id.btn15);
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
                    player = MediaPlayer.Create(this, Resource.Raw.Did_I_break_your);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Did_I_break_your);
                    player.Start();
                }
            };
            btn2.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Allow_me_to_retort);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw. Allow_me_to_retort);
                    player.Start();
                }
            };
            btn3.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.English_do_you_speak_it2);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.English_do_you_speak_it2);
                    player.Start();
                }
            };
            btn4.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Does_he_look_like_a_bitch);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Does_he_look_like_a_bitch);
                    player.Start();
                }
            };
            btn5.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Fd_up_repugnant_shit);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Fd_up_repugnant_shit);
                    player.Start();
                }
            };
            btn6.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.fonzie);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.fonzie);
                    player.Start();
                }
            };
            btn7.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Hamburgers);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Hamburgers);
                    player.Start();
                }
            };
            btn8.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.I_have_had_Enough);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.I_have_had_Enough);
                    player.Start();
                }
            };
            btn9.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Im_a_mormon);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Im_a_mormon);
                    player.Start();
                }
            };
            btn10.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.One_of_us_made_error);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.One_of_us_made_error);
                    player.Start();
                }
            };
            btn11.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Say_What_Again);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Say_What_Again);
                    player.Start();
                }
            };
            btn12.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Tasty_beverage);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Tasty_beverage);
                    player.Start();
                }
            };
            btn13.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.What_country_you_from);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.What_country_you_from);
                    player.Start();
                }
            };
            btn14.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.You_Cant_Say_no);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.You_Cant_Say_no);
                    player.Start();
                }
            };
            btn15.Click += delegate
            {
                if (player == null)
                {
                    player = MediaPlayer.Create(this, Resource.Raw.Your_ass_aint_talking_your_way);
                    player.Start();
                }
                else
                {
                    player.Reset();
                    player = MediaPlayer.Create(this, Resource.Raw.Your_ass_aint_talking_your_way);
                    player.Start();
                }
            };
        }
    }
}