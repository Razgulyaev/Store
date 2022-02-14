namespace NewStore
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
            this.Button_Admin_Entry = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Sort_All = new System.Windows.Forms.Button();
            this.Button_Sort_Data = new System.Windows.Forms.Button();
            this.Button_Sort_Alphabet = new System.Windows.Forms.Button();
            this.Button_Sort_Weight = new System.Windows.Forms.Button();
            this.Button_Sort_Price = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label_hi = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Admin_Entry
            // 
            this.Button_Admin_Entry.Location = new System.Drawing.Point(1073, 40);
            this.Button_Admin_Entry.Name = "Button_Admin_Entry";
            this.Button_Admin_Entry.Size = new System.Drawing.Size(184, 33);
            this.Button_Admin_Entry.TabIndex = 0;
            this.Button_Admin_Entry.Text = "Admin";
            this.Button_Admin_Entry.UseVisualStyleBackColor = true;
            this.Button_Admin_Entry.Click += new System.EventHandler(this.Button_Admin_Entry_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(255, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1002, 619);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewStore.Properties.Resources.vr_cod;
            this.pictureBox1.Location = new System.Drawing.Point(15, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Sort_All
            // 
            this.Button_Sort_All.Location = new System.Drawing.Point(255, 40);
            this.Button_Sort_All.Name = "Button_Sort_All";
            this.Button_Sort_All.Size = new System.Drawing.Size(142, 37);
            this.Button_Sort_All.TabIndex = 3;
            this.Button_Sort_All.Text = "Все";
            this.Button_Sort_All.UseVisualStyleBackColor = true;
            this.Button_Sort_All.Click += new System.EventHandler(this.Button_Sort_All_Click);
            // 
            // Button_Sort_Data
            // 
            this.Button_Sort_Data.Location = new System.Drawing.Point(403, 40);
            this.Button_Sort_Data.Name = "Button_Sort_Data";
            this.Button_Sort_Data.Size = new System.Drawing.Size(142, 37);
            this.Button_Sort_Data.TabIndex = 4;
            this.Button_Sort_Data.Text = "по дате";
            this.Button_Sort_Data.UseVisualStyleBackColor = true;
            this.Button_Sort_Data.Click += new System.EventHandler(this.Button_Sort_Data_Click);
            // 
            // Button_Sort_Alphabet
            // 
            this.Button_Sort_Alphabet.Location = new System.Drawing.Point(551, 40);
            this.Button_Sort_Alphabet.Name = "Button_Sort_Alphabet";
            this.Button_Sort_Alphabet.Size = new System.Drawing.Size(142, 37);
            this.Button_Sort_Alphabet.TabIndex = 5;
            this.Button_Sort_Alphabet.Text = "по алфавиту";
            this.Button_Sort_Alphabet.UseVisualStyleBackColor = true;
            this.Button_Sort_Alphabet.Click += new System.EventHandler(this.Button_Sort_Alphabet_Click);
            // 
            // Button_Sort_Weight
            // 
            this.Button_Sort_Weight.Location = new System.Drawing.Point(699, 40);
            this.Button_Sort_Weight.Name = "Button_Sort_Weight";
            this.Button_Sort_Weight.Size = new System.Drawing.Size(142, 37);
            this.Button_Sort_Weight.TabIndex = 6;
            this.Button_Sort_Weight.Text = "по весу";
            this.Button_Sort_Weight.UseVisualStyleBackColor = true;
            this.Button_Sort_Weight.Click += new System.EventHandler(this.Button_Sort_Weight_Click);
            // 
            // Button_Sort_Price
            // 
            this.Button_Sort_Price.Location = new System.Drawing.Point(847, 40);
            this.Button_Sort_Price.Name = "Button_Sort_Price";
            this.Button_Sort_Price.Size = new System.Drawing.Size(142, 37);
            this.Button_Sort_Price.TabIndex = 7;
            this.Button_Sort_Price.Text = "по цене";
            this.Button_Sort_Price.UseVisualStyleBackColor = true;
            this.Button_Sort_Price.Click += new System.EventHandler(this.Button_Sort_Price_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox2.Location = new System.Drawing.Point(15, 430);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 21);
            this.comboBox2.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "по Категории:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "по Производителю:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "до:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "от:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "по Цене:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Фильтровать";
            // 
            // Button_Ok
            // 
            this.Button_Ok.BackColor = System.Drawing.Color.LimeGreen;
            this.Button_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Ok.ForeColor = System.Drawing.Color.White;
            this.Button_Ok.Location = new System.Drawing.Point(33, 466);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(178, 29);
            this.Button_Ok.TabIndex = 25;
            this.Button_Ok.Text = "Применить";
            this.Button_Ok.UseVisualStyleBackColor = false;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(15, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(152, 324);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown2.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown2.TabIndex = 23;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(33, 324);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 20);
            this.button8.TabIndex = 33;
            this.button8.Text = "Авторизация";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(154, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 20);
            this.button9.TabIndex = 34;
            this.button9.Text = "Регистрация";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label_hi
            // 
            this.label_hi.AutoSize = true;
            this.label_hi.Location = new System.Drawing.Point(154, 16);
            this.label_hi.Name = "label_hi";
            this.label_hi.Size = new System.Drawing.Size(71, 13);
            this.label_hi.TabIndex = 35;
            this.label_hi.Text = "приветствие";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 20);
            this.button10.TabIndex = 36;
            this.button10.Text = "Выйти";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 712);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label_hi);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Button_Sort_Price);
            this.Controls.Add(this.Button_Sort_Weight);
            this.Controls.Add(this.Button_Sort_Alphabet);
            this.Controls.Add(this.Button_Sort_Data);
            this.Controls.Add(this.Button_Sort_All);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Button_Admin_Entry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Admin_Entry;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Sort_All;
        private System.Windows.Forms.Button Button_Sort_Data;
        private System.Windows.Forms.Button Button_Sort_Alphabet;
        private System.Windows.Forms.Button Button_Sort_Weight;
        private System.Windows.Forms.Button Button_Sort_Price;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label_hi;
        private System.Windows.Forms.Button button10;
    }
}

