using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TokenGenerator
{
    partial class Form1
    {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAdminAuthenticator = new System.Windows.Forms.RadioButton();
            this.rbUserLogin = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dtPickerExp = new System.Windows.Forms.DateTimePicker();
            this.txtEpocTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeZone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCulture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApiKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(102, 28);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(204, 20);
            this.txtApiKey.TabIndex = 1;
            this.txtApiKey.Text = "efood_api";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ApiKey :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAdminAuthenticator);
            this.groupBox2.Controls.Add(this.rbUserLogin);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.dtPickerExp);
            this.groupBox2.Controls.Add(this.txtEpocTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimeZone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCulture);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtChannelName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payload";
            // 
            // rbAdminAuthenticator
            // 
            this.rbAdminAuthenticator.AutoSize = true;
            this.rbAdminAuthenticator.Location = new System.Drawing.Point(128, 19);
            this.rbAdminAuthenticator.Name = "rbAdminAuthenticator";
            this.rbAdminAuthenticator.Size = new System.Drawing.Size(120, 17);
            this.rbAdminAuthenticator.TabIndex = 14;
            this.rbAdminAuthenticator.Text = "Admin Authenticator";
            this.rbAdminAuthenticator.UseVisualStyleBackColor = true;
            this.rbAdminAuthenticator.CheckedChanged += new System.EventHandler(this.rbAuthenticator_CheckedChanged);
            // 
            // rbUserLogin
            // 
            this.rbUserLogin.AutoSize = true;
            this.rbUserLogin.Checked = true;
            this.rbUserLogin.Location = new System.Drawing.Point(9, 19);
            this.rbUserLogin.Name = "rbUserLogin";
            this.rbUserLogin.Size = new System.Drawing.Size(113, 17);
            this.rbUserLogin.TabIndex = 5;
            this.rbUserLogin.TabStop = true;
            this.rbUserLogin.Text = "User Authenticator";
            this.rbUserLogin.UseVisualStyleBackColor = true;
            this.rbUserLogin.CheckedChanged += new System.EventHandler(this.rbAuthenticator_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(102, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(204, 20);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.Text = "mertoztekin";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 46);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "UserName";
            // 
            // dtPickerExp
            // 
            this.dtPickerExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerExp.Location = new System.Drawing.Point(102, 149);
            this.dtPickerExp.Name = "dtPickerExp";
            this.dtPickerExp.Size = new System.Drawing.Size(98, 20);
            this.dtPickerExp.TabIndex = 11;
            this.dtPickerExp.ValueChanged += new System.EventHandler(this.dtPickerExp_ValueChanged);
            // 
            // txtEpocTime
            // 
            this.txtEpocTime.Enabled = false;
            this.txtEpocTime.Location = new System.Drawing.Point(206, 149);
            this.txtEpocTime.Name = "txtEpocTime";
            this.txtEpocTime.Size = new System.Drawing.Size(100, 20);
            this.txtEpocTime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "exp";
            // 
            // txtTimeZone
            // 
            this.txtTimeZone.Location = new System.Drawing.Point(102, 121);
            this.txtTimeZone.Name = "txtTimeZone";
            this.txtTimeZone.Size = new System.Drawing.Size(204, 20);
            this.txtTimeZone.TabIndex = 7;
            this.txtTimeZone.Text = "Europe/Berlin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TimeZone";
            // 
            // txtCulture
            // 
            this.txtCulture.Location = new System.Drawing.Point(102, 95);
            this.txtCulture.Name = "txtCulture";
            this.txtCulture.Size = new System.Drawing.Size(204, 20);
            this.txtCulture.TabIndex = 5;
            this.txtCulture.Text = "tr-TR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Culture";
            // 
            // txtChannelName
            // 
            this.txtChannelName.Location = new System.Drawing.Point(102, 69);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(204, 20);
            this.txtChannelName.TabIndex = 3;
            this.txtChannelName.Text = "YS.MVC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ChannelName";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSecret);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Secret";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(102, 28);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(204, 20);
            this.txtSecret.TabIndex = 11;
            this.txtSecret.Text = "efood_secret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Secret Key";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtJson);
            this.groupBox4.Controls.Add(this.txtToken);
            this.groupBox4.Location = new System.Drawing.Point(417, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 313);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "JSON & Token";
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(18, 19);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(280, 131);
            this.txtJson.TabIndex = 1;
            this.txtJson.Click += new System.EventHandler(this.SelectAllText);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(18, 156);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(280, 142);
            this.txtToken.TabIndex = 0;
            this.txtToken.Click += new System.EventHandler(this.SelectAllText);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(336, 131);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encode ->";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 338);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JaaS Token Generator";
            this.Load += new System.EventHandler(this.TokenGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        private IContainer components = null;

        private GroupBox groupBox1;

        private TextBox txtApiKey;

        private Label label1;

        private GroupBox groupBox2;

        private Label label5;

        private TextBox txtTimeZone;

        private Label label4;

        private TextBox txtCulture;

        private Label label3;

        private TextBox txtChannelName;

        private Label label2;

        private GroupBox groupBox3;

        private TextBox txtSecret;

        private Label label6;

        private GroupBox groupBox4;

        private TextBox txtToken;

        private Button btnEncode;

        private DateTimePicker dtPickerExp;

        private TextBox txtEpocTime;

        private TextBox txtUserName;

        private Label lblUserName;

        private TextBox txtJson;
        #endregion

        private RadioButton rbUserLogin;
        private RadioButton rbAdminAuthenticator;
    }
}

