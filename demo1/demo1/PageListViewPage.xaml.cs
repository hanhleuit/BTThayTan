﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListViewPage : ContentPage
    {
        

        public PageListViewPage()
        {
            InitializeComponent();

            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.Loaihoas;
        }

        
    }
}
