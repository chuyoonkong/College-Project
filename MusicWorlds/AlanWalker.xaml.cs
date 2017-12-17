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

    public sealed partial class AlanWalker : Page
    {
        MediaPlayer MusicWorld;
        public AlanWalker()
        {
            this.InitializeComponent();
            MusicWorld = new MediaPlayer();
            MusicWorld.Volume = 0.3;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Fade_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Fade.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Faded_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Faded.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Spectre_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Spectre.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Routine_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Routine.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Tired_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Tired.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Alone_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Alone.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Force_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Force.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Singmetosleep_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Alan Walker");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Sing me to sleep.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            MusicWorld.Source = null;
        }

        private void Artist_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Artists));
        }
    }
}
