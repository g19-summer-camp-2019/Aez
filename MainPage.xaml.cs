using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Aez
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
        

        public MainPage()   
        {
            this.InitializeComponent();
        }
        public void Btn_Send_Click(object sender, RoutedEventArgs e)
        {

        }       
    }

    //to confirm that using microphone is permitted
    public class AudioCapturePermissions
    {
        // If no microphone is present, an exception is thrown with the following HResult value.
        private static int NoCaptureDevicesHResult = -1072845856;

        /// <summary>
        /// Note that this method only checks the Settings->Privacy->Microphone setting, it does not handle
        /// the Cortana/Dictation privacy check.
        ///
        /// You should perform this check every time the app gets focus, in case the user has changed
        /// the setting while the app was suspended or not in focus.
        /// </summary>
        /// <returns>True, if the microphone is available.</returns>
        public async static Task<bool> RequestMicrophonePermission()
        {
            try
            {
                // Request access to the audio capture device.
                MediaCaptureInitializationSettings settings = new MediaCaptureInitializationSettings();
                settings.StreamingCaptureMode = StreamingCaptureMode.Audio;
                settings.MediaCategory = MediaCategory.Speech;
                MediaCapture capture = new MediaCapture();

                await capture.InitializeAsync(settings);
            }
            catch (TypeLoadException)
            {
                // Thrown when a media player is not available.
                var messageDialog = new Windows.UI.Popups.MessageDialog("Media player components are unavailable.");
                await messageDialog.ShowAsync();
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                // Thrown when permission to use the audio capture device is denied.
                // If this occurs, show an error or disable recognition functionality.
                return false;
            }
            catch (Exception exception)
            {
                // Thrown when an audio capture device is not present.
                if (exception.HResult == NoCaptureDevicesHResult)
                {
                    var messageDialog = new Windows.UI.Popups.MessageDialog("No Audio Capture devices are present on this system.");
                    await messageDialog.ShowAsync();
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }
    }
}
