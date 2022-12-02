using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Login
{
    [DefaultEvent("CheckStateChanged")]
    public partial class LoginIndex_CheckBox : UserControl
    {
        public event EventHandler CheckStateChanged;
        [Category("自訂屬性")]
        public Color Title_BackgroundColor
        {
            get
            {
                return rJ_Lable1.BackgroundColor;
            }
            set
            {
                rJ_Lable1.BackgroundColor = value;
            }
        }
        [Category("自訂屬性")]
        public Color Title_BorderColor
        {
            get
            {
                return rJ_Lable1.BorderColor;
            }
            set
            {
                rJ_Lable1.BorderColor = value;
            }
        }
        [Category("自訂屬性")]
        public Color Title_TextColor
        {
            get
            {
                return rJ_Lable1.TextColor;
            }
            set
            {
                rJ_Lable1.TextColor = value;
            }
        }
        [Category("自訂屬性")]
        public Font Title_Font
        {
            get
            {
                return rJ_Lable1.Font;
            }
            set
            {
                rJ_Lable1.Font = value;
            }
        }
        [Category("自訂屬性")]
        public int Title_BorderRadius
        {
            get
            {
                return rJ_Lable1.BorderRadius;
            }
            set
            {
                rJ_Lable1.BorderRadius = value;
            }
        }
        [Category("自訂屬性")]
        public int Title_BorderSize
        {
            get
            {
                return rJ_Lable1.BorderSize;
            }
            set
            {
                rJ_Lable1.BorderSize = value;
            }
        }
        [Category("自訂屬性")]
        public int TitleWidth
        {
            get
            {
                return this.rJ_Lable1.Width;
            }
            set
            {
                this.rJ_Lable1.Width = value;
            }
        }
        [Category("自訂屬性")] 
        public ContentAlignment TitleTextAlignment
        {
            get
            {
                return this.rJ_Lable1.TextAlign;
            }
            set
            {
                this.rJ_Lable1.TextAlign = value;
            }
        }


        [Category("自訂屬性")]
        public int SpaceWidth
        {
            get
            {
                return this.panel_space.Width;
            }
            set
            {
                this.Width = this.rJ_Lable1.Width + value + this.rJ_CheckBox.Width + this.Padding.Size.Width;
                this.panel_space.Width = value;
            }
        }

        [Category("自訂屬性")]
        public Color CheckBox_OffBackColor
        {
            get
            {
                return this.rJ_CheckBox.OffBackColor;
            }
            set
            {
                this.rJ_CheckBox.OffBackColor = value;
            }
        }
        [Category("自訂屬性")]
        public Color CheckBox_OffToggleColor
        {
            get
            {
                return this.rJ_CheckBox.OffToggleColor;
            }
            set
            {
                this.rJ_CheckBox.OffToggleColor = value;
            }
        }
        [Category("自訂屬性")]
        public Color CheckBox_OnBackColor
        {
            get
            {
                return this.rJ_CheckBox.OnBackColor;
            }
            set
            {
                this.rJ_CheckBox.OnBackColor = value;
            }
        }
        [Category("自訂屬性")]
        public Color CheckBox_OnToggleColor
        {
            get
            {
                return this.rJ_CheckBox.OnToggleColor;
            }
            set
            {
                this.rJ_CheckBox.OnToggleColor = value;
            }
        }
        [Category("自訂屬性")]
        public bool CheckBox_SolidStyle
        {
            get
            {
                return this.rJ_CheckBox.SolidStyle;
            }
            set
            {
                this.rJ_CheckBox.SolidStyle = value;
            }
        }
        [Category("自訂屬性")]
        public int CheckBoxWidth
        {
            get
            {
                return this.rJ_CheckBox.Width;
            }
            set
            {
                this.rJ_CheckBox.Width = value;
                //this.Width = this.rJ_Lable1.Width + this.panel_space.Width + value + this.Padding.Size.Width;
            }
        }
        [Category("自訂屬性")]
        public bool Checked
        {
            get
            {
                return rJ_CheckBox.Checked;
            }
            set
            {
                rJ_CheckBox.Checked = value;
            }
        }

        [Category("自訂屬性")]
        public int PanelHeight
        {
            get
            {
                return this.Height - this.Padding.Size.Height;
            }
            set
            {
                this.Height = value + this.Padding.Size.Height;
            }
        }
        public int PanelWidth
        {
            get
            {
                return this.Width - this.Padding.Size.Width;
            }
            set
            {
                this.Width = value + this.Padding.Size.Width;
            }
        }
        [Category("自訂屬性")]
        private int index = -1;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
                Text = Text;
            }
        }
        [Category("自訂屬性")]
        private bool show_index = true;
        public bool Show_Index
        {
            get
            {
                return show_index;
            }
            set
            {
                show_index = value;
            }
        }
        [Category("自訂屬性")]
        private string text = "";
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                if (text == "") text = "##########";
                if (show_index) this.rJ_Lable1.Text = $" {index.ToString("00")}. {value}";
                else this.rJ_Lable1.Text = $"{value}";
            }
        }
        public LoginIndex_CheckBox()
        {
            InitializeComponent();
            this.rJ_CheckBox.CheckStateChanged += RJ_CheckBox_CheckStateChanged;
        }

        private void RJ_CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckStateChanged != null) CheckStateChanged(this, e);
        }
    }
}
