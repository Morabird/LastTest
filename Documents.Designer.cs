namespace Laundry_Dry_Cleaning
{
    partial class Documents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documents));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actRabotDataSet = new Laundry_Dry_Cleaning.ActRabotDataSet();
            this.актВыполненияРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.акт_выполнения_работTableAdapter = new Laundry_Dry_Cleaning.ActRabotDataSetTableAdapters.Акт_выполнения_работTableAdapter();
            this.idДокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьЗаЕдиницуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nakladnayaDataSet = new Laundry_Dry_Cleaning.NakladnayaDataSet();
            this.накладнааяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.накладнааяTableAdapter = new Laundry_Dry_Cleaning.NakladnayaDataSetTableAdapters.НакладнааяTableAdapter();
            this.idЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриёмкиЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыполненияЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеУслугиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.подписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.facturaDataSet = new Laundry_Dry_Cleaning.FacturaDataSet();
            this.счётфактураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счёт_фактураTableAdapter = new Laundry_Dry_Cleaning.FacturaDataSetTableAdapters.Счёт_фактураTableAdapter();
            this.idДокументаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actRabotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.актВыполненияРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнааяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счётфактураBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Акт выполнения работ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Накладная";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(769, 358);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Счёт-фактура";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idДокументаDataGridViewTextBoxColumn,
            this.наименованиеОрганизацииDataGridViewTextBoxColumn,
            this.наименованиеУслугиDataGridViewTextBoxColumn,
            this.стоимостьЗаЕдиницуDataGridViewTextBoxColumn,
            this.весDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.актВыполненияРаботBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // actRabotDataSet
            // 
            this.actRabotDataSet.DataSetName = "ActRabotDataSet";
            this.actRabotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // актВыполненияРаботBindingSource
            // 
            this.актВыполненияРаботBindingSource.DataMember = "Акт выполнения работ";
            this.актВыполненияРаботBindingSource.DataSource = this.actRabotDataSet;
            // 
            // акт_выполнения_работTableAdapter
            // 
            this.акт_выполнения_работTableAdapter.ClearBeforeFill = true;
            // 
            // idДокументаDataGridViewTextBoxColumn
            // 
            this.idДокументаDataGridViewTextBoxColumn.DataPropertyName = "id документа";
            this.idДокументаDataGridViewTextBoxColumn.HeaderText = "id документа";
            this.idДокументаDataGridViewTextBoxColumn.Name = "idДокументаDataGridViewTextBoxColumn";
            // 
            // наименованиеОрганизацииDataGridViewTextBoxColumn
            // 
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование организации";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.HeaderText = "Наименование организации";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.Name = "наименованиеОрганизацииDataGridViewTextBoxColumn";
            // 
            // наименованиеУслугиDataGridViewTextBoxColumn
            // 
            this.наименованиеУслугиDataGridViewTextBoxColumn.DataPropertyName = "Наименование услуги";
            this.наименованиеУслугиDataGridViewTextBoxColumn.HeaderText = "Наименование услуги";
            this.наименованиеУслугиDataGridViewTextBoxColumn.Name = "наименованиеУслугиDataGridViewTextBoxColumn";
            // 
            // стоимостьЗаЕдиницуDataGridViewTextBoxColumn
            // 
            this.стоимостьЗаЕдиницуDataGridViewTextBoxColumn.DataPropertyName = "Стоимость за единицу";
            this.стоимостьЗаЕдиницуDataGridViewTextBoxColumn.HeaderText = "Стоимость за единицу";
            this.стоимостьЗаЕдиницуDataGridViewTextBoxColumn.Name = "стоимостьЗаЕдиницуDataGridViewTextBoxColumn";
            // 
            // весDataGridViewTextBoxColumn
            // 
            this.весDataGridViewTextBoxColumn.DataPropertyName = "Вес";
            this.весDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.весDataGridViewTextBoxColumn.Name = "весDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаказаDataGridViewTextBoxColumn,
            this.датаПриёмкиЗаказаDataGridViewTextBoxColumn,
            this.датаВыполненияЗаказаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.наименованиеУслугиDataGridViewTextBoxColumn1,
            this.стоимостьУслугиDataGridViewTextBoxColumn,
            this.оплатаDataGridViewTextBoxColumn,
            this.подписиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.накладнааяBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(763, 352);
            this.dataGridView2.TabIndex = 0;
            // 
            // nakladnayaDataSet
            // 
            this.nakladnayaDataSet.DataSetName = "NakladnayaDataSet";
            this.nakladnayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // накладнааяBindingSource
            // 
            this.накладнааяBindingSource.DataMember = "Накладнаая";
            this.накладнааяBindingSource.DataSource = this.nakladnayaDataSet;
            // 
            // накладнааяTableAdapter
            // 
            this.накладнааяTableAdapter.ClearBeforeFill = true;
            // 
            // idЗаказаDataGridViewTextBoxColumn
            // 
            this.idЗаказаDataGridViewTextBoxColumn.DataPropertyName = "id заказа";
            this.idЗаказаDataGridViewTextBoxColumn.HeaderText = "id заказа";
            this.idЗаказаDataGridViewTextBoxColumn.Name = "idЗаказаDataGridViewTextBoxColumn";
            // 
            // датаПриёмкиЗаказаDataGridViewTextBoxColumn
            // 
            this.датаПриёмкиЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата приёмки заказа";
            this.датаПриёмкиЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата приёмки заказа";
            this.датаПриёмкиЗаказаDataGridViewTextBoxColumn.Name = "датаПриёмкиЗаказаDataGridViewTextBoxColumn";
            // 
            // датаВыполненияЗаказаDataGridViewTextBoxColumn
            // 
            this.датаВыполненияЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата выполнения заказа";
            this.датаВыполненияЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата выполнения заказа";
            this.датаВыполненияЗаказаDataGridViewTextBoxColumn.Name = "датаВыполненияЗаказаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // наименованиеУслугиDataGridViewTextBoxColumn1
            // 
            this.наименованиеУслугиDataGridViewTextBoxColumn1.DataPropertyName = "Наименование услуги";
            this.наименованиеУслугиDataGridViewTextBoxColumn1.HeaderText = "Наименование услуги";
            this.наименованиеУслугиDataGridViewTextBoxColumn1.Name = "наименованиеУслугиDataGridViewTextBoxColumn1";
            // 
            // стоимостьУслугиDataGridViewTextBoxColumn
            // 
            this.стоимостьУслугиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость услуги";
            this.стоимостьУслугиDataGridViewTextBoxColumn.HeaderText = "Стоимость услуги";
            this.стоимостьУслугиDataGridViewTextBoxColumn.Name = "стоимостьУслугиDataGridViewTextBoxColumn";
            // 
            // оплатаDataGridViewTextBoxColumn
            // 
            this.оплатаDataGridViewTextBoxColumn.DataPropertyName = "Оплата";
            this.оплатаDataGridViewTextBoxColumn.HeaderText = "Оплата";
            this.оплатаDataGridViewTextBoxColumn.Name = "оплатаDataGridViewTextBoxColumn";
            // 
            // подписиDataGridViewTextBoxColumn
            // 
            this.подписиDataGridViewTextBoxColumn.DataPropertyName = "Подписи";
            this.подписиDataGridViewTextBoxColumn.HeaderText = "Подписи";
            this.подписиDataGridViewTextBoxColumn.Name = "подписиDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idДокументаDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.наименованиеБанкаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.счётфактураBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(769, 358);
            this.dataGridView3.TabIndex = 0;
            // 
            // facturaDataSet
            // 
            this.facturaDataSet.DataSetName = "FacturaDataSet";
            this.facturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счётфактураBindingSource
            // 
            this.счётфактураBindingSource.DataMember = "Счёт-фактура";
            this.счётфактураBindingSource.DataSource = this.facturaDataSet;
            // 
            // счёт_фактураTableAdapter
            // 
            this.счёт_фактураTableAdapter.ClearBeforeFill = true;
            // 
            // idДокументаDataGridViewTextBoxColumn1
            // 
            this.idДокументаDataGridViewTextBoxColumn1.DataPropertyName = "id документа";
            this.idДокументаDataGridViewTextBoxColumn1.HeaderText = "id документа";
            this.idДокументаDataGridViewTextBoxColumn1.Name = "idДокументаDataGridViewTextBoxColumn1";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            // 
            // наименованиеБанкаDataGridViewTextBoxColumn
            // 
            this.наименованиеБанкаDataGridViewTextBoxColumn.DataPropertyName = "Наименование банка";
            this.наименованиеБанкаDataGridViewTextBoxColumn.HeaderText = "Наименование банка";
            this.наименованиеБанкаDataGridViewTextBoxColumn.Name = "наименованиеБанкаDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(698, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернуться назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(801, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Документы";
            this.Load += new System.EventHandler(this.Documents_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actRabotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.актВыполненияРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнааяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счётфактураBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private ActRabotDataSet actRabotDataSet;
        private System.Windows.Forms.BindingSource актВыполненияРаботBindingSource;
        private ActRabotDataSetTableAdapters.Акт_выполнения_работTableAdapter акт_выполнения_работTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьЗаЕдиницуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private NakladnayaDataSet nakladnayaDataSet;
        private System.Windows.Forms.BindingSource накладнааяBindingSource;
        private NakladnayaDataSetTableAdapters.НакладнааяTableAdapter накладнааяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриёмкиЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыполненияЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеУслугиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn подписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private FacturaDataSet facturaDataSet;
        private System.Windows.Forms.BindingSource счётфактураBindingSource;
        private FacturaDataSetTableAdapters.Счёт_фактураTableAdapter счёт_фактураTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДокументаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеБанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}