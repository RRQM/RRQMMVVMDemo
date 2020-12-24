using RRQMMVVM;
using RRQMMVVMDemo.Views.Windows;
using System;
using System.Windows;
using System.Windows.Media;

namespace RRQMMVVMDemo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            this.MessageCommand = new ExecuteCommand(Message);
        }


        #region 变量
        #endregion


        #region Command
        public ExecuteCommand MessageCommand { get; set; }
        #endregion


        #region 属性
        #endregion


        #region 公共方法 
        [RegistMethod] 
        public void ReturnMessage()
        {
            MessageBox.Show("我是ViewModel");
        }
        #endregion


        #region 绑定方法
        private void Message()
        {
            Messenger.Default.Send("mes","你好");
        }
        #endregion


        #region 事件方法
        #endregion

    }
}
