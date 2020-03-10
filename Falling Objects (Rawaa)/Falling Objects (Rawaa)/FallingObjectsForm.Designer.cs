namespace Falling_Objects__Rawaa_
{
    partial class frmFallingObjects
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(23, 115);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(562, 25);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Enter the time (in seconds) since you released the object:";
            this.lblTime.Click += new System.EventHandler(this.LblTime_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeight.Location = new System.Drawing.Point(23, 284);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(440, 25);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "The height of the object above the ground is:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(302, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 45);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(579, 120);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(108, 20);
            this.txtTime.TabIndex = 3;
            this.txtTime.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(456, 284);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(138, 25);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "                     ";
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 5;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Falling_Objects__Rawaa_.Properties.Resources.Starry_night_Image1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mnuProgram);
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects By Rawaa";
            this.Load += new System.EventHandler(this.FrmFallingObjects_Load);
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

