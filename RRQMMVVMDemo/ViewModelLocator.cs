using RRQMMVVM;
using RRQMMVVMDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMMVVMDemo
{
    /*
    若汝棋茗
    */
   public  class ViewModelLocator
    {
        public static MainViewModel MainViewModel { get { return SimpleIoc.Default.GetViewModelInstance<MainViewModel>(); } }
    }
}
