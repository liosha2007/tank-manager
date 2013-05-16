namespace tank_manager
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_exists = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_addTank = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_connect = new System.Windows.Forms.Button();
            this.m_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_server = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_summary = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_changePrc = new System.Windows.Forms.Button();
            this.m_addRadio = new System.Windows.Forms.Button();
            this.m_addCrawler = new System.Windows.Forms.Button();
            this.m_addEngine = new System.Windows.Forms.Button();
            this.m_addTower = new System.Windows.Forms.Button();
            this.m_addTool = new System.Windows.Forms.Button();
            this.m_status = new System.Windows.Forms.Label();
            this.m_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_exists);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_addTank);
            this.groupBox1.Location = new System.Drawing.Point(13, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбранный танк";
            // 
            // m_exists
            // 
            this.m_exists.Enabled = false;
            this.m_exists.FormattingEnabled = true;
            this.m_exists.Location = new System.Drawing.Point(259, 25);
            this.m_exists.Name = "m_exists";
            this.m_exists.Size = new System.Drawing.Size(517, 21);
            this.m_exists.TabIndex = 5;
            this.m_exists.SelectedIndexChanged += new System.EventHandler(this.m_currentTank_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущий танк:";
            // 
            // m_addTank
            // 
            this.m_addTank.Enabled = false;
            this.m_addTank.Location = new System.Drawing.Point(11, 18);
            this.m_addTank.Name = "m_addTank";
            this.m_addTank.Size = new System.Drawing.Size(154, 33);
            this.m_addTank.TabIndex = 3;
            this.m_addTank.Text = "Добавить танк";
            this.m_addTank.UseVisualStyleBackColor = true;
            this.m_addTank.Click += new System.EventHandler(this.m_addTank_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_connect);
            this.groupBox2.Controls.Add(this.m_password);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.m_login);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.m_server);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "База";
            // 
            // m_connect
            // 
            this.m_connect.Location = new System.Drawing.Point(681, 19);
            this.m_connect.Name = "m_connect";
            this.m_connect.Size = new System.Drawing.Size(103, 23);
            this.m_connect.TabIndex = 6;
            this.m_connect.Text = "Подключиться";
            this.m_connect.UseVisualStyleBackColor = true;
            this.m_connect.Click += new System.EventHandler(this.m_connect_Click);
            // 
            // m_password
            // 
            this.m_password.Location = new System.Drawing.Point(525, 19);
            this.m_password.Name = "m_password";
            this.m_password.PasswordChar = '*';
            this.m_password.Size = new System.Drawing.Size(150, 22);
            this.m_password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пароль:";
            // 
            // m_login
            // 
            this.m_login.Location = new System.Drawing.Point(289, 19);
            this.m_login.Name = "m_login";
            this.m_login.Size = new System.Drawing.Size(150, 22);
            this.m_login.TabIndex = 3;
            this.m_login.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин:";
            // 
            // m_server
            // 
            this.m_server.Location = new System.Drawing.Point(64, 19);
            this.m_server.Name = "m_server";
            this.m_server.Size = new System.Drawing.Size(150, 22);
            this.m_server.TabIndex = 1;
            this.m_server.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сервер:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_summary);
            this.groupBox3.Location = new System.Drawing.Point(13, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 199);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Характеристики танка";
            // 
            // m_summary
            // 
            this.m_summary.FormattingEnabled = true;
            this.m_summary.Location = new System.Drawing.Point(11, 21);
            this.m_summary.Name = "m_summary";
            this.m_summary.Size = new System.Drawing.Size(765, 160);
            this.m_summary.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_changePrc);
            this.groupBox4.Controls.Add(this.m_addRadio);
            this.groupBox4.Controls.Add(this.m_addCrawler);
            this.groupBox4.Controls.Add(this.m_addEngine);
            this.groupBox4.Controls.Add(this.m_addTower);
            this.groupBox4.Controls.Add(this.m_addTool);
            this.groupBox4.Location = new System.Drawing.Point(13, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 105);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Части танка";
            // 
            // m_changePrc
            // 
            this.m_changePrc.Enabled = false;
            this.m_changePrc.Location = new System.Drawing.Point(525, 59);
            this.m_changePrc.Name = "m_changePrc";
            this.m_changePrc.Size = new System.Drawing.Size(251, 32);
            this.m_changePrc.TabIndex = 5;
            this.m_changePrc.Text = "Редактировать процент модулей";
            this.m_changePrc.UseVisualStyleBackColor = true;
            this.m_changePrc.Click += new System.EventHandler(this.m_changePrc_Click);
            // 
            // m_addRadio
            // 
            this.m_addRadio.Enabled = false;
            this.m_addRadio.Location = new System.Drawing.Point(268, 59);
            this.m_addRadio.Name = "m_addRadio";
            this.m_addRadio.Size = new System.Drawing.Size(251, 32);
            this.m_addRadio.TabIndex = 4;
            this.m_addRadio.Text = "Добавить рацию";
            this.m_addRadio.UseVisualStyleBackColor = true;
            this.m_addRadio.Click += new System.EventHandler(this.m_addRadio_Click);
            // 
            // m_addCrawler
            // 
            this.m_addCrawler.Enabled = false;
            this.m_addCrawler.Location = new System.Drawing.Point(10, 59);
            this.m_addCrawler.Name = "m_addCrawler";
            this.m_addCrawler.Size = new System.Drawing.Size(251, 32);
            this.m_addCrawler.TabIndex = 3;
            this.m_addCrawler.Text = "Добавить гусеницу";
            this.m_addCrawler.UseVisualStyleBackColor = true;
            this.m_addCrawler.Click += new System.EventHandler(this.m_addCrawler_Click);
            // 
            // m_addEngine
            // 
            this.m_addEngine.Enabled = false;
            this.m_addEngine.Location = new System.Drawing.Point(525, 21);
            this.m_addEngine.Name = "m_addEngine";
            this.m_addEngine.Size = new System.Drawing.Size(251, 32);
            this.m_addEngine.TabIndex = 2;
            this.m_addEngine.Text = "Добавить двигатель";
            this.m_addEngine.UseVisualStyleBackColor = true;
            this.m_addEngine.Click += new System.EventHandler(this.m_addEngine_Click);
            // 
            // m_addTower
            // 
            this.m_addTower.Enabled = false;
            this.m_addTower.Location = new System.Drawing.Point(268, 21);
            this.m_addTower.Name = "m_addTower";
            this.m_addTower.Size = new System.Drawing.Size(251, 32);
            this.m_addTower.TabIndex = 1;
            this.m_addTower.Text = "Добавить башню";
            this.m_addTower.UseVisualStyleBackColor = true;
            this.m_addTower.Click += new System.EventHandler(this.m_addTower_Click);
            // 
            // m_addTool
            // 
            this.m_addTool.Enabled = false;
            this.m_addTool.Location = new System.Drawing.Point(10, 21);
            this.m_addTool.Name = "m_addTool";
            this.m_addTool.Size = new System.Drawing.Size(251, 32);
            this.m_addTool.TabIndex = 0;
            this.m_addTool.Text = "Добавить пушку";
            this.m_addTool.UseVisualStyleBackColor = true;
            this.m_addTool.Click += new System.EventHandler(this.m_addTool_Click);
            // 
            // m_status
            // 
            this.m_status.AutoSize = true;
            this.m_status.Location = new System.Drawing.Point(13, 453);
            this.m_status.Name = "m_status";
            this.m_status.Size = new System.Drawing.Size(40, 13);
            this.m_status.TabIndex = 4;
            this.m_status.Text = "Статус";
            // 
            // m_refresh
            // 
            this.m_refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_refresh.Enabled = false;
            this.m_refresh.Location = new System.Drawing.Point(799, 3);
            this.m_refresh.Name = "m_refresh";
            this.m_refresh.Size = new System.Drawing.Size(13, 11);
            this.m_refresh.TabIndex = 26;
            this.m_refresh.Text = "*";
            this.m_refresh.UseVisualStyleBackColor = false;
            this.m_refresh.Click += new System.EventHandler(this.m_refresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 475);
            this.Controls.Add(this.m_refresh);
            this.Controls.Add(this.m_status);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер игры \"Танковый армагедон\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox m_exists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_addTank;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button m_connect;
        private System.Windows.Forms.TextBox m_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button m_changePrc;
        private System.Windows.Forms.Button m_addRadio;
        private System.Windows.Forms.Button m_addCrawler;
        private System.Windows.Forms.Button m_addEngine;
        private System.Windows.Forms.Button m_addTower;
        private System.Windows.Forms.Button m_addTool;
        private System.Windows.Forms.Label m_status;
        private System.Windows.Forms.Button m_refresh;
        private System.Windows.Forms.ListBox m_summary;
    }
}

