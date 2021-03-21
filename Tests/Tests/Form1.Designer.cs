
namespace Tests
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_openFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_variantsCount = new System.Windows.Forms.TextBox();
            this.tb_testCountInVariant = new System.Windows.Forms.TextBox();
            this.tb_testCountInFile = new System.Windows.Forms.TextBox();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_openedFile = new System.Windows.Forms.RichTextBox();
            this.lbl_selectedFile = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_openFile.Location = new System.Drawing.Point(83, 24);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(286, 53);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Відкрити тест";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість варіантів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Питань у варіанті";
            // 
            // tb_variantsCount
            // 
            this.tb_variantsCount.Location = new System.Drawing.Point(248, 229);
            this.tb_variantsCount.Name = "tb_variantsCount";
            this.tb_variantsCount.Size = new System.Drawing.Size(136, 22);
            this.tb_variantsCount.TabIndex = 3;
            this.tb_variantsCount.Text = "3";
            // 
            // tb_testCountInVariant
            // 
            this.tb_testCountInVariant.Location = new System.Drawing.Point(248, 277);
            this.tb_testCountInVariant.Name = "tb_testCountInVariant";
            this.tb_testCountInVariant.Size = new System.Drawing.Size(136, 22);
            this.tb_testCountInVariant.TabIndex = 4;
            this.tb_testCountInVariant.Text = "20";
            // 
            // tb_testCountInFile
            // 
            this.tb_testCountInFile.Location = new System.Drawing.Point(294, 166);
            this.tb_testCountInFile.Name = "tb_testCountInFile";
            this.tb_testCountInFile.ReadOnly = true;
            this.tb_testCountInFile.Size = new System.Drawing.Size(90, 22);
            this.tb_testCountInFile.TabIndex = 8;
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(226, 121);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.ReadOnly = true;
            this.tb_fileName.Size = new System.Drawing.Size(158, 22);
            this.tb_fileName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(60, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість питань у тесті";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Файл з тестом";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_submit.Location = new System.Drawing.Point(192, 351);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(192, 45);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Зберегти варіанти";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_openedFile
            // 
            this.tb_openedFile.Location = new System.Drawing.Point(427, 79);
            this.tb_openedFile.Name = "tb_openedFile";
            this.tb_openedFile.ReadOnly = true;
            this.tb_openedFile.Size = new System.Drawing.Size(490, 317);
            this.tb_openedFile.TabIndex = 11;
            this.tb_openedFile.Text = "";
            // 
            // lbl_selectedFile
            // 
            this.lbl_selectedFile.AutoSize = true;
            this.lbl_selectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_selectedFile.Location = new System.Drawing.Point(555, 40);
            this.lbl_selectedFile.Name = "lbl_selectedFile";
            this.lbl_selectedFile.Size = new System.Drawing.Size(223, 20);
            this.lbl_selectedFile.TabIndex = 12;
            this.lbl_selectedFile.Text = "Обраний файл з тестами";
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(880, 37);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(37, 23);
            this.btn_help.TabIndex = 13;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(979, 430);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.lbl_selectedFile);
            this.Controls.Add(this.tb_openedFile);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_testCountInFile);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_testCountInVariant);
            this.Controls.Add(this.tb_variantsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_openFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Скомбінувати тести";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_variantsCount;
        private System.Windows.Forms.TextBox tb_testCountInVariant;
        private System.Windows.Forms.TextBox tb_testCountInFile;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RichTextBox tb_openedFile;
        private System.Windows.Forms.Label lbl_selectedFile;
        private System.Windows.Forms.Button btn_help;
    }
}

