using App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class ExampleViewModel : BaseViewModel
    {
        public ICommand cmdBtnContinueOnClick { get; set; }
        public ICommand cmdInpNameOnTextChanged { get; set; }
        public ExampleViewModel()
        {
        }
    }
}
