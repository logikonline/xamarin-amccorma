﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobile.models.Overlay
{
   public class OverlayDetails
   {
      public OverlayDetails()
      {
         this.BackgroundColor = Color.Default;
         this.HasNavigationBar = true;
         this.HasTabbedBar = false;
         if (Xamarin.Forms.Device.OS == TargetPlatform.Android)
         {
            this.Alpha = 255;
         }
         else
         {
            this.Alpha = 1;
         }
         this.AnimateClosing = false;
      }

      public Xamarin.Forms.Color BackgroundColor { get; set; }

      public bool HasTabbedBar { get; set; }

      public bool HasNavigationBar { get; set; }

      public bool AnimateClosing { get; set; }

      /// <summary>
      /// Android: 0 - 255
      /// iOS: 0 - 1
      /// </summary>
      /// <value>The alpha.</value>
      public float Alpha { get; set; }
   }
}
