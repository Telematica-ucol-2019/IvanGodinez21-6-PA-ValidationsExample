using App.Models;
using GalaSoft.MvvmLight.Command;
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
    public class FormViewModel : BaseViewModel
    {
        #region Attributes
        private string name;
        private string age;
        #endregion
        #region Properties
        public string inpNameText {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        public string inpAgeText
        {
            get { return this.age; }
            set { SetValue(ref this.age, value); }
        }
        #endregion
        #region Commads
        public ICommand cmdBtnContinue
        {
            get {
                return new RelayCommand(checkValidations);
            }
            set { }
        }
        #endregion
        #region Methods
        private void checkValidations()
        {
            if ((inpNameText != null && inpNameText != "") && (inpAgeText != null && inpAgeText != ""))
            {
                if (inpNameText.ToString().Length < 20 && inpNameText.ToString().Length > 0 && Enumerable.Range(20, 31).Contains(int.Parse(inpAgeText)))
                {
                    Application.Current.MainPage.DisplayAlert("Correct", "Done", "Ok");
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Incorrect", "Fail", "Ok");
                }
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Missing information", "Please fill all the form", "Ok");
            }
        }
        #endregion
        #region Constructor

        #endregion
    }
}