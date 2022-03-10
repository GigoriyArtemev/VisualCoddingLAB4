using System;
using System.Collections.Generic;
using VisualCoddingLAB4;
using System.Text;
using ReactiveUI;
using VisualCoddingLAB4.Models;

namespace VisualCoddingLAB4.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string greeting = "";


        public MainWindowViewModel()
        {
            OnClickCommand = ReactiveCommand.Create<string, string>((str) => Greeting = str);
        }

        public string Greeting
        {
            set
            {
                if (value != "=")
                    this.RaiseAndSetIfChanged(ref greeting, greeting + value);
                else
                {

                }

            }
            get
            {
                return greeting;
            }
        }
        public ReactiveCommand<string, string> OnClickCommand { get; }
    }
}
