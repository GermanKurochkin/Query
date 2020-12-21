
namespace Query
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlQuery = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.buttonFirstTable = new System.Windows.Forms.Button();
            this.checkedListBoxAttributes = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.checkBoxUseJoin = new System.Windows.Forms.CheckBox();
            this.textBoxQuery1 = new System.Windows.Forms.TextBox();
            this.tabPageJoin = new System.Windows.Forms.TabPage();
            this.listBoxAttr2 = new System.Windows.Forms.ListBox();
            this.listBoxAttr1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxJoin = new System.Windows.Forms.ListBox();
            this.checkedListBoxAttributesJoin = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxTablesJoin = new System.Windows.Forms.ListBox();
            this.textBoxQuery2 = new System.Windows.Forms.TextBox();
            this.tabPageWhere = new System.Windows.Forms.TabPage();
            this.textBoxQuery3 = new System.Windows.Forms.TextBox();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.buttonToConditionals = new System.Windows.Forms.Button();
            this.buttonCancel1 = new System.Windows.Forms.Button();
            this.buttonCancel2 = new System.Windows.Forms.Button();
            this.buttonCancel3 = new System.Windows.Forms.Button();
            this.listBoxAttrConditional = new System.Windows.Forms.ListBox();
            this.listBoxSign = new System.Windows.Forms.ListBox();
            this.buttonWhere = new System.Windows.Forms.Button();
            this.textBoxVal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxFunct = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonToResult = new System.Windows.Forms.Button();
            this.tabControlQuery.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.tabPageJoin.SuspendLayout();
            this.tabPageWhere.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlQuery
            // 
            this.tabControlQuery.Controls.Add(this.tabPageTable);
            this.tabControlQuery.Controls.Add(this.tabPageJoin);
            this.tabControlQuery.Controls.Add(this.tabPageWhere);
            this.tabControlQuery.Controls.Add(this.tabPageQuery);
            this.tabControlQuery.Location = new System.Drawing.Point(3, 12);
            this.tabControlQuery.Name = "tabControlQuery";
            this.tabControlQuery.SelectedIndex = 0;
            this.tabControlQuery.Size = new System.Drawing.Size(1190, 672);
            this.tabControlQuery.TabIndex = 0;
            this.tabControlQuery.SelectedIndexChanged += new System.EventHandler(this.tabControlQuery_SelectedIndexChanged);
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.buttonFirstTable);
            this.tabPageTable.Controls.Add(this.checkedListBoxAttributes);
            this.tabPageTable.Controls.Add(this.label2);
            this.tabPageTable.Controls.Add(this.label1);
            this.tabPageTable.Controls.Add(this.listBoxTables);
            this.tabPageTable.Controls.Add(this.checkBoxUseJoin);
            this.tabPageTable.Controls.Add(this.textBoxQuery1);
            this.tabPageTable.Location = new System.Drawing.Point(4, 29);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(1182, 639);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "Начальная таблица";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // buttonFirstTable
            // 
            this.buttonFirstTable.Location = new System.Drawing.Point(844, 112);
            this.buttonFirstTable.Name = "buttonFirstTable";
            this.buttonFirstTable.Size = new System.Drawing.Size(147, 40);
            this.buttonFirstTable.TabIndex = 18;
            this.buttonFirstTable.Text = "Выполнить";
            this.buttonFirstTable.UseVisualStyleBackColor = true;
            this.buttonFirstTable.Click += new System.EventHandler(this.buttonFirstTable_Click);
            // 
            // checkedListBoxAttributes
            // 
            this.checkedListBoxAttributes.CheckOnClick = true;
            this.checkedListBoxAttributes.FormattingEnabled = true;
            this.checkedListBoxAttributes.Location = new System.Drawing.Point(355, 46);
            this.checkedListBoxAttributes.Name = "checkedListBoxAttributes";
            this.checkedListBoxAttributes.Size = new System.Drawing.Size(217, 211);
            this.checkedListBoxAttributes.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Выбрать атрибуты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выбрать таблицу:";
            // 
            // listBoxTables
            // 
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.ItemHeight = 20;
            this.listBoxTables.Items.AddRange(new object[] {
            "т1",
            "т2"});
            this.listBoxTables.Location = new System.Drawing.Point(45, 46);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(243, 224);
            this.listBoxTables.TabIndex = 14;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.listBoxTables_SelectedIndexChanged);
            // 
            // checkBoxUseJoin
            // 
            this.checkBoxUseJoin.AutoSize = true;
            this.checkBoxUseJoin.Checked = true;
            this.checkBoxUseJoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseJoin.Location = new System.Drawing.Point(760, 46);
            this.checkBoxUseJoin.Name = "checkBoxUseJoin";
            this.checkBoxUseJoin.Size = new System.Drawing.Size(344, 24);
            this.checkBoxUseJoin.TabIndex = 13;
            this.checkBoxUseJoin.Text = "Использовать присоединения и условия";
            this.checkBoxUseJoin.UseVisualStyleBackColor = true;
            // 
            // textBoxQuery1
            // 
            this.textBoxQuery1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuery1.Location = new System.Drawing.Point(45, 454);
            this.textBoxQuery1.Multiline = true;
            this.textBoxQuery1.Name = "textBoxQuery1";
            this.textBoxQuery1.ReadOnly = true;
            this.textBoxQuery1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxQuery1.Size = new System.Drawing.Size(1097, 158);
            this.textBoxQuery1.TabIndex = 12;
            this.textBoxQuery1.TextChanged += new System.EventHandler(this.textBoxQuery1_TextChanged);
            // 
            // tabPageJoin
            // 
            this.tabPageJoin.Controls.Add(this.buttonToResult);
            this.tabPageJoin.Controls.Add(this.buttonCancel1);
            this.tabPageJoin.Controls.Add(this.buttonToConditionals);
            this.tabPageJoin.Controls.Add(this.buttonJoin);
            this.tabPageJoin.Controls.Add(this.label7);
            this.tabPageJoin.Controls.Add(this.label6);
            this.tabPageJoin.Controls.Add(this.listBoxAttr2);
            this.tabPageJoin.Controls.Add(this.listBoxAttr1);
            this.tabPageJoin.Controls.Add(this.label5);
            this.tabPageJoin.Controls.Add(this.listBoxJoin);
            this.tabPageJoin.Controls.Add(this.checkedListBoxAttributesJoin);
            this.tabPageJoin.Controls.Add(this.label3);
            this.tabPageJoin.Controls.Add(this.label4);
            this.tabPageJoin.Controls.Add(this.listBoxTablesJoin);
            this.tabPageJoin.Controls.Add(this.textBoxQuery2);
            this.tabPageJoin.Location = new System.Drawing.Point(4, 29);
            this.tabPageJoin.Name = "tabPageJoin";
            this.tabPageJoin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJoin.Size = new System.Drawing.Size(1182, 639);
            this.tabPageJoin.TabIndex = 1;
            this.tabPageJoin.Text = "Присоединение таблиц";
            this.tabPageJoin.UseVisualStyleBackColor = true;
            // 
            // listBoxAttr2
            // 
            this.listBoxAttr2.FormattingEnabled = true;
            this.listBoxAttr2.ItemHeight = 20;
            this.listBoxAttr2.Location = new System.Drawing.Point(752, 290);
            this.listBoxAttr2.Name = "listBoxAttr2";
            this.listBoxAttr2.Size = new System.Drawing.Size(281, 124);
            this.listBoxAttr2.TabIndex = 25;
            // 
            // listBoxAttr1
            // 
            this.listBoxAttr1.FormattingEnabled = true;
            this.listBoxAttr1.ItemHeight = 20;
            this.listBoxAttr1.Location = new System.Drawing.Point(752, 64);
            this.listBoxAttr1.Name = "listBoxAttr1";
            this.listBoxAttr1.Size = new System.Drawing.Size(281, 184);
            this.listBoxAttr1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Присоединение:";
            // 
            // listBoxJoin
            // 
            this.listBoxJoin.FormattingEnabled = true;
            this.listBoxJoin.ItemHeight = 20;
            this.listBoxJoin.Items.AddRange(new object[] {
            "inner join",
            "right join",
            "left join"});
            this.listBoxJoin.Location = new System.Drawing.Point(590, 144);
            this.listBoxJoin.Name = "listBoxJoin";
            this.listBoxJoin.Size = new System.Drawing.Size(120, 84);
            this.listBoxJoin.TabIndex = 22;
            // 
            // checkedListBoxAttributesJoin
            // 
            this.checkedListBoxAttributesJoin.CheckOnClick = true;
            this.checkedListBoxAttributesJoin.FormattingEnabled = true;
            this.checkedListBoxAttributesJoin.Location = new System.Drawing.Point(329, 64);
            this.checkedListBoxAttributesJoin.Name = "checkedListBoxAttributesJoin";
            this.checkedListBoxAttributesJoin.Size = new System.Drawing.Size(215, 211);
            this.checkedListBoxAttributesJoin.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Выбрать атрибуты для отображения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Выбрать присоединяемую таблицу:";
            // 
            // listBoxTablesJoin
            // 
            this.listBoxTablesJoin.FormattingEnabled = true;
            this.listBoxTablesJoin.ItemHeight = 20;
            this.listBoxTablesJoin.Items.AddRange(new object[] {
            "т1",
            "т2"});
            this.listBoxTablesJoin.Location = new System.Drawing.Point(34, 64);
            this.listBoxTablesJoin.Name = "listBoxTablesJoin";
            this.listBoxTablesJoin.Size = new System.Drawing.Size(276, 224);
            this.listBoxTablesJoin.TabIndex = 18;
            this.listBoxTablesJoin.SelectedIndexChanged += new System.EventHandler(this.listBoxTablesJoin_SelectedIndexChanged);
            // 
            // textBoxQuery2
            // 
            this.textBoxQuery2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuery2.Location = new System.Drawing.Point(34, 443);
            this.textBoxQuery2.Multiline = true;
            this.textBoxQuery2.Name = "textBoxQuery2";
            this.textBoxQuery2.ReadOnly = true;
            this.textBoxQuery2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxQuery2.Size = new System.Drawing.Size(1108, 158);
            this.textBoxQuery2.TabIndex = 13;
            // 
            // tabPageWhere
            // 
            this.tabPageWhere.Controls.Add(this.label12);
            this.tabPageWhere.Controls.Add(this.label11);
            this.tabPageWhere.Controls.Add(this.listBoxFunct);
            this.tabPageWhere.Controls.Add(this.label10);
            this.tabPageWhere.Controls.Add(this.label9);
            this.tabPageWhere.Controls.Add(this.label8);
            this.tabPageWhere.Controls.Add(this.textBoxVal);
            this.tabPageWhere.Controls.Add(this.buttonWhere);
            this.tabPageWhere.Controls.Add(this.listBoxSign);
            this.tabPageWhere.Controls.Add(this.listBoxAttrConditional);
            this.tabPageWhere.Controls.Add(this.buttonCancel2);
            this.tabPageWhere.Controls.Add(this.textBoxQuery3);
            this.tabPageWhere.Location = new System.Drawing.Point(4, 29);
            this.tabPageWhere.Name = "tabPageWhere";
            this.tabPageWhere.Size = new System.Drawing.Size(1182, 639);
            this.tabPageWhere.TabIndex = 2;
            this.tabPageWhere.Text = "Условия";
            this.tabPageWhere.UseVisualStyleBackColor = true;
            // 
            // textBoxQuery3
            // 
            this.textBoxQuery3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuery3.Location = new System.Drawing.Point(25, 448);
            this.textBoxQuery3.Multiline = true;
            this.textBoxQuery3.Name = "textBoxQuery3";
            this.textBoxQuery3.ReadOnly = true;
            this.textBoxQuery3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxQuery3.Size = new System.Drawing.Size(1121, 158);
            this.textBoxQuery3.TabIndex = 13;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.buttonCancel3);
            this.tabPageQuery.Controls.Add(this.dataGridViewQuery);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 29);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Size = new System.Drawing.Size(1182, 639);
            this.tabPageQuery.TabIndex = 3;
            this.tabPageQuery.Text = "Результат запроса";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.AllowUserToAddRows = false;
            this.dataGridViewQuery.AllowUserToDeleteRows = false;
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Location = new System.Drawing.Point(20, 19);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.ReadOnly = true;
            this.dataGridViewQuery.RowHeadersWidth = 62;
            this.dataGridViewQuery.RowTemplate.Height = 28;
            this.dataGridViewQuery.Size = new System.Drawing.Size(872, 595);
            this.dataGridViewQuery.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Атрибуты связи:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(881, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 32);
            this.label7.TabIndex = 27;
            this.label7.Text = "||";
            // 
            // buttonJoin
            // 
            this.buttonJoin.Location = new System.Drawing.Point(1052, 64);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(111, 52);
            this.buttonJoin.TabIndex = 28;
            this.buttonJoin.Text = "Выполнить";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // buttonToConditionals
            // 
            this.buttonToConditionals.Location = new System.Drawing.Point(1052, 350);
            this.buttonToConditionals.Name = "buttonToConditionals";
            this.buttonToConditionals.Size = new System.Drawing.Size(111, 64);
            this.buttonToConditionals.TabIndex = 29;
            this.buttonToConditionals.Text = "Перейти к условиям";
            this.buttonToConditionals.UseVisualStyleBackColor = true;
            this.buttonToConditionals.Click += new System.EventHandler(this.buttonToConditionals_Click);
            // 
            // buttonCancel1
            // 
            this.buttonCancel1.Location = new System.Drawing.Point(611, 350);
            this.buttonCancel1.Name = "buttonCancel1";
            this.buttonCancel1.Size = new System.Drawing.Size(99, 64);
            this.buttonCancel1.TabIndex = 30;
            this.buttonCancel1.Text = "Начать сначала";
            this.buttonCancel1.UseVisualStyleBackColor = true;
            this.buttonCancel1.Click += new System.EventHandler(this.buttonCancel1_Click);
            // 
            // buttonCancel2
            // 
            this.buttonCancel2.Location = new System.Drawing.Point(1035, 315);
            this.buttonCancel2.Name = "buttonCancel2";
            this.buttonCancel2.Size = new System.Drawing.Size(111, 64);
            this.buttonCancel2.TabIndex = 31;
            this.buttonCancel2.Text = "Начать сначала";
            this.buttonCancel2.UseVisualStyleBackColor = true;
            this.buttonCancel2.Click += new System.EventHandler(this.buttonCancel2_Click);
            // 
            // buttonCancel3
            // 
            this.buttonCancel3.Location = new System.Drawing.Point(993, 502);
            this.buttonCancel3.Name = "buttonCancel3";
            this.buttonCancel3.Size = new System.Drawing.Size(99, 53);
            this.buttonCancel3.TabIndex = 32;
            this.buttonCancel3.Text = "Новый запрос";
            this.buttonCancel3.UseVisualStyleBackColor = true;
            this.buttonCancel3.Click += new System.EventHandler(this.buttonCancel3_Click);
            // 
            // listBoxAttrConditional
            // 
            this.listBoxAttrConditional.FormattingEnabled = true;
            this.listBoxAttrConditional.ItemHeight = 20;
            this.listBoxAttrConditional.Location = new System.Drawing.Point(25, 83);
            this.listBoxAttrConditional.Name = "listBoxAttrConditional";
            this.listBoxAttrConditional.Size = new System.Drawing.Size(534, 204);
            this.listBoxAttrConditional.TabIndex = 33;
            // 
            // listBoxSign
            // 
            this.listBoxSign.FormattingEnabled = true;
            this.listBoxSign.ItemHeight = 20;
            this.listBoxSign.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.listBoxSign.Location = new System.Drawing.Point(601, 83);
            this.listBoxSign.Name = "listBoxSign";
            this.listBoxSign.Size = new System.Drawing.Size(66, 124);
            this.listBoxSign.TabIndex = 34;
            this.listBoxSign.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // buttonWhere
            // 
            this.buttonWhere.Location = new System.Drawing.Point(1035, 108);
            this.buttonWhere.Name = "buttonWhere";
            this.buttonWhere.Size = new System.Drawing.Size(111, 59);
            this.buttonWhere.TabIndex = 35;
            this.buttonWhere.Text = "Добавить условие";
            this.buttonWhere.UseVisualStyleBackColor = true;
            this.buttonWhere.Click += new System.EventHandler(this.buttonWhere_Click);
            // 
            // textBoxVal
            // 
            this.textBoxVal.Location = new System.Drawing.Point(700, 83);
            this.textBoxVal.Name = "textBoxVal";
            this.textBoxVal.Size = new System.Drawing.Size(157, 26);
            this.textBoxVal.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Атрибут:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Знак:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(696, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Значение:";
            // 
            // listBoxFunct
            // 
            this.listBoxFunct.FormattingEnabled = true;
            this.listBoxFunct.ItemHeight = 20;
            this.listBoxFunct.Items.AddRange(new object[] {
            "or",
            "and",
            ";"});
            this.listBoxFunct.Location = new System.Drawing.Point(898, 83);
            this.listBoxFunct.Name = "listBoxFunct";
            this.listBoxFunct.Size = new System.Drawing.Size(68, 84);
            this.listBoxFunct.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(894, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Соединение:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(894, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "; - конец";
            // 
            // buttonToResult
            // 
            this.buttonToResult.Location = new System.Drawing.Point(1052, 268);
            this.buttonToResult.Name = "buttonToResult";
            this.buttonToResult.Size = new System.Drawing.Size(111, 61);
            this.buttonToResult.TabIndex = 31;
            this.buttonToResult.Text = "К результату";
            this.buttonToResult.UseVisualStyleBackColor = true;
            this.buttonToResult.Click += new System.EventHandler(this.buttonToResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 684);
            this.Controls.Add(this.tabControlQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlQuery.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            this.tabPageTable.PerformLayout();
            this.tabPageJoin.ResumeLayout(false);
            this.tabPageJoin.PerformLayout();
            this.tabPageWhere.ResumeLayout(false);
            this.tabPageWhere.PerformLayout();
            this.tabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQuery;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TabPage tabPageJoin;
        private System.Windows.Forms.TabPage tabPageWhere;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.CheckBox checkBoxUseJoin;
        private System.Windows.Forms.TextBox textBoxQuery1;
        private System.Windows.Forms.TextBox textBoxQuery2;
        private System.Windows.Forms.TextBox textBoxQuery3;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.CheckedListBox checkedListBoxAttributes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirstTable;
        private System.Windows.Forms.CheckedListBox checkedListBoxAttributesJoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTablesJoin;
        private System.Windows.Forms.ListBox listBoxAttr1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxJoin;
        private System.Windows.Forms.ListBox listBoxAttr2;
        private System.Windows.Forms.Button buttonCancel1;
        private System.Windows.Forms.Button buttonToConditionals;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel2;
        private System.Windows.Forms.Button buttonCancel3;
        private System.Windows.Forms.ListBox listBoxSign;
        private System.Windows.Forms.ListBox listBoxAttrConditional;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVal;
        private System.Windows.Forms.Button buttonWhere;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxFunct;
        private System.Windows.Forms.Button buttonToResult;
    }
}

