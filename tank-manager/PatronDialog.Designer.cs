namespace tank_manager
{
    partial class PatronDialog
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
            this.m_create = new System.Windows.Forms.Button();
            this.m_createAndClose = new System.Windows.Forms.Button();
            this.m_price = new System.Windows.Forms.NumericUpDown();
            this.m_damage = new System.Windows.Forms.NumericUpDown();
            this.m_probity = new System.Windows.Forms.NumericUpDown();
            this.m_calibre = new System.Windows.Forms.NumericUpDown();
            this.m_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_status = new System.Windows.Forms.Label();
            this.m_refresh = new System.Windows.Forms.Button();
            this.m_del = new System.Windows.Forms.Button();
            this.m_edit = new System.Windows.Forms.Button();
            this.m_exists = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_damage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_probity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_calibre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_create);
            this.groupBox1.Controls.Add(this.m_createAndClose);
            this.groupBox1.Controls.Add(this.m_price);
            this.groupBox1.Controls.Add(this.m_damage);
            this.groupBox1.Controls.Add(this.m_probity);
            this.groupBox1.Controls.Add(this.m_calibre);
            this.groupBox1.Controls.Add(this.m_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Патрон";
            // 
            // m_create
            // 
            this.m_create.Location = new System.Drawing.Point(6, 161);
            this.m_create.Name = "m_create";
            this.m_create.Size = new System.Drawing.Size(160, 29);
            this.m_create.TabIndex = 11;
            this.m_create.Text = "Готово";
            this.m_create.UseVisualStyleBackColor = true;
            this.m_create.Click += new System.EventHandler(this.m_create_Click);
            // 
            // m_createAndClose
            // 
            this.m_createAndClose.Location = new System.Drawing.Point(172, 161);
            this.m_createAndClose.Name = "m_createAndClose";
            this.m_createAndClose.Size = new System.Drawing.Size(160, 29);
            this.m_createAndClose.TabIndex = 10;
            this.m_createAndClose.Text = "Готово (Закрыть)";
            this.m_createAndClose.UseVisualStyleBackColor = true;
            this.m_createAndClose.Click += new System.EventHandler(this.m_createAndClose_Click);
            // 
            // m_price
            // 
            this.m_price.Location = new System.Drawing.Point(84, 133);
            this.m_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.m_price.Name = "m_price";
            this.m_price.Size = new System.Drawing.Size(120, 22);
            this.m_price.TabIndex = 9;
            // 
            // m_damage
            // 
            this.m_damage.Location = new System.Drawing.Point(84, 105);
            this.m_damage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_damage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_damage.Name = "m_damage";
            this.m_damage.Size = new System.Drawing.Size(120, 22);
            this.m_damage.TabIndex = 8;
            this.m_damage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m_probity
            // 
            this.m_probity.Location = new System.Drawing.Point(84, 77);
            this.m_probity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_probity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_probity.Name = "m_probity";
            this.m_probity.Size = new System.Drawing.Size(120, 22);
            this.m_probity.TabIndex = 7;
            this.m_probity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m_calibre
            // 
            this.m_calibre.Location = new System.Drawing.Point(84, 49);
            this.m_calibre.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.m_calibre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_calibre.Name = "m_calibre";
            this.m_calibre.Size = new System.Drawing.Size(120, 22);
            this.m_calibre.TabIndex = 6;
            this.m_calibre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m_name
            // 
            this.m_name.Location = new System.Drawing.Point(84, 21);
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(248, 22);
            this.m_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Урон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пробитие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Калибр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // m_status
            // 
            this.m_status.AutoSize = true;
            this.m_status.Location = new System.Drawing.Point(9, 262);
            this.m_status.Name = "m_status";
            this.m_status.Size = new System.Drawing.Size(40, 13);
            this.m_status.TabIndex = 75;
            this.m_status.Text = "Статус";
            // 
            // m_refresh
            // 
            this.m_refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_refresh.Location = new System.Drawing.Point(346, 3);
            this.m_refresh.Name = "m_refresh";
            this.m_refresh.Size = new System.Drawing.Size(13, 11);
            this.m_refresh.TabIndex = 93;
            this.m_refresh.Text = "*";
            this.m_refresh.UseVisualStyleBackColor = false;
            this.m_refresh.Click += new System.EventHandler(this.m_refresh_Click);
            // 
            // m_del
            // 
            this.m_del.Location = new System.Drawing.Point(321, 238);
            this.m_del.Name = "m_del";
            this.m_del.Size = new System.Drawing.Size(32, 23);
            this.m_del.TabIndex = 96;
            this.m_del.Text = "Del";
            this.m_del.UseVisualStyleBackColor = true;
            this.m_del.Click += new System.EventHandler(this.m_del_Click);
            // 
            // m_edit
            // 
            this.m_edit.Location = new System.Drawing.Point(212, 238);
            this.m_edit.Name = "m_edit";
            this.m_edit.Size = new System.Drawing.Size(103, 23);
            this.m_edit.TabIndex = 95;
            this.m_edit.Text = "Редактировать";
            this.m_edit.UseVisualStyleBackColor = true;
            this.m_edit.Click += new System.EventHandler(this.m_edit_Click);
            // 
            // m_exists
            // 
            this.m_exists.FormattingEnabled = true;
            this.m_exists.Location = new System.Drawing.Point(12, 238);
            this.m_exists.Name = "m_exists";
            this.m_exists.Size = new System.Drawing.Size(194, 21);
            this.m_exists.TabIndex = 94;
            // 
            // PatronDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 283);
            this.Controls.Add(this.m_del);
            this.Controls.Add(this.m_edit);
            this.Controls.Add(this.m_exists);
            this.Controls.Add(this.m_refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PatronDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Патроны";
            this.Load += new System.EventHandler(this.PatronDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_damage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_probity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_calibre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown m_price;
        private System.Windows.Forms.NumericUpDown m_damage;
        private System.Windows.Forms.NumericUpDown m_probity;
        private System.Windows.Forms.NumericUpDown m_calibre;
        private System.Windows.Forms.TextBox m_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_create;
        private System.Windows.Forms.Button m_createAndClose;
        private System.Windows.Forms.Label m_status;
        private System.Windows.Forms.Button m_refresh;
        private System.Windows.Forms.Button m_del;
        private System.Windows.Forms.Button m_edit;
        private System.Windows.Forms.ComboBox m_exists;
    }
}