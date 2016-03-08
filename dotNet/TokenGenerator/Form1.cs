using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JWT;

namespace TokenGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEncode_Click(object sender, EventArgs e)
        {
            this.dtPickerExp_ValueChanged(null, null);
            Dictionary<string, object> strs = new Dictionary<string, object>()
            {
                { "ApiKey", this.txtApiKey.Text }
            };
            Dictionary<string, string> strs1 = new Dictionary<string, string>()
            {
                { "UserName", this.txtUserName.Text },
                { "ChannelName", this.txtChannelName.Text },
                { "Culture", this.txtCulture.Text },
                { "TimeZone", this.txtTimeZone.Text },
                { "exp", this.txtEpocTime.Text }
            };
            this.txtJson.Text = JsonWebToken.JsonSerializer.Serialize(strs1);
            this.txtToken.Text = JsonWebToken.Encode(strs, strs1, this.txtSecret.Text, 0);
        }

        private void dtPickerExp_ValueChanged(object sender, EventArgs e)
        {
            TextBox str = this.txtEpocTime;
            DateTime value = this.dtPickerExp.Value;
            TimeSpan universalTime = value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long ınt64 = Convert.ToInt64(universalTime.TotalSeconds);
            str.Text = ınt64.ToString();
        }
        private void SelectAllText(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                ((TextBox)sender).SelectAll();
            }
        }
        private void TokenGenerator_Load(object sender, EventArgs e)
        {
            this.dtPickerExp.Value = DateTime.UtcNow;
        }
    }
   
}
