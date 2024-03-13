﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAherencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nbi = int.Parse(textBox2.Text);

            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("ingresa el numero de bigotes");
            }
            else
            {
                Gato gato = new Gato("milo", 5, nbi);

                textBox1.Text = gato.mostrarGato();
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int lts = int.Parse(textBox3.Text);

            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("ingresa los lts de leche");
            }
            else
            {
                Vaca vaca = new Vaca (textBox4.Text, double.Parse(textBox5.Text) , double.Parse(textBox3.Text));

                textBox1.Text = vaca.mostrarVaca();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
