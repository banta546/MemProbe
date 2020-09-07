namespace GHL_LinkGrabber
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
            this.txtMemAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnGrabLink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numChunkSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numPollRate = new System.Windows.Forms.NumericUpDown();
            this.bgwMemProbe = new System.ComponentModel.BackgroundWorker();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numChunkSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPollRate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemAddr
            // 
            this.txtMemAddr.Location = new System.Drawing.Point(102, 300);
            this.txtMemAddr.Name = "txtMemAddr";
            this.txtMemAddr.Size = new System.Drawing.Size(166, 20);
            this.txtMemAddr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MemAddress";
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(12, 12);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(337, 251);
            this.lbLog.TabIndex = 7;
            // 
            // btnGrabLink
            // 
            this.btnGrabLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabLink.Location = new System.Drawing.Point(274, 269);
            this.btnGrabLink.Name = "btnGrabLink";
            this.btnGrabLink.Size = new System.Drawing.Size(75, 51);
            this.btnGrabLink.TabIndex = 4;
            this.btnGrabLink.Text = "Start";
            this.btnGrabLink.UseVisualStyleBackColor = true;
            this.btnGrabLink.Click += new System.EventHandler(this.grabLink);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poll Interval (ms)";
            // 
            // txtProcName
            // 
            this.txtProcName.Location = new System.Drawing.Point(102, 269);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(166, 20);
            this.txtProcName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ProcessName";
            // 
            // numChunkSize
            // 
            this.numChunkSize.Location = new System.Drawing.Point(102, 358);
            this.numChunkSize.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numChunkSize.Name = "numChunkSize";
            this.numChunkSize.Size = new System.Drawing.Size(46, 20);
            this.numChunkSize.TabIndex = 3;
            this.numChunkSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ChunkSize";
            // 
            // numPollRate
            // 
            this.numPollRate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPollRate.Location = new System.Drawing.Point(102, 328);
            this.numPollRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPollRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPollRate.Name = "numPollRate";
            this.numPollRate.Size = new System.Drawing.Size(46, 20);
            this.numPollRate.TabIndex = 2;
            this.numPollRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // bgwMemProbe
            // 
            this.bgwMemProbe.WorkerReportsProgress = true;
            this.bgwMemProbe.WorkerSupportsCancellation = true;
            this.bgwMemProbe.DoWork += new System.ComponentModel.DoWorkEventHandler(this.startProbe);
            this.bgwMemProbe.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.updateProbe);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(274, 328);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 51);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.cancelProbe);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(274, 385);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 51);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.exportText);
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 449);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.numPollRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numChunkSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGrabLink);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemAddr);
            this.Name = "Form1";
            this.Text = "MemProbe";
            ((System.ComponentModel.ISupportInitialize)(this.numChunkSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPollRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnGrabLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numChunkSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPollRate;
        private System.ComponentModel.BackgroundWorker bgwMemProbe;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdExport;
    }
}

