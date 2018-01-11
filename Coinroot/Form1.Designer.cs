namespace Coinroot
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
            this.balance_bitcoin = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wallet_panel = new System.Windows.Forms.Panel();
            this.bitcoin_wallet_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bitcoin_balance_wallet_label = new System.Windows.Forms.Label();
            this.bitcoin_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recieve_bitcoin_button = new System.Windows.Forms.Button();
            this.send_bitcoin_button = new System.Windows.Forms.Button();
            this.signup_label = new System.Windows.Forms.Label();
            this.signin_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.home_logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.wallet_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_panel = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.bitcoin_home_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wallet_panel.SuspendLayout();
            this.bitcoin_wallet_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_logo_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.home_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // balance_bitcoin
            // 
            this.balance_bitcoin.AutoSize = true;
            this.balance_bitcoin.Location = new System.Drawing.Point(221, 102);
            this.balance_bitcoin.Name = "balance_bitcoin";
            this.balance_bitcoin.Size = new System.Drawing.Size(0, 13);
            this.balance_bitcoin.TabIndex = 2;
            // 
            // wallet_panel
            // 
            this.wallet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.wallet_panel.Controls.Add(this.bitcoin_wallet_panel);
            this.wallet_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wallet_panel.Location = new System.Drawing.Point(187, 261);
            this.wallet_panel.Name = "wallet_panel";
            this.wallet_panel.Size = new System.Drawing.Size(706, 420);
            this.wallet_panel.TabIndex = 8;
            // 
            // bitcoin_wallet_panel
            // 
            this.bitcoin_wallet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.bitcoin_wallet_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bitcoin_wallet_panel.BackgroundImage")));
            this.bitcoin_wallet_panel.Controls.Add(this.button2);
            this.bitcoin_wallet_panel.Controls.Add(this.bitcoin_balance_wallet_label);
            this.bitcoin_wallet_panel.Controls.Add(this.bitcoin_listView);
            this.bitcoin_wallet_panel.Controls.Add(this.recieve_bitcoin_button);
            this.bitcoin_wallet_panel.Controls.Add(this.send_bitcoin_button);
            this.bitcoin_wallet_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bitcoin_wallet_panel.Location = new System.Drawing.Point(0, 6);
            this.bitcoin_wallet_panel.Name = "bitcoin_wallet_panel";
            this.bitcoin_wallet_panel.Size = new System.Drawing.Size(706, 414);
            this.bitcoin_wallet_panel.TabIndex = 6;
            this.bitcoin_wallet_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bitcoin_wallet_panel_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(643, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bitcoin_balance_wallet_label
            // 
            this.bitcoin_balance_wallet_label.AutoSize = true;
            this.bitcoin_balance_wallet_label.BackColor = System.Drawing.Color.Transparent;
            this.bitcoin_balance_wallet_label.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitcoin_balance_wallet_label.ForeColor = System.Drawing.Color.White;
            this.bitcoin_balance_wallet_label.Location = new System.Drawing.Point(229, 79);
            this.bitcoin_balance_wallet_label.Name = "bitcoin_balance_wallet_label";
            this.bitcoin_balance_wallet_label.Size = new System.Drawing.Size(114, 41);
            this.bitcoin_balance_wallet_label.TabIndex = 6;
            this.bitcoin_balance_wallet_label.Text = "label3";
            this.bitcoin_balance_wallet_label.Click += new System.EventHandler(this.bitcoin_balance_wallet_label_Click);
            // 
            // bitcoin_listView
            // 
            this.bitcoin_listView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bitcoin_listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bitcoin_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.bitcoin_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitcoin_listView.ForeColor = System.Drawing.Color.Black;
            this.bitcoin_listView.GridLines = true;
            this.bitcoin_listView.Location = new System.Drawing.Point(121, 294);
            this.bitcoin_listView.Name = "bitcoin_listView";
            this.bitcoin_listView.Size = new System.Drawing.Size(476, 112);
            this.bitcoin_listView.TabIndex = 5;
            this.bitcoin_listView.UseCompatibleStateImageBehavior = false;
            this.bitcoin_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S. No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            // 
            // recieve_bitcoin_button
            // 
            this.recieve_bitcoin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieve_bitcoin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieve_bitcoin_button.ForeColor = System.Drawing.Color.White;
            this.recieve_bitcoin_button.Location = new System.Drawing.Point(490, 187);
            this.recieve_bitcoin_button.Name = "recieve_bitcoin_button";
            this.recieve_bitcoin_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.recieve_bitcoin_button.Size = new System.Drawing.Size(107, 50);
            this.recieve_bitcoin_button.TabIndex = 4;
            this.recieve_bitcoin_button.Text = "Receive";
            this.recieve_bitcoin_button.UseVisualStyleBackColor = true;
            this.recieve_bitcoin_button.Click += new System.EventHandler(this.recieve_bitcoin_button_Click);
            // 
            // send_bitcoin_button
            // 
            this.send_bitcoin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_bitcoin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_bitcoin_button.ForeColor = System.Drawing.Color.White;
            this.send_bitcoin_button.Location = new System.Drawing.Point(121, 187);
            this.send_bitcoin_button.Name = "send_bitcoin_button";
            this.send_bitcoin_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.send_bitcoin_button.Size = new System.Drawing.Size(98, 50);
            this.send_bitcoin_button.TabIndex = 3;
            this.send_bitcoin_button.Text = "Send";
            this.send_bitcoin_button.UseVisualStyleBackColor = true;
            this.send_bitcoin_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.BackColor = System.Drawing.Color.Transparent;
            this.signup_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label.ForeColor = System.Drawing.Color.White;
            this.signup_label.Location = new System.Drawing.Point(299, 159);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(164, 24);
            this.signup_label.TabIndex = 9;
            this.signup_label.Text = "Sign up for 7coinZ";
            this.signup_label.Click += new System.EventHandler(this.signup_label_Click);
            // 
            // signin_button
            // 
            this.signin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_button.Location = new System.Drawing.Point(535, 102);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(94, 39);
            this.signin_button.TabIndex = 8;
            this.signin_button.Text = "SIGN IN";
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(242, 24);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(105, 20);
            this.username_label.TabIndex = 7;
            this.username_label.Text = "USERNAME:";
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.ForeColor = System.Drawing.Color.Black;
            this.password_textBox.Location = new System.Drawing.Point(455, 50);
            this.password_textBox.MaxLength = 30;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(195, 29);
            this.password_textBox.TabIndex = 6;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // username_textBox
            // 
            this.username_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textBox.ForeColor = System.Drawing.Color.Black;
            this.username_textBox.Location = new System.Drawing.Point(236, 47);
            this.username_textBox.MaxLength = 40;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(195, 29);
            this.username_textBox.TabIndex = 5;
            this.username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(467, 24);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(107, 20);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "PASSWORD:";
            // 
            // home_logo_pictureBox
            // 
            this.home_logo_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.home_logo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("home_logo_pictureBox.Image")));
            this.home_logo_pictureBox.Location = new System.Drawing.Point(68, 24);
            this.home_logo_pictureBox.Name = "home_logo_pictureBox";
            this.home_logo_pictureBox.Size = new System.Drawing.Size(146, 117);
            this.home_logo_pictureBox.TabIndex = 0;
            this.home_logo_pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 600);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.wallet_button);
            this.panel4.Controls.Add(this.home_button);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 339);
            this.panel4.TabIndex = 1;
            // 
            // wallet_button
            // 
            this.wallet_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wallet_button.ForeColor = System.Drawing.Color.White;
            this.wallet_button.Location = new System.Drawing.Point(0, 110);
            this.wallet_button.Name = "wallet_button";
            this.wallet_button.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.wallet_button.Size = new System.Drawing.Size(187, 84);
            this.wallet_button.TabIndex = 1;
            this.wallet_button.UseVisualStyleBackColor = true;
            this.wallet_button.Click += new System.EventHandler(this.wallet_button_Click);
            // 
            // home_button
            // 
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.ForeColor = System.Drawing.Color.White;
            this.home_button.Location = new System.Drawing.Point(0, 6);
            this.home_button.Name = "home_button";
            this.home_button.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.home_button.Size = new System.Drawing.Size(187, 84);
            this.home_button.TabIndex = 0;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 261);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home_panel
            // 
            this.home_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.home_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_panel.BackgroundImage")));
            this.home_panel.Controls.Add(this.error_label);
            this.home_panel.Controls.Add(this.signup_label);
            this.home_panel.Controls.Add(this.Close_button);
            this.home_panel.Controls.Add(this.signin_button);
            this.home_panel.Controls.Add(this.label_1);
            this.home_panel.Controls.Add(this.password_textBox);
            this.home_panel.Controls.Add(this.username_label);
            this.home_panel.Controls.Add(this.password_label);
            this.home_panel.Controls.Add(this.username_textBox);
            this.home_panel.Controls.Add(this.bitcoin_home_label);
            this.home_panel.Controls.Add(this.label2);
            this.home_panel.Controls.Add(this.home_logo_pictureBox);
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_panel.Location = new System.Drawing.Point(187, 0);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(706, 261);
            this.home_panel.TabIndex = 7;
            this.home_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.home_panel_Paint);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.Transparent;
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(389, 146);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 13;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.Transparent;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.Color.White;
            this.Close_button.Location = new System.Drawing.Point(643, 6);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(60, 38);
            this.Close_button.TabIndex = 0;
            this.Close_button.Text = "X";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.Transparent;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.label_1.Location = new System.Drawing.Point(77, 174);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(137, 26);
            this.label_1.TabIndex = 12;
            this.label_1.Text = "BALANCE: ";
            // 
            // bitcoin_home_label
            // 
            this.bitcoin_home_label.AutoSize = true;
            this.bitcoin_home_label.BackColor = System.Drawing.Color.Transparent;
            this.bitcoin_home_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitcoin_home_label.ForeColor = System.Drawing.Color.White;
            this.bitcoin_home_label.Location = new System.Drawing.Point(266, 93);
            this.bitcoin_home_label.Name = "bitcoin_home_label";
            this.bitcoin_home_label.Size = new System.Drawing.Size(86, 31);
            this.bitcoin_home_label.TabIndex = 8;
            this.bitcoin_home_label.Text = "label6";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-465, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BITCOIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 600);
            this.Controls.Add(this.wallet_panel);
            this.Controls.Add(this.home_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.balance_bitcoin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Root";
            this.wallet_panel.ResumeLayout(false);
            this.bitcoin_wallet_panel.ResumeLayout(false);
            this.bitcoin_wallet_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_logo_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balance_bitcoin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bitcoin_home_label;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Panel bitcoin_wallet_panel;
        private System.Windows.Forms.Label bitcoin_balance_wallet_label;
        private System.Windows.Forms.ListView bitcoin_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button recieve_bitcoin_button;
        private System.Windows.Forms.Button send_bitcoin_button;
        private System.Windows.Forms.Panel wallet_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button wallet_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.PictureBox home_logo_pictureBox;
        private System.Windows.Forms.Label error_label;

    }
}

