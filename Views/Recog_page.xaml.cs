using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using Aez.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Aez.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Recog_page : Page
    {
        public Recog_page()
        {
            this.InitializeComponent();
        }
        public bool isCat = true;
        public void Btn_Send_Click(object sender, RoutedEventArgs e)
        {
            string inputAni = Tb_Answer.Text;

            if (isCat)
            {
                if (inputAni == "cat")
                {
                    OutPutText.Text = "恭喜您答对了";
                }
                else
                {
                    OutPutText.Text = "您答错了，上张是猫，这张是什么？";
                }
            }
            else
            {
                if (inputAni == "dog")
                {
                    OutPutText.Text = "恭喜您答对了";
                }
                else
                {
                    OutPutText.Text = "您答错了，上张是狗，这张是什么？";
                }
            }

            Random rd = new Random();
            int x = rd.Next();
            isCat = (x % 5 == 0);

            if (!isCat)
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.UriSource = new Uri("ms-appx:Assets/dog2.jpg");
                AniType.Source = bi3;
            }
            else
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.UriSource = new Uri("ms-appx:Assets/cat1.jpg");
                AniType.Source = bi3;
            }
        }
    }
}
