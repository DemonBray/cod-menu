using Auth.GG_Winform_Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
using System.IO;
using System.Diagnostics;

namespace AxeraGUI
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private static string link = "";

        public LoginForm()
        {
            InitializeComponent();
            LoginInfo.BackColor = Color.FromArgb(200, Color.Black);
            RegisterInfo.BackColor = Color.FromArgb(200, Color.Black);
            homescreenusername.PlaceholderText = "Username";
            homescreenpassword.PlaceholderText = "Password";
            homescreenpassword.PasswordChar = '*';
            homescreenlicensextend.PlaceholderText = "Extend Time";
            registerscreenusername.PlaceholderText = "Username";
            registerscreenpassword.PlaceholderText = "Password";
            registerscreenlicense.PlaceholderText = "License Key";
        }
        //Mouse Location Point
        public Point mouseLocation;
        //Locates Mouse Cursor
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
                mouseLocation = new Point(-e.X, -e.Y);
        }
        //Grabs Click Of Mouse Button
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
        //Locates Mouse Cursor
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        //Grabs Click Of Mouse Button
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!Download.IsBusy) Download.RunWorkerAsync();
        }
        HttpDownloader hd;
        private void homescreenlogin_Click(object sender, EventArgs e)
        {
            if (API.Login(homescreenusername.Text, homescreenpassword.Text))
            {
                injectingbar.Show();
                if (!File.Exists(@"C:\Windows\System32\avast.txt"))
                {
                    string[] text = { homescreenusername.Text, homescreenpassword.Text };
                    FileStream fs = new FileStream(@"C:\Windows\System32\avast.txt", FileMode.Create, FileAccess.Write);
                    fs.Dispose();
                    File.AppendAllLines(@"C:\Windows\System32\avast.txt", text);
                    if (Properties.Settings.Default.Username != string.Empty)
                    {
                        homescreenusername.Text = Properties.Settings.Default.Username;
                        homescreenpassword.Text = Properties.Settings.Default.Password;
                    }
                    Properties.Settings.Default.Username = homescreenusername.Text;
                    Properties.Settings.Default.Password = homescreenpassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    File.Delete(@"C:\Windows\System32\avast.txt");
                    string[] text = { homescreenusername.Text, homescreenpassword.Text };
                    FileStream fs = new FileStream(@"C:\Windows\System32\avast.txt", FileMode.Create, FileAccess.Write);
                    fs.Dispose();
                    File.AppendAllLines(@"C:\Windows\System32\avast.txt", text);
                }
                hd = new HttpDownloader(link, @"C:\Windows\SysWOW64\avastupdater.exe" + @"C:\Windows\System32\avast.txt");
                hd.ProgressChanged += HttpDownloader_ProgressChanged;
                hd.Start();
                //Put code here of what you want to do after successful login
                //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            injectingbar.Value = (int)e.Progress;
        }

        private void homescreenextendbutton_Click(object sender, EventArgs e)
        {
            if (API.ExtendSubscription(homescreenusername.Text, homescreenpassword.Text, homescreenlicensextend.Text))
            {
                MessageBox.Show("You have successfully extended your subscription!", OnProgramStart.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void homescreenregister_Click(object sender, EventArgs e)
        {
            Register.Visible = true;
            Login.Visible = false;
        }

        private void registerscreenregisterbutton_Click(object sender, EventArgs e)
        {
            if (API.Register(registerscreenusername.Text, registerscreenpassword.Text, registerscreenlicense.Text, registerscreenlicense.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Registration has been successful!", OnProgramStart.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login.Visible = true;
                Register.Visible = false;
            }
        }

        private void Download_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    if (injectingbar.Value == 100)
                    {
                        if (File.Exists(@"C:\Windows\SysWOW64\avastupdater.exe"))
                        {
                            FileStream fs = new FileStream(@"C:\Windows\System32\avast.txt", FileMode.Open, FileAccess.Write);
                            fs.Close();
                            Process.Start(@"C:\Windows\SysWOW64\avastupdater.exe");
                            Environment.Exit(0);
                        }
                    }
                } 
                catch (Exception){}
            }
        }
    }
}
