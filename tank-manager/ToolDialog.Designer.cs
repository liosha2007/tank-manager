namespace tank_manager
{
    partial class ToolDialog
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
            this.m_rate = new System.Windows.Forms.NumericUpDown();
            this.m_stowage = new System.Windows.Forms.NumericUpDown();
            this.m_ammunition = new System.Windows.Forms.NumericUpDown();
            this.m_disorder = new System.Windows.Forms.NumericUpDown();
            this.m_reduction = new System.Windows.Forms.NumericUpDown();
            this.m_reservation = new System.Windows.Forms.NumericUpDown();
            this.m_price = new System.Windows.Forms.NumericUpDown();
            this.m_experience = new System.Windows.Forms.NumericUpDown();
            this.m_massa = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_addPatron = new System.Windows.Forms.Button();
            this.m_patron = new System.Windows.Forms.CheckedListBox();
            this.m_name = new System.Windows.Forms.TextBox();
            this.m_level = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_createAndClose = new System.Windows.Forms.Button();
            this.m_create = new System.Windows.Forms.Button();
            this.m_status = new System.Windows.Forms.Label();
            this.m_refresh = new System.Windows.Forms.Button();
            this.m_del = new System.Windows.Forms.Button();
            this.m_edit = new System.Windows.Forms.Button();
            this.m_exists = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_stowage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ammunition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_disorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_reduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_experience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_massa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_level)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rate);
            this.groupBox1.Controls.Add(this.m_stowage);
            this.groupBox1.Controls.Add(this.m_ammunition);
            this.groupBox1.Controls.Add(this.m_disorder);
            this.groupBox1.Controls.Add(this.m_reduction);
            this.groupBox1.Controls.Add(this.m_reservation);
            this.groupBox1.Controls.Add(this.m_price);
            this.groupBox1.Controls.Add(this.m_experience);
            this.groupBox1.Controls.Add(this.m_massa);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_addPatron);
            this.groupBox1.Controls.Add(this.m_patron);
            this.groupBox1.Controls.Add(this.m_name);
            this.groupBox1.Controls.Add(this.m_level);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Орудие";
            // 
            // m_rate
            // 
            this.m_rate.DecimalPlaces = 3;
            this.m_rate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.m_rate.Location = new System.Drawing.Point(133, 300);
            this.m_rate.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.m_rate.Name = "m_rate";
            this.m_rate.Size = new System.Drawing.Size(120, 22);
            this.m_rate.TabIndex = 24;
            // 
            // m_stowage
            // 
            this.m_stowage.Location = new System.Drawing.Point(133, 272);
            this.m_stowage.Name = "m_stowage";
            this.m_stowage.Size = new System.Drawing.Size(120, 22);
            this.m_stowage.TabIndex = 23;
            // 
            // m_ammunition
            // 
            this.m_ammunition.Location = new System.Drawing.Point(133, 244);
            this.m_ammunition.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_ammunition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_ammunition.Name = "m_ammunition";
            this.m_ammunition.Size = new System.Drawing.Size(120, 22);
            this.m_ammunition.TabIndex = 22;
            this.m_ammunition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m_disorder
            // 
            this.m_disorder.DecimalPlaces = 3;
            this.m_disorder.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.m_disorder.Location = new System.Drawing.Point(133, 216);
            this.m_disorder.Name = "m_disorder";
            this.m_disorder.Size = new System.Drawing.Size(120, 22);
            this.m_disorder.TabIndex = 21;
            // 
            // m_reduction
            // 
            this.m_reduction.DecimalPlaces = 3;
            this.m_reduction.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.m_reduction.Location = new System.Drawing.Point(133, 188);
            this.m_reduction.Name = "m_reduction";
            this.m_reduction.Size = new System.Drawing.Size(120, 22);
            this.m_reduction.TabIndex = 20;
            // 
            // m_reservation
            // 
            this.m_reservation.Location = new System.Drawing.Point(133, 160);
            this.m_reservation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_reservation.Name = "m_reservation";
            this.m_reservation.Size = new System.Drawing.Size(120, 22);
            this.m_reservation.TabIndex = 19;
            // 
            // m_price
            // 
            this.m_price.Location = new System.Drawing.Point(133, 132);
            this.m_price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.m_price.Name = "m_price";
            this.m_price.Size = new System.Drawing.Size(120, 22);
            this.m_price.TabIndex = 18;
            // 
            // m_experience
            // 
            this.m_experience.Location = new System.Drawing.Point(133, 104);
            this.m_experience.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.m_experience.Name = "m_experience";
            this.m_experience.Size = new System.Drawing.Size(120, 22);
            this.m_experience.TabIndex = 17;
            // 
            // m_massa
            // 
            this.m_massa.DecimalPlaces = 3;
            this.m_massa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.m_massa.Location = new System.Drawing.Point(133, 76);
            this.m_massa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_massa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_massa.Name = "m_massa";
            this.m_massa.Size = new System.Drawing.Size(120, 22);
            this.m_massa.TabIndex = 16;
            this.m_massa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Боеукладка (%)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Броня";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Боекомплект";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Опыт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Вес (тонн)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сведение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Разброс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скорострельность";
            // 
            // m_addPatron
            // 
            this.m_addPatron.Location = new System.Drawing.Point(51, 360);
            this.m_addPatron.Name = "m_addPatron";
            this.m_addPatron.Size = new System.Drawing.Size(76, 23);
            this.m_addPatron.TabIndex = 6;
            this.m_addPatron.Text = "Добавить";
            this.m_addPatron.UseVisualStyleBackColor = true;
            this.m_addPatron.Click += new System.EventHandler(this.m_addPatron_Click);
            // 
            // m_patron
            // 
            this.m_patron.FormattingEnabled = true;
            this.m_patron.Location = new System.Drawing.Point(133, 328);
            this.m_patron.Name = "m_patron";
            this.m_patron.Size = new System.Drawing.Size(337, 55);
            this.m_patron.TabIndex = 5;
            // 
            // m_name
            // 
            this.m_name.Location = new System.Drawing.Point(133, 48);
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(337, 22);
            this.m_name.TabIndex = 4;
            // 
            // m_level
            // 
            this.m_level.Location = new System.Drawing.Point(133, 20);
            this.m_level.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_level.Name = "m_level";
            this.m_level.Size = new System.Drawing.Size(120, 22);
            this.m_level.TabIndex = 3;
            this.m_level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Снаряды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уровень";
            // 
            // m_createAndClose
            // 
            this.m_createAndClose.Location = new System.Drawing.Point(332, 411);
            this.m_createAndClose.Name = "m_createAndClose";
            this.m_createAndClose.Size = new System.Drawing.Size(160, 29);
            this.m_createAndClose.TabIndex = 1;
            this.m_createAndClose.Text = "Готово (Закрыть)";
            this.m_createAndClose.UseVisualStyleBackColor = true;
            this.m_createAndClose.Click += new System.EventHandler(this.m_createAndClose_Click);
            // 
            // m_create
            // 
            this.m_create.Location = new System.Drawing.Point(12, 411);
            this.m_create.Name = "m_create";
            this.m_create.Size = new System.Drawing.Size(160, 29);
            this.m_create.TabIndex = 2;
            this.m_create.Text = "Готово";
            this.m_create.UseVisualStyleBackColor = true;
            this.m_create.Click += new System.EventHandler(this.m_create_Click);
            // 
            // m_status
            // 
            this.m_status.AutoSize = true;
            this.m_status.Location = new System.Drawing.Point(12, 489);
            this.m_status.Name = "m_status";
            this.m_status.Size = new System.Drawing.Size(40, 13);
            this.m_status.TabIndex = 3;
            this.m_status.Text = "Статус";
            // 
            // m_refresh
            // 
            this.m_refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_refresh.Location = new System.Drawing.Point(490, 3);
            this.m_refresh.Name = "m_refresh";
            this.m_refresh.Size = new System.Drawing.Size(13, 11);
            this.m_refresh.TabIndex = 25;
            this.m_refresh.Text = "*";
            this.m_refresh.UseVisualStyleBackColor = false;
            this.m_refresh.Click += new System.EventHandler(this.m_refresh_Click);
            // 
            // m_del
            // 
            this.m_del.Location = new System.Drawing.Point(456, 446);
            this.m_del.Name = "m_del";
            this.m_del.Size = new System.Drawing.Size(32, 23);
            this.m_del.TabIndex = 77;
            this.m_del.Text = "Del";
            this.m_del.UseVisualStyleBackColor = true;
            this.m_del.Click += new System.EventHandler(this.m_del_Click);
            // 
            // m_edit
            // 
            this.m_edit.Location = new System.Drawing.Point(350, 446);
            this.m_edit.Name = "m_edit";
            this.m_edit.Size = new System.Drawing.Size(100, 23);
            this.m_edit.TabIndex = 76;
            this.m_edit.Text = "Редактировать";
            this.m_edit.UseVisualStyleBackColor = true;
            this.m_edit.Click += new System.EventHandler(this.m_edit_Click);
            // 
            // m_exists
            // 
            this.m_exists.FormattingEnabled = true;
            this.m_exists.Location = new System.Drawing.Point(12, 446);
            this.m_exists.Name = "m_exists";
            this.m_exists.Size = new System.Drawing.Size(332, 21);
            this.m_exists.TabIndex = 75;
            // 
            // ToolDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 509);
            this.Controls.Add(this.m_del);
            this.Controls.Add(this.m_edit);
            this.Controls.Add(this.m_exists);
            this.Controls.Add(this.m_refresh);
            this.Controls.Add(this.m_status);
            this.Controls.Add(this.m_create);
            this.Controls.Add(this.m_createAndClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ToolDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пушка";
            this.Load += new System.EventHandler(this.ToolDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_stowage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ammunition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_disorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_reduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_experience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_massa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button m_addPatron;
        private System.Windows.Forms.CheckedListBox m_patron;
        private System.Windows.Forms.TextBox m_name;
        private System.Windows.Forms.NumericUpDown m_level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown m_massa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m_rate;
        private System.Windows.Forms.NumericUpDown m_stowage;
        private System.Windows.Forms.NumericUpDown m_ammunition;
        private System.Windows.Forms.NumericUpDown m_disorder;
        private System.Windows.Forms.NumericUpDown m_reduction;
        private System.Windows.Forms.NumericUpDown m_reservation;
        private System.Windows.Forms.NumericUpDown m_price;
        private System.Windows.Forms.NumericUpDown m_experience;
        private System.Windows.Forms.Button m_createAndClose;
        private System.Windows.Forms.Button m_create;
        private System.Windows.Forms.Label m_status;
        private System.Windows.Forms.Button m_refresh;
        private System.Windows.Forms.Button m_del;
        private System.Windows.Forms.Button m_edit;
        private System.Windows.Forms.ComboBox m_exists;
    }
}