using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_sql
{
    public partial class Form1 : Form
    {
        connect_to_server server;
        string Safety_key = "sWW$hKqopcJkIp0AG7kEJgkQpCRGXwH9o23{pdr_Schef2002";

        string zapros = "WITH t1 as ((SELECT inn,SUM(sumuplnal) as nolog FROM xml WHERE inn IN (SELECT inn FROM kirov) GROUP BY inn)), t2 as ((SELECT SUM(sumuplnal) FROM xml WHERE inn IN (SELECT inn FROM kirov))),t3 as (SELECT inn,(nolog/(SELECT * FROM t2)) * 100 as nal FROM t1 WHERE nolog > 0 ORDER BY nal ASC) SELECT inn,ROUND(nal,2) FROM t3 WHERE ROUND(nal,2) > 0";

        ReadExcel reader_excel = new ReadExcel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new connect_to_server();
            number_box.Visible = false;
            textBox1.Visible = false;
            comboBox1.SelectedIndex = 0;
            ColumnBox.Visible = false;
            ValueBox.Visible = false;
            list_box.Visible = false;
            comboBox3.SelectedItem = "Кировский";
            UpdateLabelNalog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public string[] ReadFromFile(string filename)
        {
            string[] str = File.ReadAllText(filename).Split(" ");
        
            return str;
        }

        private string customize_zapros()
        {
            return buf_zapros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Загрузка данных...");
            listBox1.Update();
            buf_zapros = zapros;
            string fix_str = "",fix_str1 = "";
            switch (comboBox1.SelectedItem)
            {
                case "Данные из базы (XML)":
                    buf_zapros = zapros;
                    break;
                case "Выбрать файл":
                    buf_zapros = buf_zapros.Replace("(SELECT * FROM t2)", "'" + ValueBox.Text + "'");

                    break;
                case "Свое число":

                    buf_zapros = buf_zapros.Replace("(SELECT * FROM t2)", "'" + number_box.Text + "'");
                    break;
                case "Свой запрос":
                    buf_zapros = textBox1.Text;
                    break;
                default:
                    buf_zapros = zapros;
                    break;
            }


            if(Selected_okpo.Count > 0 && checkBox1.CheckState != CheckState.Checked)
            {

                for(int i = 0; i < Selected_okpo.Count;i++)
                {
                    if(i == 0)
                    {
                        fix_str += "LIKE '%" + Selected_okpo[i] + "%'";
                        fix_str1 += "LIKE '%" + Selected_okpo[i] + "%'";
                    }
                    else
                    {
                        fix_str += " OR fact_okved_neosn LIKE '%" + Selected_okpo[i] + "%' ";
                        fix_str1 += " OR fact_okved_osn LIKE '%" + Selected_okpo[i] + "%' ";
                    }
                }
                
                buf_zapros = buf_zapros.Replace("t1 as ((SELECT inn,SUM(sumuplnal) as nolog FROM xml WHERE inn IN (SELECT inn FROM kirov) GROUP BY inn))",
                "t1 as ((SELECT inn, SUM(sumuplnal) as nolog FROM xml WHERE inn IN(SELECT inn FROM kirov WHERE fact_okved_neosn "+ fix_str + "OR fact_okved_osn "+ fix_str + ") GROUP BY inn))");
            
            }
           
            if(comboBox2.SelectedItem != default && checkBox2.CheckState != CheckState.Checked)
            {

                buf_zapros = buf_zapros.Replace("GROUP BY inn", "AND naimnalog = '" + comboBox2.SelectedItem.ToString() + "' GROUP BY inn");
                if(SumNalogBox.CheckState == CheckState.Checked)
                {
                    buf_zapros = buf_zapros.Replace("t2 as ((SELECT SUM(sumuplnal) FROM xml WHERE inn IN (SELECT inn FROM kirov)))", "t2 as ((SELECT SUM(sumuplnal) FROM xml WHERE inn IN (SELECT inn FROM kirov) AND naimnalog = '" + comboBox2.SelectedItem.ToString() + "'))");

                }
            }

            switch(comboBox3.SelectedItem)
            {
                case "Кировский":
                    buf_zapros = buf_zapros.Replace("ryzanskiy", "kirov");
                    break;
                case "Рязанский":
                    buf_zapros = buf_zapros.Replace("kirov", "ryzanskiy");
                    break;
            }

            listBox1.Items.Clear();
            try
            {
                    server.Connect_and_Request_to_server(buf_zapros + '|' + Safety_key);

                string[] str_mass = ReadFromFile(server.get_filename());
                int count_in_str = 0;
                string buf_str = "";
                if (str_mass[0].Length > 0 && str_mass[0] != "ERROR")
                {
                    
                    foreach (string str in str_mass)
                    {
                        count_in_str++;
                        if (count_in_str < 2)
                        {
                            buf_str += str;
                        }
                       else
                        {
                            count_in_str = 0;
                            buf_str += " "+ str;
                            listBox1.Items.Add(buf_str);
                            buf_str = "";
                        }
                   
                    }
                    
                }
                else
                {

                    listBox1.Items.Add("В базе нет результатов подходящие под критерии!");
                }
            }
            catch
            {

                listBox1.Items.Add("Произошла ошибка при подключении к серверу!");
                listBox1.Items.Add("Проверьте соединение с интернетом");
                listBox1.Items.Add("Или обратитесь к администратору");
            }


        }
        string buf_zapros;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch(comboBox1.SelectedItem)
            {
                case "Данные из базы (XML)":
                    UpdateLabelNalog();

                    number_box.Visible = false;
                    textBox1.Visible = false;
                    ColumnBox.Visible = false;
                    ValueBox.Visible = false;
                    list_box.Visible = false;
                    break;
                case "Выбрать файл":
                   
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    // Set the default file name and extension

                    openFileDialog.DefaultExt = "xlxs";
                    DialogResult result = openFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        list_box.Items.Clear();
                        reader_excel.OpenFile(openFileDialog.FileName);
                        list_box.Visible = true;
                        
                        for(int i = 0; i < reader_excel.GetListCount();i++)
                        {
                            list_box.Items.Add(i.ToString());
                        }

         

                    }
                    number_box.Visible = false;
                    textBox1.Visible = false;
                    break;
                case "Свое число":
                    list_box.Visible = false;
                    number_box.Visible = true;
                    textBox1.Visible = false;
                    ColumnBox.Visible = false;
                    ValueBox.Visible = false;
                    //buf_zapros = zapros.Replace("(SELECT * FROM t2)", "'" + number_box.Text + "'");
                    break;
                case "Свой запрос":
                    list_box.Visible = false;
                    textBox1.Visible = true;
                    number_box.Visible = false;
                    ColumnBox.Visible = false;
                    ValueBox.Visible = false;
                    break;
                default:
                    number_box.Visible = false;
                    textBox1.Visible = false;
                    ColumnBox.Visible = false;
                    ValueBox.Visible = false;
                    list_box.Visible = false;
                    break;

            }
            label1.Text = comboBox1.SelectedItem.ToString();
            //SELECT * FROM kirov LIMIT 1
            // if() WITH t1 as ((SELECT inn,SUM(sumuplnal) as nolog FROM xml WHERE inn IN (SELECT inn FROM kirov) GROUP BY inn)), t2 as ((SELECT SUM(sumuplnal) FROM xml WHERE inn IN (SELECT inn FROM kirov))),t3 as (SELECT inn,(nolog/(SELECT * FROM t2)) * 100 as nal FROM t1 WHERE nolog > 0 ORDER BY nal ASC) SELECT inn,ROUND(nal,2) FROM t3 WHERE ROUND(nal,2) > 0;
            // WITH t1 as ((SELECT inn, SUM(sumuplnal) as nolog FROM xml WHERE inn IN(SELECT inn FROM kirov WHERE fact_okved_neosn LIKE '%43.99%' OR fact_okved_osn LIKE '%43.99%') GROUP BY inn)), t2 as ((SELECT SUM(sumuplnal)FROM xml WHERE inn IN(SELECT inn FROM kirov))),t3 as (SELECT inn, (nolog/ (SELECT * FROM t2)) *100 as nal FROM t1 WHERE nolog > 0 ORDER BY nal ASC) SELECT inn, ROUND(nal, 2) FROM t3 WHERE ROUND(nal,2) > 0;

        }

        List<String> Selected_okpo = new List<string>();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = checkedListBox1.CheckedItems as CheckedListBox.CheckedItemCollection;

            Selected_okpo.Clear();

            label1.Text = "Выбраные ОКВЕД: ";

            for (int i = 0; i < items.Count; i++)
            {
                if(Selected_okpo.IndexOf(items[i].ToString()) == -1)
                {
                    Selected_okpo.Add(items[i].ToString());

                    if(checkBox1.CheckState != CheckState.Checked)
                    {
                       label1.Text += items[i].ToString() + " ";
                    }

                }
                
            }

        }

        string okved_parcer(string okved)
        {
            okved = okved.Replace('.', ',');
            try
            {
                
                if (okved.Length >= 7)
                {
                    okved = okved.Replace(",", string.Empty);
                    okved = okved.Insert(2, ",");
                }
              
            }
            catch
            {

            }
            try
            {
                if (okved.LastIndexOf(',') == okved.Length - 1)
                {
                    okved = okved.Substring(0, okved.Length - 2);
                }
            }
            catch
            {

            }
            return okved;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search_str = okved_parcer(textBox2.Text);

            try
             {
                checkedListBox1.Items.Clear();
                for(int i = 0; i < Selected_okpo.Count;i++)
                {
                    checkedListBox1.Items.Add(Selected_okpo[i]);
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
                if (search_str.Length < 6)
                {
                    for (float i = float.Parse(search_str); i < float.Parse(search_str) + 0.99; i += 0.01f)
                    {
                        checkedListBox1.Items.Add(Math.Round(i, 2).ToString().Replace(',','.'));
                       
                    }
                    checkedListBox1.Update();
                }
                else
                {
                    for (float i = float.Parse(search_str); i < float.Parse(search_str) + 0.99; i += 0.0001f)
                    {
                        if(textBox2.Text[0] == '0') //если первый символ строки 0 
                        {
                            checkedListBox1.Items.Add(Math.Round(i, 4).ToString().Insert(4, ".").Replace(',', '.'));
                        }
                        else
                        {
                            checkedListBox1.Items.Add(Math.Round(i, 4).ToString().Insert(5, ".").Replace(',', '.'));
                        }
                       
                        
                    }
                    checkedListBox1.Update();
                }

              }
             catch
             {

             }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                label1.Text = "Выбраные ОКВЕД: Все";
            } 
            else
            {
                label1.Text = "Выбраные ОКВЕД: ";
                foreach (string str in Selected_okpo)
                {
                    label1.Text += str + " ";
                }
                
            }
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelNalog();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string buf_str = "";
            for(int i = 0; i < listBox1.Items.Count;i++)
            {
                buf_str += listBox1.GetItemText(listBox1.Items[i]) +'\n';
                
            }
            Safefile(buf_str);
        }

        void Safefile(string text)
        {
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the default file name and extension
            saveFileDialog.FileName = "data.txt";
            saveFileDialog.DefaultExt = "txt";

            // Display the dialog and get the result
            DialogResult result = saveFileDialog.ShowDialog();

            // If the user clicked OK, save the file
            if (result == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                File.WriteAllText(path, text);
            }
            
        }

        private void ColumnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str_mass_buf;
            ValueBox.Items.Clear();
            ValueBox.Visible = true;
            str_mass_buf = reader_excel.Get_Val_In_Cols(ColumnBox.SelectedItem.ToString());
            for (int i = 0; i < str_mass_buf.Length; i++)
            {
                ValueBox.Items.Add(str_mass_buf[i]);
            }

        }

        private void list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str_mass_buf;
            str_mass_buf = reader_excel.Get_Col_names(Int32.Parse(list_box.SelectedItem.ToString()));
            ColumnBox.Items.Clear();
            ColumnBox.Visible = true;

            for (int i = 0; i < str_mass_buf.Length; i++)
            {
                ColumnBox.Items.Add(str_mass_buf[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void number_box_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelNalog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabelNalog();
        }

        void UpdateLabelNalog()
        {
            if (comboBox2.SelectedItem == default || checkBox2.CheckState == CheckState.Checked)
            {
                percentLabel.Text = "Процент будет расчитан от суммы всех налогов в базе";
            }
            else
            {
                percentLabel.Text = "Процент будет расчитан от суммы всех " + comboBox2.SelectedItem;
            }

            if(ValueBox.Visible)
            {
                percentLabel.Text = "Процент будет расчитан от : " + ValueBox.SelectedItem;
            }

            if(number_box.Visible)
            {
                percentLabel.Text = "Процент будет расчитан от числа : " + number_box.Text;
            }
        }

        private void ValueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabelNalog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
