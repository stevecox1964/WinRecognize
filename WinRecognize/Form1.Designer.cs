namespace WinRecognize
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
            this.btnRecordVoice = new System.Windows.Forms.Button();
            this.btnSpeechInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPlayAudio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecordVoice
            // 
            this.btnRecordVoice.Location = new System.Drawing.Point(12, 12);
            this.btnRecordVoice.Name = "btnRecordVoice";
            this.btnRecordVoice.Size = new System.Drawing.Size(75, 23);
            this.btnRecordVoice.TabIndex = 0;
            this.btnRecordVoice.Text = "Record Voice";
            this.btnRecordVoice.UseVisualStyleBackColor = true;
            this.btnRecordVoice.Click += new System.EventHandler(this.btnRecordVoice_Click);
            // 
            // btnSpeechInfo
            // 
            this.btnSpeechInfo.Location = new System.Drawing.Point(12, 70);
            this.btnSpeechInfo.Name = "btnSpeechInfo";
            this.btnSpeechInfo.Size = new System.Drawing.Size(100, 23);
            this.btnSpeechInfo.TabIndex = 1;
            this.btnSpeechInfo.Text = "Convert Speech";
            this.btnSpeechInfo.UseVisualStyleBackColor = true;
            this.btnSpeechInfo.Click += new System.EventHandler(this.btnSpeechInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 150);
            this.textBox1.TabIndex = 3;
            // 
            // btnPlayAudio
            // 
            this.btnPlayAudio.Location = new System.Drawing.Point(118, 41);
            this.btnPlayAudio.Name = "btnPlayAudio";
            this.btnPlayAudio.Size = new System.Drawing.Size(100, 23);
            this.btnPlayAudio.TabIndex = 4;
            this.btnPlayAudio.Text = "Play Audio";
            this.btnPlayAudio.UseVisualStyleBackColor = true;
            this.btnPlayAudio.Visible = false;
            this.btnPlayAudio.Click += new System.EventHandler(this.btnPlayAudio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPlayAudio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSpeechInfo);
            this.Controls.Add(this.btnRecordVoice);
            this.Name = "Form1";
            this.Text = "Win Recognize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordVoice;
        private System.Windows.Forms.Button btnSpeechInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPlayAudio;
    }
}

