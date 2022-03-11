using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.Web.WebView2.Core;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace The_Satan_Records_Audio_Player
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "The Satan Records Audio Player";
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new Windows.Graphics.SizeInt32 { Width = 1080, Height = 650 });
            LoadIcon("tsr-icon.ico");
            gr.Children.Add(web);
            web_load();
        }

        public WebView2 web = new WebView2();

        private void LoadIcon(string iconName)
        {
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var hIcon = PInvoke.User32.LoadImage(System.IntPtr.Zero, iconName,
                      PInvoke.User32.ImageType.IMAGE_ICON, 16, 16, PInvoke.User32.LoadImageFlags.LR_LOADFROMFILE);
            PInvoke.User32.SendMessage(hwnd, PInvoke.User32.WindowMessage.WM_SETICON, (System.IntPtr)0, hIcon);
        }

        private async void web_load()
        {
            Class1 thtml = new Class1();
            string html = thtml.htmlplayer.Replace(@"\", ""); //File.ReadAllText("player.txt");

            await web.EnsureCoreWebView2Async();
            web.NavigateToString(html);
        }
    }
}
