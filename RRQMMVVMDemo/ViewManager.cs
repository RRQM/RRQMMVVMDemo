using RRQMMVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMMVVMDemo
{
  public  class ViewManager:IMessageManager
    {
        [RegistMethod]
        public void ShowWindow()
        {
            RRQMSkin.RRQMEffectWindow window = new RRQMSkin.RRQMEffectWindow();
            window.Show();
        }
    }
}
