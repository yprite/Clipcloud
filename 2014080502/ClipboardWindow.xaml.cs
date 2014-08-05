using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Interop;
using System.IO;

using System.Data.SQLite;


namespace Clipcloud
{
    public partial class ClipboardWindow : Window
    {
        #region Private fields

        /// <summary>
        /// Next clipboard viewer window 
        /// </summary>
        private IntPtr hWndNextViewer;

        /// <summary>
        /// The <see cref="HwndSource"/> for this window.
        /// </summary>
        private HwndSource hWndSource;


        // <summary>
        //  DB connection in SQLite3
        // </summary>
        public static SQLiteConnection mConnDB;



        private bool isViewing=false;

        #endregion

        #region .ctor

        public ClipboardWindow()
        {
            InitializeComponent();
            mConnDB = new SQLiteConnection(@"Data Source=ClipcloudDB.s3db");
            mConnDB.Open();
            SQLiteCommand selectCmd = new SQLiteCommand(mConnDB);
            selectCmd.CommandText = @"SELECT captureID, timestamp FROM capture";
            SQLiteDataReader sqlReader = selectCmd.ExecuteReader();
            while (sqlReader.Read()) {
                TextBox mTextBox = new TextBox();
                mTextBox.Text = sqlReader.GetInt32(0).ToString();
                pnlContent.Children.Add(mTextBox);
            }
        }

        #endregion

        #region Clipboard viewer related methods

        private void InitCBViewer()
        {
            WindowInteropHelper wih = new WindowInteropHelper(this);
            hWndSource = HwndSource.FromHwnd(wih.Handle);

            hWndSource.AddHook(this.WinProc);   // start processing window messages
            hWndNextViewer = Win32.SetClipboardViewer(hWndSource.Handle);   // set this window as a viewer
            isViewing = true;
        }

        private void CloseCBViewer()
        {


            //에러처리 함 (20140805--hWndSource.Handle Nullpointerexception 에러)
            if (isViewing == true)
            { 
            // remove this window from the clipboard viewer chain
            Win32.ChangeClipboardChain(hWndSource.Handle, hWndNextViewer);
            
            hWndNextViewer = IntPtr.Zero;
            hWndSource.RemoveHook(this.WinProc);
            pnlContent.Children.Clear();
            isViewing = false;
            }
        }

        private void DrawContent()
        {
            pnlContent.Children.Clear();

            if (Clipboard.ContainsText())
            {
                // we have some text in the clipboard.
                TextBox tb = new TextBox();
                tb.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                tb.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                tb.Text = Clipboard.GetText();
                tb.IsReadOnly = true;
                tb.TextWrapping = TextWrapping.NoWrap;
                pnlContent.Children.Add(tb);
            }
            else if (Clipboard.ContainsFileDropList())
            {
                // we have a file drop list in the clipboard
                ListBox lb = new ListBox();
                lb.ItemsSource = Clipboard.GetFileDropList();
                pnlContent.Children.Add(lb);
            }
            else if (Clipboard.ContainsImage())
            {
                // Because of a known issue in WPF,
                // we have to use a workaround to get correct
                // image that can be displayed.
                // The image have to be saved to a stream and then 
                // read out to workaround the issue.
                MemoryStream ms = new MemoryStream();
                BmpBitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(Clipboard.GetImage()));
                enc.Save(ms);
                ms.Seek(0, SeekOrigin.Begin);

                BmpBitmapDecoder dec = new BmpBitmapDecoder(ms,
                    BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);

                Image img = new Image();
                img.Stretch = Stretch.Uniform;
                img.Source = dec.Frames[0];
                pnlContent.Children.Add(img);
            }
            else
            {
                Label lb = new Label();
                lb.Content = "The type of the data in the clipboard is not supported by this sample.";
                pnlContent.Children.Add(lb);
            }
        }

        private IntPtr WinProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                case Win32.WM_CHANGECBCHAIN:
                    if (wParam == hWndNextViewer)
                    {
                        // clipboard viewer chain changed, need to fix it.
                        hWndNextViewer = lParam;
                    }
                    else if (hWndNextViewer != IntPtr.Zero)
                    {
                        // pass the message to the next viewer.
                        Win32.SendMessage(hWndNextViewer, msg, wParam, lParam);
                    }
                    break;

                case Win32.WM_DRAWCLIPBOARD:
                    // clipboard content changed
                    this.DrawContent();
                    // pass the message to the next viewer.
                    Win32.SendMessage(hWndNextViewer, msg, wParam, lParam);
                    break;
            }

            return IntPtr.Zero;
        }

        #endregion

        #region Control event handlers

        private void btnSwitch_Click(object sender, RoutedEventArgs e)
        {
            // switching between start/stop viewing state
            if (!isViewing)
            {
                this.InitCBViewer();
                btnSwitch.Content = "Stop viewer";
            }
            else
            {
                this.CloseCBViewer();
                btnSwitch.Content = "Start viewer";
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.CloseCBViewer();
        }

        #endregion
    }
}
