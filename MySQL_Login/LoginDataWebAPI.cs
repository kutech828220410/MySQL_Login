using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using Basic;
namespace MySQL_Login
{
    public class LoginDataWebAPI
    {
        public enum enum_login_data
        {
            GUID,
            權限等級,
            Data01,
            Data02,
            Data03,
            Data04,

        }
        public enum enum_login_data_index
        {
            GUID,
            索引,
            Name,
            Type,
        }
        public class Class_login_data
        {
            private MyConvert myConvert = new MyConvert();
            private string _level = "";
            private List<bool> list_data = new List<bool>();

            public string level { get => _level; set => _level = value; }
            public List<bool> data { get => list_data; set => list_data = value; }
            public Class_login_data()
            {
                while (true)
                {
                    if (list_data.Count >= 256) break;
                    list_data.Add(false);
                }
            }
            [JsonIgnore]
            public long data01
            {
                get
                {
                    long value = 0;
                    int index = 0;
                    for (int i = 0; i < 64; i++)
                    {
                        index = i + 0 * 64;
                        if (index < data.Count)
                        {
                            value = myConvert.Int64SetBit(this.data[index], value, i);
                        }
                    }
                    return value;
                }
            }
            [JsonIgnore]
            public long data02
            {
                get
                {
                    long value = 0;
                    int index = 0;
                    for (int i = 0; i < 64; i++)
                    {
                        index = i + 1 * 64;
                        if (index < data.Count)
                        {
                            value = myConvert.Int64SetBit(this.data[index], value, i);
                        }
                    }
                    return value;
                }
            }
            [JsonIgnore]
            public long data03
            {
                get
                {
                    long value = 0;
                    int index = 0;
                    for (int i = 0; i < 64; i++)
                    {
                        index = i + 2 * 64;
                        if (index < data.Count)
                        {
                            value = myConvert.Int64SetBit(this.data[index], value, i);
                        }
                    }
                    return value;
                }
            }
            [JsonIgnore]
            public long data04
            {
                get
                {
                    long value = 0;
                    int index = 0;
                    for (int i = 0; i < 64; i++)
                    {
                        index = i + 3 * 64;
                        if (index < data.Count)
                        {
                            value = myConvert.Int64SetBit(this.data[index], value, i);
                        }
                    }
                    return value;
                }
            }
        }
        public class Class_login_data_index
        {
            private string _索引 = "";
            private string _Name = "";
            private string _Type = "";

            public string 索引 { get => _索引; set => _索引 = value; }
            public string Name { get => _Name; set => _Name = value; }
            public string Type { get => _Type; set => _Type = value; }


            public bool GetTypeBool(enum_login_data_type _enum_Login_Data_Type)
            {
                int type = Type.StringToInt32();
                if (type == -1) return false;
                return myConvert.Int32GetBit(type, (int)_enum_Login_Data_Type);
            }
        }
        static private MyConvert myConvert = new MyConvert();
        static public List<LoginDataWebAPI.Class_login_data> Get_login_data(SQLUI.SQLControl sQLControl)
        {
            List<LoginDataWebAPI.Class_login_data> list_class_Login_Data = new List<Class_login_data>();
            List<object[]> list_value = sQLControl.GetAllRows(null);
            for (int k = 0; k < list_value.Count; k++)
            {
                LoginDataWebAPI.Class_login_data class_Login_Data = null;
                class_Login_Data = new LoginDataWebAPI.Class_login_data();
                class_Login_Data.level = list_value[k][(int)enum_login_data.權限等級].ObjectToString();
                long value = 0;
                long.TryParse(list_value[k][(int)LoginDataWebAPI.enum_login_data.Data01].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 0] = myConvert.Int64GetBit(value, i);
                }
                long.TryParse(list_value[k][(int)LoginDataWebAPI.enum_login_data.Data02].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 64] = myConvert.Int64GetBit(value, i);
                }
                long.TryParse(list_value[k][(int)LoginDataWebAPI.enum_login_data.Data03].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 128] = myConvert.Int64GetBit(value, i);
                }
                long.TryParse(list_value[k][(int)LoginDataWebAPI.enum_login_data.Data04].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 192] = myConvert.Int64GetBit(value, i);
                }
                list_class_Login_Data.Add(class_Login_Data);
            }
            return list_class_Login_Data;

        }
        static public LoginDataWebAPI.Class_login_data Get_login_data(int level, SQLUI.SQLControl sQLControl)
        {
            LoginDataWebAPI.Class_login_data class_Login_Data = null;
            List<object[]> list_value = sQLControl.GetRowsByDefult(null, LoginDataWebAPI.enum_login_data.權限等級.GetEnumName(), level.ToString("00"));
            if (list_value.Count > 0)
            {
                class_Login_Data = new LoginDataWebAPI.Class_login_data();
                class_Login_Data.level = level.ToString("00");
                long value = 0;
                long.TryParse(list_value[0][(int)LoginDataWebAPI.enum_login_data.Data01].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 0] = myConvert.Int64GetBit(value, i);
                }
                long.TryParse(list_value[0][(int)LoginDataWebAPI.enum_login_data.Data02].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 64] = myConvert.Int64GetBit(value, i);
                }
                long.TryParse(list_value[0][(int)LoginDataWebAPI.enum_login_data.Data03].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 128] = myConvert.Int64GetBit(value, i);
                }
                long.TryParse(list_value[0][(int)LoginDataWebAPI.enum_login_data.Data04].ObjectToString(), out value);
                for (int i = 0; i < 64; i++)
                {
                    class_Login_Data.data[i + 192] = myConvert.Int64GetBit(value, i);
                }

            }
            return class_Login_Data;
        }
        static public string Get_login_data_JSONString(int level, SQLUI.SQLControl sQLControl)
        {
            string JSONString = "";
            LoginDataWebAPI.Class_login_data class_Login_Data = Get_login_data(level, sQLControl);
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            if (class_Login_Data == null) return JSONString;
            JSONString = JsonSerializer.Serialize<LoginDataWebAPI.Class_login_data>(class_Login_Data, options);
            return JSONString;
        }
        static public void Set_login_data(Class_login_data class_Login_Data, SQLUI.SQLControl sQLControl)
        {
            int level = class_Login_Data.level.StringToInt32();
            if (level == -1) return;      
            object[] value = new object[new enum_login_data().GetLength()];
            List<object[]> list_value = sQLControl.GetRowsByDefult(null, enum_login_data.權限等級.GetEnumName(), class_Login_Data.level);
            if (list_value.Count == 0) return;
            value[(int)enum_login_data.GUID] = list_value[0][(int)enum_login_data.GUID];
            value[(int)enum_login_data.權限等級] = class_Login_Data.level;
            value[(int)enum_login_data.Data01] = class_Login_Data.data01.ToString();
            value[(int)enum_login_data.Data02] = class_Login_Data.data02.ToString();
            value[(int)enum_login_data.Data03] = class_Login_Data.data03.ToString();
            value[(int)enum_login_data.Data04] = class_Login_Data.data04.ToString();
            sQLControl.UpdateByDefult(null, enum_login_data.GUID.GetEnumName(), value[(int)enum_login_data.GUID].ObjectToString(), value);
        }


        static public List<LoginDataWebAPI.Class_login_data_index> Get_login_data_index(SQLUI.SQLControl sQLControl)
        {
            List<LoginDataWebAPI.Class_login_data_index> list_class_Login_Data_Index = new List<LoginDataWebAPI.Class_login_data_index>();
            List<object[]> list_value = sQLControl.GetAllRows(null);
            list_value.Sort(new ICP_SqL_DataGridView_login_data_index());
            for (int i = 0; i < list_value.Count; i++)
            {
                LoginDataWebAPI.Class_login_data_index class_Login_Data_Index = new LoginDataWebAPI.Class_login_data_index();
                class_Login_Data_Index.Name = list_value[i][(int)LoginDataWebAPI.enum_login_data_index.Name].ObjectToString();
                class_Login_Data_Index.Type = list_value[i][(int)LoginDataWebAPI.enum_login_data_index.Type].ObjectToString();
                class_Login_Data_Index.索引 = list_value[i][(int)LoginDataWebAPI.enum_login_data_index.索引].ObjectToString();

                list_class_Login_Data_Index.Add(class_Login_Data_Index);
            }
            return list_class_Login_Data_Index;
        }
        static public string Get_login_data_index_JSONString(SQLUI.SQLControl sQLControl)
        {
            string JSONString = "";
            List<LoginDataWebAPI.Class_login_data_index> list_class_Login_Data_Index = Get_login_data_index(sQLControl);
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            if (list_class_Login_Data_Index.Count == 0) return JSONString;
            JSONString = JsonSerializer.Serialize<List<LoginDataWebAPI.Class_login_data_index>>(list_class_Login_Data_Index, options);
            return JSONString;
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
    }
}
