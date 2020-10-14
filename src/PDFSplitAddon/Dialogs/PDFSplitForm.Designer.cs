namespace PDFSplit
{
    partial class PDFSplitForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbReferences = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.NumericUpDown();
            this.tbEnd = new System.Windows.Forms.NumericUpDown();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblPageCounter = new System.Windows.Forms.Label();
            this.tbPages = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbShowBigBox = new System.Windows.Forms.PictureBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbView = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbHideBox = new System.Windows.Forms.PictureBox();
            this.pbBigView = new System.Windows.Forms.PictureBox();
            this.tbMain = new System.Windows.Forms.TabPage();
            this.btnSetAsEnd = new System.Windows.Forms.Button();
            this.btnSetAsStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPages)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowBigBox)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tbView.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigView)).BeginInit();
            this.tbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(444, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(363, 509);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lbReferences
            // 
            this.lbReferences.FormattingEnabled = true;
            this.lbReferences.Location = new System.Drawing.Point(6, 6);
            this.lbReferences.Name = "lbReferences";
            this.lbReferences.Size = new System.Drawing.Size(215, 498);
            this.lbReferences.TabIndex = 1;
            this.lbReferences.SelectedIndexChanged += new System.EventHandler(this.LbReferences_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "bis";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(257, 449);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(221, 20);
            this.tbStart.TabIndex = 5;
            this.tbStart.ValueChanged += new System.EventHandler(this.tbStart_ValueChanged);
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(257, 473);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(221, 20);
            this.tbEnd.TabIndex = 7;
            this.tbEnd.ValueChanged += new System.EventHandler(this.TbEnd_ValueChanged);
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(3, 3);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(285, 377);
            this.previewBox.TabIndex = 9;
            this.previewBox.TabStop = false;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(257, 390);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(35, 23);
            this.btnPrevPage.TabIndex = 2;
            this.btnPrevPage.Text = "<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.BtnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(457, 390);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(35, 23);
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // lblPageCounter
            // 
            this.lblPageCounter.AutoSize = true;
            this.lblPageCounter.Location = new System.Drawing.Point(334, 421);
            this.lblPageCounter.Name = "lblPageCounter";
            this.lblPageCounter.Size = new System.Drawing.Size(35, 13);
            this.lblPageCounter.TabIndex = 13;
            this.lblPageCounter.Text = "label4";
            // 
            // tbPages
            // 
            this.tbPages.Location = new System.Drawing.Point(298, 389);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(153, 45);
            this.tbPages.TabIndex = 3;
            this.tbPages.ValueChanged += new System.EventHandler(this.TbPages_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pbShowBigBox);
            this.panel1.Controls.Add(this.previewBox);
            this.panel1.Location = new System.Drawing.Point(227, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 383);
            this.panel1.TabIndex = 15;
            // 
            // pbShowBigBox
            // 
            this.pbShowBigBox.BackColor = System.Drawing.Color.Transparent;
            this.pbShowBigBox.Image = global::PDFSplit.Properties.Resources.icon;
            this.pbShowBigBox.Location = new System.Drawing.Point(264, 3);
            this.pbShowBigBox.Name = "pbShowBigBox";
            this.pbShowBigBox.Size = new System.Drawing.Size(24, 24);
            this.pbShowBigBox.TabIndex = 10;
            this.pbShowBigBox.TabStop = false;
            this.pbShowBigBox.Click += new System.EventHandler(this.PbShowBigBox_Click);
            // 
            // tbControl
            // 
            this.tbControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbControl.Controls.Add(this.tbView);
            this.tbControl.Controls.Add(this.tbMain);
            this.tbControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tbControl.Location = new System.Drawing.Point(3, 2);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(537, 548);
            this.tbControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbControl.TabIndex = 16;
            this.tbControl.TabStop = false;
            // 
            // tbView
            // 
            this.tbView.Controls.Add(this.panel2);
            this.tbView.Location = new System.Drawing.Point(4, 5);
            this.tbView.Name = "tbView";
            this.tbView.Padding = new System.Windows.Forms.Padding(3);
            this.tbView.Size = new System.Drawing.Size(529, 539);
            this.tbView.TabIndex = 1;
            this.tbView.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.pbHideBox);
            this.panel2.Controls.Add(this.pbBigView);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 539);
            this.panel2.TabIndex = 0;
            // 
            // pbHideBox
            // 
            this.pbHideBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHideBox.BackColor = System.Drawing.Color.Transparent;
            this.pbHideBox.Image = global::PDFSplit.Properties.Resources.cancel;
            this.pbHideBox.Location = new System.Drawing.Point(496, 3);
            this.pbHideBox.Name = "pbHideBox";
            this.pbHideBox.Size = new System.Drawing.Size(24, 24);
            this.pbHideBox.TabIndex = 11;
            this.pbHideBox.TabStop = false;
            this.pbHideBox.Click += new System.EventHandler(this.PbHideBox_Click);
            // 
            // pbBigView
            // 
            this.pbBigView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBigView.Location = new System.Drawing.Point(3, 3);
            this.pbBigView.Name = "pbBigView";
            this.pbBigView.Size = new System.Drawing.Size(517, 533);
            this.pbBigView.TabIndex = 0;
            this.pbBigView.TabStop = false;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.btnSetAsEnd);
            this.tbMain.Controls.Add(this.btnSetAsStart);
            this.tbMain.Controls.Add(this.lbReferences);
            this.tbMain.Controls.Add(this.btnOk);
            this.tbMain.Controls.Add(this.tbEnd);
            this.tbMain.Controls.Add(this.btnCancel);
            this.tbMain.Controls.Add(this.lblPageCounter);
            this.tbMain.Controls.Add(this.tbStart);
            this.tbMain.Controls.Add(this.label2);
            this.tbMain.Controls.Add(this.btnNextPage);
            this.tbMain.Controls.Add(this.label1);
            this.tbMain.Controls.Add(this.tbPages);
            this.tbMain.Controls.Add(this.btnPrevPage);
            this.tbMain.Controls.Add(this.panel1);
            this.tbMain.Location = new System.Drawing.Point(4, 5);
            this.tbMain.Name = "tbMain";
            this.tbMain.Padding = new System.Windows.Forms.Padding(3);
            this.tbMain.Size = new System.Drawing.Size(529, 539);
            this.tbMain.TabIndex = 0;
            this.tbMain.UseVisualStyleBackColor = true;
            // 
            // btnSetAsEnd
            // 
            this.btnSetAsEnd.Location = new System.Drawing.Point(484, 475);
            this.btnSetAsEnd.Name = "btnSetAsEnd";
            this.btnSetAsEnd.Size = new System.Drawing.Size(35, 20);
            this.btnSetAsEnd.TabIndex = 8;
            this.btnSetAsEnd.Text = "<-";
            this.btnSetAsEnd.UseVisualStyleBackColor = true;
            this.btnSetAsEnd.Click += new System.EventHandler(this.BtnSetAsEnd_Click);
            // 
            // btnSetAsStart
            // 
            this.btnSetAsStart.Location = new System.Drawing.Point(484, 449);
            this.btnSetAsStart.Name = "btnSetAsStart";
            this.btnSetAsStart.Size = new System.Drawing.Size(35, 20);
            this.btnSetAsStart.TabIndex = 6;
            this.btnSetAsStart.Text = "<-";
            this.btnSetAsStart.UseVisualStyleBackColor = true;
            this.btnSetAsStart.Click += new System.EventHandler(this.BtnSetAsStart_Click);
            // 
            // PDFSplitForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(542, 551);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDFSplitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF aufteilen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.tbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPages)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowBigBox)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tbView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHideBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigView)).EndInit();
            this.tbMain.ResumeLayout(false);
            this.tbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckedListBox lbReferences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbStart;
        private System.Windows.Forms.NumericUpDown tbEnd;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPageCounter;
        private System.Windows.Forms.TrackBar tbPages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.TabPage tbMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbBigView;
        private System.Windows.Forms.PictureBox pbShowBigBox;
        private System.Windows.Forms.PictureBox pbHideBox;
        private System.Windows.Forms.Button btnSetAsEnd;
        private System.Windows.Forms.Button btnSetAsStart;
    }
}