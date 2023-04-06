namespace wf03_property
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GbxMain = new System.Windows.Forms.GroupBox();
            this.Rdoindent = new System.Windows.Forms.RadioButton();
            this.RdoNomal = new System.Windows.Forms.RadioButton();
            this.NudFontSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.CboFontFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PgnDummy = new System.Windows.Forms.ProgressBar();
            this.TrbDummy = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMessageBox = new System.Windows.Forms.Button();
            this.BtnModaless = new System.Windows.Forms.Button();
            this.BtnModal = new System.Windows.Forms.Button();
            this.PgbDummy = new System.Windows.Forms.GroupBox();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.BtnAddRoot = new System.Windows.Forms.Button();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btnload = new System.Windows.Forms.Button();
            this.PcbDummy = new System.Windows.Forms.PictureBox();
            this.GbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.PgbDummy.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxMain
            // 
            this.GbxMain.Controls.Add(this.Rdoindent);
            this.GbxMain.Controls.Add(this.RdoNomal);
            this.GbxMain.Controls.Add(this.NudFontSize);
            this.GbxMain.Controls.Add(this.label2);
            this.GbxMain.Controls.Add(this.TxtResult);
            this.GbxMain.Controls.Add(this.ChkItalic);
            this.GbxMain.Controls.Add(this.ChkBold);
            this.GbxMain.Controls.Add(this.CboFontFamily);
            this.GbxMain.Controls.Add(this.label1);
            this.GbxMain.Location = new System.Drawing.Point(12, 12);
            this.GbxMain.Name = "GbxMain";
            this.GbxMain.Size = new System.Drawing.Size(398, 188);
            this.GbxMain.TabIndex = 0;
            this.GbxMain.TabStop = false;
            this.GbxMain.Text = "컨트롤 학습";
            // 
            // Rdoindent
            // 
            this.Rdoindent.AutoSize = true;
            this.Rdoindent.Location = new System.Drawing.Point(277, 56);
            this.Rdoindent.Name = "Rdoindent";
            this.Rdoindent.Size = new System.Drawing.Size(69, 18);
            this.Rdoindent.TabIndex = 5;
            this.Rdoindent.TabStop = true;
            this.Rdoindent.Text = "들여쓰기";
            this.Rdoindent.UseVisualStyleBackColor = true;
            this.Rdoindent.CheckedChanged += new System.EventHandler(this.RdoNomal_CheckedChanged);
            // 
            // RdoNomal
            // 
            this.RdoNomal.AutoSize = true;
            this.RdoNomal.Location = new System.Drawing.Point(220, 56);
            this.RdoNomal.Name = "RdoNomal";
            this.RdoNomal.Size = new System.Drawing.Size(47, 18);
            this.RdoNomal.TabIndex = 5;
            this.RdoNomal.TabStop = true;
            this.RdoNomal.Text = "일반";
            this.RdoNomal.UseVisualStyleBackColor = true;
            this.RdoNomal.CheckedChanged += new System.EventHandler(this.RdoNomal_CheckedChanged);
            // 
            // NudFontSize
            // 
            this.NudFontSize.Location = new System.Drawing.Point(94, 54);
            this.NudFontSize.Name = "NudFontSize";
            this.NudFontSize.Size = new System.Drawing.Size(120, 21);
            this.NudFontSize.TabIndex = 4;
            this.NudFontSize.ValueChanged += new System.EventHandler(this.NudFontSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "글자크기";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(16, 81);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(364, 69);
            this.TxtResult.TabIndex = 6;
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Location = new System.Drawing.Point(277, 28);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(59, 18);
            this.ChkItalic.TabIndex = 3;
            this.ChkItalic.Text = "이탤릭";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Location = new System.Drawing.Point(223, 28);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(48, 18);
            this.ChkBold.TabIndex = 2;
            this.ChkBold.Text = "볼드";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // CboFontFamily
            // 
            this.CboFontFamily.FormattingEnabled = true;
            this.CboFontFamily.Location = new System.Drawing.Point(94, 26);
            this.CboFontFamily.Name = "CboFontFamily";
            this.CboFontFamily.Size = new System.Drawing.Size(121, 22);
            this.CboFontFamily.TabIndex = 1;
            this.CboFontFamily.SelectedIndexChanged += new System.EventHandler(this.CboFontFamily_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "글자체";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PgnDummy);
            this.groupBox1.Controls.Add(this.TrbDummy);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "트랙바 및 진행바";
            // 
            // PgnDummy
            // 
            this.PgnDummy.Location = new System.Drawing.Point(16, 88);
            this.PgnDummy.Maximum = 20;
            this.PgnDummy.Name = "PgnDummy";
            this.PgnDummy.Size = new System.Drawing.Size(364, 23);
            this.PgnDummy.TabIndex = 8;
            this.PgnDummy.Click += new System.EventHandler(this.PgnDummy_Click);
            // 
            // TrbDummy
            // 
            this.TrbDummy.Location = new System.Drawing.Point(16, 37);
            this.TrbDummy.Maximum = 20;
            this.TrbDummy.Name = "TrbDummy";
            this.TrbDummy.Size = new System.Drawing.Size(364, 45);
            this.TrbDummy.TabIndex = 7;
            this.TrbDummy.Scroll += new System.EventHandler(this.TrbDummy_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMessageBox);
            this.groupBox2.Controls.Add(this.BtnModaless);
            this.groupBox2.Controls.Add(this.BtnModal);
            this.groupBox2.Location = new System.Drawing.Point(12, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnMessageBox
            // 
            this.BtnMessageBox.Location = new System.Drawing.Point(178, 41);
            this.BtnMessageBox.Name = "BtnMessageBox";
            this.BtnMessageBox.Size = new System.Drawing.Size(93, 30);
            this.BtnMessageBox.TabIndex = 11;
            this.BtnMessageBox.Text = "MessageBox";
            this.BtnMessageBox.UseVisualStyleBackColor = true;
            this.BtnMessageBox.Click += new System.EventHandler(this.BtnMessageBox_Click);
            // 
            // BtnModaless
            // 
            this.BtnModaless.Location = new System.Drawing.Point(97, 41);
            this.BtnModaless.Name = "BtnModaless";
            this.BtnModaless.Size = new System.Drawing.Size(75, 30);
            this.BtnModaless.TabIndex = 10;
            this.BtnModaless.Text = "Modaless";
            this.BtnModaless.UseVisualStyleBackColor = true;
            this.BtnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(16, 41);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(75, 30);
            this.BtnModal.TabIndex = 9;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // PgbDummy
            // 
            this.PgbDummy.Controls.Add(this.tvDummy);
            this.PgbDummy.Controls.Add(this.BtnAddChild);
            this.PgbDummy.Controls.Add(this.BtnAddRoot);
            this.PgbDummy.Controls.Add(this.lvDummy);
            this.PgbDummy.Location = new System.Drawing.Point(416, 12);
            this.PgbDummy.Name = "PgbDummy";
            this.PgbDummy.Size = new System.Drawing.Size(398, 188);
            this.PgbDummy.TabIndex = 3;
            this.PgbDummy.TabStop = false;
            this.PgbDummy.Text = "트리뷰 / 리스트뷰";
            this.PgbDummy.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(16, 20);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(176, 130);
            this.tvDummy.TabIndex = 12;
            this.tvDummy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDummy_AfterSelect);
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(117, 156);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(75, 23);
            this.BtnAddChild.TabIndex = 15;
            this.BtnAddChild.Text = "자식추가";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // BtnAddRoot
            // 
            this.BtnAddRoot.Location = new System.Drawing.Point(16, 156);
            this.BtnAddRoot.Name = "BtnAddRoot";
            this.BtnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRoot.TabIndex = 14;
            this.BtnAddRoot.Text = "루트추가";
            this.BtnAddRoot.UseVisualStyleBackColor = true;
            this.BtnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(198, 20);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(185, 130);
            this.lvDummy.TabIndex = 13;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.SelectedIndexChanged += new System.EventHandler(this.lvDummy_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btnload);
            this.groupBox3.Controls.Add(this.PcbDummy);
            this.groupBox3.Location = new System.Drawing.Point(417, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 219);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "픽쳐박스";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter_1);
            // 
            // Btnload
            // 
            this.Btnload.Location = new System.Drawing.Point(314, 21);
            this.Btnload.Name = "Btnload";
            this.Btnload.Size = new System.Drawing.Size(67, 23);
            this.Btnload.TabIndex = 1;
            this.Btnload.Text = "button1";
            this.Btnload.UseVisualStyleBackColor = true;
            this.Btnload.Click += new System.EventHandler(this.Btnload_Click);
            // 
            // PcbDummy
            // 
            this.PcbDummy.Location = new System.Drawing.Point(7, 20);
            this.PcbDummy.Name = "PcbDummy";
            this.PcbDummy.Size = new System.Drawing.Size(253, 198);
            this.PcbDummy.TabIndex = 0;
            this.PcbDummy.TabStop = false;
            this.PcbDummy.Click += new System.EventHandler(this.PcbDummy_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(868, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PgbDummy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbxMain);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "속성확인";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GbxMain.ResumeLayout(false);
            this.GbxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.PgbDummy.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxMain;
        private System.Windows.Forms.NumericUpDown NudFontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.ComboBox CboFontFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar TrbDummy;
        private System.Windows.Forms.ProgressBar PgnDummy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMessageBox;
        private System.Windows.Forms.Button BtnModaless;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.GroupBox PgbDummy;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.Button BtnAddRoot;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.TreeView tvDummy;
        private System.Windows.Forms.RadioButton RdoNomal;
        private System.Windows.Forms.RadioButton Rdoindent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox PcbDummy;
        private System.Windows.Forms.Button Btnload;
    }
}