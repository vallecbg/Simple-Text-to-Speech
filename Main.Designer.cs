namespace TextToSpeech
{
    partial class Main
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
            this.voiceSelector = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Voice:";
            // 
            // voiceSelector
            // 
            this.voiceSelector.FormattingEnabled = true;
            this.voiceSelector.Items.AddRange(new object[] {
            "Not Set",
            "Male",
            "Female",
            "Neutral"});
            this.voiceSelector.Location = new System.Drawing.Point(89, 12);
            this.voiceSelector.Name = "voiceSelector";
            this.voiceSelector.Size = new System.Drawing.Size(203, 21);
            this.voiceSelector.TabIndex = 1;
            this.voiceSelector.SelectedIndexChanged += new System.EventHandler(this.voiceSelector_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(488, 277);
            this.textBox1.TabIndex = 2;
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(150, 340);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(83, 37);
            this.btnSpeak.TabIndex = 3;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(239, 340);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(83, 37);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(328, 340);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(83, 37);
            this.btnResume.TabIndex = 5;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(417, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 387);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.voiceSelector);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox voiceSelector;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnSave;
    }
}

