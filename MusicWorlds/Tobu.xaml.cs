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

    public sealed partial class Tobu : Page
    {
        MediaPlayer MusicWorld;
        public Tobu()
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

        private async void Hope_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Hope.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Cloud9_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Cloud9.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Sunburst_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Sunburst.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Infectious_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Infectious.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Higher_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Higher.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Candyland_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Candyland.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Life_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Life.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void SuchFun_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Tobu");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("SuchFun.mp3");

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
