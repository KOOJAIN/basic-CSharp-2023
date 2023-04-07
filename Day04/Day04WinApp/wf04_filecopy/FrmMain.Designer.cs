namespace wf04_filecopy
{
    partial class FrmMain
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
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.LblSource = new System.Windows.Forms.Label();
            this.LblTarget = new System.Windows.Forms.Label();
            this.BtnAsyncCopy = new System.Windows.Forms.Button();
            this.BtnSyncCopy = new System.Windows.Forms.Button();
            this.PgbCopy = new System.Windows.Forms.ProgressBar();
            this.BtnFindTarget = new System.Windows.Forms.Button();
            this.BtnFindSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(70, 12);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(231, 21);
            this.TxtSource.TabIndex = 0;
            this.TxtSource.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // TxtTarget
            // 
            this.TxtTarget.Location = new System.Drawing.Point(70, 36);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(231, 21);
            this.TxtTarget.TabIndex = 0;
            this.TxtTarget.TextChanged += new System.EventHandler(this.TxtTarget_TextChanged);
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Location = new System.Drawing.Point(13, 18);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(53, 12);
            this.LblSource.TabIndex = 1;
            this.LblSource.Text = "Source :";
            this.LblSource.Click += new System.EventHandler(this.LblSource_Click);
            // 
            // LblTarget
            // 
            this.LblTarget.AutoSize = true;
            this.LblTarget.Location = new System.Drawing.Point(17, 39);
            this.LblTarget.Name = "LblTarget";
            this.LblTarget.Size = new System.Drawing.Size(49, 12);
            this.LblTarget.TabIndex = 1;
            this.LblTarget.Text = "Target :";
            this.LblTarget.Click += new System.EventHandler(this.LblTarget_Click);
            // 
            // BtnAsyncCopy
            // 
            this.BtnAsyncCopy.Location = new System.Drawing.Point(70, 75);
            this.BtnAsyncCopy.Name = "BtnAsyncCopy";
            this.BtnAsyncCopy.Size = new System.Drawing.Size(123, 23);
            this.BtnAsyncCopy.TabIndex = 2;
            this.BtnAsyncCopy.Text = "Async Copy";
            this.BtnAsyncCopy.UseVisualStyleBackColor = true;
            this.BtnAsyncCopy.Click += new System.EventHandler(this.BtnAsyncCopy_Click);
            // 
            // BtnSyncCopy
            // 
            this.BtnSyncCopy.Location = new System.Drawing.Point(209, 75);
            this.BtnSyncCopy.Name = "BtnSyncCopy";
            this.BtnSyncCopy.Size = new System.Drawing.Size(107, 23);
            this.BtnSyncCopy.TabIndex = 2;
            this.BtnSyncCopy.Text = "Sync Copy";
            this.BtnSyncCopy.UseVisualStyleBackColor = true;
            this.BtnSyncCopy.Click += new System.EventHandler(this.BtnSyncCopy_Click_1);
            // 
            // PgbCopy
            // 
            this.PgbCopy.Location = new System.Drawing.Point(12, 110);
            this.PgbCopy.Name = "PgbCopy";
            this.PgbCopy.Size = new System.Drawing.Size(337, 23);
            this.PgbCopy.TabIndex = 3;
            // 
            // BtnFindTarget
            // 
            this.BtnFindTarget.Location = new System.Drawing.Point(317, 36);
            this.BtnFindTarget.Name = "BtnFindTarget";
            this.BtnFindTarget.Size = new System.Drawing.Size(32, 23);
            this.BtnFindTarget.TabIndex = 4;
            this.BtnFindTarget.Text = "...";
            this.BtnFindTarget.UseVisualStyleBackColor = true;
            this.BtnFindTarget.Click += new System.EventHandler(this.BtnFindTarget_Click);
            // 
            // BtnFindSource
            // 
            this.BtnFindSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnFindSource.Location = new System.Drawing.Point(317, 10);
            this.BtnFindSource.Name = "BtnFindSource";
            this.BtnFindSource.Size = new System.Drawing.Size(32, 23);
            this.BtnFindSource.TabIndex = 4;
            this.BtnFindSource.Text = "...";
            this.BtnFindSource.UseVisualStyleBackColor = true;
            this.BtnFindSource.Click += new System.EventHandler(this.BtnFindSource_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 152);
            this.Controls.Add(this.BtnFindSource);
            this.Controls.Add(this.BtnFindTarget);
            this.Controls.Add(this.PgbCopy);
            this.Controls.Add(this.BtnSyncCopy);
            this.Controls.Add(this.BtnAsyncCopy);
            this.Controls.Add(this.LblTarget);
            this.Controls.Add(this.LblSource);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.TxtSource);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Label LblTarget;
        private System.Windows.Forms.Button BtnAsyncCopy;
        private System.Windows.Forms.Button BtnSyncCopy;
        private System.Windows.Forms.ProgressBar PgbCopy;
        private System.Windows.Forms.Button BtnFindTarget;
        private System.Windows.Forms.Button BtnFindSource;
    }
}