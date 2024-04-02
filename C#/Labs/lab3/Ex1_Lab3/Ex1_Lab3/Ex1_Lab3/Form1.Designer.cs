namespace Ex1_Lab3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_InsertUniv = new System.Windows.Forms.Button();
            this.button_UpdateUniv = new System.Windows.Forms.Button();
            this.button_DeleteUniv = new System.Windows.Forms.Button();
            this.textBox_CodUniv = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_NumeUniv = new System.Windows.Forms.TextBox();
            this.textBox_IdUniv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_InsertUniv);
            this.groupBox1.Controls.Add(this.button_UpdateUniv);
            this.groupBox1.Controls.Add(this.button_DeleteUniv);
            this.groupBox1.Controls.Add(this.textBox_CodUniv);
            this.groupBox1.Controls.Add(this.textBox_City);
            this.groupBox1.Controls.Add(this.textBox_NumeUniv);
            this.groupBox1.Controls.Add(this.textBox_IdUniv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox_Fac);
            this.groupBox1.Controls.Add(this.listBox_Univ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemplu DB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(298, 318);
            this.dataGridView1.TabIndex = 15;
            // 
            // button_InsertUniv
            // 
            this.button_InsertUniv.Location = new System.Drawing.Point(203, 390);
            this.button_InsertUniv.Name = "button_InsertUniv";
            this.button_InsertUniv.Size = new System.Drawing.Size(85, 25);
            this.button_InsertUniv.TabIndex = 14;
            this.button_InsertUniv.Text = "Introducere";
            this.button_InsertUniv.UseVisualStyleBackColor = true;
            this.button_InsertUniv.Click += new System.EventHandler(this.button_InsertUniv_Click);
            // 
            // button_UpdateUniv
            // 
            this.button_UpdateUniv.Location = new System.Drawing.Point(294, 390);
            this.button_UpdateUniv.Name = "button_UpdateUniv";
            this.button_UpdateUniv.Size = new System.Drawing.Size(88, 25);
            this.button_UpdateUniv.TabIndex = 13;
            this.button_UpdateUniv.Text = "Actualizare";
            this.button_UpdateUniv.UseVisualStyleBackColor = true;
            this.button_UpdateUniv.Click += new System.EventHandler(this.button_UpdateUniv_Click);
            // 
            // button_DeleteUniv
            // 
            this.button_DeleteUniv.Location = new System.Drawing.Point(59, 283);
            this.button_DeleteUniv.Name = "button_DeleteUniv";
            this.button_DeleteUniv.Size = new System.Drawing.Size(84, 23);
            this.button_DeleteUniv.TabIndex = 12;
            this.button_DeleteUniv.Text = "Stergere";
            this.button_DeleteUniv.UseVisualStyleBackColor = true;
            this.button_DeleteUniv.Click += new System.EventHandler(this.button_DeleteUniv_Click);
            // 
            // textBox_CodUniv
            // 
            this.textBox_CodUniv.Location = new System.Drawing.Point(203, 352);
            this.textBox_CodUniv.Name = "textBox_CodUniv";
            this.textBox_CodUniv.ReadOnly = true;
            this.textBox_CodUniv.Size = new System.Drawing.Size(179, 22);
            this.textBox_CodUniv.TabIndex = 11;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(203, 302);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(179, 22);
            this.textBox_City.TabIndex = 10;
            // 
            // textBox_NumeUniv
            // 
            this.textBox_NumeUniv.Location = new System.Drawing.Point(203, 254);
            this.textBox_NumeUniv.Name = "textBox_NumeUniv";
            this.textBox_NumeUniv.Size = new System.Drawing.Size(179, 22);
            this.textBox_NumeUniv.TabIndex = 9;
            // 
            // textBox_IdUniv
            // 
            this.textBox_IdUniv.Location = new System.Drawing.Point(203, 213);
            this.textBox_IdUniv.Name = "textBox_IdUniv";
            this.textBox_IdUniv.Size = new System.Drawing.Size(179, 22);
            this.textBox_IdUniv.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cod Univ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nume Univ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.ItemHeight = 16;
            this.listBox_Fac.Location = new System.Drawing.Point(203, 97);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(179, 84);
            this.listBox_Fac.TabIndex = 3;
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.ItemHeight = 16;
            this.listBox_Univ.Location = new System.Drawing.Point(46, 97);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(106, 180);
            this.listBox_Univ.TabIndex = 2;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listBox_Univ_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facultati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Universitati";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_InsertUniv;
        private System.Windows.Forms.Button button_UpdateUniv;
        private System.Windows.Forms.Button button_DeleteUniv;
        private System.Windows.Forms.TextBox textBox_CodUniv;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_NumeUniv;
        private System.Windows.Forms.TextBox textBox_IdUniv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

