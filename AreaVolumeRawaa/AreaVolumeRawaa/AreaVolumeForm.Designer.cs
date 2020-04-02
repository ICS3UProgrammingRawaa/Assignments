namespace AreaVolumeRawaa
{
    partial class frmAreaVolume
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
            this.lblLengthA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniShape = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTrapezoid = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSphere = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCylinder = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeightTrapezoid = new System.Windows.Forms.Label();
            this.txtLengthA = new System.Windows.Forms.TextBox();
            this.txtHeigthTrapezoid = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRadiusSphere = new System.Windows.Forms.Label();
            this.txtRadiusSphere = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblVolumeSphere = new System.Windows.Forms.Label();
            this.lblRadiusCylinder = new System.Windows.Forms.Label();
            this.txtRadiusCylinder = new System.Windows.Forms.TextBox();
            this.lblHeightCylinder = new System.Windows.Forms.Label();
            this.txtHeightCylinder = new System.Windows.Forms.TextBox();
            this.lblVolumeCylinder = new System.Windows.Forms.Label();
            this.lblVolumeC = new System.Windows.Forms.Label();
            this.lblLengthB = new System.Windows.Forms.Label();
            this.txtLengthB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLengthA
            // 
            this.lblLengthA.AutoSize = true;
            this.lblLengthA.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthA.Location = new System.Drawing.Point(240, 145);
            this.lblLengthA.Name = "lblLengthA";
            this.lblLengthA.Size = new System.Drawing.Size(273, 40);
            this.lblLengthA.TabIndex = 0;
            this.lblLengthA.Text = "Enter the lengthA:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniShape});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(54, 29);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(270, 34);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniShape
            // 
            this.mniShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTrapezoid,
            this.mniSphere,
            this.mniCylinder});
            this.mniShape.Name = "mniShape";
            this.mniShape.Size = new System.Drawing.Size(77, 29);
            this.mniShape.Text = "Shape";
            // 
            // mniTrapezoid
            // 
            this.mniTrapezoid.Name = "mniTrapezoid";
            this.mniTrapezoid.Size = new System.Drawing.Size(270, 34);
            this.mniTrapezoid.Text = "Trapezoid";
            this.mniTrapezoid.Click += new System.EventHandler(this.mniTrapezoid_Click);
            // 
            // mniSphere
            // 
            this.mniSphere.Name = "mniSphere";
            this.mniSphere.Size = new System.Drawing.Size(270, 34);
            this.mniSphere.Text = "Sphere ";
            this.mniSphere.Click += new System.EventHandler(this.mniSphere_Click);
            // 
            // mniCylinder
            // 
            this.mniCylinder.Name = "mniCylinder";
            this.mniCylinder.Size = new System.Drawing.Size(270, 34);
            this.mniCylinder.Text = "Cylinder";
            this.mniCylinder.Click += new System.EventHandler(this.mniCylinder_Click);
            // 
            // lblHeightTrapezoid
            // 
            this.lblHeightTrapezoid.AutoSize = true;
            this.lblHeightTrapezoid.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightTrapezoid.Location = new System.Drawing.Point(240, 297);
            this.lblHeightTrapezoid.Name = "lblHeightTrapezoid";
            this.lblHeightTrapezoid.Size = new System.Drawing.Size(252, 40);
            this.lblHeightTrapezoid.TabIndex = 2;
            this.lblHeightTrapezoid.Text = "Enter the height:";
            // 
            // txtLengthA
            // 
            this.txtLengthA.Location = new System.Drawing.Point(581, 155);
            this.txtLengthA.Name = "txtLengthA";
            this.txtLengthA.Size = new System.Drawing.Size(173, 26);
            this.txtLengthA.TabIndex = 3;
            // 
            // txtHeigthTrapezoid
            // 
            this.txtHeigthTrapezoid.Location = new System.Drawing.Point(581, 297);
            this.txtHeigthTrapezoid.Name = "txtHeigthTrapezoid";
            this.txtHeigthTrapezoid.Size = new System.Drawing.Size(173, 26);
            this.txtHeigthTrapezoid.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(316, 486);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(176, 40);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "The area is:";
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAnswer.Location = new System.Drawing.Point(574, 486);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(59, 40);
            this.lblAreaAnswer.TabIndex = 6;
            this.lblAreaAnswer.Text = "???";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(915, 370);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(195, 51);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRadiusSphere
            // 
            this.lblRadiusSphere.AutoSize = true;
            this.lblRadiusSphere.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiusSphere.Location = new System.Drawing.Point(269, 297);
            this.lblRadiusSphere.Name = "lblRadiusSphere";
            this.lblRadiusSphere.Size = new System.Drawing.Size(247, 40);
            this.lblRadiusSphere.TabIndex = 8;
            this.lblRadiusSphere.Text = "Enter the radius:";
            // 
            // txtRadiusSphere
            // 
            this.txtRadiusSphere.Location = new System.Drawing.Point(617, 307);
            this.txtRadiusSphere.Name = "txtRadiusSphere";
            this.txtRadiusSphere.Size = new System.Drawing.Size(173, 26);
            this.txtRadiusSphere.TabIndex = 9;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(354, 486);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(221, 40);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "The volume is:";
            // 
            // lblVolumeSphere
            // 
            this.lblVolumeSphere.AutoSize = true;
            this.lblVolumeSphere.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeSphere.Location = new System.Drawing.Point(659, 486);
            this.lblVolumeSphere.Name = "lblVolumeSphere";
            this.lblVolumeSphere.Size = new System.Drawing.Size(59, 40);
            this.lblVolumeSphere.TabIndex = 11;
            this.lblVolumeSphere.Text = "???";
            // 
            // lblRadiusCylinder
            // 
            this.lblRadiusCylinder.AutoSize = true;
            this.lblRadiusCylinder.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiusCylinder.Location = new System.Drawing.Point(245, 247);
            this.lblRadiusCylinder.Name = "lblRadiusCylinder";
            this.lblRadiusCylinder.Size = new System.Drawing.Size(247, 40);
            this.lblRadiusCylinder.TabIndex = 12;
            this.lblRadiusCylinder.Text = "Enter the radius:";
            // 
            // txtRadiusCylinder
            // 
            this.txtRadiusCylinder.Location = new System.Drawing.Point(581, 257);
            this.txtRadiusCylinder.Name = "txtRadiusCylinder";
            this.txtRadiusCylinder.Size = new System.Drawing.Size(173, 26);
            this.txtRadiusCylinder.TabIndex = 13;
            // 
            // lblHeightCylinder
            // 
            this.lblHeightCylinder.AutoSize = true;
            this.lblHeightCylinder.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightCylinder.Location = new System.Drawing.Point(245, 359);
            this.lblHeightCylinder.Name = "lblHeightCylinder";
            this.lblHeightCylinder.Size = new System.Drawing.Size(252, 40);
            this.lblHeightCylinder.TabIndex = 14;
            this.lblHeightCylinder.Text = "Enter the height:";
            this.lblHeightCylinder.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHeightCylinder
            // 
            this.txtHeightCylinder.Location = new System.Drawing.Point(581, 369);
            this.txtHeightCylinder.Name = "txtHeightCylinder";
            this.txtHeightCylinder.Size = new System.Drawing.Size(173, 26);
            this.txtHeightCylinder.TabIndex = 15;
            // 
            // lblVolumeCylinder
            // 
            this.lblVolumeCylinder.AutoSize = true;
            this.lblVolumeCylinder.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeCylinder.Location = new System.Drawing.Point(731, 526);
            this.lblVolumeCylinder.Name = "lblVolumeCylinder";
            this.lblVolumeCylinder.Size = new System.Drawing.Size(59, 40);
            this.lblVolumeCylinder.TabIndex = 16;
            this.lblVolumeCylinder.Text = "???";
            // 
            // lblVolumeC
            // 
            this.lblVolumeC.AutoSize = true;
            this.lblVolumeC.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeC.Location = new System.Drawing.Point(328, 526);
            this.lblVolumeC.Name = "lblVolumeC";
            this.lblVolumeC.Size = new System.Drawing.Size(221, 40);
            this.lblVolumeC.TabIndex = 17;
            this.lblVolumeC.Text = "The volume is:";
            // 
            // lblLengthB
            // 
            this.lblLengthB.AutoSize = true;
            this.lblLengthB.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthB.Location = new System.Drawing.Point(240, 230);
            this.lblLengthB.Name = "lblLengthB";
            this.lblLengthB.Size = new System.Drawing.Size(270, 40);
            this.lblLengthB.TabIndex = 18;
            this.lblLengthB.Text = "Enter the lengthB:";
            // 
            // txtLengthB
            // 
            this.txtLengthB.Location = new System.Drawing.Point(581, 225);
            this.txtLengthB.Name = "txtLengthB";
            this.txtLengthB.Size = new System.Drawing.Size(173, 26);
            this.txtLengthB.TabIndex = 19;
            // 
            // frmAreaVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtLengthB);
            this.Controls.Add(this.lblLengthB);
            this.Controls.Add(this.lblVolumeC);
            this.Controls.Add(this.lblVolumeCylinder);
            this.Controls.Add(this.txtHeightCylinder);
            this.Controls.Add(this.lblHeightCylinder);
            this.Controls.Add(this.txtRadiusCylinder);
            this.Controls.Add(this.lblRadiusCylinder);
            this.Controls.Add(this.lblVolumeSphere);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtRadiusSphere);
            this.Controls.Add(this.lblRadiusSphere);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtHeigthTrapezoid);
            this.Controls.Add(this.txtLengthA);
            this.Controls.Add(this.lblHeightTrapezoid);
            this.Controls.Add(this.lblLengthA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAreaVolume";
            this.Text = "Area and Volume By Rawaa";
            this.Load += new System.EventHandler(this.frmAreaVolume_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLengthA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniShape;
        private System.Windows.Forms.ToolStripMenuItem mniTrapezoid;
        private System.Windows.Forms.ToolStripMenuItem mniSphere;
        private System.Windows.Forms.ToolStripMenuItem mniCylinder;
        private System.Windows.Forms.Label lblHeightTrapezoid;
        private System.Windows.Forms.TextBox txtLengthA;
        private System.Windows.Forms.TextBox txtHeigthTrapezoid;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRadiusSphere;
        private System.Windows.Forms.TextBox txtRadiusSphere;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblVolumeSphere;
        private System.Windows.Forms.Label lblRadiusCylinder;
        private System.Windows.Forms.TextBox txtRadiusCylinder;
        private System.Windows.Forms.Label lblHeightCylinder;
        private System.Windows.Forms.TextBox txtHeightCylinder;
        private System.Windows.Forms.Label lblVolumeCylinder;
        private System.Windows.Forms.Label lblVolumeC;
        private System.Windows.Forms.Label lblLengthB;
        private System.Windows.Forms.TextBox txtLengthB;
    }
}

