namespace PasswordGeneratorApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Special = new System.Windows.Forms.CheckBox();
            this.Nombre = new System.Windows.Forms.CheckBox();
            this.Upper = new System.Windows.Forms.CheckBox();
            this.Lower = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Généré";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(497, 212);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Special);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.Upper);
            this.groupBox1.Controls.Add(this.Lower);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(248, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 96);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // Special
            // 
            this.Special.Location = new System.Drawing.Point(6, 68);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(119, 18);
            this.Special.TabIndex = 6;
            this.Special.Text = "^$%{([])}=+-";
            this.Special.UseVisualStyleBackColor = true;
            this.Special.CheckedChanged += new System.EventHandler(this.Special_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(6, 50);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 21);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "0-9";
            this.Nombre.UseVisualStyleBackColor = true;
            this.Nombre.CheckedChanged += new System.EventHandler(this.Nombre_CheckedChanged);
            // 
            // Upper
            // 
            this.Upper.Location = new System.Drawing.Point(6, 32);
            this.Upper.Name = "Upper";
            this.Upper.Size = new System.Drawing.Size(47, 18);
            this.Upper.TabIndex = 4;
            this.Upper.Text = "A-Z";
            this.Upper.CheckedChanged += new System.EventHandler(this.Upper_CheckedChanged);
            // 
            // Lower
            // 
            this.Lower.Location = new System.Drawing.Point(6, 13);
            this.Lower.Name = "Lower";
            this.Lower.Size = new System.Drawing.Size(47, 20);
            this.Lower.TabIndex = 3;
            this.Lower.Text = "a-z";
            this.Lower.UseVisualStyleBackColor = true;
            this.Lower.CheckedChanged += new System.EventHandler(this.Lower_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de caractères";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mot de passe généré";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(458, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 10);
            this.label3.TabIndex = 9;
            this.label3.Text = "by zechaos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Copier dans le presse papier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(203, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 19);
            this.label4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(534, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Special;

        private System.Windows.Forms.CheckBox Nombre;

        private System.Windows.Forms.CheckBox Lower;
        private System.Windows.Forms.CheckBox Upper;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}