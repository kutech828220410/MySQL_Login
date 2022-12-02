namespace MySQL_Login
{
    partial class LoginIndex_CheckBox
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rJ_Lable1 = new MyUI.RJ_Lable();
            this.rJ_CheckBox = new MyUI.RJ_CheckBox();
            this.panel_space = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rJ_Lable1
            // 
            this.rJ_Lable1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Lable1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Lable1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable1.BorderRadius = 5;
            this.rJ_Lable1.BorderSize = 0;
            this.rJ_Lable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_Lable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable1.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable1.Location = new System.Drawing.Point(3, 3);
            this.rJ_Lable1.Name = "rJ_Lable1";
            this.rJ_Lable1.Size = new System.Drawing.Size(151, 30);
            this.rJ_Lable1.TabIndex = 0;
            this.rJ_Lable1.Text = "###########";
            this.rJ_Lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable1.TextColor = System.Drawing.Color.White;
            // 
            // rJ_CheckBox
            // 
            this.rJ_CheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_CheckBox.Location = new System.Drawing.Point(164, 3);
            this.rJ_CheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.rJ_CheckBox.MinimumSize = new System.Drawing.Size(45, 22);
            this.rJ_CheckBox.Name = "rJ_CheckBox";
            this.rJ_CheckBox.OffBackColor = System.Drawing.Color.Gray;
            this.rJ_CheckBox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rJ_CheckBox.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_CheckBox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_CheckBox.Padding = new System.Windows.Forms.Padding(5);
            this.rJ_CheckBox.Size = new System.Drawing.Size(59, 30);
            this.rJ_CheckBox.SolidStyle = true;
            this.rJ_CheckBox.TabIndex = 3;
            this.rJ_CheckBox.UseVisualStyleBackColor = true;
            // 
            // panel_space
            // 
            this.panel_space.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_space.Location = new System.Drawing.Point(154, 3);
            this.panel_space.Name = "panel_space";
            this.panel_space.Size = new System.Drawing.Size(10, 30);
            this.panel_space.TabIndex = 4;
            // 
            // LoginIndex_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rJ_Lable1);
            this.Controls.Add(this.panel_space);
            this.Controls.Add(this.rJ_CheckBox);
            this.Name = "LoginIndex_CheckBox";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(226, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private MyUI.RJ_Lable rJ_Lable1;
        private MyUI.RJ_CheckBox rJ_CheckBox;
        private System.Windows.Forms.Panel panel_space;
    }
}
