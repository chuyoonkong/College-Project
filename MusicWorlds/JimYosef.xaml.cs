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

    public sealed partial class JimYosef : Page
    {
        MediaPlayer MusicWorld;
        public JimYosef()
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

        private async void Eclipse_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Eclipse.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Firefly_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Firefly.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Cant_Wait_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Cant Wait.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Forces_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Forces.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Arrow_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Arrow.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Canary_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Canary.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Lights_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Lights.mp3");

            MusicWorld.AutoPlay = false;
            MusicWorld.Source = MediaSource.CreateFromStorageFile(file);

            MusicWorld.Play();
        }

        private async void Miracle_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Jin Yosef");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Miracle.mp3");

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
