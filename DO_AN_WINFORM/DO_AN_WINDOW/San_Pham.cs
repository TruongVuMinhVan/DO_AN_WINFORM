﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class San_Pham : Form
    {
        public San_Pham()
        {
            InitializeComponent();
            this.TopLevel = false; //hoạt động trong panel
            this.FormBorderStyle = FormBorderStyle.None;// ẩn viền
            this.Dock = DockStyle.Fill;
        }

    }
}