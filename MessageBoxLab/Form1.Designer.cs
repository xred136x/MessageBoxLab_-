namespace MessageBoxLab
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
            this.components = new System.ComponentModel.Container();
            this.btnOneB = new System.Windows.Forms.Button();
            this.btnTwoB = new System.Windows.Forms.Button();
            this.btnThreeB = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelUserChoice = new System.Windows.Forms.Label();
            this.rbOkCancel = new System.Windows.Forms.RadioButton();
            this.rbRetryCancel = new System.Windows.Forms.RadioButton();
            this.label2button = new System.Windows.Forms.Label();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbYesNoCancel = new System.Windows.Forms.RadioButton();
            this.rbAbortRetryIgnore = new System.Windows.Forms.RadioButton();
            this.rbOK = new System.Windows.Forms.RadioButton();
            this.listBoxIcon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOneB
            // 
            this.btnOneB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOneB.Location = new System.Drawing.Point(38, 35);
            this.btnOneB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOneB.Name = "btnOneB";
            this.btnOneB.Size = new System.Drawing.Size(222, 100);
            this.btnOneB.TabIndex = 0;
            this.btnOneB.Text = "1 кнопка";
            this.btnOneB.UseVisualStyleBackColor = true;
            this.btnOneB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOneB_MouseClick);
            // 
            // btnTwoB
            // 
            this.btnTwoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTwoB.Location = new System.Drawing.Point(345, 35);
            this.btnTwoB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTwoB.Name = "btnTwoB";
            this.btnTwoB.Size = new System.Drawing.Size(222, 100);
            this.btnTwoB.TabIndex = 0;
            this.btnTwoB.Text = "2 кнопки";
            this.btnTwoB.UseVisualStyleBackColor = true;
            this.btnTwoB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTwoB_MouseClick);
            this.btnTwoB.MouseLeave += new System.EventHandler(this.btnTwoB_MouseLeave);
            this.btnTwoB.MouseHover += new System.EventHandler(this.btnTwoB_MouseHover);
            // 
            // btnThreeB
            // 
            this.btnThreeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThreeB.Location = new System.Drawing.Point(663, 35);
            this.btnThreeB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThreeB.Name = "btnThreeB";
            this.btnThreeB.Size = new System.Drawing.Size(222, 100);
            this.btnThreeB.TabIndex = 0;
            this.btnThreeB.Text = "3 кнопки";
            this.btnThreeB.UseVisualStyleBackColor = true;
            this.btnThreeB.Click += new System.EventHandler(this.btnThreeB_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(28, 402);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(126, 46);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelUserChoice
            // 
            this.labelUserChoice.AutoSize = true;
            this.labelUserChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserChoice.Location = new System.Drawing.Point(28, 475);
            this.labelUserChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserChoice.Name = "labelUserChoice";
            this.labelUserChoice.Size = new System.Drawing.Size(126, 46);
            this.labelUserChoice.TabIndex = 1;
            this.labelUserChoice.Text = "label1";
            // 
            // rbOkCancel
            // 
            this.rbOkCancel.AutoSize = true;
            this.rbOkCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOkCancel.Location = new System.Drawing.Point(345, 217);
            this.rbOkCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOkCancel.Name = "rbOkCancel";
            this.rbOkCancel.Size = new System.Drawing.Size(192, 36);
            this.rbOkCancel.TabIndex = 2;
            this.rbOkCancel.TabStop = true;
            this.rbOkCancel.Text = "OK - Cancel";
            this.rbOkCancel.UseVisualStyleBackColor = true;
            this.rbOkCancel.CheckedChanged += new System.EventHandler(this.rbOkCancel_CheckedChanged);
            // 
            // rbRetryCancel
            // 
            this.rbRetryCancel.AutoSize = true;
            this.rbRetryCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRetryCancel.Location = new System.Drawing.Point(345, 252);
            this.rbRetryCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRetryCancel.Name = "rbRetryCancel";
            this.rbRetryCancel.Size = new System.Drawing.Size(218, 36);
            this.rbRetryCancel.TabIndex = 2;
            this.rbRetryCancel.TabStop = true;
            this.rbRetryCancel.Text = "Retry - Cancel";
            this.rbRetryCancel.UseVisualStyleBackColor = true;
            // 
            // label2button
            // 
            this.label2button.AutoSize = true;
            this.label2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2button.Location = new System.Drawing.Point(345, 165);
            this.label2button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2button.Name = "label2button";
            this.label2button.Size = new System.Drawing.Size(111, 32);
            this.label2button.TabIndex = 3;
            this.label2button.Text = "Кнопки";
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbYesNo.Location = new System.Drawing.Point(345, 291);
            this.rbYesNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(147, 36);
            this.rbYesNo.TabIndex = 2;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "Yes - No";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbYesNoCancel
            // 
            this.rbYesNoCancel.AutoSize = true;
            this.rbYesNoCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbYesNoCancel.Location = new System.Drawing.Point(649, 186);
            this.rbYesNoCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbYesNoCancel.Name = "rbYesNoCancel";
            this.rbYesNoCancel.Size = new System.Drawing.Size(259, 36);
            this.rbYesNoCancel.TabIndex = 2;
            this.rbYesNoCancel.TabStop = true;
            this.rbYesNoCancel.Text = "Yes - No - Cancel";
            this.rbYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // rbAbortRetryIgnore
            // 
            this.rbAbortRetryIgnore.AutoSize = true;
            this.rbAbortRetryIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAbortRetryIgnore.Location = new System.Drawing.Point(649, 232);
            this.rbAbortRetryIgnore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAbortRetryIgnore.Name = "rbAbortRetryIgnore";
            this.rbAbortRetryIgnore.Size = new System.Drawing.Size(300, 36);
            this.rbAbortRetryIgnore.TabIndex = 2;
            this.rbAbortRetryIgnore.TabStop = true;
            this.rbAbortRetryIgnore.Text = "Abort - Retry - Ignore";
            this.rbAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.rbAbortRetryIgnore.CheckedChanged += new System.EventHandler(this.rbOkCancel_CheckedChanged);
            // 
            // rbOK
            // 
            this.rbOK.AutoSize = true;
            this.rbOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOK.Location = new System.Drawing.Point(91, 186);
            this.rbOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOK.Name = "rbOK";
            this.rbOK.Size = new System.Drawing.Size(87, 36);
            this.rbOK.TabIndex = 2;
            this.rbOK.TabStop = true;
            this.rbOK.Text = "OK ";
            this.rbOK.UseVisualStyleBackColor = true;
            this.rbOK.CheckedChanged += new System.EventHandler(this.rbOkCancel_CheckedChanged);
            // 
            // listBoxIcon
            // 
            this.listBoxIcon.FormattingEnabled = true;
            this.listBoxIcon.ItemHeight = 20;
            this.listBoxIcon.Items.AddRange(new object[] {
            "Asterisk",
            "Warning",
            "Error",
            "Exclamation",
            "Hand",
            "Information",
            "None",
            "Question",
            "Stop"});
            this.listBoxIcon.Location = new System.Drawing.Point(675, 324);
            this.listBoxIcon.Name = "listBoxIcon";
            this.listBoxIcon.Size = new System.Drawing.Size(251, 184);
            this.listBoxIcon.TabIndex = 4;
            this.listBoxIcon.SelectedIndexChanged += new System.EventHandler(this.listBoxIcon_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 728);
            this.Controls.Add(this.listBoxIcon);
            this.Controls.Add(this.label2button);
            this.Controls.Add(this.rbYesNoCancel);
            this.Controls.Add(this.rbYesNo);
            this.Controls.Add(this.rbRetryCancel);
            this.Controls.Add(this.rbOK);
            this.Controls.Add(this.rbAbortRetryIgnore);
            this.Controls.Add(this.rbOkCancel);
            this.Controls.Add(this.labelUserChoice);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnThreeB);
            this.Controls.Add(this.btnTwoB);
            this.Controls.Add(this.btnOneB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneB;
        private System.Windows.Forms.Button btnTwoB;
        private System.Windows.Forms.Button btnThreeB;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelUserChoice;
        private System.Windows.Forms.RadioButton rbOkCancel;
        private System.Windows.Forms.RadioButton rbRetryCancel;
        private System.Windows.Forms.Label label2button;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbYesNoCancel;
        private System.Windows.Forms.RadioButton rbAbortRetryIgnore;
        private System.Windows.Forms.RadioButton rbOK;
        private System.Windows.Forms.ListBox listBoxIcon;
    }
}

