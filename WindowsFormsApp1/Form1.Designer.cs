namespace WindowsFormsApp1
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentWeighttextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaintreeView = new System.Windows.Forms.TreeView();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.AlltextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий суммарный вес";
            // 
            // CurrentWeighttextBox
            // 
            this.CurrentWeighttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentWeighttextBox.Location = new System.Drawing.Point(16, 34);
            this.CurrentWeighttextBox.Name = "CurrentWeighttextBox";
            this.CurrentWeighttextBox.ReadOnly = true;
            this.CurrentWeighttextBox.Size = new System.Drawing.Size(167, 27);
            this.CurrentWeighttextBox.TabIndex = 1;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(231, 34);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(116, 27);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(556, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Собрать набор вещей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaintreeView
            // 
            this.MaintreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaintreeView.Location = new System.Drawing.Point(16, 78);
            this.MaintreeView.Name = "MaintreeView";
            this.MaintreeView.Size = new System.Drawing.Size(534, 468);
            this.MaintreeView.TabIndex = 4;
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResulttextBox.Location = new System.Drawing.Point(556, 78);
            this.ResulttextBox.Multiline = true;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.ReadOnly = true;
            this.ResulttextBox.Size = new System.Drawing.Size(361, 468);
            this.ResulttextBox.TabIndex = 5;
            // 
            // AlltextBox1
            // 
            this.AlltextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlltextBox1.Location = new System.Drawing.Point(924, 78);
            this.AlltextBox1.Multiline = true;
            this.AlltextBox1.Name = "AlltextBox1";
            this.AlltextBox1.ReadOnly = true;
            this.AlltextBox1.Size = new System.Drawing.Size(361, 468);
            this.AlltextBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(924, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Все предметы";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlltextBox1);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.MaintreeView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.CurrentWeighttextBox);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentWeighttextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView MaintreeView;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.TextBox AlltextBox1;
        private System.Windows.Forms.Label label2;
    }
}

