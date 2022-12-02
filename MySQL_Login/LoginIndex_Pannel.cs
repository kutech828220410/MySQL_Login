using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using Basic;
namespace MySQL_Login
{
    public class LoginIndex_Pannel : UserControl
    {
        private LoginDataWebAPI.Class_login_data Current_class_Login_Data;
        private FlowLayoutPanel panel;
        static private LoginIndex_CheckBox loginIndex_CheckBox = new LoginIndex_CheckBox();
        private LoginIndex_CheckBox[] loginIndex_CheckBoxes = new LoginIndex_CheckBox[256];
        private List<LoginIndex_CheckBox> List_LoginIndex_CheckBox = new List<LoginIndex_CheckBox>();
        #region 自訂屬性
        private List<string> loginIndex = new List<string>();
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        [ReadOnly(false), Browsable(true), Category("自訂屬性"), Description(""), DefaultValue("")]
        public List<string> LoginIndex
        {
            get { return loginIndex; }
            set
            {
                loginIndex = value;            
            }
        }
    
        private Color title_BackgroundColor = loginIndex_CheckBox.Title_BackgroundColor;
        [Category("自訂屬性")]
        public Color Title_BackgroundColor
        {
            get
            {
                return title_BackgroundColor;
            }
            set
            {
                title_BackgroundColor = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Title_BackgroundColor = value;
                }
                this.Refresh();
            }
        }
     
        private Color title_BorderColor = loginIndex_CheckBox.Title_BorderColor;
        [Category("自訂屬性")]
        public Color Title_BorderColor
        {
            get
            {
                return title_BorderColor;
            }
            set
            {
                title_BorderColor = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Title_BorderColor = value;
                }
                this.Refresh();
            }
        }
     
        private Color title_TextColor = loginIndex_CheckBox.Title_TextColor;
        [Category("自訂屬性")]
        public Color Title_TextColor
        {
            get
            {
                return title_TextColor;
            }
            set
            {
                title_TextColor = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Title_TextColor = value;
                }
                this.Refresh();
            }
        }
       
        private Font title_Font = loginIndex_CheckBox.Title_Font;
        [Category("自訂屬性")]
        public Font Title_Font
        {
            get
            {
                return title_Font;
            }
            set
            {
                title_Font = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Title_Font = value;
                }
                this.Refresh();
            }
        }

        private int title_BorderRadius = loginIndex_CheckBox.Title_BorderRadius;
        [Category("自訂屬性")]
        public int Title_BorderRadius
        {
            get
            {
                return title_BorderRadius;
            }
            set
            {
                title_BorderRadius = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Title_BorderRadius = value;
                }
                this.Refresh();
            }
        }

        private int title_BorderSize = loginIndex_CheckBox.Title_BorderSize;
        [Category("自訂屬性")]
        public int Title_BorderSize
        {
            get
            {
                return title_BorderSize;
            }
            set
            {
                title_BorderSize = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Title_BorderSize = value;
                }
                this.Refresh();
            }
        }
    
        private int titleWidth = loginIndex_CheckBox.TitleWidth;
        [Category("自訂屬性")]
        public int TitleWidth
        {
            get
            {
                return titleWidth;
            }
            set
            {
                titleWidth = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].TitleWidth = value;
                }
                this.Refresh();
            }
        }


        private ContentAlignment titleTextAlignment = loginIndex_CheckBox.TitleTextAlignment;
        [Category("自訂屬性")]
        public ContentAlignment TitleTextAlignment
        {
            get
            {
                return titleTextAlignment;
            }
            set
            {
                titleTextAlignment = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].TitleTextAlignment = value;
                }
                this.Refresh();
            }
        }

        private int spaceWidth = loginIndex_CheckBox.SpaceWidth;
        [Category("自訂屬性")]
        public int SpaceWidth
        {
            get
            {
                return spaceWidth;
            }
            set
            {
                spaceWidth = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].SpaceWidth = value;
                }
                this.Refresh();
            }
        }

        private Color checkBox_OffBackColor = loginIndex_CheckBox.CheckBox_OffBackColor;
        [Category("自訂屬性")]
        public Color CheckBox_OffBackColor
        {
            get
            {
                return checkBox_OffBackColor;
            }
            set
            {
                checkBox_OffBackColor = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].CheckBox_OffBackColor = value;
                }
                this.Refresh();
            }
        }
       
        private Color checkBox_OffToggleColor = loginIndex_CheckBox.CheckBox_OffToggleColor;
        [Category("自訂屬性")]
        public Color CheckBox_OffToggleColor
        {
            get
            {
                return checkBox_OffToggleColor;
            }
            set
            {
                checkBox_OffToggleColor = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].CheckBox_OffToggleColor = value;
                }
                this.Refresh();
            }
        }
      
        private Color checkBox_OnBackColor = loginIndex_CheckBox.CheckBox_OnBackColor;
        [Category("自訂屬性")]
        public Color CheckBox_OnBackColor
        {
            get
            {
                return checkBox_OnBackColor;
            }
            set
            {
                checkBox_OnBackColor = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].CheckBox_OnBackColor = value;
                }
                this.Refresh();
            }
        }
       
        private Color checkBox_OnToggleColor = loginIndex_CheckBox.CheckBox_OnToggleColor;
        [Category("自訂屬性")]
        public Color CheckBox_OnToggleColor
        {
            get
            {
                return checkBox_OnToggleColor;
            }
            set
            {
                checkBox_OnToggleColor = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].CheckBox_OnToggleColor = value;
                }
                this.Refresh();
            }
        }
       
        private bool checkBox_SolidStyle = loginIndex_CheckBox.CheckBox_SolidStyle;
        [Category("自訂屬性")]
        public bool CheckBox_SolidStyle
        {
            get
            {
                return checkBox_SolidStyle;
            }
            set
            {
                checkBox_SolidStyle = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].CheckBox_SolidStyle = value;
                }
                this.Refresh();
            }
        }
 
        private int checkBoxWidth = loginIndex_CheckBox.CheckBoxWidth;
        [Category("自訂屬性")]
        public int CheckBoxWidth
        {
            get
            {
                return checkBoxWidth;
            }
            set
            {
                checkBoxWidth = value;
           
                this.Refresh();
            }
        }
 
        private int panelHeight = loginIndex_CheckBox.PanelHeight;
        [Category("自訂屬性")]
        public int PanelHeight
        {
            get
            {
                return panelHeight;
            }
            set
            {
                panelHeight = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].PanelHeight = value;
                }
                this.Refresh();
            }
        }
        private int panelWidth = loginIndex_CheckBox.PanelWidth;
        [Category("自訂屬性")]
        public int PanelWidth
        {
            get
            {
                return panelWidth;
            }
            set
            {
                panelWidth = value;
              
                this.Refresh();
            }
        }
        private int index = loginIndex_CheckBox.Index;
        [Category("自訂屬性")] 
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Index = value;
                }
            }
        }

        private bool show_index = loginIndex_CheckBox.Show_Index;
        [Category("自訂屬性")]
        public bool Show_Index
        {
            get
            {
                return show_index;
            }
            set
            {
                show_index = value;
                for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Show_Index = value;
                }
                this.Refresh();
            }
        }
        #endregion
        public LoginIndex_Pannel()
        {
            this.Init();
        }

        public void Set_Login_Data(LoginDataWebAPI.Class_login_data class_Login_Data)
        {
            this.Current_class_Login_Data = class_Login_Data;
            this.Set_Login_Data(class_Login_Data.data);
        }
        public void Set_Login_Data(List<bool> data)
        {
            this.Invoke(new Action(delegate
            {
                for (int i = 0; i < data.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Checked = data[i];
                }
            }));
        }
        public void Set_Login_Data_Index(List<LoginDataWebAPI.Class_login_data_index> list_Class_login_data_index)
        {
            this.Invoke(new Action(delegate
            {
                for (int i = 0; i < list_Class_login_data_index.Count; i++)
                {
                    List_LoginIndex_CheckBox[i].Index = list_Class_login_data_index[i].索引.StringToInt32();
                    List_LoginIndex_CheckBox[i].Text = list_Class_login_data_index[i].Name;
                    if (list_Class_login_data_index[i].Name == "None" || !list_Class_login_data_index[i].GetTypeBool(enum_login_data_type.windows_permission))
                    {
                        List_LoginIndex_CheckBox[i].Visible = false;
                    }
                    else
                    {
                        List_LoginIndex_CheckBox[i].Visible = true;
                    }
                }
            }));
        }
        public void Set_Login_Data_Index(List<LoginDataWebAPI.Class_login_data_index> list_Class_login_data_index, enum_login_data_type enum_Login_Data_Type)
        {
            this.Set_Login_Data_Index(list_Class_login_data_index);
            this.Invoke(new Action(delegate
            {
                for (int i = 0; i < list_Class_login_data_index.Count; i++)
                {
                    if (!list_Class_login_data_index[i].GetTypeBool(enum_Login_Data_Type))
                    {
                        List_LoginIndex_CheckBox[i].Visible = false;
                    }
                    else
                    {
                        List_LoginIndex_CheckBox[i].Visible = true;
                    }
                }
            }));
        }
        private void Init()
        {
            this.Controls.Clear();
            this.List_LoginIndex_CheckBox.Clear();
            panel = new System.Windows.Forms.FlowLayoutPanel();

            this.SuspendLayout();
            // 
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "flowLayoutPanel1";
            panel.Size = new System.Drawing.Size(this.Width, this.Height);
            panel.TabIndex = 0;
            for (int i = 0; i < loginIndex_CheckBoxes.Length; i++)
            {
                loginIndex_CheckBoxes[i] = new LoginIndex_CheckBox();
                panel.Controls.Add(loginIndex_CheckBoxes[i]);
                loginIndex_CheckBoxes[i].Index = i;
                loginIndex_CheckBoxes[i].Visible = false;
                loginIndex_CheckBoxes[i].Name = $"LoginIndex_CheckBox{i.ToString()}";
                loginIndex_CheckBoxes[i].TabIndex = i + 5;
                loginIndex_CheckBoxes[i].CheckStateChanged += LoginIndex_Pannel_CheckStateChanged;
                this.List_LoginIndex_CheckBox.Add(loginIndex_CheckBoxes[i]);
            }
    
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(panel);
            this.Name = "LoginIndex_Pannel";
            this.Size = new System.Drawing.Size(600, 400);
            panel.ResumeLayout(false);
            this.ResumeLayout(false);

            this.Resize += LoginIndex_Pannel_Resize;


        }

        private void LoginIndex_Pannel_CheckStateChanged(object sender, EventArgs e)
        {
            LoginIndex_CheckBox loginIndex_CheckBox = (LoginIndex_CheckBox)sender;
            if (this.Current_class_Login_Data != null) this.Current_class_Login_Data.data[loginIndex_CheckBox.Index] = loginIndex_CheckBox.Checked;
        }

        public override void Refresh()
        {
            this.SuspendLayout();
            for (int i = 0; i < loginIndex_CheckBoxes.Length; i++)
            {
                loginIndex_CheckBoxes[i].Visible = false;
                loginIndex_CheckBoxes[i].Index = i;
            }
            for (int i = 0; i < List_LoginIndex_CheckBox.Count; i++)
            {
                List_LoginIndex_CheckBox[i].CheckBoxWidth = checkBoxWidth;
                List_LoginIndex_CheckBox[i].PanelWidth = panelWidth;
            }

            for (int i = 0; i < loginIndex.Count; i++)
            {
                int index = loginIndex[i].StringToInt32();

                if (index >= 0)
                {
                    loginIndex_CheckBoxes[index].Visible = true;
                }
            }
  
            panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Invalidate();
            base.Refresh();

        }
        private void LoginIndex_Pannel_Resize(object sender, EventArgs e)
        {
            this.Refresh();            
        }
        
    }
}
