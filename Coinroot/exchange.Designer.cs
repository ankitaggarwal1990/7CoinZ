namespace Coinroot
{
    partial class exchange
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.recieve_unit_label = new System.Windows.Forms.Label();
            this.exchange_unit_label = new System.Windows.Forms.Label();
            this.exchange_button = new System.Windows.Forms.Button();
            this.recieve_textBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.recieve_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exchange_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recieve_comboBox = new System.Windows.Forms.ComboBox();
            this.exchange_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recieve_unit_label);
            this.panel1.Controls.Add(this.exchange_unit_label);
            this.panel1.Controls.Add(this.exchange_button);
            this.panel1.Controls.Add(this.recieve_textBox);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.recieve_label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exchange_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.recieve_comboBox);
            this.panel1.Controls.Add(this.exchange_comboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 413);
            this.panel1.TabIndex = 0;
            // 
            // recieve_unit_label
            // 
            this.recieve_unit_label.AutoSize = true;
            this.recieve_unit_label.Location = new System.Drawing.Point(581, 172);
            this.recieve_unit_label.Name = "recieve_unit_label";
            this.recieve_unit_label.Size = new System.Drawing.Size(35, 13);
            this.recieve_unit_label.TabIndex = 14;
            this.recieve_unit_label.Text = "label6";
            // 
            // exchange_unit_label
            // 
            this.exchange_unit_label.AutoSize = true;
            this.exchange_unit_label.Location = new System.Drawing.Point(262, 172);
            this.exchange_unit_label.Name = "exchange_unit_label";
            this.exchange_unit_label.Size = new System.Drawing.Size(35, 13);
            this.exchange_unit_label.TabIndex = 13;
            this.exchange_unit_label.Text = "label4";
            // 
            // exchange_button
            // 
            this.exchange_button.Location = new System.Drawing.Point(262, 332);
            this.exchange_button.Name = "exchange_button";
            this.exchange_button.Size = new System.Drawing.Size(75, 23);
            this.exchange_button.TabIndex = 12;
            this.exchange_button.Text = "Exchange";
            this.exchange_button.UseVisualStyleBackColor = true;
            this.exchange_button.Click += new System.EventHandler(this.exchange_button_Click);
            // 
            // recieve_textBox
            // 
            this.recieve_textBox.Location = new System.Drawing.Point(473, 251);
            this.recieve_textBox.Name = "recieve_textBox";
            this.recieve_textBox.ReadOnly = true;
            this.recieve_textBox.Size = new System.Drawing.Size(100, 20);
            this.recieve_textBox.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 8;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Location = new System.Drawing.Point(132, 250);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Recieve Balance : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enter Balance :";
            // 
            // recieve_label
            // 
            this.recieve_label.AutoSize = true;
            this.recieve_label.Location = new System.Drawing.Point(478, 172);
            this.recieve_label.Name = "recieve_label";
            this.recieve_label.Size = new System.Drawing.Size(35, 13);
            this.recieve_label.TabIndex = 7;
            this.recieve_label.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wallet Balance : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // exchange_label
            // 
            this.exchange_label.AutoSize = true;
            this.exchange_label.Location = new System.Drawing.Point(155, 172);
            this.exchange_label.Name = "exchange_label";
            this.exchange_label.Size = new System.Drawing.Size(35, 13);
            this.exchange_label.TabIndex = 5;
            this.exchange_label.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wallet Balance : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Recieve : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Exchage : ";
            // 
            // recieve_comboBox
            // 
            this.recieve_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recieve_comboBox.FormattingEnabled = true;
            this.recieve_comboBox.Location = new System.Drawing.Point(452, 97);
            this.recieve_comboBox.Name = "recieve_comboBox";
            this.recieve_comboBox.Size = new System.Drawing.Size(121, 21);
            this.recieve_comboBox.TabIndex = 1;
            this.recieve_comboBox.SelectedIndexChanged += new System.EventHandler(this.recieve_comboBox_SelectedIndexChanged);
            // 
            // exchange_comboBox
            // 
            this.exchange_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exchange_comboBox.FormattingEnabled = true;
            this.exchange_comboBox.Location = new System.Drawing.Point(132, 97);
            this.exchange_comboBox.Name = "exchange_comboBox";
            this.exchange_comboBox.Size = new System.Drawing.Size(121, 21);
            this.exchange_comboBox.TabIndex = 0;
            this.exchange_comboBox.SelectedIndexChanged += new System.EventHandler(this.exchange_comboBox_SelectedIndexChanged_1);
            // 
            // exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 413);
            this.Controls.Add(this.panel1);
            this.Name = "exchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exchange_button;
        private System.Windows.Forms.TextBox recieve_textBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label recieve_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exchange_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox recieve_comboBox;
        private System.Windows.Forms.ComboBox exchange_comboBox;
        private System.Windows.Forms.Label recieve_unit_label;
        private System.Windows.Forms.Label exchange_unit_label;
    }
}