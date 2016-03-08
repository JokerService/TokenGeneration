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
            this.groupBox1 = new GroupBox();
            this.txtApiKey = new TextBox();
            this.label1 = new Label();
            this.groupBox2 = new GroupBox();
            this.dtPickerExp = new DateTimePicker();
            this.txtEpocTime = new TextBox();
            this.label5 = new Label();
            this.txtTimeZone = new TextBox();
            this.label4 = new Label();
            this.txtCulture = new TextBox();
            this.label3 = new Label();
            this.txtChannelName = new TextBox();
            this.label2 = new Label();
            this.groupBox3 = new GroupBox();
            this.txtSecret = new TextBox();
            this.label6 = new Label();
            this.groupBox4 = new GroupBox();
            this.txtToken = new TextBox();
            this.btnEncode = new Button();
            this.txtUserName = new TextBox();
            this.label7 = new Label();
            this.txtJson = new TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.Controls.Add(this.txtApiKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(318, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            this.txtApiKey.Location = new Point(102, 28);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new Size(204, 20);
            this.txtApiKey.TabIndex = 1;
            this.txtApiKey.Text = "efood_api";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ApiKey :";
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtPickerExp);
            this.groupBox2.Controls.Add(this.txtEpocTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimeZone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCulture);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtChannelName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(318, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payload";
            this.dtPickerExp.Format = DateTimePickerFormat.Short;
            this.dtPickerExp.Location = new Point(102, 125);
            this.dtPickerExp.Name = "dtPickerExp";
            this.dtPickerExp.Size = new Size(98, 20);
            this.dtPickerExp.TabIndex = 11;
            this.dtPickerExp.ValueChanged += new EventHandler(this.dtPickerExp_ValueChanged);
            this.txtEpocTime.Enabled = false;
            this.txtEpocTime.Location = new Point(206, 125);
            this.txtEpocTime.Name = "txtEpocTime";
            this.txtEpocTime.Size = new Size(100, 20);
            this.txtEpocTime.TabIndex = 10;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "exp";
            this.txtTimeZone.Location = new Point(102, 97);
            this.txtTimeZone.Name = "txtTimeZone";
            this.txtTimeZone.Size = new Size(204, 20);
            this.txtTimeZone.TabIndex = 7;
            this.txtTimeZone.Text = "Europe/Berlin";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TimeZone";
            this.txtCulture.Location = new Point(102, 71);
            this.txtCulture.Name = "txtCulture";
            this.txtCulture.Size = new Size(204, 20);
            this.txtCulture.TabIndex = 5;
            this.txtCulture.Text = "tr-TR";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Culture";
            this.txtChannelName.Location = new Point(102, 45);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new Size(204, 20);
            this.txtChannelName.TabIndex = 3;
            this.txtChannelName.Text = "YS.MVC";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ChannelName";
            this.groupBox3.Controls.Add(this.txtSecret);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new Point(12, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(318, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Secret";
            this.txtSecret.Location = new Point(102, 28);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new Size(204, 20);
            this.txtSecret.TabIndex = 11;
            this.txtSecret.Text = "efood_secret";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Secret Key";
            this.groupBox4.Controls.Add(this.txtJson);
            this.groupBox4.Controls.Add(this.txtToken);
            this.groupBox4.Location = new Point(417, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(318, 313);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "JSON & Token";
            this.txtToken.Location = new Point(18, 156);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new Size(280, 142);
            this.txtToken.TabIndex = 0;
            this.txtToken.Click += new EventHandler(this.SelectAllText);
            this.btnEncode.Location = new Point(336, 131);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new Size(75, 23);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encode ->";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new EventHandler(this.btnEncode_Click);
            this.txtUserName.Location = new Point(102, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new Size(204, 20);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.Text = "mertoztekin";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "UserName";
            this.txtJson.Location = new Point(18, 19);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new Size(280, 131);
            this.txtJson.TabIndex = 1;
            this.txtJson.Click += new EventHandler(this.SelectAllText);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(745, 338);
            base.Controls.Add(this.btnEncode);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "TokenGenerator";
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "JaaS Token Generator";
            base.Load += new EventHandler(this.TokenGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            base.ResumeLayout(false);
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

        private Label label7;

        private TextBox txtJson;
        #endregion
    }
}

