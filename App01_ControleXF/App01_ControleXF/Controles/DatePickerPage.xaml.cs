﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
        }

        private void ActionDateSelected(object sender, DateChangedEventArgs e)
        {
            lblResultado.Text = e.OldDate.ToString("dd/MM/yyyy") + " > " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}