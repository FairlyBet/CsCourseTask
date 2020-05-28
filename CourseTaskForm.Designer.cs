namespace CsCourseTask
{
    partial class CourseTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseTask));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.createNote = new System.Windows.Forms.Button();
            this.formBox = new System.Windows.Forms.GroupBox();
            this.NumToEditUpDown = new System.Windows.Forms.NumericUpDown();
            this.PayedBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.debtAmountTextBox = new System.Windows.Forms.TextBox();
            this.serviceCostTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.workTypeTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.saveInfButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.FIleStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОбщийСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьПоНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьДолжниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общаяЗадолженностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипоамРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьПоНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumToDelTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.стеретьНедолжниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassCheckGroupBox = new System.Windows.Forms.GroupBox();
            this.SavePass = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.CancelAllowButton = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.patientsTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.formBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumToEditUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PassCheckGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Enabled = false;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(534, 5);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(116, 14);
            this.searchBox.TabIndex = 4;
            this.searchBox.TabStop = false;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // createNote
            // 
            this.createNote.BackColor = System.Drawing.SystemColors.Control;
            this.createNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createNote.Enabled = false;
            this.createNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNote.Location = new System.Drawing.Point(552, 510);
            this.createNote.Margin = new System.Windows.Forms.Padding(2);
            this.createNote.Name = "createNote";
            this.createNote.Size = new System.Drawing.Size(98, 22);
            this.createNote.TabIndex = 6;
            this.createNote.Text = "Новая запись";
            this.createNote.UseVisualStyleBackColor = false;
            this.createNote.Click += new System.EventHandler(this.CreateNote_Click);
            // 
            // formBox
            // 
            this.formBox.Controls.Add(this.NumToEditUpDown);
            this.formBox.Controls.Add(this.PayedBox);
            this.formBox.Controls.Add(this.label7);
            this.formBox.Controls.Add(this.label6);
            this.formBox.Controls.Add(this.cancelButton);
            this.formBox.Controls.Add(this.label5);
            this.formBox.Controls.Add(this.label4);
            this.formBox.Controls.Add(this.label3);
            this.formBox.Controls.Add(this.label2);
            this.formBox.Controls.Add(this.label1);
            this.formBox.Controls.Add(this.debtAmountTextBox);
            this.formBox.Controls.Add(this.serviceCostTextBox);
            this.formBox.Controls.Add(this.cardNumberTextBox);
            this.formBox.Controls.Add(this.workTypeTextBox);
            this.formBox.Controls.Add(this.fullNameTextBox);
            this.formBox.Controls.Add(this.saveInfButton);
            this.formBox.Controls.Add(this.EditButton);
            this.formBox.Enabled = false;
            this.formBox.Location = new System.Drawing.Point(191, 123);
            this.formBox.Margin = new System.Windows.Forms.Padding(2);
            this.formBox.Name = "formBox";
            this.formBox.Padding = new System.Windows.Forms.Padding(2);
            this.formBox.Size = new System.Drawing.Size(281, 249);
            this.formBox.TabIndex = 7;
            this.formBox.TabStop = false;
            this.formBox.Visible = false;
            this.formBox.Leave += new System.EventHandler(this.formBox_Leave);
            // 
            // NumToEditUpDown
            // 
            this.NumToEditUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.NumToEditUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumToEditUpDown.Enabled = false;
            this.NumToEditUpDown.Location = new System.Drawing.Point(164, 227);
            this.NumToEditUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumToEditUpDown.Name = "NumToEditUpDown";
            this.NumToEditUpDown.Size = new System.Drawing.Size(36, 16);
            this.NumToEditUpDown.TabIndex = 17;
            this.NumToEditUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumToEditUpDown.Visible = false;
            this.NumToEditUpDown.ValueChanged += new System.EventHandler(this.NumToEditUpDown_ValueChanged);
            // 
            // PayedBox
            // 
            this.PayedBox.AutoSize = true;
            this.PayedBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PayedBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayedBox.Location = new System.Drawing.Point(103, 135);
            this.PayedBox.Name = "PayedBox";
            this.PayedBox.Size = new System.Drawing.Size(75, 17);
            this.PayedBox.TabIndex = 16;
            this.PayedBox.Text = "Оплачено";
            this.PayedBox.UseVisualStyleBackColor = false;
            this.PayedBox.CheckedChanged += new System.EventHandler(this.PayedBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(79, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "₴";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(79, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "₴";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Location = new System.Drawing.Point(4, 225);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 20);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сумма долга";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер карточики";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип работы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // debtAmountTextBox
            // 
            this.debtAmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.debtAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debtAmountTextBox.Enabled = false;
            this.debtAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debtAmountTextBox.Location = new System.Drawing.Point(4, 172);
            this.debtAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.debtAmountTextBox.Name = "debtAmountTextBox";
            this.debtAmountTextBox.Size = new System.Drawing.Size(75, 20);
            this.debtAmountTextBox.TabIndex = 4;
            this.debtAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // serviceCostTextBox
            // 
            this.serviceCostTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.serviceCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceCostTextBox.Location = new System.Drawing.Point(4, 133);
            this.serviceCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serviceCostTextBox.Name = "serviceCostTextBox";
            this.serviceCostTextBox.Size = new System.Drawing.Size(75, 20);
            this.serviceCostTextBox.TabIndex = 3;
            this.serviceCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.serviceCostTextBox.TextChanged += new System.EventHandler(this.serviceCostTextBox_TextChanged);
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cardNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNumberTextBox.Location = new System.Drawing.Point(4, 94);
            this.cardNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.cardNumberTextBox.TabIndex = 2;
            // 
            // workTypeTextBox
            // 
            this.workTypeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.workTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workTypeTextBox.Location = new System.Drawing.Point(4, 55);
            this.workTypeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workTypeTextBox.Name = "workTypeTextBox";
            this.workTypeTextBox.Size = new System.Drawing.Size(272, 20);
            this.workTypeTextBox.TabIndex = 1;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTextBox.Location = new System.Drawing.Point(4, 16);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(272, 20);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // saveInfButton
            // 
            this.saveInfButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveInfButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveInfButton.Location = new System.Drawing.Point(211, 225);
            this.saveInfButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveInfButton.Name = "saveInfButton";
            this.saveInfButton.Size = new System.Drawing.Size(66, 20);
            this.saveInfButton.TabIndex = 5;
            this.saveInfButton.Text = "Добавить";
            this.saveInfButton.UseVisualStyleBackColor = false;
            this.saveInfButton.Click += new System.EventHandler(this.SaveInfButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.Enabled = false;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Location = new System.Drawing.Point(205, 225);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(72, 20);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Сохранить";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FIleStripMenu
            // 
            this.FIleStripMenu.BackColor = System.Drawing.SystemColors.Control;
            this.FIleStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FIleStripMenu.Name = "FIleStripMenu";
            this.FIleStripMenu.Size = new System.Drawing.Size(48, 20);
            this.FIleStripMenu.Text = "Файл";
            // 
            // CreateStripMenuItem
            // 
            this.CreateStripMenuItem.Name = "CreateStripMenuItem";
            this.CreateStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateStripMenuItem.Text = "Создать";
            this.CreateStripMenuItem.Click += new System.EventHandler(this.CreateStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.SaveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FIleStripMenu,
            this.EditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьОбщийСписокToolStripMenuItem,
            this.изменитьЗаписьПоНомеруToolStripMenuItem,
            this.показатьДолжниковToolStripMenuItem,
            this.удалитьЗаписьПоНомеруToolStripMenuItem,
            this.стеретьНедолжниковToolStripMenuItem});
            this.EditToolStripMenuItem.Enabled = false;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.EditToolStripMenuItem.Text = "Редактировать";
            // 
            // показатьОбщийСписокToolStripMenuItem
            // 
            this.показатьОбщийСписокToolStripMenuItem.Name = "показатьОбщийСписокToolStripMenuItem";
            this.показатьОбщийСписокToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.показатьОбщийСписокToolStripMenuItem.Text = "Показать общий список";
            this.показатьОбщийСписокToolStripMenuItem.Click += new System.EventHandler(this.ShowFullListToolStripMenuItem_Click);
            // 
            // изменитьЗаписьПоНомеруToolStripMenuItem
            // 
            this.изменитьЗаписьПоНомеруToolStripMenuItem.Name = "изменитьЗаписьПоНомеруToolStripMenuItem";
            this.изменитьЗаписьПоНомеруToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.изменитьЗаписьПоНомеруToolStripMenuItem.Text = "Изменить запись по номеру";
            this.изменитьЗаписьПоНомеруToolStripMenuItem.Click += new System.EventHandler(this.EditByNumToolStripMenuItem_Click);
            // 
            // показатьДолжниковToolStripMenuItem
            // 
            this.показатьДолжниковToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общаяЗадолженностьToolStripMenuItem,
            this.поТипоамРаботToolStripMenuItem});
            this.показатьДолжниковToolStripMenuItem.Name = "показатьДолжниковToolStripMenuItem";
            this.показатьДолжниковToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.показатьДолжниковToolStripMenuItem.Text = "Показать должников ";
            // 
            // общаяЗадолженностьToolStripMenuItem
            // 
            this.общаяЗадолженностьToolStripMenuItem.Name = "общаяЗадолженностьToolStripMenuItem";
            this.общаяЗадолженностьToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.общаяЗадолженностьToolStripMenuItem.Text = "Общая задолженность";
            this.общаяЗадолженностьToolStripMenuItem.Click += new System.EventHandler(this.DebtSearchToolStripMenuItem_Click);
            // 
            // поТипоамРаботToolStripMenuItem
            // 
            this.поТипоамРаботToolStripMenuItem.Name = "поТипоамРаботToolStripMenuItem";
            this.поТипоамРаботToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.поТипоамРаботToolStripMenuItem.Text = "По типам работ";
            this.поТипоамРаботToolStripMenuItem.Click += new System.EventHandler(this.WorkTypeSearchToolStripMenuItem_Click);
            // 
            // удалитьЗаписьПоНомеруToolStripMenuItem
            // 
            this.удалитьЗаписьПоНомеруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumToDelTextBox});
            this.удалитьЗаписьПоНомеруToolStripMenuItem.Name = "удалитьЗаписьПоНомеруToolStripMenuItem";
            this.удалитьЗаписьПоНомеруToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.удалитьЗаписьПоНомеруToolStripMenuItem.Text = "Удалить запись по номеру";
            this.удалитьЗаписьПоНомеруToolStripMenuItem.Click += new System.EventHandler(this.DeleteByNumToolStripMenuItem_Click);
            // 
            // NumToDelTextBox
            // 
            this.NumToDelTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NumToDelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumToDelTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumToDelTextBox.Name = "NumToDelTextBox";
            this.NumToDelTextBox.Size = new System.Drawing.Size(30, 16);
            this.NumToDelTextBox.Text = "0";
            this.NumToDelTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumToDelTextBox.Leave += new System.EventHandler(this.NumToDelTextBox_Leave);
            // 
            // стеретьНедолжниковToolStripMenuItem
            // 
            this.стеретьНедолжниковToolStripMenuItem.Name = "стеретьНедолжниковToolStripMenuItem";
            this.стеретьНедолжниковToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.стеретьНедолжниковToolStripMenuItem.Text = "Стереть недолжников";
            this.стеретьНедолжниковToolStripMenuItem.Click += new System.EventHandler(this.RemoveNonDebtorsToolStripMenuItem_Click);
            // 
            // PassCheckGroupBox
            // 
            this.PassCheckGroupBox.Controls.Add(this.SavePass);
            this.PassCheckGroupBox.Controls.Add(this.acceptButton);
            this.PassCheckGroupBox.Controls.Add(this.CancelAllowButton);
            this.PassCheckGroupBox.Controls.Add(this.PassBox);
            this.PassCheckGroupBox.Enabled = false;
            this.PassCheckGroupBox.Location = new System.Drawing.Point(237, 180);
            this.PassCheckGroupBox.Name = "PassCheckGroupBox";
            this.PassCheckGroupBox.Size = new System.Drawing.Size(200, 89);
            this.PassCheckGroupBox.TabIndex = 14;
            this.PassCheckGroupBox.TabStop = false;
            this.PassCheckGroupBox.Text = "Введите пароль";
            this.PassCheckGroupBox.Visible = false;
            // 
            // SavePass
            // 
            this.SavePass.BackColor = System.Drawing.SystemColors.Control;
            this.SavePass.Enabled = false;
            this.SavePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SavePass.Location = new System.Drawing.Point(122, 64);
            this.SavePass.Margin = new System.Windows.Forms.Padding(2);
            this.SavePass.Name = "SavePass";
            this.SavePass.Size = new System.Drawing.Size(72, 20);
            this.SavePass.TabIndex = 17;
            this.SavePass.Text = "Запомнить";
            this.SavePass.UseVisualStyleBackColor = false;
            this.SavePass.Visible = false;
            this.SavePass.Click += new System.EventHandler(this.SavePass_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.SystemColors.Control;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptButton.Location = new System.Drawing.Point(105, 64);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 20);
            this.acceptButton.TabIndex = 16;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelAllowButton
            // 
            this.CancelAllowButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelAllowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelAllowButton.Location = new System.Drawing.Point(5, 64);
            this.CancelAllowButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelAllowButton.Name = "CancelAllowButton";
            this.CancelAllowButton.Size = new System.Drawing.Size(67, 20);
            this.CancelAllowButton.TabIndex = 15;
            this.CancelAllowButton.Text = "Отменить";
            this.CancelAllowButton.UseVisualStyleBackColor = false;
            this.CancelAllowButton.Click += new System.EventHandler(this.CancelAllowButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.SystemColors.Control;
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(6, 19);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(188, 20);
            this.PassBox.TabIndex = 0;
            // 
            // patientsTextBox
            // 
            this.patientsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.patientsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientsTextBox.Location = new System.Drawing.Point(12, 28);
            this.patientsTextBox.Name = "patientsTextBox";
            this.patientsTextBox.ReadOnly = true;
            this.patientsTextBox.ShortcutsEnabled = false;
            this.patientsTextBox.Size = new System.Drawing.Size(638, 504);
            this.patientsTextBox.TabIndex = 15;
            this.patientsTextBox.TabStop = false;
            this.patientsTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(491, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Поиск";
            // 
            // CourseTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(662, 535);
            this.Controls.Add(this.PassCheckGroupBox);
            this.Controls.Add(this.formBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.createNote);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.patientsTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.formBox.ResumeLayout(false);
            this.formBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumToEditUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PassCheckGroupBox.ResumeLayout(false);
            this.PassCheckGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button createNote;
        private System.Windows.Forms.GroupBox formBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox workTypeTextBox;
        private System.Windows.Forms.Button saveInfButton;
        private System.Windows.Forms.TextBox debtAmountTextBox;
        private System.Windows.Forms.TextBox serviceCostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolStripMenuItem FIleStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox PassCheckGroupBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button CancelAllowButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.RichTextBox patientsTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьПоНомеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьПоНомеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьДолжниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общаяЗадолженностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТипоамРаботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьОбщийСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox NumToDelTextBox;
        private System.Windows.Forms.ToolStripMenuItem стеретьНедолжниковToolStripMenuItem;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.CheckBox PayedBox;
        private System.Windows.Forms.NumericUpDown NumToEditUpDown;
        private System.Windows.Forms.Button SavePass;
    }
}