﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab11MVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleDemo : ContentPage
    {
        public SimpleDemo()
        {
            InitializeComponent();
        }
    }
}