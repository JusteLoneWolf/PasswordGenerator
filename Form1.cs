using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Hide();
            richTextBox1.Clear();
            string chr = "";

            if (Lower.Checked)
            {
                string lower = "abcdefghijklmnopqrstuvwxyz";
                chr = string.Concat(chr,lower);
            }

            if (Upper.Checked)
            {
                string upper = "ABCDEFGHIJKLMOPQRSTYVWXYZ";
                chr = string.Concat(chr,upper);
            }

            if (Nombre.Checked)
            {
                string upper = "1234567890";
                chr = string.Concat(chr,upper);
            }

            if (Special.Checked)
            {
                string upper = "^$%{([])}=+-";
                chr = string.Concat(chr,upper);
            }

            if (textBox1.Text.Length == 0 || textBox1.Text.Contains(" "))
            {
                 MessageBox.Show("Veuillez entrer des chiffres");
            }
            else
            {
                try
                {
                    int length = Int32.Parse(textBox1.Text);

                    if (length >= 1000000)
                    {
                        MessageBox.Show("Chiffre trop grand");
                    }
                    else
                    {
                        int longueur = chr.Length - 1;
                        var chars = new char[length];
                        for (var i = 0; i < length; i++)
                        {
                            chars[i] = chr[random.Next(0, longueur)];
                        }
                        button2.Show();

                        richTextBox1.AppendText(new String(chars)); 
                    }
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Veuillez entrer des chiffre");

                }
            }

        }
        
        

        private void Lower_CheckedChanged(object sender, EventArgs e)
        {
            if (Lower.Checked || Upper.Checked || Nombre.Checked || Special.Checked)
            {
                button1.Show();
            }
            else if(!Lower.Checked && !Upper.Checked && !Nombre.Checked && !Special.Checked)
            {
                button1.Hide();
                button2.Hide();
                richTextBox1.Clear();

            }
            
        }

        private void Upper_CheckedChanged(object sender, EventArgs e)
        {
            if (Lower.Checked || Upper.Checked || Nombre.Checked || Special.Checked)
            {
                button1.Show();
            }
            else if(!Lower.Checked && !Upper.Checked && !Nombre.Checked && !Special.Checked)
            {
                button1.Hide();
                button2.Hide();
                richTextBox1.Clear();

            }
        }

        private void Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (Lower.Checked || Upper.Checked || Nombre.Checked || Special.Checked)
            {
                button1.Show();
            }
            else if(!Lower.Checked && !Upper.Checked && !Nombre.Checked && !Special.Checked)
            {
                button1.Hide();
                button2.Hide();
                richTextBox1.Clear();

            }
        }

        private void Special_CheckedChanged(object sender, EventArgs e)
        {
            if (Lower.Checked || Upper.Checked || Nombre.Checked || Special.Checked)
            {
                button1.Show();
            }
            else if(!Lower.Checked && !Upper.Checked && !Nombre.Checked && !Special.Checked)
            {
                button1.Hide();
                button2.Hide();
                richTextBox1.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, richTextBox1.Text);
            label4.Text = "Sauvegardé ! ";
            label4.ForeColor = Color.Green;
        }
    }
}