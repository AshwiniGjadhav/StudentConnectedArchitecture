namespace StudentConnectedArchitecture
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblRollno = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSub1 = new System.Windows.Forms.Label();
            this.lblSub2 = new System.Windows.Forms.Label();
            this.lblSub3 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSub1 = new System.Windows.Forms.TextBox();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.txtSub3 = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(372, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(306, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(191, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(599, 309);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 26);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblRollno
            // 
            this.lblRollno.AutoSize = true;
            this.lblRollno.Location = new System.Drawing.Point(69, 43);
            this.lblRollno.Name = "lblRollno";
            this.lblRollno.Size = new System.Drawing.Size(128, 16);
            this.lblRollno.TabIndex = 5;
            this.lblRollno.Text = "Enter Student Rollno";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Enter Student Name";
            // 
            // lblSub1
            // 
            this.lblSub1.AutoSize = true;
            this.lblSub1.Location = new System.Drawing.Point(69, 143);
            this.lblSub1.Name = "lblSub1";
            this.lblSub1.Size = new System.Drawing.Size(105, 16);
            this.lblSub1.TabIndex = 7;
            this.lblSub1.Text = "Enter Sub1 Mark";
            // 
            // lblSub2
            // 
            this.lblSub2.AutoSize = true;
            this.lblSub2.Location = new System.Drawing.Point(69, 194);
            this.lblSub2.Name = "lblSub2";
            this.lblSub2.Size = new System.Drawing.Size(105, 16);
            this.lblSub2.TabIndex = 8;
            this.lblSub2.Text = "Enter Sub2 Mark";
            // 
            // lblSub3
            // 
            this.lblSub3.AutoSize = true;
            this.lblSub3.Location = new System.Drawing.Point(69, 242);
            this.lblSub3.Name = "lblSub3";
            this.lblSub3.Size = new System.Drawing.Size(105, 16);
            this.lblSub3.TabIndex = 9;
            this.lblSub3.Text = "Enter Sub3 Mark";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(69, 291);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(111, 16);
            this.lblPercentage.TabIndex = 10;
            this.lblPercentage.Text = "Enter Percentage";
            // 
            // txtRollno
            // 
            this.txtRollno.Location = new System.Drawing.Point(226, 43);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(115, 22);
            this.txtRollno.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 22);
            this.txtName.TabIndex = 12;
            // 
            // txtSub1
            // 
            this.txtSub1.Location = new System.Drawing.Point(226, 140);
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.Size = new System.Drawing.Size(115, 22);
            this.txtSub1.TabIndex = 13;
            // 
            // txtSub2
            // 
            this.txtSub2.Location = new System.Drawing.Point(226, 194);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(115, 22);
            this.txtSub2.TabIndex = 14;
            // 
            // txtSub3
            // 
            this.txtSub3.Location = new System.Drawing.Point(226, 242);
            this.txtSub3.Name = "txtSub3";
            this.txtSub3.Size = new System.Drawing.Size(115, 22);
            this.txtSub3.TabIndex = 15;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(226, 288);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(115, 22);
            this.txtPercentage.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(482, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(306, 215);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtSub3);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblSub3);
            this.Controls.Add(this.lblSub2);
            this.Controls.Add(this.lblSub1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollno);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblRollno;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSub1;
        private System.Windows.Forms.Label lblSub2;
        private System.Windows.Forms.Label lblSub3;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSub1;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.TextBox txtSub3;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

