﻿using System;
using System.Windows.Controls;
using WpfApp1.DataBase;
using WpfApp1.Interfaces;
namespace WpfApp1.Controllers
{
    public partial class Aileron : UserControl , IViewable
    {
        public Aileron()
        {
            InitializeComponent();
        }
        public void Controller_Drag(object sender, EventArgs e)
        {
            Data.aileron_slider_value = (Convert.ToDouble(Aileron_slider.Value.ToString()));
            view();
            Console.WriteLine("Aileron Value: " + Data.aileron_value +" Slider Value: "+ Data.aileron_slider_value);
        }
        public void view()
        {
            Aileron_slider.Value = Data.aileron_slider_value;
        }
    }
}