namespace TEST_Form
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginUI = new MySQL_Login.LoginUI();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loginIndex_CheckBox1 = new MySQL_Login.LoginIndex_CheckBox();
            this.loginIndex_CheckBox2 = new MySQL_Login.LoginIndex_CheckBox();
            this.loginIndex_Pannel1 = new MySQL_Login.LoginIndex_Pannel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginUI
            // 
            this.loginUI.Level_num = ((uint)(20u));
            this.loginUI.Location = new System.Drawing.Point(21, 12);
            this.loginUI.Login_data_DataBasename = "test03";
            this.loginUI.Login_data_index_DataBasename = "test03";
            this.loginUI.Login_data_index_mySqlSslMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.loginUI.Login_data_index_Password = "66437068";
            this.loginUI.Login_data_index_Port = ((uint)(3306u));
            this.loginUI.Login_data_index_Server = "localhost";
            this.loginUI.Login_data_index_UserName = "user";
            this.loginUI.Login_data_mySqlSslMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.loginUI.Login_data_Password = "66437068";
            this.loginUI.Login_data_Port = ((uint)(3306u));
            this.loginUI.Login_data_Server = "localhost";
            this.loginUI.Login_data_UserName = "user";
            this.loginUI.Name = "loginUI";
            this.loginUI.Size = new System.Drawing.Size(861, 643);
            this.loginUI.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.loginIndex_CheckBox1);
            this.flowLayoutPanel1.Controls.Add(this.loginIndex_CheckBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(550, 684);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 202);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // loginIndex_CheckBox1
            // 
            this.loginIndex_CheckBox1.CheckBox_OffBackColor = System.Drawing.Color.Gray;
            this.loginIndex_CheckBox1.CheckBox_OffToggleColor = System.Drawing.Color.Gainsboro;
            this.loginIndex_CheckBox1.CheckBox_OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginIndex_CheckBox1.CheckBox_OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.loginIndex_CheckBox1.CheckBox_SolidStyle = true;
            this.loginIndex_CheckBox1.CheckBoxWidth = 59;
            this.loginIndex_CheckBox1.Checked = false;
            this.loginIndex_CheckBox1.Index = -1;
            this.loginIndex_CheckBox1.Location = new System.Drawing.Point(3, 3);
            this.loginIndex_CheckBox1.Name = "loginIndex_CheckBox1";
            this.loginIndex_CheckBox1.Padding = new System.Windows.Forms.Padding(3);
            this.loginIndex_CheckBox1.PanelHeight = 29;
            this.loginIndex_CheckBox1.PanelWidth = 269;
            this.loginIndex_CheckBox1.Show_Index = true;
            this.loginIndex_CheckBox1.Size = new System.Drawing.Size(275, 35);
            this.loginIndex_CheckBox1.SpaceWidth = 10;
            this.loginIndex_CheckBox1.TabIndex = 0;
            this.loginIndex_CheckBox1.Title_BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.loginIndex_CheckBox1.Title_BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginIndex_CheckBox1.Title_BorderRadius = 5;
            this.loginIndex_CheckBox1.Title_BorderSize = 0;
            this.loginIndex_CheckBox1.Title_Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginIndex_CheckBox1.Title_TextColor = System.Drawing.Color.White;
            this.loginIndex_CheckBox1.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginIndex_CheckBox1.TitleWidth = 200;
            // 
            // loginIndex_CheckBox2
            // 
            this.loginIndex_CheckBox2.CheckBox_OffBackColor = System.Drawing.Color.Gray;
            this.loginIndex_CheckBox2.CheckBox_OffToggleColor = System.Drawing.Color.Gainsboro;
            this.loginIndex_CheckBox2.CheckBox_OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginIndex_CheckBox2.CheckBox_OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.loginIndex_CheckBox2.CheckBox_SolidStyle = true;
            this.loginIndex_CheckBox2.CheckBoxWidth = 59;
            this.loginIndex_CheckBox2.Checked = false;
            this.loginIndex_CheckBox2.Index = -1;
            this.loginIndex_CheckBox2.Location = new System.Drawing.Point(3, 44);
            this.loginIndex_CheckBox2.Name = "loginIndex_CheckBox2";
            this.loginIndex_CheckBox2.Padding = new System.Windows.Forms.Padding(3);
            this.loginIndex_CheckBox2.PanelHeight = 30;
            this.loginIndex_CheckBox2.PanelWidth = 269;
            this.loginIndex_CheckBox2.Show_Index = true;
            this.loginIndex_CheckBox2.Size = new System.Drawing.Size(275, 36);
            this.loginIndex_CheckBox2.SpaceWidth = 50;
            this.loginIndex_CheckBox2.TabIndex = 1;
            this.loginIndex_CheckBox2.Title_BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.loginIndex_CheckBox2.Title_BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginIndex_CheckBox2.Title_BorderRadius = 5;
            this.loginIndex_CheckBox2.Title_BorderSize = 0;
            this.loginIndex_CheckBox2.Title_Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginIndex_CheckBox2.Title_TextColor = System.Drawing.Color.White;
            this.loginIndex_CheckBox2.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginIndex_CheckBox2.TitleWidth = 160;
            // 
            // loginIndex_Pannel1
            // 
            this.loginIndex_Pannel1.CheckBox_OffBackColor = System.Drawing.Color.Gray;
            this.loginIndex_Pannel1.CheckBox_OffToggleColor = System.Drawing.Color.Gainsboro;
            this.loginIndex_Pannel1.CheckBox_OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginIndex_Pannel1.CheckBox_OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.loginIndex_Pannel1.CheckBox_SolidStyle = true;
            this.loginIndex_Pannel1.CheckBoxWidth = 80;
            this.loginIndex_Pannel1.Index = -1;
            this.loginIndex_Pannel1.Location = new System.Drawing.Point(21, 661);
            this.loginIndex_Pannel1.LoginIndex = ((System.Collections.Generic.List<string>)(resources.GetObject("loginIndex_Pannel1.LoginIndex")));
            this.loginIndex_Pannel1.Name = "loginIndex_Pannel1";
            this.loginIndex_Pannel1.PanelHeight = 40;
            this.loginIndex_Pannel1.PanelWidth = 300;
            this.loginIndex_Pannel1.Show_Index = true;
            this.loginIndex_Pannel1.Size = new System.Drawing.Size(440, 253);
            this.loginIndex_Pannel1.SpaceWidth = 10;
            this.loginIndex_Pannel1.TabIndex = 4;
            this.loginIndex_Pannel1.Title_BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.loginIndex_Pannel1.Title_BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginIndex_Pannel1.Title_BorderRadius = 5;
            this.loginIndex_Pannel1.Title_BorderSize = 0;
            this.loginIndex_Pannel1.Title_Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginIndex_Pannel1.Title_TextColor = System.Drawing.Color.White;
            this.loginIndex_Pannel1.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginIndex_Pannel1.TitleWidth = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 915);
            this.Controls.Add(this.loginIndex_Pannel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginUI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MySQL_Login.LoginUI loginUI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MySQL_Login.LoginIndex_CheckBox loginIndex_CheckBox1;
        private MySQL_Login.LoginIndex_CheckBox loginIndex_CheckBox2;
        private MySQL_Login.LoginIndex_Pannel loginIndex_Pannel1;
    }
}

