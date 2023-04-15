using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace module2labb
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void DateSelected(object sender, DateChangedEventArgs e)
        {
            int today = DateTime.Now.Year;
            int userDOB = e.NewDate.Year;

            int numOfYearsUntil21 = 21 - (today - userDOB);

            if (numOfYearsUntil21 > 0)
            {
                NumOfYears.Text = numOfYearsUntil21.ToString();
            }
            else
            {
                NumOfYears.Text = "0";
            }

            
        }
    }
}

