namespace minesweeper_3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.beginner = new System.Windows.Forms.RadioButton();
            this.board = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.hard);
            this.panel1.Controls.Add(this.medium);
            this.panel1.Controls.Add(this.beginner);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 70);
            this.panel1.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(375, 21);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(384, 23);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(295, 27);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(46, 17);
            this.hard.TabIndex = 3;
            this.hard.TabStop = true;
            this.hard.Text = "hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(168, 27);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(61, 17);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // beginner
            // 
            this.beginner.AutoSize = true;
            this.beginner.Location = new System.Drawing.Point(41, 27);
            this.beginner.Name = "beginner";
            this.beginner.Size = new System.Drawing.Size(66, 17);
            this.beginner.TabIndex = 1;
            this.beginner.TabStop = true;
            this.beginner.Text = "beginner";
            this.beginner.UseVisualStyleBackColor = true;
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(2, 76);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(798, 290);
            this.board.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.board);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton beginner;
        private System.Windows.Forms.FlowLayoutPanel board;
    }
}

