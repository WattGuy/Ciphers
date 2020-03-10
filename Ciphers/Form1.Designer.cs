namespace Ciphers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.switchTrans = new System.Windows.Forms.Button();
            this.switchCesar = new System.Windows.Forms.Button();
            this.switchBinary = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cipherName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.labelCesarTo = new System.Windows.Forms.Label();
            this.labelCesarOn = new System.Windows.Forms.Label();
            this.labelCesarPositions = new System.Windows.Forms.Label();
            this.numericCesar = new System.Windows.Forms.NumericUpDown();
            this.switchAtbash = new System.Windows.Forms.Button();
            this.switchSWord = new System.Windows.Forms.Button();
            this.comboBoxSWordAlphabet = new System.Windows.Forms.ComboBox();
            this.labelSWordAlphabet = new System.Windows.Forms.Label();
            this.labelSWordWord = new System.Windows.Forms.Label();
            this.textBoxSWordWord = new System.Windows.Forms.TextBox();
            this.switchA1Z26 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCesar)).BeginInit();
            this.SuspendLayout();
            // 
            // switchTrans
            // 
            this.switchTrans.Enabled = false;
            this.switchTrans.Location = new System.Drawing.Point(9, 308);
            this.switchTrans.Name = "switchTrans";
            this.switchTrans.Size = new System.Drawing.Size(110, 23);
            this.switchTrans.TabIndex = 0;
            this.switchTrans.Text = "Транспозиция";
            this.switchTrans.UseVisualStyleBackColor = true;
            this.switchTrans.Click += new System.EventHandler(this.switchTrans_Click);
            // 
            // switchCesar
            // 
            this.switchCesar.AllowDrop = true;
            this.switchCesar.Location = new System.Drawing.Point(125, 308);
            this.switchCesar.Name = "switchCesar";
            this.switchCesar.Size = new System.Drawing.Size(107, 23);
            this.switchCesar.TabIndex = 1;
            this.switchCesar.Text = "Шифр Цезаря";
            this.switchCesar.UseVisualStyleBackColor = true;
            this.switchCesar.Click += new System.EventHandler(this.switchCesar_Click);
            // 
            // switchBinary
            // 
            this.switchBinary.Location = new System.Drawing.Point(238, 308);
            this.switchBinary.Name = "switchBinary";
            this.switchBinary.Size = new System.Drawing.Size(107, 23);
            this.switchBinary.TabIndex = 2;
            this.switchBinary.Text = "Бинарный Шифр";
            this.switchBinary.UseVisualStyleBackColor = true;
            this.switchBinary.Click += new System.EventHandler(this.switchBinary_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(9, 25);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(694, 96);
            this.inputBox.TabIndex = 3;
            this.inputBox.Text = "";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ввод";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(9, 191);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(694, 96);
            this.outputBox.TabIndex = 5;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вывод";
            // 
            // cipherName
            // 
            this.cipherName.AutoSize = true;
            this.cipherName.Location = new System.Drawing.Point(9, 124);
            this.cipherName.Name = "cipherName";
            this.cipherName.Size = new System.Drawing.Size(80, 13);
            this.cipherName.TabIndex = 7;
            this.cipherName.Text = "Транспозиция";
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Location = new System.Drawing.Point(12, 141);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(347, 32);
            this.description.TabIndex = 8;
            this.description.Text = "Перевернёт введенное Вами слово задом наперёд!";
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(519, 160);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(56, 17);
            this.radioLeft.TabIndex = 9;
            this.radioLeft.Text = "Влево";
            this.radioLeft.UseVisualStyleBackColor = true;
            this.radioLeft.Visible = false;
            this.radioLeft.CheckedChanged += new System.EventHandler(this.radioLeft_CheckedChanged);
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Checked = true;
            this.radioRight.Location = new System.Drawing.Point(519, 137);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(62, 17);
            this.radioRight.TabIndex = 10;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Вправо";
            this.radioRight.UseVisualStyleBackColor = true;
            this.radioRight.Visible = false;
            this.radioRight.CheckedChanged += new System.EventHandler(this.radioRight_CheckedChanged);
            // 
            // labelCesarTo
            // 
            this.labelCesarTo.AutoSize = true;
            this.labelCesarTo.Location = new System.Drawing.Point(476, 151);
            this.labelCesarTo.Name = "labelCesarTo";
            this.labelCesarTo.Size = new System.Drawing.Size(37, 13);
            this.labelCesarTo.TabIndex = 11;
            this.labelCesarTo.Text = "Сдвиг";
            this.labelCesarTo.Visible = false;
            // 
            // labelCesarOn
            // 
            this.labelCesarOn.AutoSize = true;
            this.labelCesarOn.Location = new System.Drawing.Point(581, 151);
            this.labelCesarOn.Name = "labelCesarOn";
            this.labelCesarOn.Size = new System.Drawing.Size(19, 13);
            this.labelCesarOn.TabIndex = 12;
            this.labelCesarOn.Text = "на";
            this.labelCesarOn.Visible = false;
            // 
            // labelCesarPositions
            // 
            this.labelCesarPositions.AutoSize = true;
            this.labelCesarPositions.Location = new System.Drawing.Point(654, 151);
            this.labelCesarPositions.Name = "labelCesarPositions";
            this.labelCesarPositions.Size = new System.Drawing.Size(49, 13);
            this.labelCesarPositions.TabIndex = 13;
            this.labelCesarPositions.Text = "позиций";
            this.labelCesarPositions.Visible = false;
            // 
            // numericCesar
            // 
            this.numericCesar.Location = new System.Drawing.Point(605, 149);
            this.numericCesar.Name = "numericCesar";
            this.numericCesar.Size = new System.Drawing.Size(49, 20);
            this.numericCesar.TabIndex = 15;
            this.numericCesar.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCesar.Visible = false;
            this.numericCesar.ValueChanged += new System.EventHandler(this.numericCesar_ValueChanged);
            // 
            // switchAtbash
            // 
            this.switchAtbash.Location = new System.Drawing.Point(351, 308);
            this.switchAtbash.Name = "switchAtbash";
            this.switchAtbash.Size = new System.Drawing.Size(107, 23);
            this.switchAtbash.TabIndex = 16;
            this.switchAtbash.Text = "Шифр Атбаш";
            this.switchAtbash.UseVisualStyleBackColor = true;
            this.switchAtbash.Click += new System.EventHandler(this.switchAtbash_Click);
            // 
            // switchSWord
            // 
            this.switchSWord.Location = new System.Drawing.Point(464, 308);
            this.switchSWord.Name = "switchSWord";
            this.switchSWord.Size = new System.Drawing.Size(145, 23);
            this.switchSWord.TabIndex = 17;
            this.switchSWord.Text = "Шифр с кодовым словом";
            this.switchSWord.UseVisualStyleBackColor = true;
            this.switchSWord.Click += new System.EventHandler(this.switchSWord_Click);
            // 
            // comboBoxSWordAlphabet
            // 
            this.comboBoxSWordAlphabet.DisplayMember = "Русский";
            this.comboBoxSWordAlphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSWordAlphabet.FormattingEnabled = true;
            this.comboBoxSWordAlphabet.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBoxSWordAlphabet.Location = new System.Drawing.Point(441, 152);
            this.comboBoxSWordAlphabet.Name = "comboBoxSWordAlphabet";
            this.comboBoxSWordAlphabet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSWordAlphabet.TabIndex = 18;
            this.comboBoxSWordAlphabet.Visible = false;
            this.comboBoxSWordAlphabet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSWordAlphabet_SelectedIndexChanged);
            // 
            // labelSWordAlphabet
            // 
            this.labelSWordAlphabet.AutoSize = true;
            this.labelSWordAlphabet.Location = new System.Drawing.Point(438, 137);
            this.labelSWordAlphabet.Name = "labelSWordAlphabet";
            this.labelSWordAlphabet.Size = new System.Drawing.Size(51, 13);
            this.labelSWordAlphabet.TabIndex = 19;
            this.labelSWordAlphabet.Text = "Алфавит";
            this.labelSWordAlphabet.Visible = false;
            // 
            // labelSWordWord
            // 
            this.labelSWordWord.AutoSize = true;
            this.labelSWordWord.Location = new System.Drawing.Point(577, 137);
            this.labelSWordWord.Name = "labelSWordWord";
            this.labelSWordWord.Size = new System.Drawing.Size(83, 13);
            this.labelSWordWord.TabIndex = 20;
            this.labelSWordWord.Text = "Кодовое слово";
            this.labelSWordWord.Visible = false;
            // 
            // textBoxSWordWord
            // 
            this.textBoxSWordWord.Location = new System.Drawing.Point(580, 152);
            this.textBoxSWordWord.Name = "textBoxSWordWord";
            this.textBoxSWordWord.Size = new System.Drawing.Size(122, 20);
            this.textBoxSWordWord.TabIndex = 21;
            this.textBoxSWordWord.Text = "Шифр";
            this.textBoxSWordWord.Visible = false;
            this.textBoxSWordWord.TextChanged += new System.EventHandler(this.textBoxSWordWord_TextChanged);
            // 
            // switchA1Z26
            // 
            this.switchA1Z26.Location = new System.Drawing.Point(615, 308);
            this.switchA1Z26.Name = "switchA1Z26";
            this.switchA1Z26.Size = new System.Drawing.Size(87, 23);
            this.switchA1Z26.TabIndex = 22;
            this.switchA1Z26.Text = "Шифр A1Z26";
            this.switchA1Z26.UseVisualStyleBackColor = true;
            this.switchA1Z26.Click += new System.EventHandler(this.switchA1Z26_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 343);
            this.Controls.Add(this.switchA1Z26);
            this.Controls.Add(this.textBoxSWordWord);
            this.Controls.Add(this.labelSWordWord);
            this.Controls.Add(this.labelSWordAlphabet);
            this.Controls.Add(this.comboBoxSWordAlphabet);
            this.Controls.Add(this.switchSWord);
            this.Controls.Add(this.switchAtbash);
            this.Controls.Add(this.numericCesar);
            this.Controls.Add(this.labelCesarPositions);
            this.Controls.Add(this.labelCesarOn);
            this.Controls.Add(this.labelCesarTo);
            this.Controls.Add(this.radioRight);
            this.Controls.Add(this.radioLeft);
            this.Controls.Add(this.description);
            this.Controls.Add(this.cipherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.switchBinary);
            this.Controls.Add(this.switchCesar);
            this.Controls.Add(this.switchTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифры";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCesar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button switchTrans;
        private System.Windows.Forms.Button switchCesar;
        private System.Windows.Forms.Button switchBinary;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cipherName;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.Label labelCesarTo;
        private System.Windows.Forms.Label labelCesarOn;
        private System.Windows.Forms.Label labelCesarPositions;
        private System.Windows.Forms.NumericUpDown numericCesar;
        private System.Windows.Forms.Button switchAtbash;
        private System.Windows.Forms.Button switchSWord;
        private System.Windows.Forms.ComboBox comboBoxSWordAlphabet;
        private System.Windows.Forms.Label labelSWordAlphabet;
        private System.Windows.Forms.Label labelSWordWord;
        private System.Windows.Forms.TextBox textBoxSWordWord;
        private System.Windows.Forms.Button switchA1Z26;
    }
}

