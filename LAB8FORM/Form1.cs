using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8FORM
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// class properties 
        /// </summary>
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        ///    this is the constructor for lab 8
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserName = txtName.Text;
            UserAge = float.Parse(txtAge.Text);
            lblresult.Text = "Name:"+txtName.Text +"  "+ "Age:"+ txtAge.Text;

            ClearForm();

        }
        /// <summary>
        ///     this method is clear the form
        /// </summary>
        private void ClearForm()
        {
            txtName.Clear();
            txtAge.Clear();
            btnSubmit.Enabled = false;
        }

        /// <summary>
        /// this is the event handler for the name text change event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = (txtName.Text.Length < 2) ? false : true;
        }
        /// <summary>
        /// this event handler for the agetxt 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UserAge = float.Parse(txtAge.Text);
                btnSubmit.Enabled = true;
            }
            catch
            {

                btnSubmit.Enabled = false;
            }

        }
        /// <summary>
        /// this is the form load handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();

            
        }
    }
}
