namespace NoteTaking
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btNew = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 65);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(74, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(253, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(74, 65);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(253, 160);
            this.txtMessage.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(353, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(140, 160);
            this.dataGridView.TabIndex = 4;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(74, 231);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 5;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(155, 231);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(236, 231);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 7;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(317, 231);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 281);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taking Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btDelete;
    }
}

