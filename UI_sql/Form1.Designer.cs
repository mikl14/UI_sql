
namespace UI_sql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.number_box = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.ColumnBox = new System.Windows.Forms.ComboBox();
            this.ValueBox = new System.Windows.Forms.ComboBox();
            this.list_box = new System.Windows.Forms.ComboBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.SumNalogBox = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(139, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 229);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Введите sql запрос без ; в конце";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Данные из базы (XML)",
            "Выбрать файл",
            "Свое число",
            "Свой запрос"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // number_box
            // 
            this.number_box.Location = new System.Drawing.Point(12, 50);
            this.number_box.Name = "number_box";
            this.number_box.Size = new System.Drawing.Size(121, 23);
            this.number_box.TabIndex = 4;
            this.number_box.Text = "Введите число";
            this.number_box.TextChanged += new System.EventHandler(this.number_box_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(593, 248);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(593, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Введите ОКВЕД";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Акцизы, всего",
            "Водный налог",
            "Государственная пошлина",
            "Единый налог на вмененный доход для отдельных видов  деятельности",
            "Единый сельскохозяйственный налог",
            "Задолженность и перерасчеты по ОТМЕНЕННЫМ НАЛОГАМ  и сборам и иным обязательным п" +
                "латежам  (кроме ЕСН, страх. Взносов)",
            "Земельный налог",
            "Налог на добавленную стоимость",
            "Налог на добычу полезных ископаемых",
            "Налог на дополнительный доход от добычи углеводородного сырья",
            "Налог на доходы физических лиц",
            "Налог на игорный",
            "Налог на имущество организаций",
            "Налог на имущество физических лиц",
            "Налог на прибыль",
            "Налог, взимаемый в связи с  применением патентной системы  налогообложения",
            "Налог, взимаемый в связи с  применением упрощенной  системы налогообложения",
            "НЕНАЛОГОВЫЕ ДОХОДЫ, администрируемые налоговыми органами",
            "Регулярные платежи за добычу полезных ископаемых (роялти) при выполнении соглашен" +
                "ий о разделе продукции",
            "Сборы за пользование объектами животного мира  и за пользование объектами ВБР",
            "Страховые взносы на обязательное медицинское страхование работающего населения, з" +
                "ачисляемые в бюджет Федерального фонда обязательного медицинского страхования",
            "Страховые взносы на обязательное социальное страхование на случай временной нетру" +
                "доспособности и в связи с материнством",
            "Страховые и другие взносы на обязательное пенсионное страхование, зачисляемые в П" +
                "енсионный фонд Российской Федерации",
            "Торговый сбор",
            "Транспортный налог",
            "Утилизационный сбор"});
            this.comboBox2.Location = new System.Drawing.Point(593, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(272, 23);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Выберите налог";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(593, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Не учитывать ОКВЕД";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(593, 113);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(164, 19);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Не учитывать тип налога";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(336, 393);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "Save txt";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // ColumnBox
            // 
            this.ColumnBox.FormattingEnabled = true;
            this.ColumnBox.Items.AddRange(new object[] {
            "Акцизы, всего",
            "Водный налог",
            "Государственная пошлина",
            "Единый налог на вмененный доход для отдельных видов  деятельности",
            "Единый сельскохозяйственный налог",
            "Задолженность и перерасчеты по ОТМЕНЕННЫМ НАЛОГАМ  и сборам и иным обязательным п" +
                "латежам  (кроме ЕСН, страх. Взносов)",
            "Земельный налог",
            "Налог на добавленную стоимость",
            "Налог на добычу полезных ископаемых",
            "Налог на дополнительный доход от добычи углеводородного сырья",
            "Налог на доходы физических лиц",
            "Налог на игорный",
            "Налог на имущество организаций",
            "Налог на имущество физических лиц",
            "Налог на прибыль",
            "Налог, взимаемый в связи с  применением патентной системы  налогообложения",
            "Налог, взимаемый в связи с  применением упрощенной  системы налогообложения",
            "НЕНАЛОГОВЫЕ ДОХОДЫ, администрируемые налоговыми органами",
            "Регулярные платежи за добычу полезных ископаемых (роялти) при выполнении соглашен" +
                "ий о разделе продукции",
            "Сборы за пользование объектами животного мира  и за пользование объектами ВБР",
            "Страховые взносы на обязательное медицинское страхование работающего населения, з" +
                "ачисляемые в бюджет Федерального фонда обязательного медицинского страхования",
            "Страховые взносы на обязательное социальное страхование на случай временной нетру" +
                "доспособности и в связи с материнством",
            "Страховые и другие взносы на обязательное пенсионное страхование, зачисляемые в П" +
                "енсионный фонд Российской Федерации",
            "Торговый сбор",
            "Транспортный налог",
            "Утилизационный сбор"});
            this.ColumnBox.Location = new System.Drawing.Point(12, 145);
            this.ColumnBox.Name = "ColumnBox";
            this.ColumnBox.Size = new System.Drawing.Size(121, 23);
            this.ColumnBox.TabIndex = 12;
            this.ColumnBox.Text = "Выберите столбец";
            this.ColumnBox.SelectedIndexChanged += new System.EventHandler(this.ColumnBox_SelectedIndexChanged);
            // 
            // ValueBox
            // 
            this.ValueBox.FormattingEnabled = true;
            this.ValueBox.Items.AddRange(new object[] {
            "Акцизы, всего",
            "Водный налог",
            "Государственная пошлина",
            "Единый налог на вмененный доход для отдельных видов  деятельности",
            "Единый сельскохозяйственный налог",
            "Задолженность и перерасчеты по ОТМЕНЕННЫМ НАЛОГАМ  и сборам и иным обязательным п" +
                "латежам  (кроме ЕСН, страх. Взносов)",
            "Земельный налог",
            "Налог на добавленную стоимость",
            "Налог на добычу полезных ископаемых",
            "Налог на дополнительный доход от добычи углеводородного сырья",
            "Налог на доходы физических лиц",
            "Налог на игорный",
            "Налог на имущество организаций",
            "Налог на имущество физических лиц",
            "Налог на прибыль",
            "Налог, взимаемый в связи с  применением патентной системы  налогообложения",
            "Налог, взимаемый в связи с  применением упрощенной  системы налогообложения",
            "НЕНАЛОГОВЫЕ ДОХОДЫ, администрируемые налоговыми органами",
            "Регулярные платежи за добычу полезных ископаемых (роялти) при выполнении соглашен" +
                "ий о разделе продукции",
            "Сборы за пользование объектами животного мира  и за пользование объектами ВБР",
            "Страховые взносы на обязательное медицинское страхование работающего населения, з" +
                "ачисляемые в бюджет Федерального фонда обязательного медицинского страхования",
            "Страховые взносы на обязательное социальное страхование на случай временной нетру" +
                "доспособности и в связи с материнством",
            "Страховые и другие взносы на обязательное пенсионное страхование, зачисляемые в П" +
                "енсионный фонд Российской Федерации",
            "Торговый сбор",
            "Транспортный налог",
            "Утилизационный сбор"});
            this.ValueBox.Location = new System.Drawing.Point(12, 182);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(121, 23);
            this.ValueBox.TabIndex = 13;
            this.ValueBox.Text = "Выберите значение";
            this.ValueBox.SelectedIndexChanged += new System.EventHandler(this.ValueBox_SelectedIndexChanged);
            // 
            // list_box
            // 
            this.list_box.FormattingEnabled = true;
            this.list_box.Location = new System.Drawing.Point(12, 109);
            this.list_box.Name = "list_box";
            this.list_box.Size = new System.Drawing.Size(121, 23);
            this.list_box.TabIndex = 14;
            this.list_box.Text = "Выберите Лист";
            this.list_box.SelectedIndexChanged += new System.EventHandler(this.list_box_SelectedIndexChanged);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(232, 53);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(38, 15);
            this.percentLabel.TabIndex = 15;
            this.percentLabel.Text = "label2";
            // 
            // SumNalogBox
            // 
            this.SumNalogBox.AutoSize = true;
            this.SumNalogBox.Location = new System.Drawing.Point(593, 88);
            this.SumNalogBox.Name = "SumNalogBox";
            this.SumNalogBox.Size = new System.Drawing.Size(177, 19);
            this.SumNalogBox.TabIndex = 16;
            this.SumNalogBox.Text = "Считать процент по налогу";
            this.SumNalogBox.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Кировский",
            "Рязанский"});
            this.comboBox3.Location = new System.Drawing.Point(592, 35);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 428);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.SumNalogBox);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.list_box);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.ColumnBox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.number_box);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox number_box;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox ColumnBox;
        private System.Windows.Forms.ComboBox ValueBox;
        private System.Windows.Forms.ComboBox list_box;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.CheckBox SumNalogBox;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

