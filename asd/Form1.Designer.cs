namespace asd
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listboxStories = new System.Windows.Forms.ListBox();
            this.listboxNotStarted = new System.Windows.Forms.ListBox();
            this.listBoxInProgress = new System.Windows.Forms.ListBox();
            this.listBoxDone = new System.Windows.Forms.ListBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxStories
            // 
            this.listboxStories.AllowDrop = true;
            this.listboxStories.FormattingEnabled = true;
            this.listboxStories.HorizontalScrollbar = true;
            this.listboxStories.Location = new System.Drawing.Point(27, 486);
            this.listboxStories.Name = "listboxStories";
            this.listboxStories.Size = new System.Drawing.Size(195, 277);
            this.listboxStories.Sorted = true;
            this.listboxStories.TabIndex = 0;
            // 
            // listboxNotStarted
            // 
            this.listboxNotStarted.AllowDrop = true;
            this.listboxNotStarted.FormattingEnabled = true;
            this.listboxNotStarted.HorizontalScrollbar = true;
            this.listboxNotStarted.Location = new System.Drawing.Point(245, 486);
            this.listboxNotStarted.Name = "listboxNotStarted";
            this.listboxNotStarted.Size = new System.Drawing.Size(195, 277);
            this.listboxNotStarted.Sorted = true;
            this.listboxNotStarted.TabIndex = 1;
            this.listboxNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxNotStarted_DragDrop);
            this.listboxNotStarted.DragOver += new System.Windows.Forms.DragEventHandler(this.listboxNotStarted_DragOver);
            this.listboxNotStarted.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listboxNotStarted_MouseDown);
            // 
            // listBoxInProgress
            // 
            this.listBoxInProgress.AllowDrop = true;
            this.listBoxInProgress.FormattingEnabled = true;
            this.listBoxInProgress.HorizontalScrollbar = true;
            this.listBoxInProgress.Location = new System.Drawing.Point(465, 486);
            this.listBoxInProgress.Name = "listBoxInProgress";
            this.listBoxInProgress.Size = new System.Drawing.Size(195, 277);
            this.listBoxInProgress.Sorted = true;
            this.listBoxInProgress.TabIndex = 2;
            this.listBoxInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxInProgress_DragDrop);
            this.listBoxInProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxInProgress_DragOver);
            this.listBoxInProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxInProgress_MouseDown);
            // 
            // listBoxDone
            // 
            this.listBoxDone.AllowDrop = true;
            this.listBoxDone.FormattingEnabled = true;
            this.listBoxDone.HorizontalScrollbar = true;
            this.listBoxDone.Location = new System.Drawing.Point(677, 486);
            this.listBoxDone.Name = "listBoxDone";
            this.listBoxDone.Size = new System.Drawing.Size(195, 277);
            this.listBoxDone.Sorted = true;
            this.listBoxDone.TabIndex = 3;
            this.listBoxDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxDone_DragDrop);
            this.listBoxDone.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxDone_DragOver);
            this.listBoxDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxDone_MouseDown);
            // 
            // Ekle
            // 
            this.Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle.Location = new System.Drawing.Point(711, 187);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(122, 62);
            this.Ekle.TabIndex = 6;
            this.Ekle.Text = "Stories Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(287, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Not Started";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(512, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "In Progress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(722, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Done";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(711, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 62);
            this.button1.TabIndex = 12;
            this.button1.Text = "Task Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 355);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 29);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(51, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Task Hangi Stories\'e Ait";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(277, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Task\'i Kim Gerçekleştiricek";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(490, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 40);
            this.label7.TabIndex = 15;
            this.label7.Text = "Task\'in Yapılma Tarihi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = null;
            this.textEdit1.Location = new System.Drawing.Point(465, 355);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.textEdit1.Properties.DisplayFormat.FormatString = "";
            this.textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit1.Properties.EditFormat.FormatString = "";
            this.textEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit1.Properties.Mask.EditMask = "";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.textEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.textEdit1.Size = new System.Drawing.Size(195, 20);
            this.textEdit1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(711, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 62);
            this.button2.TabIndex = 17;
            this.button2.Text = "Kaydet ve Çık";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(280, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 40);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stories Bilgileri";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 26);
            this.comboBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(51, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 40);
            this.label9.TabIndex = 21;
            this.label9.Text = "Stories Adı";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 210);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 29);
            this.textBox3.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(538, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 62);
            this.button3.TabIndex = 22;
            this.button3.Text = "Çık";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 777);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxDone);
            this.Controls.Add(this.listBoxInProgress);
            this.Controls.Add(this.listboxNotStarted);
            this.Controls.Add(this.listboxStories);
            this.Controls.Add(this.textEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Scrum";
            this.TransparencyKey = System.Drawing.Color.DarkOrange;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxStories;
        private System.Windows.Forms.ListBox listboxNotStarted;
        private System.Windows.Forms.ListBox listBoxInProgress;
        private System.Windows.Forms.ListBox listBoxDone;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit textEdit1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
    }
}

