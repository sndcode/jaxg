﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XNAPlatformerLevelEditor
{
    public partial class NewLevelForm : Form
    {
        public bool OKPressed = false;

        public NewLevelForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            OKPressed = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            OKPressed = false;
            Close();
        }

        private void NewLevelForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndint = rnd.Next(1, 99);
            nameTextBox.Text = rndint.ToString();
        }
    }
}
