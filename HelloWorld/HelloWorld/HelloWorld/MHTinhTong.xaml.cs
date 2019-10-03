using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MHTinhTong : ContentPage
    {
        public MHTinhTong()
        {
            InitializeComponent();
        }
        private void cmdTinhTong_Clicked(object sender, EventArgs e)
        {
            double soA, soB, tong;
            soA = double.Parse(txtsoA.Text);
            soB = double.Parse(txtsoB.Text);
            tong = soA + soB;
            txtSum.Text = tong.ToString();

        }
        private void cmdGoHom_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
