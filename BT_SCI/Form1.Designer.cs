namespace BT_SCI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPortBluetooth = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPortSelect = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonScan = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxPortSelect
            // 
            this.comboBoxPortSelect.Enabled = false;
            this.comboBoxPortSelect.FormattingEnabled = true;
            this.comboBoxPortSelect.Location = new System.Drawing.Point(270, 14);
            this.comboBoxPortSelect.Name = "comboBoxPortSelect";
            this.comboBoxPortSelect.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPortSelect.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(397, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "通信開始";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(206, 17);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(58, 12);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "COMポート";
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(12, 12);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(78, 23);
            this.buttonScan.TabIndex = 3;
            this.buttonScan.Text = "ポートスキャン";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(459, 309);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxPortSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "学科展SCIプログラム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortBluetooth;
        private System.Windows.Forms.ComboBox comboBoxPortSelect;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

