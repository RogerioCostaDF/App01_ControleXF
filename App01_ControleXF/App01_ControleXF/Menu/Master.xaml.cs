﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new Controles.ActivityIndicatorPage();
        }

        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarPage();
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.BoxViewPage();
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new Controles.LabelPage();
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new Controles.ButtonPage ();
        }

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new Controles.EntryEditorPage();
        }

        private void GoDatePickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.DatePickerPage();
        }

        private void GoTimePickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.TimePickerPage();
        }

        private void GoPickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.PickerPage();
        }

        private void GoSearchBarPage(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
        }

        private void GoSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new Controles.SliderStepperPage();
        }
    }
}