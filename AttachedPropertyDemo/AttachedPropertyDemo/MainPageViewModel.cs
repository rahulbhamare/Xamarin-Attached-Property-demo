using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AttachedPropertyDemo
{
    public class MainPageViewModel
    {
        //Created a Attached Property with IsAttached name
        public static readonly BindableProperty IsAttachedProperty =
  BindableProperty.CreateAttached("IsAttached", typeof(bool), typeof(MainPage),false);

        //Get IsAttached property value
        public static bool GetIsAttached(BindableObject view)
        {
            return (bool)view.GetValue(IsAttachedProperty);
        }

        //Set IsAttached property value
        public static void SetIsAttached(BindableObject view, bool value)
        {
            view.SetValue(IsAttachedProperty, value);
        }
    }
}
