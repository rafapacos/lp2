﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            frmEx1 frm1 = new frmEx1();
            frm1.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e) {
            frmEx2 frm2 = new frmEx2();
            frm2.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e) {
            frmEx3 frm3 = new frmEx3();
            frm3.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e) {
            frmEx4 frm4 = new frmEx4();
            frm4.Show();
        }
    }
}
