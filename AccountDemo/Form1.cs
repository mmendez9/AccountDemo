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

namespace AccountDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> accounts = new List<int>();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Open the file to set it in the list box
                StreamReader input = File.OpenText("accts.txt");

                string n;
                while (!input.EndOfStream)
                {
                    n = input.ReadLine();
                    int u = int.Parse(n);
                    accounts.Add(u);
                    listAccounts.Items.Add(u);
                }
                input.Close();
                accounts.Sort();
            }
            catch (Exception)
            {
                MessageBox.Show("File doesn't found", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            tbxNewNum.Visible = true;
            btmAdd.Visible = false;
            add.Visible = true;
            cancel.Visible = true;
            btmVer.Visible = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(tbxNewNum.Text, out num))
            {
                if (!accounts.Contains(num)) // Test the number if it is in the list
                {
                    accounts.Add(num); // Add the new number
                    add.Visible = false;
                    cancel.Visible = false;
                    tbxNewNum.Visible = false;
                    btmAdd.Visible = true;
                    btmVer.Visible = true;
                }
                else
                {
                    DialogResult r = MessageBox.Show("Number already in used", "Number Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (r == DialogResult.OK)
                    {
                        tbxNewNum.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Mising or not numeric", "Add New",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            tbxNewNum.Visible = false;
            add.Visible = false;
            cancel.Visible = false;
            btmAdd.Visible = true;
            btmVer.Visible = true;
        }

        private void btmVer_Click(object sender, EventArgs e)
        {
            tbxVerN.Visible = true;
            verify.Visible = true;
            cancelVer.Visible = true;
            btmAdd.Visible = false;
            btmVer.Visible = false;

        }

        private void verify_Click(object sender, EventArgs e)
        {
            int v;
            if (int.TryParse(tbxVerN.Text, out v))
            {
                Verification(v);
            }
            else
            {
                MessageBox.Show("Mising or not numeric", "Add New",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelVer_Click(object sender, EventArgs e)
        {
            btmAdd.Visible = true;
            btmVer.Visible = true;
            tbxVerN.Visible = false;
            verify.Visible = false;
            cancelVer.Visible = false;
        }

        private void btmDel_Click(object sender, EventArgs e)
        {
            btmVer.Visible = false;
            btmDel.Visible = false;
            tbxDelNum.Visible = true;
            DelNum.Visible = true;
            CancelDel.Visible = true;
        }

        private void DelNum_Click(object sender, EventArgs e)
        {
            int d;
            if (int.TryParse(tbxDelNum.Text, out d))
            {
                if (Verification(d) == true)
                {
                    DialogResult r = MessageBox.Show("Are you sure to DELETE the Account Number?", "Account Verification",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int b = int.Parse(tbxDelNum.Text);
                        accounts.Remove(b);
                    }
                }
            }
            else
            {
                MessageBox.Show("Mising or not numeric", "Add New",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Are you sure to CLEAR the list?", "Clear List", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (t == DialogResult.Yes)
            {
                accounts.Clear();
                listAccounts.Refresh();
            }
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            StreamWriter file = File.CreateText("accts.txt");
            foreach (int a in accounts)
            {
                file.WriteLine(a.ToString());
            }
            file.Close();
            Close();
        }

        private bool Verification(int a)
        {
            if (!accounts.Contains(a))
            {
                MessageBox.Show("Account Number does not exist.", "Account Verification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Account Number exits.", "Account Verification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

    }
}
