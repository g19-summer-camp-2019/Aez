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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Aez.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SamplePage2 : Page
    {
        public SamplePage2()
        {
            this.InitializeComponent();
        }

        public bool isToSay = true;
        private void SpeechBu_Click(object sender, RoutedEventArgs e)
        {
            if (isToSay)
            {              
                SpeechBu.Content = "我说完了";              
                isToSay = false;               
            }
            else
            {
                Random rd = new Random();
                int socre = rd.Next(100);
                scoreText.Text = socre.ToString();
                SpeechBu.Content = "开始说";
                isToSay = true;
            }
        }
    }
}
