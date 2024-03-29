﻿using System;
using System.Windows.Forms;

namespace TERG.Forms
{
    public partial class InputBox : Form
    {
        private InputBox()
        {
            InitializeComponent();
        }

        public static InputBoxResult Show(string Prompt, string Title, string Default)
        {
            using (InputBox form = new InputBox())
            {
                form.lblText.Text = Prompt;
                form.Text = Title;
                form.txtInput.Text = Default;

                DialogResult dialog = form.ShowDialog();

                InputBoxResult retval = new InputBoxResult();
                if (dialog == DialogResult.OK)
                {
                    retval.OK = true;
                    retval.Text = form.txtInput.Text;
                }
                return retval;
            }
        }

        public static InputBoxResult Show(string Prompt, string Title)
        {
            return InputBox.Show(Prompt, Title, "");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class InputBoxResult
    {
        public bool OK;
        public string Text;
    }
}
