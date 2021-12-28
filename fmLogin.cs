﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Production
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private bool _move;
        private int move_x, move_y;

        private void Label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            txtUsername.Select();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new barcode_dbEntities())
            {
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();
                try
                {

                    var user = db.USERs.Where(m => m.Code == username && m.Password == password).FirstOrDefault();
                    if (user is object)
                    {
                        this.Hide();
                        new ListModel().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Kết nối đến server thất bại !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _move = true;
            move_x = Cursor.Position.X - this.Left;
            move_y = Cursor.Position.Y - this.Top;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _move = false;
        }

        private void TimerCaplock_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lblCapslock.Text = "Caps Lock is on";
            }
            else
            {
                lblCapslock.Text = "";
            }
        }

        private void txtUsername_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.Focus();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move)
            {
                this.Top = Cursor.Position.Y - move_y;
                this.Left = Cursor.Position.X - move_x;
            }
        }
    }
}
