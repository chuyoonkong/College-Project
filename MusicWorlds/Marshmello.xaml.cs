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
using Windows.Media.Playback;
using Windows.Media.Core;

namespace MusicWorlds
{

    public sealed partial class Marshmello : Page
    {
        MediaPlayer MusicWorld;
        public Marshmello()
        {
            this.InitializeComponent();
            MusicWorld = new MediaPlayer();
            MusicWorld.Volume = 0.3;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Artist_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Artists));
        }
        private async void Wolves_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Wolves.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Silence_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Silence.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Magic_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Magic.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Summer_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Summer.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Keep_It_Mello_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Keep it mello.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Where_R_U_Now_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Where r u now.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Alone_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Alone.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Ritual_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Marshmallow");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Ritual.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            MusicWorld.Source = null;
        }
    }
}
