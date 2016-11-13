﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_WinForms_Donchenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _buttonText = "button1";

        private void button1_MouseHover(object sender, EventArgs e)
        {
            var button = (Button) sender;
            button.Text = "Hovered";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Text = _buttonText;
        }
    }
}
