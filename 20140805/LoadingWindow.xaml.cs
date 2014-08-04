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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Threading;

namespace Clipcloud
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

   
   
    public partial class LoadingWindow : Window
    {

        private BackgroundWorker mBackgroundWorker = new BackgroundWorker();
        private Clipcloud.ClipboardWindow mClipboardWindow = new Clipcloud.ClipboardWindow();
        public LoadingWindow()
        {
            InitializeComponent();
            mBackgroundWorker.DoWork += mBackgroundWorker_DoWork;
            mBackgroundWorker.RunWorkerCompleted += mBackgroundWorker_RunWorkerCompleted;
            mBackgroundWorker.RunWorkerAsync();
            
        }

        void mBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            mClipboardWindow.InitializeComponent();
            mClipboardWindow.Show();
        }

        void mBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(10000);
        }
    }
}
