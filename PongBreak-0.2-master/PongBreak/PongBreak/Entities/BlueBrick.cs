﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocosSharp;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
/*BlueBrick inherits the Brick class
 *  and overrides the CCSprite to be a blue brick sprite
 *  instead of green
 */
namespace PongBreak
{
    class BlueBrick : Brick
    {
        CCSprite sprite;
        public BlueBrick()
        {
            BrickSprite();
            AddChild(BrickSprite());
            this.ContentSize = BrickSprite().ContentSize;
        }

        public override CCSprite BrickSprite()
        {
            sprite = new CCSprite("blueBrick.png");
            return sprite;
        }
    }
}