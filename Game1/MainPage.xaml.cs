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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Game1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Windows.Media.Playback.MediaPlayer _mediaPlayer;

        public MainPage()
        {
            this.InitializeComponent();

            _mediaPlayer = new Windows.Media.Playback.MediaPlayer();
            _mediaPlayer.Source = Windows.Media.Core.MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Kevin_MacLeod_-_Nu_Flute.mp3"));
            // TODO: need to reduce volume on startup
            _mediaPlayer.Play();
        }

        

        private void buttonQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
