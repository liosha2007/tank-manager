namespace tank_manager
{
    partial class TowerDialog
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
            this.m_strength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.m_review = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m_rotation = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.m_reservation = new System.Windows.Forms.NumericUpDown();
            this.m_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_price = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.m_experience = new System.Windows.Forms.NumericUpDown();
            this.m_level = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.m_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_createAndClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.m_massa = new System.Windows.Forms.NumericUpDown();
            this.m_status = new System.Windows.Forms.Label();
            this.m_refresh = new System.Windows.Forms.Button();
            this.m_del = new System.Windows.Forms.Button();
            this.m_edit = new System.Windows.Forms.Button();
            this.m_exists = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_strength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_review)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_experience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_massa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_strength);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_review);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_rotation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_reservation);
            this.groupBox1.Controls.Add(this.m_create);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_experience);
            this.groupBox1.Controls.Add(this.m_level);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.m_name);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.m_createAndClose);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.m_massa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Башня";
            // 
            // m_strength
            // 
            this.m_strength.Location = new System.Drawing.Point(132, 240);
            this.m_strength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_strength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_strength.Name = "m_strength";
            this.m_strength.Size = new System.Drawing.Size(120, 22);
            this.m_strength.TabIndex = 39;
            this.m_strength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Прочность";
            // 
            // m_review
            // 
            this.m_review.Location = new System.Drawing.Point(132, 212);
            this.m_review.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.m_review.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_review.Name = "m_review";
            this.m_review.Size = new System.Drawing.Size(120, 22);
            this.m_review.TabIndex = 37;
            this.m_review.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Обзор";
            // 
            // m_rotation
            // 
            this.m_rotation.Location = new System.Drawing.Point(132, 184);
            this.m_rotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.m_rotation.Name = "m_rotation";
            this.m_rotation.Size = new System.Drawing.Size(120, 22);
            this.m_rotation.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Поворот";
            // 
            // m_reservation
            // 
            this.m_reservation.Location = new System.Drawing.Point(132, 156);
            this.m_reservation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_reservation.Name = "m_reservation";
            this.m_reservation.Size = new System.Drawing.Size(120, 22);
            this.m_reservation.TabIndex = 33;
            // 
            // m_create
            // 
            this.m_create.Location = new System.Drawing.Point(6, 268);
            this.m_create.Name = "m_create";
            this.m_create.Size = new System.Drawing.Size(160, 29);
            this.m_create.TabIndex = 23;
            this.m_create.Text = "Готово";
            this.m_create.UseVisualStyleBackColor = true;
            this.m_create.Click += new System.EventHandler(this.m_create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Уровень";
            // 
            // m_price
            // 
            this.m_price.Location = new System.Drawing.Point(132, 128);
            this.m_price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.m_price.Name = "m_price";
            this.m_price.Size = new System.Drawing.Size(120, 22);
            this.m_price.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Название";
            // 
            // m_experience
            // 
            this.m_experience.Location = new System.Drawing.Point(132, 100);
            this.m_experience.Name = "m_experience";
            this.m_experience.Size = new System.Drawing.Size(120, 22);
            this.m_experience.TabIndex = 31;
            // 
            // m_level
            // 
            this.m_level.Location = new System.Drawing.Point(132, 16);
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
            this.m_level.TabIndex = 24;
            this.m_level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Опыт";
            // 
            // m_name
            // 
            this.m_name.Location = new System.Drawing.Point(132, 44);
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(337, 22);
            this.m_name.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Вес (тонн)";
            // 
            // m_createAndClose
            // 
            this.m_createAndClose.Location = new System.Drawing.Point(309, 268);
            this.m_createAndClose.Name = "m_createAndClose";
            this.m_createAndClose.Size = new System.Drawing.Size(160, 29);
            this.m_createAndClose.TabIndex = 21;
            this.m_createAndClose.Text = "Готово (Закрыть)";
            this.m_createAndClose.UseVisualStyleBackColor = true;
            this.m_createAndClose.Click += new System.EventHandler(this.m_createAndClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Броня";
            // 
            // m_massa
            // 
            this.m_massa.DecimalPlaces = 3;
            this.m_massa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.m_massa.Location = new System.Drawing.Point(132, 72);
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
            this.m_massa.TabIndex = 30;
            this.m_massa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m_status
            // 
            this.m_status.AutoSize = true;
            this.m_status.Location = new System.Drawing.Point(12, 366);
            this.m_status.Name = "m_status";
            this.m_status.Size = new System.Drawing.Size(40, 13);
            this.m_status.TabIndex = 40;
            this.m_status.Text = "Статус";
            // 
            // m_refresh
            // 
            this.m_refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_refresh.Location = new System.Drawing.Point(484, 2);
            this.m_refresh.Name = "m_refresh";
            this.m_refresh.Size = new System.Drawing.Size(13, 11);
            this.m_refresh.TabIndex = 81;
            this.m_refresh.Text = "*";
            this.m_refresh.UseVisualStyleBackColor = false;
            this.m_refresh.Click += new System.EventHandler(this.m_refresh_Click);
            // 
            // m_del
            // 
            this.m_del.Location = new System.Drawing.Point(456, 325);
            this.m_del.Name = "m_del";
            this.m_del.Size = new System.Drawing.Size(32, 23);
            this.m_del.TabIndex = 84;
            this.m_del.Text = "Del";
            this.m_del.UseVisualStyleBackColor = true;
            this.m_del.Click += new System.EventHandler(this.m_del_Click);
            // 
            // m_edit
            // 
            this.m_edit.Location = new System.Drawing.Point(350, 325);
            this.m_edit.Name = "m_edit";
            this.m_edit.Size = new System.Drawing.Size(100, 23);
            this.m_edit.TabIndex = 83;
            this.m_edit.Text = "Редактировать";
            this.m_edit.UseVisualStyleBackColor = true;
            this.m_edit.Click += new System.EventHandler(this.m_edit_Click);
            // 
            // m_exists
            // 
            this.m_exists.FormattingEnabled = true;
            this.m_exists.Location = new System.Drawing.Point(12, 325);
            this.m_exists.Name = "m_exists";
            this.m_exists.Size = new System.Drawing.Size(332, 21);
            this.m_exists.TabIndex = 82;
            // 
            // TowerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 387);
            this.Controls.Add(this.m_del);
            this.Controls.Add(this.m_edit);
            this.Controls.Add(this.m_exists);
            this.Controls.Add(this.m_refresh);
            this.Controls.Add(this.m_status);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TowerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Башня";
            this.Load += new System.EventHandler(this.TowerDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_strength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_review)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_experience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_massa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown m_rotation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown m_reservation;
        private System.Windows.Forms.Button m_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown m_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown m_experience;
        private System.Windows.Forms.NumericUpDown m_level;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button m_createAndClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown m_massa;
        private System.Windows.Forms.NumericUpDown m_strength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown m_review;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_status;
        private System.Windows.Forms.Button m_refresh;
        private System.Windows.Forms.Button m_del;
        private System.Windows.Forms.Button m_edit;
        private System.Windows.Forms.ComboBox m_exists;
    }
}