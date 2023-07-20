
namespace AxeraGUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdateInfo = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Panel();
            this.LoginInfo = new System.Windows.Forms.Panel();
            this.injectingbar = new Siticone.UI.WinForms.SiticoneProgressBar();
            this.homescreenextendbutton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.homescreenlicensextend = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.homewelcomemessage = new Siticone.UI.WinForms.SiticoneLabel();
            this.homesep = new Siticone.UI.WinForms.SiticoneVSeparator();
            this.homescreenusername = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.homescreenpassword = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.homescreenlogin = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.homescreenregister = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.Register = new System.Windows.Forms.Panel();
            this.RegisterInfo = new System.Windows.Forms.Panel();
            this.registerwelcomemessage = new Siticone.UI.WinForms.SiticoneLabel();
            this.registersep = new Siticone.UI.WinForms.SiticoneVSeparator();
            this.registerscreenusername = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.registerscreenpassword = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.registerscreenlicense = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.registerscreenregisterbutton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.Download = new System.ComponentModel.BackgroundWorker();
            this.Login.SuspendLayout();
            this.LoginInfo.SuspendLayout();
            this.Register.SuspendLayout();
            this.RegisterInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.UpdateInfo.Location = new System.Drawing.Point(22, 79);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(284, 293);
            this.UpdateInfo.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Login.BackgroundImage = global::AxeraGUI.Properties.Resources.nightsky1;
            this.Login.Controls.Add(this.LoginInfo);
            this.Login.Location = new System.Drawing.Point(-6, 5);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(691, 447);
            this.Login.TabIndex = 1;
            this.Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            // 
            // LoginInfo
            // 
            this.LoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.LoginInfo.Controls.Add(this.injectingbar);
            this.LoginInfo.Controls.Add(this.homescreenextendbutton);
            this.LoginInfo.Controls.Add(this.homescreenlicensextend);
            this.LoginInfo.Controls.Add(this.homewelcomemessage);
            this.LoginInfo.Controls.Add(this.homesep);
            this.LoginInfo.Controls.Add(this.homescreenusername);
            this.LoginInfo.Controls.Add(this.homescreenpassword);
            this.LoginInfo.Controls.Add(this.homescreenlogin);
            this.LoginInfo.Controls.Add(this.homescreenregister);
            this.LoginInfo.Location = new System.Drawing.Point(44, 58);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(608, 314);
            this.LoginInfo.TabIndex = 0;
            // 
            // injectingbar
            // 
            this.injectingbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.injectingbar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.injectingbar.Location = new System.Drawing.Point(343, 189);
            this.injectingbar.Name = "injectingbar";
            this.injectingbar.ProgressColor = System.Drawing.Color.Lime;
            this.injectingbar.ProgressColor2 = System.Drawing.Color.Lime;
            this.injectingbar.ShadowDecoration.Parent = this.injectingbar;
            this.injectingbar.Size = new System.Drawing.Size(255, 30);
            this.injectingbar.TabIndex = 7;
            this.injectingbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.injectingbar.Visible = false;
            // 
            // homescreenextendbutton
            // 
            this.homescreenextendbutton.BackColor = System.Drawing.Color.Transparent;
            this.homescreenextendbutton.BorderColor = System.Drawing.Color.Transparent;
            this.homescreenextendbutton.CheckedState.Parent = this.homescreenextendbutton;
            this.homescreenextendbutton.CustomImages.Parent = this.homescreenextendbutton;
            this.homescreenextendbutton.FillColor = System.Drawing.Color.Green;
            this.homescreenextendbutton.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homescreenextendbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.homescreenextendbutton.HoveredState.Parent = this.homescreenextendbutton;
            this.homescreenextendbutton.Location = new System.Drawing.Point(48, 249);
            this.homescreenextendbutton.Name = "homescreenextendbutton";
            this.homescreenextendbutton.ShadowDecoration.Parent = this.homescreenextendbutton;
            this.homescreenextendbutton.Size = new System.Drawing.Size(250, 30);
            this.homescreenextendbutton.TabIndex = 0;
            this.homescreenextendbutton.Text = "Extend Time";
            this.homescreenextendbutton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.homescreenextendbutton.Click += new System.EventHandler(this.homescreenextendbutton_Click);
            // 
            // homescreenlicensextend
            // 
            this.homescreenlicensextend.BackColor = System.Drawing.Color.Transparent;
            this.homescreenlicensextend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.homescreenlicensextend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.homescreenlicensextend.DefaultText = "";
            this.homescreenlicensextend.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.homescreenlicensextend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.homescreenlicensextend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.homescreenlicensextend.DisabledState.Parent = this.homescreenlicensextend;
            this.homescreenlicensextend.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.homescreenlicensextend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.homescreenlicensextend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.homescreenlicensextend.FocusedState.Parent = this.homescreenlicensextend;
            this.homescreenlicensextend.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.homescreenlicensextend.HoveredState.Parent = this.homescreenlicensextend;
            this.homescreenlicensextend.Location = new System.Drawing.Point(48, 136);
            this.homescreenlicensextend.Name = "homescreenlicensextend";
            this.homescreenlicensextend.PasswordChar = '\0';
            this.homescreenlicensextend.PlaceholderText = "Extend License";
            this.homescreenlicensextend.SelectedText = "";
            this.homescreenlicensextend.ShadowDecoration.Parent = this.homescreenlicensextend;
            this.homescreenlicensextend.Size = new System.Drawing.Size(250, 36);
            this.homescreenlicensextend.TabIndex = 6;
            this.homescreenlicensextend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // homewelcomemessage
            // 
            this.homewelcomemessage.BackColor = System.Drawing.Color.Transparent;
            this.homewelcomemessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.homewelcomemessage.ForeColor = System.Drawing.SystemColors.Control;
            this.homewelcomemessage.Location = new System.Drawing.Point(343, 154);
            this.homewelcomemessage.Name = "homewelcomemessage";
            this.homewelcomemessage.Size = new System.Drawing.Size(115, 27);
            this.homewelcomemessage.TabIndex = 5;
            this.homewelcomemessage.Text = "Welcome To \r\n\r\n";
            // 
            // homesep
            // 
            this.homesep.BackColor = System.Drawing.Color.Transparent;
            this.homesep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.homesep.Location = new System.Drawing.Point(326, 52);
            this.homesep.Name = "homesep";
            this.homesep.Size = new System.Drawing.Size(10, 227);
            this.homesep.TabIndex = 4;
            // 
            // homescreenusername
            // 
            this.homescreenusername.BackColor = System.Drawing.Color.Transparent;
            this.homescreenusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.homescreenusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.homescreenusername.DefaultText = "";
            this.homescreenusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.homescreenusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.homescreenusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.homescreenusername.DisabledState.Parent = this.homescreenusername;
            this.homescreenusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.homescreenusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.homescreenusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.homescreenusername.FocusedState.Parent = this.homescreenusername;
            this.homescreenusername.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.homescreenusername.HoveredState.Parent = this.homescreenusername;
            this.homescreenusername.Location = new System.Drawing.Point(48, 52);
            this.homescreenusername.Name = "homescreenusername";
            this.homescreenusername.PasswordChar = '\0';
            this.homescreenusername.PlaceholderText = "Username";
            this.homescreenusername.SelectedText = "";
            this.homescreenusername.ShadowDecoration.Parent = this.homescreenusername;
            this.homescreenusername.Size = new System.Drawing.Size(250, 36);
            this.homescreenusername.TabIndex = 0;
            this.homescreenusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // homescreenpassword
            // 
            this.homescreenpassword.BackColor = System.Drawing.Color.Transparent;
            this.homescreenpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.homescreenpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.homescreenpassword.DefaultText = "";
            this.homescreenpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.homescreenpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.homescreenpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.homescreenpassword.DisabledState.Parent = this.homescreenpassword;
            this.homescreenpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.homescreenpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.homescreenpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.homescreenpassword.FocusedState.Parent = this.homescreenpassword;
            this.homescreenpassword.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.homescreenpassword.HoveredState.Parent = this.homescreenpassword;
            this.homescreenpassword.Location = new System.Drawing.Point(48, 94);
            this.homescreenpassword.Name = "homescreenpassword";
            this.homescreenpassword.PasswordChar = '\0';
            this.homescreenpassword.PlaceholderText = "Password";
            this.homescreenpassword.SelectedText = "";
            this.homescreenpassword.ShadowDecoration.Parent = this.homescreenpassword;
            this.homescreenpassword.Size = new System.Drawing.Size(250, 36);
            this.homescreenpassword.TabIndex = 1;
            this.homescreenpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // homescreenlogin
            // 
            this.homescreenlogin.BackColor = System.Drawing.Color.Transparent;
            this.homescreenlogin.BorderColor = System.Drawing.Color.Transparent;
            this.homescreenlogin.CheckedState.Parent = this.homescreenlogin;
            this.homescreenlogin.CustomImages.Parent = this.homescreenlogin;
            this.homescreenlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.homescreenlogin.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homescreenlogin.ForeColor = System.Drawing.SystemColors.Control;
            this.homescreenlogin.HoveredState.Parent = this.homescreenlogin;
            this.homescreenlogin.Location = new System.Drawing.Point(48, 178);
            this.homescreenlogin.Name = "homescreenlogin";
            this.homescreenlogin.ShadowDecoration.Parent = this.homescreenlogin;
            this.homescreenlogin.Size = new System.Drawing.Size(250, 30);
            this.homescreenlogin.TabIndex = 2;
            this.homescreenlogin.Text = "Login";
            this.homescreenlogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.homescreenlogin.Click += new System.EventHandler(this.homescreenlogin_Click);
            // 
            // homescreenregister
            // 
            this.homescreenregister.BackColor = System.Drawing.Color.Transparent;
            this.homescreenregister.BorderColor = System.Drawing.Color.Teal;
            this.homescreenregister.CheckedState.Parent = this.homescreenregister;
            this.homescreenregister.CustomImages.Parent = this.homescreenregister;
            this.homescreenregister.FillColor = System.Drawing.Color.Teal;
            this.homescreenregister.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.homescreenregister.ForeColor = System.Drawing.SystemColors.Control;
            this.homescreenregister.HoveredState.Parent = this.homescreenregister;
            this.homescreenregister.Location = new System.Drawing.Point(48, 214);
            this.homescreenregister.Name = "homescreenregister";
            this.homescreenregister.ShadowDecoration.Parent = this.homescreenregister;
            this.homescreenregister.Size = new System.Drawing.Size(250, 30);
            this.homescreenregister.TabIndex = 3;
            this.homescreenregister.Text = "Register";
            this.homescreenregister.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.homescreenregister.Click += new System.EventHandler(this.homescreenregister_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Register.BackgroundImage = global::AxeraGUI.Properties.Resources.nightsky1;
            this.Register.Controls.Add(this.RegisterInfo);
            this.Register.Location = new System.Drawing.Point(-6, 5);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(691, 447);
            this.Register.TabIndex = 2;
            // 
            // RegisterInfo
            // 
            this.RegisterInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.RegisterInfo.Controls.Add(this.registerwelcomemessage);
            this.RegisterInfo.Controls.Add(this.registersep);
            this.RegisterInfo.Controls.Add(this.registerscreenusername);
            this.RegisterInfo.Controls.Add(this.registerscreenpassword);
            this.RegisterInfo.Controls.Add(this.registerscreenlicense);
            this.RegisterInfo.Controls.Add(this.registerscreenregisterbutton);
            this.RegisterInfo.Location = new System.Drawing.Point(44, 58);
            this.RegisterInfo.Name = "RegisterInfo";
            this.RegisterInfo.Size = new System.Drawing.Size(608, 314);
            this.RegisterInfo.TabIndex = 0;
            // 
            // registerwelcomemessage
            // 
            this.registerwelcomemessage.BackColor = System.Drawing.Color.Transparent;
            this.registerwelcomemessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.registerwelcomemessage.ForeColor = System.Drawing.SystemColors.Control;
            this.registerwelcomemessage.Location = new System.Drawing.Point(343, 152);
            this.registerwelcomemessage.Name = "registerwelcomemessage";
            this.registerwelcomemessage.Size = new System.Drawing.Size(208, 31);
            this.registerwelcomemessage.TabIndex = 5;
            this.registerwelcomemessage.Text = "Welcome To Axera";
            // 
            // registersep
            // 
            this.registersep.BackColor = System.Drawing.Color.Transparent;
            this.registersep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.registersep.Location = new System.Drawing.Point(326, 63);
            this.registersep.Name = "registersep";
            this.registersep.Size = new System.Drawing.Size(10, 200);
            this.registersep.TabIndex = 4;
            // 
            // registerscreenusername
            // 
            this.registerscreenusername.BackColor = System.Drawing.Color.Transparent;
            this.registerscreenusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.registerscreenusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.registerscreenusername.DefaultText = "";
            this.registerscreenusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.registerscreenusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.registerscreenusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerscreenusername.DisabledState.Parent = this.registerscreenusername;
            this.registerscreenusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerscreenusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.registerscreenusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registerscreenusername.FocusedState.Parent = this.registerscreenusername;
            this.registerscreenusername.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registerscreenusername.HoveredState.Parent = this.registerscreenusername;
            this.registerscreenusername.Location = new System.Drawing.Point(48, 88);
            this.registerscreenusername.Name = "registerscreenusername";
            this.registerscreenusername.PasswordChar = '\0';
            this.registerscreenusername.PlaceholderText = "Username";
            this.registerscreenusername.SelectedText = "";
            this.registerscreenusername.ShadowDecoration.Parent = this.registerscreenusername;
            this.registerscreenusername.Size = new System.Drawing.Size(250, 36);
            this.registerscreenusername.TabIndex = 0;
            this.registerscreenusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerscreenpassword
            // 
            this.registerscreenpassword.BackColor = System.Drawing.Color.Transparent;
            this.registerscreenpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.registerscreenpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.registerscreenpassword.DefaultText = "";
            this.registerscreenpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.registerscreenpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.registerscreenpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerscreenpassword.DisabledState.Parent = this.registerscreenpassword;
            this.registerscreenpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerscreenpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.registerscreenpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registerscreenpassword.FocusedState.Parent = this.registerscreenpassword;
            this.registerscreenpassword.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registerscreenpassword.HoveredState.Parent = this.registerscreenpassword;
            this.registerscreenpassword.Location = new System.Drawing.Point(48, 130);
            this.registerscreenpassword.Name = "registerscreenpassword";
            this.registerscreenpassword.PasswordChar = '\0';
            this.registerscreenpassword.PlaceholderText = "Password";
            this.registerscreenpassword.SelectedText = "";
            this.registerscreenpassword.ShadowDecoration.Parent = this.registerscreenpassword;
            this.registerscreenpassword.Size = new System.Drawing.Size(250, 36);
            this.registerscreenpassword.TabIndex = 1;
            this.registerscreenpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerscreenlicense
            // 
            this.registerscreenlicense.BackColor = System.Drawing.Color.Transparent;
            this.registerscreenlicense.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.registerscreenlicense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.registerscreenlicense.DefaultText = "";
            this.registerscreenlicense.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.registerscreenlicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.registerscreenlicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerscreenlicense.DisabledState.Parent = this.registerscreenlicense;
            this.registerscreenlicense.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerscreenlicense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.registerscreenlicense.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registerscreenlicense.FocusedState.Parent = this.registerscreenlicense;
            this.registerscreenlicense.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registerscreenlicense.HoveredState.Parent = this.registerscreenlicense;
            this.registerscreenlicense.Location = new System.Drawing.Point(48, 172);
            this.registerscreenlicense.Name = "registerscreenlicense";
            this.registerscreenlicense.PasswordChar = '\0';
            this.registerscreenlicense.PlaceholderText = "License Key";
            this.registerscreenlicense.SelectedText = "";
            this.registerscreenlicense.ShadowDecoration.Parent = this.registerscreenlicense;
            this.registerscreenlicense.Size = new System.Drawing.Size(250, 36);
            this.registerscreenlicense.TabIndex = 6;
            this.registerscreenlicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerscreenregisterbutton
            // 
            this.registerscreenregisterbutton.BackColor = System.Drawing.Color.Transparent;
            this.registerscreenregisterbutton.BorderColor = System.Drawing.Color.Teal;
            this.registerscreenregisterbutton.CheckedState.Parent = this.registerscreenregisterbutton;
            this.registerscreenregisterbutton.CustomImages.Parent = this.registerscreenregisterbutton;
            this.registerscreenregisterbutton.FillColor = System.Drawing.Color.Teal;
            this.registerscreenregisterbutton.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.registerscreenregisterbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerscreenregisterbutton.HoveredState.Parent = this.registerscreenregisterbutton;
            this.registerscreenregisterbutton.Location = new System.Drawing.Point(48, 214);
            this.registerscreenregisterbutton.Name = "registerscreenregisterbutton";
            this.registerscreenregisterbutton.ShadowDecoration.Parent = this.registerscreenregisterbutton;
            this.registerscreenregisterbutton.Size = new System.Drawing.Size(250, 30);
            this.registerscreenregisterbutton.TabIndex = 3;
            this.registerscreenregisterbutton.Text = "Register";
            this.registerscreenregisterbutton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.registerscreenregisterbutton.Click += new System.EventHandler(this.registerscreenregisterbutton_Click);
            // 
            // Download
            // 
            this.Download.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Download_DoWork);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.Login.ResumeLayout(false);
            this.LoginInfo.ResumeLayout(false);
            this.LoginInfo.PerformLayout();
            this.Register.ResumeLayout(false);
            this.RegisterInfo.ResumeLayout(false);
            this.RegisterInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel Update;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Panel LoginInfo;
        private Siticone.UI.WinForms.SiticoneRoundedButton homescreenregister;
        private Siticone.UI.WinForms.SiticoneRoundedButton homescreenlogin;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox homescreenpassword;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox homescreenusername;
        private System.Windows.Forms.Panel UpdateInfo;
        private Siticone.UI.WinForms.SiticoneLabel homewelcomemessage;
        private Siticone.UI.WinForms.SiticoneVSeparator homesep;
        private System.Windows.Forms.Panel Register;
        private System.Windows.Forms.Panel RegisterInfo;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox registerscreenlicense;
        private Siticone.UI.WinForms.SiticoneLabel registerwelcomemessage;
        private Siticone.UI.WinForms.SiticoneVSeparator registersep;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox registerscreenusername;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox registerscreenpassword;
        private Siticone.UI.WinForms.SiticoneRoundedButton registerscreenregisterbutton;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox homescreenlicensextend;
        private Siticone.UI.WinForms.SiticoneRoundedButton homescreenextendbutton;
        private Siticone.UI.WinForms.SiticoneProgressBar injectingbar;
        private System.ComponentModel.BackgroundWorker Download;
    }
}

