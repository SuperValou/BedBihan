using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BedBihanGUI
{
    class MapView : Panel
    {

        // when you click on something
        protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);

        }

        protected override void OnRender(System.Windows.Media.DrawingContext dc)
        {
            System.Diagnostics.Debug.WriteLine("OnRender");

            BitmapImage woodsImg = new BitmapImage();
            woodsImg.BeginInit();
            woodsImg.UriSource = new Uri ("textures/woods.png",UriKind.RelativeOrAbsolute);
            woodsImg.EndInit();
            Rect rectWoods = new Rect(0,0,69,79);
            dc.DrawImage(woodsImg,rectWoods);
            BitmapImage plainImg = new BitmapImage();
            plainImg.BeginInit();
            plainImg.UriSource = new Uri("textures/plain.png", UriKind.RelativeOrAbsolute);
            plainImg.EndInit();
            Rect rectPlain = new Rect(69, 0, 69, 79);
            dc.DrawImage(plainImg, rectPlain);
          
        }


        internal void generateClassic()
        {
            throw new NotImplementedException();
        }

        internal void generateSmall()
        {
            throw new NotImplementedException();
        }

        internal void generateDemo()
        {
            throw new NotImplementedException();
        }
    }
}
