﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebapp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs args)
        {
            int n = Convert.ToInt32(textBox1.Text.Length);
            String exp;
            bool pangrama = true;
            for (int i = 0; i < n; i++) {

                exp = textBox1.Text.Trim();
                for (char ascii = 'A'; ascii <= 'Z'; ascii++ )
                {

                    if (!exp.ToUpper().Contains(""+ ascii))
                    {
                        pangrama = false;
                    }
                }
            } ;
            textBox2.Text = (pangrama ? "SI" : "NO");
        }
     

    }
}
