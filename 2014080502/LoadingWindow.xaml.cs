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
    /// LoadingWindow.xaml에 대한 상호 작용 논리
    /// 
    /// </summary>
    /// 

   
   
    public partial class LoadingWindow : Window
    {
        #region BackgroundWorker
        //BackgroundWorker 변수 정의
        private BackgroundWorker mBackgroundWorker = new BackgroundWorker();
        #endregion
        #region MainWindow
        //MainWinodw 변수 (객체 생성)
        private Clipcloud.ClipboardWindow mClipboardWindow = new Clipcloud.ClipboardWindow();
        #endregion
        public LoadingWindow()
        {
            InitializeComponent();

            //작업표시줄 가리기(안뜨게 하기)
            this.ShowInTaskbar = false;

            //BackgroundWorker는 백그라운드에서 동작 하는 쓰레드 (C# or WPF 에서 제공함 : Netframework 4.5 버젼 이상에서)
            #region BackgroundWorker 
            //이벤트 정의
            mBackgroundWorker.DoWork += mBackgroundWorker_DoWork;
            mBackgroundWorker.RunWorkerCompleted += mBackgroundWorker_RunWorkerCompleted;
            mBackgroundWorker.RunWorkerAsync();
            #endregion

        }
        #region Background Function
        //callback 함수 오버라이딩
        //_RunWorkerCompleted   : 동작완료후 기능 선언
        //_DoWork               : 동작 중 기능 선언
        void mBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            mClipboardWindow.InitializeComponent();
            mClipboardWindow.Show();
        }

        void mBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
        }
        #endregion
    }
}
