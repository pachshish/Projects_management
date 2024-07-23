namespace Projects_management
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.btnAddProjact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProjact = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "מערכת ניהול פרויקטים";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(592, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(360, 117);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 2;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(232, 117);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(100, 22);
            this.txtLanguage.TabIndex = 3;
            // 
            // btnAddProjact
            // 
            this.btnAddProjact.Location = new System.Drawing.Point(106, 117);
            this.btnAddProjact.Name = "btnAddProjact";
            this.btnAddProjact.Size = new System.Drawing.Size(102, 25);
            this.btnAddProjact.TabIndex = 4;
            this.btnAddProjact.Text = "הוסף פרויקט";
            this.btnAddProjact.UseVisualStyleBackColor = true;
            this.btnAddProjact.Click += new System.EventHandler(this.btnAddProjact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "שם הפרויקט";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "תאריך יצירת הפרויקט";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "שפה";
            // 
            // dgvProjact
            // 
            this.dgvProjact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.language,
            this.date});
            this.dgvProjact.Location = new System.Drawing.Point(205, 223);
            this.dgvProjact.Name = "dgvProjact";
            this.dgvProjact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProjact.RowHeadersWidth = 51;
            this.dgvProjact.RowTemplate.Height = 24;
            this.dgvProjact.Size = new System.Drawing.Size(426, 215);
            this.dgvProjact.TabIndex = 8;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "שם הפרויקט";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // language
            // 
            this.language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.language.HeaderText = "שפה";
            this.language.MinimumWidth = 6;
            this.language.Name = "language";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "תאריך יצירת הפרויקט";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProjact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddProjact);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Button btnAddProjact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProjact;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}

