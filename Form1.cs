using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Query
{
    public partial class Form1 : Form
    {
        static string sqlConnectBD = "Data Source=DESKTOP-E1M45QQ\\SQLEXPRESS;Initial Catalog=BD;Integrated Security=True";
        static string sqlConnectNEW = "Data Source=DESKTOP-E1M45QQ\\SQLEXPRESS;Initial Catalog=NEW;Integrated Security=True";
        static List<string[]> tables;
        static List<string[]> attributes;
        static List<string[]> attributesAll;
        static string attr = "select ";
        static string firstTabl = " from ";
        static string join = "";
        static string where = "";
        static int attrNum = 0;
        static int tabControlindex = 0;

        public Form1()
        {
            InitializeComponent();

            LoadTables();
            listBoxJoin.SelectedIndex = 0;
            listBoxSign.SelectedIndex = 0;
            listBoxFunct.SelectedIndex = 2;
        }
        private void LoadTables()
        {
            SqlConnection myConnection = new SqlConnection(sqlConnectBD);
            myConnection.Open();
            string query = "select * from Tables;";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            tables = new List<string[]>();
            while (reader.Read())
            {
                tables.Add(new string[2]);
                tables[tables.Count - 1][0] = reader[0].ToString();
                tables[tables.Count - 1][1] = reader[1].ToString();
            }
            reader.Close();
            myConnection.Close();

            listBoxTables.Items.Clear();
            foreach (string[] s in tables)
                listBoxTables.Items.Add(s[0]);
        }

        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttributesForTable();

        }
        private void LoadAttributesForTable()
        {
            SqlConnection myConnection = new SqlConnection(sqlConnectBD);
            myConnection.Open();
            string query = "select Attribute_name,type,table_name from Attributes inner join Tables on Tables.id = Attributes.id_table"
                + $" where table_name='{listBoxTables.SelectedItem}';";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            attributes = new List<string[]>();
            while (reader.Read())
            {
                attributes.Add(new string[3]);
                attributes[attributes.Count - 1][0] = reader[0].ToString();
                attributes[attributes.Count - 1][1] = reader[1].ToString();
                attributes[attributes.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            myConnection.Close();

            checkedListBoxAttributes.Items.Clear();
            foreach (string[] s in attributes)
                checkedListBoxAttributes.Items.Add(s[0]);

        }
        private void GetFirstSelect()
        {
            foreach (int checkedInd in checkedListBoxAttributes.CheckedIndices)
            {
                attr += $"{attributes[checkedInd][2]}.{attributes[checkedInd][0]},";
                dataGridViewQuery.Columns.Add("1", $"{attributes[checkedInd][2]}.{attributes[checkedInd][0]}");
                attrNum++;
            }
            attr=attr.Substring(0,attr.Length - 1);
            firstTabl += listBoxTables.SelectedItem.ToString();
            
        }

        private void buttonFirstTable_Click(object sender, EventArgs e)
        {
           
            if (checkedListBoxAttributes.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Выберите атрибуты");
            }
            else
            {
                GetFirstSelect();
                attributesAll = new List<string[]>();
                foreach (string[] mas in attributes)
                {
                    attributesAll.Add(new string[mas.Length]);
                    attributesAll[attributesAll.Count - 1][0] = mas[0];
                    attributesAll[attributesAll.Count - 1][1] = mas[1];
                    attributesAll[attributesAll.Count - 1][2] = mas[2];
                }
                if (checkBoxUseJoin.Checked)
                {
                    tabControlindex = 1;
                    tabControlQuery.SelectedIndex = 1;

                    listBoxTablesJoin.Items.Clear();
                    foreach (string[] s in tables)
                        if(s[0]!= listBoxTables.SelectedItem.ToString()) listBoxTablesJoin.Items.Add(s[0]);

                    listBoxAttr1.Items.Clear();
                    foreach (string[] s in attributesAll)
                    {
                        listBoxAttr1.Items.Add($"{s[2]}.{s[0]}"); 
                    }
                    
                }
                else
                {
                    tabControlindex = 3;
                    tabControlQuery.SelectedIndex = 3;              
                    GetQuery();
                }
            }
            textBoxQuery1.Text = attr + firstTabl + join + where ;
        }
        private void GetQuery()
        {
            SqlConnection myConnection = new SqlConnection(sqlConnectNEW);
            myConnection.Open();
            string query = attr+firstTabl+join+where+";";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> queryDGV = new List<string[]>();
            while (reader.Read())
            {
                queryDGV.Add(new string[attrNum]);
                for(int i=0;i<attrNum;i++)
                   queryDGV[queryDGV.Count - 1][i] = reader[i].ToString();
               
            }
            reader.Close();
            myConnection.Close();

            foreach (string[] s in queryDGV)
                dataGridViewQuery.Rows.Add(s);
        }

        private void tabControlQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlQuery.SelectedIndex!=tabControlindex)
            {
                MessageBox.Show("Используйте кнопки");
                tabControlQuery.SelectedIndex = tabControlindex;
            }
          
        }

        private void textBoxQuery1_TextChanged(object sender, EventArgs e)
        {
            textBoxQuery2.Text = textBoxQuery1.Text;
            textBoxQuery3.Text = textBoxQuery1.Text;
        }

        private void listBoxTablesJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttributesForTableJoin();
        }
        private void LoadAttributesForTableJoin()
        {
            SqlConnection myConnection = new SqlConnection(sqlConnectBD);
            myConnection.Open();
            string query = "select Attribute_name,type,table_name from Attributes inner join Tables on Tables.id = Attributes.id_table"
                + $" where table_name='{listBoxTablesJoin.SelectedItem}';";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            attributes = new List<string[]>();
            while (reader.Read())
            {
                attributes.Add(new string[3]);
                attributes[attributes.Count - 1][0] = reader[0].ToString();
                attributes[attributes.Count - 1][1] = reader[1].ToString();
                attributes[attributes.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            myConnection.Close();

            checkedListBoxAttributesJoin.Items.Clear();
            listBoxAttr2.Items.Clear();
            foreach (string[] s in attributes)
            {
                checkedListBoxAttributesJoin.Items.Add(s[0]);
                listBoxAttr2.Items.Add(s[0]);
            }

        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            Cancelation();
        }
        private void Cancelation()
        {
            attr = "select ";
            firstTabl = " from ";
            join = "";
            where = "";
            attrNum = 0;
            tabControlindex = 0;
            tabControlQuery.SelectedIndex = 0;
            textBoxQuery1.Text = "";
            LoadAttributesForTable();
        }

        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            Cancelation();
        }

        private void buttonCancel3_Click(object sender, EventArgs e)
        {
            Cancelation();
        }

        private void buttonToConditionals_Click(object sender, EventArgs e)
        {
            tabControlindex = 2;
            tabControlQuery.SelectedIndex = 2;
            foreach (string[] s in attributesAll)
            {
                listBoxAttrConditional.Items.Add($"{s[2]}.{s[0]}");
            }
        }

     

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            if (listBoxTablesJoin.SelectedItem==null || listBoxAttr1.SelectedItem==null  || listBoxAttr2.SelectedItem == null)
            {
                MessageBox.Show("Выберите атрибуты");
            }
            else
            {
                if (attributesAll[listBoxAttr1.SelectedIndex][1] != attributes[listBoxAttr2.SelectedIndex][1]) MessageBox.Show("Типы связанных атрибутов не совпадают");
                else
                {
                    GetJoin();

                    foreach (string[] mas in attributes)
                    {
                        attributesAll.Add(new string[mas.Length]);
                        for (int i = 0; i < mas.Length; i++)
                            attributesAll[attributesAll.Count - 1][i] = mas[i];

                    }

                    listBoxAttr1.Items.Clear();
                    foreach (string[] s in attributesAll)
                    {
                        listBoxAttr1.Items.Add($"{s[2]}.{s[0]}");
                    }
                    checkedListBoxAttributesJoin.Items.Clear();
                    listBoxAttr2.Items.Clear();
                    listBoxTablesJoin.Items.RemoveAt(listBoxTablesJoin.SelectedIndex);
                }
            }
            textBoxQuery1.Text = attr + firstTabl + join + where;
        }
        private void GetJoin()
        {
            foreach (int checkedInd in checkedListBoxAttributesJoin.CheckedIndices)
            {
                attr += $",{attributes[checkedInd][2]}.{attributes[checkedInd][0]}";
                dataGridViewQuery.Columns.Add("1", $"{attributes[checkedInd][2]}.{attributes[checkedInd][0]}");
                attrNum++;
            }          
            join += $" {listBoxJoin.SelectedItem}";
            join += $" {listBoxTablesJoin.SelectedItem} on";
            join += $" {listBoxAttr1.SelectedItem}={listBoxTablesJoin.SelectedItem}.{listBoxAttr2.SelectedItem}";


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonWhere_Click(object sender, EventArgs e)
        {
            if (listBoxAttrConditional.SelectedItem == null )
            {
                MessageBox.Show("Выберите атрибуты");
            }
            else
            {
                if (textBoxVal.Text=="") MessageBox.Show("Введите значения");
                else
                {
                    GetConditional();
                    textBoxVal.Text = "";
                    if(listBoxFunct.SelectedItem.ToString()==";")
                    {
                        tabControlindex = 3;
                        tabControlQuery.SelectedIndex = 3;
                        GetQuery();
                    }
                }
            }
            textBoxQuery1.Text = attr + firstTabl + join + where;
        }
        private void GetConditional()
        {
            if (where == "") where += " where";
            where += $" {listBoxAttrConditional.SelectedItem} {listBoxSign.SelectedItem} {textBoxVal.Text} {listBoxFunct.SelectedItem}";
        }

        private void buttonToResult_Click(object sender, EventArgs e)
        {
            tabControlindex = 3;
            tabControlQuery.SelectedIndex = 3;
            GetQuery();
        }
    }
}
