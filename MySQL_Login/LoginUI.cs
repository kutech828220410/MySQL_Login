using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using MySql.Data.MySqlClient;
using Basic;
using SQLUI;
namespace MySQL_Login
{
    public enum enum_login_data_type
    {
        view,
        add,
        update,
        delete,
        windows_permission,
        web_permission,

        group01 = 10,
        group02 = 11,
        group03 = 12,
        group04 = 13,
        group05 = 14,
    }
    public partial class LoginUI : UserControl
    {
       
       
        #region 自訂屬性
        private string login_data_DataBasename = "";
        private string login_data_UserName = "user";
        private string login_data_Password = "66437068";
        private string login_data_Server = "localhost";
        private uint login_data_Port = 3306;
        private MySql.Data.MySqlClient.MySqlSslMode login_data_mySqlSslMode = MySql.Data.MySqlClient.MySqlSslMode.None;

        [ReadOnly(false), Browsable(true), Category("SQL Congig 1"), Description(""), DefaultValue("")]
        public string Login_data_DataBasename { get => login_data_DataBasename; set => login_data_DataBasename = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 1"), Description(""), DefaultValue("")]
        public string Login_data_UserName { get => login_data_UserName; set => login_data_UserName = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 1"), Description(""), DefaultValue("")]
        public string Login_data_Password { get => login_data_Password; set => login_data_Password = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 1"), Description(""), DefaultValue("")]
        public string Login_data_Server { get => login_data_Server; set => login_data_Server = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 1"), Description(""), DefaultValue("")]
        public uint Login_data_Port { get => login_data_Port; set => login_data_Port = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 1"), Description(""), DefaultValue("")]
        public MySqlSslMode Login_data_mySqlSslMode { get => login_data_mySqlSslMode; set => login_data_mySqlSslMode = value; }

        private string login_data_index_DataBasename = "";
        private string login_data_index_UserName = "user";
        private string login_data_index_Password = "66437068";
        private string login_data_index_Server = "localhost";
        private uint login_data_index_Port = 3306;
        private MySql.Data.MySqlClient.MySqlSslMode login_data_index_mySqlSslMode = MySql.Data.MySqlClient.MySqlSslMode.None;

        [ReadOnly(false), Browsable(true), Category("SQL Congig 2"), Description(""), DefaultValue("")]
        public MySqlSslMode Login_data_index_mySqlSslMode { get => login_data_index_mySqlSslMode; set => login_data_index_mySqlSslMode = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 2"), Description(""), DefaultValue("")]
        public string Login_data_index_DataBasename { get => login_data_index_DataBasename; set => login_data_index_DataBasename = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 2"), Description(""), DefaultValue("")]
        public string Login_data_index_UserName { get => login_data_index_UserName; set => login_data_index_UserName = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 2"), Description(""), DefaultValue("")]
        public string Login_data_index_Password { get => login_data_index_Password; set => login_data_index_Password = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 2"), Description(""), DefaultValue("")]
        public string Login_data_index_Server { get => login_data_index_Server; set => login_data_index_Server = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 2"), Description(""), DefaultValue("")]
        public uint Login_data_index_Port { get => login_data_index_Port; set => login_data_index_Port = value; }
        [ReadOnly(false), Browsable(true), Category("SQL Congig 2"), Description(""), DefaultValue("")]

        private uint level_num = 20;
        [ReadOnly(false), Browsable(true), Category("Login data"), Description(""), DefaultValue("")]
        public uint Level_num { get => level_num; set => level_num = value; }


        #endregion

        public object[] Current_login_data;
        public object[] Current_login_data_index;
        private List<CheckBox> List_CheckBox = new List<CheckBox>();
        private MyConvert myConvert = new MyConvert();

        public LoginUI()
        {
            InitializeComponent();
        }     
        public void Set_login_data_DB(SQL_DataGridView.ConnentionClass connentionClass)
        {
            login_data_DataBasename = connentionClass.DataBaseName;
            login_data_UserName = connentionClass.UserName;
            login_data_Password = connentionClass.Password;
            login_data_Server = connentionClass.IP;
            login_data_Port = connentionClass.Port;
            login_data_mySqlSslMode = connentionClass.MySqlSslMode;
        }
        public void Set_login_data_index_DB(SQL_DataGridView.ConnentionClass connentionClass)
        {
            login_data_index_DataBasename = connentionClass.DataBaseName;
            login_data_index_UserName = connentionClass.UserName;
            login_data_index_Password = connentionClass.Password;
            login_data_index_Server = connentionClass.IP;
            login_data_index_Port = connentionClass.Port;
            login_data_index_mySqlSslMode = connentionClass.MySqlSslMode;
        }
        public void Init()
        {
            this.sqL_DataGridView_login_data.TableName = "login_data";
            this.sqL_DataGridView_login_data_index.TableName = "login_data_index";
            SQLUI.SQL_DataGridView.SQL_Set_Properties(this.sqL_DataGridView_login_data, login_data_DataBasename, login_data_UserName, login_data_Password, login_data_Server, login_data_Port, login_data_mySqlSslMode);
            SQLUI.SQL_DataGridView.SQL_Set_Properties(this.sqL_DataGridView_login_data_index, login_data_index_DataBasename, login_data_index_UserName, login_data_index_Password, login_data_index_Server, login_data_index_Port, login_data_index_mySqlSslMode);

            this.sqL_DataGridView_login_data.Init();
            if(!this.sqL_DataGridView_login_data.SQL_IsTableCreat())
            {
                this.sqL_DataGridView_login_data.SQL_CreateTable();
            }
            this.sqL_DataGridView_login_data_index.Init();
            if (!this.sqL_DataGridView_login_data_index.SQL_IsTableCreat())
            {
                this.sqL_DataGridView_login_data_index.SQL_CreateTable();
            }
            this.sqL_DataGridView_login_data.DataGridRowsChangeEvent += SqL_DataGridView_login_data_DataGridRowsChangeEvent;
            this.sqL_DataGridView_login_data.RowDoubleClickEvent += SqL_DataGridView_login_data_RowDoubleClickEvent;
            this.sqL_DataGridView_login_data.RowEnterEvent += SqL_DataGridView_login_data_RowEnterEvent;

            this.sqL_DataGridView_login_data_index.DataGridRowsChangeEvent += SqL_DataGridView_login_data_index_DataGridRowsChangeEvent;
            this.sqL_DataGridView_login_data_index.RowDoubleClickEvent += SqL_DataGridView_login_data_index_RowDoubleClickEvent;
            this.sqL_DataGridView_login_data_index.RowEnterEvent += SqL_DataGridView_login_data_index_RowEnterEvent;

            this.check_login_data_table();
            this.check_login_data_index_table();
            this.sqL_DataGridView_login_data.SQL_GetAllRows(true);
            this.sqL_DataGridView_login_data_index.SQL_GetAllRows(true);

            this.List_CheckBox.Add(this.checkBox1);
            this.List_CheckBox.Add(this.checkBox2);
            this.List_CheckBox.Add(this.checkBox3);
            this.List_CheckBox.Add(this.checkBox4);
            this.List_CheckBox.Add(this.checkBox5);
            this.List_CheckBox.Add(this.checkBox6);
            this.List_CheckBox.Add(this.checkBox7);
            this.List_CheckBox.Add(this.checkBox8);
            this.List_CheckBox.Add(this.checkBox9);
            this.List_CheckBox.Add(this.checkBox10);
            this.List_CheckBox.Add(this.checkBox11);
            this.List_CheckBox.Add(this.checkBox12);
            this.List_CheckBox.Add(this.checkBox13);
            this.List_CheckBox.Add(this.checkBox14);
            this.List_CheckBox.Add(this.checkBox15);
            this.List_CheckBox.Add(this.checkBox16);
            this.List_CheckBox.Add(this.checkBox17);
            this.List_CheckBox.Add(this.checkBox18);
            this.List_CheckBox.Add(this.checkBox19);
            this.List_CheckBox.Add(this.checkBox20);
            this.List_CheckBox.Add(this.checkBox21);
            this.List_CheckBox.Add(this.checkBox22);
            this.List_CheckBox.Add(this.checkBox23);
            this.List_CheckBox.Add(this.checkBox24);
            this.List_CheckBox.Add(this.checkBox25);
            this.List_CheckBox.Add(this.checkBox26);
            this.List_CheckBox.Add(this.checkBox27);
            this.List_CheckBox.Add(this.checkBox28);
            this.List_CheckBox.Add(this.checkBox29);
            this.List_CheckBox.Add(this.checkBox30);
            this.List_CheckBox.Add(this.checkBox31);
            this.List_CheckBox.Add(this.checkBox32);
            this.List_CheckBox.Add(this.checkBox33);
            this.List_CheckBox.Add(this.checkBox34);
            this.List_CheckBox.Add(this.checkBox35);
            this.List_CheckBox.Add(this.checkBox36);
            this.List_CheckBox.Add(this.checkBox37);
            this.List_CheckBox.Add(this.checkBox38);
            this.List_CheckBox.Add(this.checkBox39);
            this.List_CheckBox.Add(this.checkBox40);
            this.List_CheckBox.Add(this.checkBox41);
            this.List_CheckBox.Add(this.checkBox42);
            this.List_CheckBox.Add(this.checkBox43);
            this.List_CheckBox.Add(this.checkBox44);
            this.List_CheckBox.Add(this.checkBox45);
            this.List_CheckBox.Add(this.checkBox46);
            this.List_CheckBox.Add(this.checkBox47);
            this.List_CheckBox.Add(this.checkBox48);
            this.List_CheckBox.Add(this.checkBox49);
            this.List_CheckBox.Add(this.checkBox50);
            this.List_CheckBox.Add(this.checkBox51);
            this.List_CheckBox.Add(this.checkBox52);
            this.List_CheckBox.Add(this.checkBox53);
            this.List_CheckBox.Add(this.checkBox54);
            this.List_CheckBox.Add(this.checkBox55);
            this.List_CheckBox.Add(this.checkBox56);
            this.List_CheckBox.Add(this.checkBox57);
            this.List_CheckBox.Add(this.checkBox58);
            this.List_CheckBox.Add(this.checkBox59);
            this.List_CheckBox.Add(this.checkBox60);
            this.List_CheckBox.Add(this.checkBox61);
            this.List_CheckBox.Add(this.checkBox62);
            this.List_CheckBox.Add(this.checkBox63);
            this.List_CheckBox.Add(this.checkBox64);
            for (int i = 0; i < this.List_CheckBox.Count; i++)
            {
                this.List_CheckBox[i].CheckedChanged += LoginUI_CheckedChanged;
            }

            this.comboBox_logindata_data.SelectedIndex = 0;
            


        }



        public List<LoginDataWebAPI.Class_login_data> Get_login_data()
        {
            return LoginDataWebAPI.Get_login_data(this.sqL_DataGridView_login_data.GetSQLControl());
        }
        public LoginDataWebAPI.Class_login_data Get_login_data(int level)
        {
            return LoginDataWebAPI.Get_login_data(level, this.sqL_DataGridView_login_data.GetSQLControl());
        }
        public bool Get_login_data_byName(int level ,string name)
        {
            int index = Get_login_data_index_byName(name);
            if (index == -1) return false;
            LoginDataWebAPI.Class_login_data class_Login_Data = Get_login_data(level);
            return class_Login_Data.data[index];
        }
        public int Get_login_data_index_byName(string name)
        {
            int index = -1;
            List<LoginDataWebAPI.Class_login_data_index> list_login_data_index = Get_login_data_index();
            list_login_data_index = (from value in list_login_data_index
                                     where value.Name == name
                                     select value).ToList();
            if (list_login_data_index.Count > 0)
            {
                index = list_login_data_index[0].索引.StringToInt32();
            }
            return index;
        }
        public string Get_login_data_JSONString(int level)
        {
            return LoginDataWebAPI.Get_login_data_JSONString(level, this.sqL_DataGridView_login_data.GetSQLControl()); ;
        }
        public void Set_login_data(LoginDataWebAPI.Class_login_data class_Login_Data)
        {
            LoginDataWebAPI.Set_login_data(class_Login_Data, this.sqL_DataGridView_login_data.GetSQLControl());
        }

        public List<LoginDataWebAPI.Class_login_data_index> Get_login_data_index()
        {
            return LoginDataWebAPI.Get_login_data_index(sqL_DataGridView_login_data_index.GetSQLControl());
        }   
        public string Get_login_data_index_JSONString()
        {
            return LoginDataWebAPI.Get_login_data_index_JSONString(sqL_DataGridView_login_data_index.GetSQLControl());
        }
    
        #region Function
        #region login_data
        private void check_login_data_table()
        {
            List<object[]> list_value = this.sqL_DataGridView_login_data.SQL_GetAllRows(false);
            List<object[]> list_value_buf = new List<object[]>();
            List<object[]> list_value_add = new List<object[]>();
            List<object[]> list_value_replace_Value = new List<object[]>();
            List<string[]> list_value_replace_SerchValue = new List<string[]>();
            List<object[]> list_value_delete = new List<object[]>();
            for (int i = 1; i <= 20; i++)
            {
                list_value_buf = (from value in list_value
                                  where value[(int)LoginDataWebAPI.enum_login_data.權限等級].ObjectToString() == i.ToString("00")
                                  select value).ToList();
                if(list_value_buf.Count == 0)
                {
                    object[] value = new object[LoginDataWebAPI.enum_login_data.GUID.GetEnumNames().Length];
                    value[(int)LoginDataWebAPI.enum_login_data.GUID] = Guid.NewGuid().ToString();
                    value[(int)LoginDataWebAPI.enum_login_data.權限等級] = i.ToString("00");
                    value[(int)LoginDataWebAPI.enum_login_data.Data01] = "0";
                    value[(int)LoginDataWebAPI.enum_login_data.Data02] = "0";
                    value[(int)LoginDataWebAPI.enum_login_data.Data03] = "0";
                    value[(int)LoginDataWebAPI.enum_login_data.Data04] = "0";

                    list_value_add.Add(value);
                }
                else
                {
                    if (list_value_buf[0][(int)LoginDataWebAPI.enum_login_data.GUID].ObjectToString().StringIsEmpty())
                    {
                        list_value_buf[0][(int)LoginDataWebAPI.enum_login_data.GUID] = Guid.NewGuid().ToString();
                        list_value_replace_SerchValue.Add(new string[] { list_value_buf[0][(int)LoginDataWebAPI.enum_login_data.權限等級].ObjectToString() });
                        list_value_replace_Value.Add(list_value_buf[0]);
                    }


                }
            }
            for (int i = 0; i < list_value.Count; i++)
            {
                int value = list_value[i][(int)LoginDataWebAPI.enum_login_data.權限等級].ObjectToString().StringToInt32();
                if (value <= 0 || value > 20) list_value_delete.Add(list_value[i]);
            }
            this.sqL_DataGridView_login_data.SQL_AddRows(list_value_add,false);
            this.sqL_DataGridView_login_data.SQL_ReplaceExtra(new string[] { LoginDataWebAPI.enum_login_data.權限等級.GetEnumName() }, list_value_replace_SerchValue, list_value_replace_Value, false);
            for (int i = 0; i < list_value_delete.Count; i++)
            {
                this.sqL_DataGridView_login_data.SQL_Delete(LoginDataWebAPI.enum_login_data.權限等級.GetEnumName(), list_value_delete[i][(int)LoginDataWebAPI.enum_login_data.權限等級].ObjectToString(), false);
            }
        }
        public class ICP_SqL_DataGridView_login_data : IComparer<object[]>
        {
            public int Compare(object[] value01, object[] value02)
            {
                int index01 = value01[(int)LoginDataWebAPI.enum_login_data.權限等級].ObjectToString().StringToInt32();
                int index02 = value02[(int)LoginDataWebAPI.enum_login_data.權限等級].ObjectToString().StringToInt32();
                if (index01 > index02) return 1;
                else if (index01 < index02) return -1;
                else return 0;
            }
        }
        #endregion
        #region login_data_index
        private void check_login_data_index_table()
        {
            List<object[]> list_value = this.sqL_DataGridView_login_data_index.SQL_GetAllRows(false);
            List<object[]> list_value_buf = new List<object[]>();
            List<object[]> list_value_add = new List<object[]>();
            List<object[]> list_value_replace_Value = new List<object[]>();
            List<string[]> list_value_replace_SerchValue = new List<string[]>();
            List<object[]> list_value_delete = new List<object[]>();

            for (int i = 0; i < 64 * 4; i++)
            {
                list_value_buf = (from value in list_value
                                  where value[(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString() == i.ToString("00")
                                  select value).ToList();
                if (list_value_buf.Count == 0)
                {
                    object[] value = new object[LoginDataWebAPI.enum_login_data_index.GUID.GetEnumNames().Length];
                    value[(int)LoginDataWebAPI.enum_login_data_index.GUID] = Guid.NewGuid().ToString();
                    value[(int)LoginDataWebAPI.enum_login_data_index.索引] = i.ToString("00");
                    value[(int)LoginDataWebAPI.enum_login_data_index.Name] = "None";
                    value[(int)LoginDataWebAPI.enum_login_data_index.Type] = "0";
                    list_value_add.Add(value);
                }
            }
            for (int i = 0; i < list_value.Count; i++)
            {
                int value = list_value[i][(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString().StringToInt32();
                if (value < 0 || value >= 64 * 4) list_value_delete.Add(list_value[i]);
            }

            this.sqL_DataGridView_login_data_index.SQL_AddRows(list_value_add, false);
            this.sqL_DataGridView_login_data_index.SQL_ReplaceExtra(new string[] { LoginDataWebAPI.enum_login_data_index.GUID.GetEnumName() }, list_value_replace_SerchValue, list_value_replace_Value, false);
            for (int i = 0; i < list_value_delete.Count; i++)
            {
                this.sqL_DataGridView_login_data_index.SQL_Delete(LoginDataWebAPI.enum_login_data_index.GUID.GetEnumName(), list_value_delete[i][(int)LoginDataWebAPI.enum_login_data.GUID].ObjectToString(), false);
            }
        }
        public class ICP_SqL_DataGridView_login_data_index : IComparer<object[]>
        {
            public int Compare(object[] value01, object[] value02)
            {
                int index01 = value01[(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString().StringToInt32();
                int index02 = value02[(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString().StringToInt32();
                if (index01 > index02) return 1;
                else if (index01 < index02) return -1;
                else return 0;
            }
        }
        #endregion
        #endregion
        #region Event
        #region login_data
        private void SqL_DataGridView_login_data_index_DataGridRowsChangeEvent(List<object[]> RowsList)
        {
            RowsList.Sort(new ICP_SqL_DataGridView_login_data());
        }
        private void SqL_DataGridView_login_data_DataGridRowsChangeEvent(List<object[]> RowsList)
        {
            RowsList.Sort(new ICP_SqL_DataGridView_login_data_index());
        }
        private void SqL_DataGridView_login_data_RowDoubleClickEvent(object[] RowValue)
        {

        }  
        private void SqL_DataGridView_login_data_RowEnterEvent(object[] RowValue)
        {
            this.Current_login_data = RowValue;
            this.comboBox_logindata_data.SelectedIndex = 0;
            this.comboBox_logindata_data_SelectedIndexChanged(null, new EventArgs());
        }
        private void LoginUI_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            for (int i = 0; i < this.List_CheckBox.Count; i++)
            {
                if (this.List_CheckBox[i].Name == checkBox.Name)
                {
                    int index = comboBox_logindata_data.Text.StringToInt32();
                    long value = 0;
                    if (index == 1)
                    {
                        long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data01].ObjectToString(), out value);
                        value = myConvert.Int64SetBit(checkBox.Checked, value, i);
                        this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data01] = value.ToString();
                    }
                    else if (index == 2)
                    {
                        long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data02].ObjectToString(), out value);
                        value = myConvert.Int64SetBit(checkBox.Checked, value, i);
                        this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data02] = value.ToString();
                    }
                    else if (index == 3)
                    {
                        long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data03].ObjectToString(), out value);
                        value = myConvert.Int64SetBit(checkBox.Checked, value, i);
                        this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data03] = value.ToString();
                    }
                    else if (index == 4)
                    {
                        long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data04].ObjectToString(), out value);
                        value = myConvert.Int64SetBit(checkBox.Checked, value, i);
                        this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data04] = value.ToString();
                    }
                }
            }
        }
        private void comboBox_logindata_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data != null)
            {
                this.rJ_TextBox_login_data_權限等級.Text = this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.權限等級].ObjectToString();
                int index = comboBox_logindata_data.Text.StringToInt32();
                long value = 0;
                if(index == 1)
                {
                    long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data01].ObjectToString(), out value);

                }
                else if (index == 2)
                {
                    long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data02].ObjectToString(), out value);

                }
                else if (index == 3)
                {
                    long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data03].ObjectToString(), out value);

                }
                else if (index == 4)
                {
                    long.TryParse(this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.Data04].ObjectToString(), out value);

                }

                for (int i = 0; i < this.List_CheckBox.Count; i++)
                {
                    this.List_CheckBox[i].Checked = myConvert.Int64GetBit(value, i);
                }
            }
        }
        private void rJ_Button_login_data_寫入_Click(object sender, EventArgs e)
        {
            if (this.Current_login_data != null)
            {
                string GUID = this.Current_login_data[(int)LoginDataWebAPI.enum_login_data.GUID].ObjectToString();
                this.sqL_DataGridView_login_data.SQL_Replace(LoginDataWebAPI.enum_login_data.GUID.GetEnumName(), GUID, this.Current_login_data , true);
                this.rJ_TextBox_login_data_權限等級.Text = "";
                for (int i = 0; i < this.List_CheckBox.Count; i++)
                {
                    this.List_CheckBox[i].Checked = false;
                }
                this.Current_login_data = null;
            }
        }
        private void rJ_Button_login_data_更新_Click(object sender, EventArgs e)
        {
            this.sqL_DataGridView_login_data.SQL_GetAllRows(true);
        }


        #endregion
        #region login_data_index
        private void rJ_Button_login_data_index_匯出_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog_SaveExcel.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = this.sqL_DataGridView_login_data_index.GetDataTable().DeepClone();
                CSVHelper.SaveFile(dataTable, this.saveFileDialog_SaveExcel.FileName);
            }
        }
        private void rJ_Button_login_data_index_匯入_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog_LoadExcel.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = new DataTable();
                CSVHelper.LoadFile(this.openFileDialog_LoadExcel.FileName, 0, dataTable);
                DataTable datatable_buf = dataTable.ReorderTable(new LoginDataWebAPI.enum_login_data_index());
                if (datatable_buf == null)
                {
                    MyMessageBox.ShowDialog("匯入檔案,資料錯誤!");
                    return;
                }
                List<object[]> list_SQL_Value = this.sqL_DataGridView_login_data_index.SQL_GetAllRows(false);
                List<object[]> list_Add = new List<object[]>();
                List<object[]> list_Delete_ColumnName = new List<object[]>();
                List<object[]> list_Delete_SerchValue = new List<object[]>();
                List<string[]> list_Replace_SerchValue = new List<string[]>();
                List<object[]> list_Replace_Value = new List<object[]>();
                List<object[]> list_Value_buf = new List<object[]>();
                foreach (System.Data.DataRow dr in datatable_buf.Rows)
                {
                    object[] src_obj = new string[LoginDataWebAPI.enum_login_data_index.GUID.GetEnumNames().Length];

                    src_obj[(int)LoginDataWebAPI.enum_login_data_index.GUID] = dr[LoginDataWebAPI.enum_login_data_index.GUID.GetEnumName()].ObjectToString();
                    src_obj[(int)LoginDataWebAPI.enum_login_data_index.Name] = dr[LoginDataWebAPI.enum_login_data_index.Name.GetEnumName()].ObjectToString();
                    src_obj[(int)LoginDataWebAPI.enum_login_data_index.Type] = dr[LoginDataWebAPI.enum_login_data_index.Type.GetEnumName()].ObjectToString();
                    src_obj[(int)LoginDataWebAPI.enum_login_data_index.索引] = dr[LoginDataWebAPI.enum_login_data_index.索引.GetEnumName()].ObjectToString();

                    list_Value_buf = (from value in list_SQL_Value
                                      where value[(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString().StringToInt32() == src_obj[(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString().StringToInt32()
                                      select value).ToList();
                    if (list_Value_buf.Count == 0)
                    {

                    }
                    else
                    {
                        list_Value_buf[0][(int)LoginDataWebAPI.enum_login_data_index.Name] = src_obj[(int)LoginDataWebAPI.enum_login_data_index.Name];
                        list_Value_buf[0][(int)LoginDataWebAPI.enum_login_data_index.Type] = src_obj[(int)LoginDataWebAPI.enum_login_data_index.Type];
                        list_Replace_SerchValue.Add((new string[] { list_Value_buf[0][(int)LoginDataWebAPI.enum_login_data_index.GUID].ObjectToString() }));
                        list_Replace_Value.Add(list_Value_buf[0]);
                    }
                }
                this.sqL_DataGridView_login_data_index.SQL_ReplaceExtra(new string[] { LoginDataWebAPI.enum_login_data_index.GUID.GetEnumName() }, list_Replace_SerchValue, list_Replace_Value, false);
                this.sqL_DataGridView_login_data_index.SQL_GetAllRows(true);
            }
        }
        private void SqL_DataGridView_login_data_index_RowDoubleClickEvent(object[] RowValue)
        {

        }
        private void SqL_DataGridView_login_data_index_RowEnterEvent(object[] RowValue)
        {
            this.Current_login_data_index = RowValue;
            this.rJ_TextBox_login_data_index_索引號.Text = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString();
            this.rJ_TextBox_login_data_index_名稱.Text = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Name].ObjectToString();
            int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
            this.checkBox_login_data_index_查詢.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.view);
            this.checkBox_login_data_index_新增.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.add);
            this.checkBox_login_data_index_刪除.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.delete);
            this.checkBox_login_data_index_修改.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.update);
            this.checkBox_login_data_index_Windows權限.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.windows_permission);
            this.checkBox_login_data_index_Web權限.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.web_permission);
            this.checkBox_login_data_index_group01.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.group01);
            this.checkBox_login_data_index_group02.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.group02);
            this.checkBox_login_data_index_group03.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.group03);
            this.checkBox_login_data_index_group04.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.group04);
            this.checkBox_login_data_index_group05.Checked = myConvert.Int32GetBit(TYPE, (int)enum_login_data_type.group05);
        }
        private void rJ_TextBox_login_data_index_名稱_TextChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Name] = rJ_TextBox_login_data_index_名稱.Texts;
            }
        }
        private void checkBox_login_data_index_查詢_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_查詢.Checked, TYPE, (int)enum_login_data_type.view);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        
        }
        private void checkBox_login_data_index_新增_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_新增.Checked, TYPE, (int)enum_login_data_type.add);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
   
        }
        private void checkBox_login_data_index_刪除_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_刪除.Checked, TYPE, (int)enum_login_data_type.delete);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        
        }
        private void checkBox_login_data_index_修改_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_修改.Checked, TYPE, (int)enum_login_data_type.update);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
          
        }
        private void checkBox_login_data_index_Windows權限_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_Windows權限.Checked, TYPE, (int)enum_login_data_type.windows_permission);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        }
        private void checkBox_login_data_index_Web權限_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_Web權限.Checked, TYPE, (int)enum_login_data_type.web_permission);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        }
        private void checkBox_login_data_index_group01_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_group01.Checked, TYPE, (int)enum_login_data_type.group01);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        }
        private void checkBox_login_data_index_group02_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_group02.Checked, TYPE, (int)enum_login_data_type.group02);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        }
        private void checkBox_login_data_index_group03_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_group03.Checked, TYPE, (int)enum_login_data_type.group03);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        }
        private void checkBox_login_data_index_group04_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_group04.Checked, TYPE, (int)enum_login_data_type.group04);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        }
        private void checkBox_login_data_index_group05_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Current_login_data_index != null)
            {
                int TYPE = this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString().StringToInt32();
                TYPE = myConvert.Int32SetBit(checkBox_login_data_index_group05.Checked, TYPE, (int)enum_login_data_type.group05);
                this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.Type] = TYPE.ToString();
            }
        }
        private void rJ_Button_login_data_index_寫入_Click(object sender, EventArgs e)
        {
            if(this.Current_login_data_index != null)
            {
                this.sqL_DataGridView_login_data_index.SQL_Replace(LoginDataWebAPI.enum_login_data_index.GUID.GetEnumName(), this.Current_login_data_index[(int)LoginDataWebAPI.enum_login_data_index.GUID].ObjectToString(), this.Current_login_data_index, true);
            }
     
        }





        #endregion

        #endregion

  
    }
}
