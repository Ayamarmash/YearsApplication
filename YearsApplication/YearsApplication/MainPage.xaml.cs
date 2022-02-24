using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YearsApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int x = 1990;
            for (int i = 0; i < 40; i++)
            {
                MyLabel.Text += x.ToString() + " , ";
                x ++;
            }
            MyLabel.Text += x.ToString();
        }
    }
}
