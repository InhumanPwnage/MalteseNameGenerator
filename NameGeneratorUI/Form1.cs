using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGeneratorUI
{
    public partial class Form1 : Form
    {
        private string[] prefixes;
        private string[] suffixes;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdPrefix.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblPrefix.Text = ofdPrefix.FileName;

                try
                {
                    prefixes = File.ReadAllLines(lblPrefix.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }

                Console.WriteLine("Loaded prefixes from: " + lblPrefix.Text);
            }
        }

        private void btnSuffix_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdSuffix.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblSuffix.Text = ofdSuffix.FileName;

                try
                {
                    suffixes = File.ReadAllLines(lblSuffix.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }

                Console.WriteLine("Loaded suffixes from: " + lblSuffix.Text);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();

                var fullName =
                    $@"{prefixes[r.Next(0, prefixes.Length)]} {suffixes[r.Next(0, suffixes.Length)]}";

                txtResult.Text = fullName;

                Console.WriteLine(fullName);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
