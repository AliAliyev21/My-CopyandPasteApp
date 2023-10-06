namespace WindowsFormsApp8
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.copybtn = new System.Windows.Forms.Button();
            this.pastebtn = new System.Windows.Forms.Button();
            this.cutbtn = new System.Windows.Forms.Button();
            this.undobtn = new System.Windows.Forms.Button();
            this.redobtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::WindowsFormsApp8.Properties.Resources.treimages1;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 450);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(78, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(656, 341);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // copybtn
            // 
            this.copybtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.copybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copybtn.Location = new System.Drawing.Point(78, 347);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(130, 31);
            this.copybtn.TabIndex = 2;
            this.copybtn.Text = "Copy";
            this.copybtn.UseVisualStyleBackColor = false;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // pastebtn
            // 
            this.pastebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.pastebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastebtn.Location = new System.Drawing.Point(214, 347);
            this.pastebtn.Name = "pastebtn";
            this.pastebtn.Size = new System.Drawing.Size(126, 31);
            this.pastebtn.TabIndex = 3;
            this.pastebtn.Text = "Paste";
            this.pastebtn.UseVisualStyleBackColor = false;
            this.pastebtn.Click += new System.EventHandler(this.pastebtn_Click);
            // 
            // cutbtn
            // 
            this.cutbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutbtn.Location = new System.Drawing.Point(346, 347);
            this.cutbtn.Name = "cutbtn";
            this.cutbtn.Size = new System.Drawing.Size(124, 31);
            this.cutbtn.TabIndex = 4;
            this.cutbtn.Text = "Cut";
            this.cutbtn.UseVisualStyleBackColor = false;
            this.cutbtn.Click += new System.EventHandler(this.cutbtn_Click);
            // 
            // undobtn
            // 
            this.undobtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.undobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undobtn.Location = new System.Drawing.Point(476, 347);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(121, 31);
            this.undobtn.TabIndex = 5;
            this.undobtn.Text = "Undo";
            this.undobtn.UseVisualStyleBackColor = false;
            this.undobtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // redobtn
            // 
            this.redobtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.redobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redobtn.Location = new System.Drawing.Point(603, 347);
            this.redobtn.Name = "redobtn";
            this.redobtn.Size = new System.Drawing.Size(131, 31);
            this.redobtn.TabIndex = 6;
            this.redobtn.Text = "Redo";
            this.redobtn.UseVisualStyleBackColor = false;
            this.redobtn.Click += new System.EventHandler(this.redobtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redobtn);
            this.Controls.Add(this.undobtn);
            this.Controls.Add(this.cutbtn);
            this.Controls.Add(this.pastebtn);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button copybtn;
        private System.Windows.Forms.Button pastebtn;
        private System.Windows.Forms.Button cutbtn;
        private System.Windows.Forms.Button undobtn;
        private System.Windows.Forms.Button redobtn;
    }
}

