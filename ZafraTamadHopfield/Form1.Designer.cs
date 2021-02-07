namespace ZafraTamadHopfield
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
            this.createNNbtn = new System.Windows.Forms.Button();
            this.addPatternbtn = new System.Windows.Forms.Button();
            this.runbtn = new System.Windows.Forms.Button();
            this.patternspanelholder = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nnStatePanel = new System.Windows.Forms.GroupBox();
            this.nnState = new ImageMagnifier.ImageMagnifier();
            this.patternspanel = new System.Windows.Forms.Panel();
            this.patternspanelholder.SuspendLayout();
            this.nnStatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNNbtn
            // 
            this.createNNbtn.Location = new System.Drawing.Point(104, 318);
            this.createNNbtn.Name = "createNNbtn";
            this.createNNbtn.Size = new System.Drawing.Size(75, 23);
            this.createNNbtn.TabIndex = 0;
            this.createNNbtn.Text = "Create NN";
            this.createNNbtn.UseVisualStyleBackColor = true;
            this.createNNbtn.Click += new System.EventHandler(this.createNNbtn_Click);
            // 
            // addPatternbtn
            // 
            this.addPatternbtn.Enabled = false;
            this.addPatternbtn.Location = new System.Drawing.Point(185, 318);
            this.addPatternbtn.Name = "addPatternbtn";
            this.addPatternbtn.Size = new System.Drawing.Size(75, 23);
            this.addPatternbtn.TabIndex = 2;
            this.addPatternbtn.Text = "Add Pattern";
            this.addPatternbtn.UseVisualStyleBackColor = true;
            this.addPatternbtn.Click += new System.EventHandler(this.addPatternbtn_Click);
            // 
            // runbtn
            // 
            this.runbtn.Enabled = false;
            this.runbtn.Location = new System.Drawing.Point(266, 318);
            this.runbtn.Name = "runbtn";
            this.runbtn.Size = new System.Drawing.Size(75, 23);
            this.runbtn.TabIndex = 3;
            this.runbtn.Text = "Run";
            this.runbtn.UseVisualStyleBackColor = true;
            this.runbtn.Click += new System.EventHandler(this.runbtn_Click);
            // 
            // patternspanelholder
            // 
            this.patternspanelholder.Controls.Add(this.patternspanel);
            this.patternspanelholder.Location = new System.Drawing.Point(318, 12);
            this.patternspanelholder.Name = "patternspanelholder";
            this.patternspanelholder.Size = new System.Drawing.Size(105, 300);
            this.patternspanelholder.TabIndex = 4;
            this.patternspanelholder.TabStop = false;
            this.patternspanelholder.Text = "Patterns in NN";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // nnStatePanel
            // 
            this.nnStatePanel.Controls.Add(this.nnState);
            this.nnStatePanel.Location = new System.Drawing.Point(12, 12);
            this.nnStatePanel.Name = "nnStatePanel";
            this.nnStatePanel.Size = new System.Drawing.Size(300, 300);
            this.nnStatePanel.TabIndex = 5;
            this.nnStatePanel.TabStop = false;
            this.nnStatePanel.Text = "NN State";
            // 
            // nnState
            // 
            this.nnState.ImageToMagnify = null;
            this.nnState.Location = new System.Drawing.Point(14, 14);
            this.nnState.MagnificationCoefficient = 1;
            this.nnState.Name = "nnState";
            this.nnState.Size = new System.Drawing.Size(270, 270);
            this.nnState.TabIndex = 3;
            // 
            // patternspanel
            // 
            this.patternspanel.AutoScroll = true;
            this.patternspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patternspanel.Location = new System.Drawing.Point(3, 16);
            this.patternspanel.Name = "patternspanel";
            this.patternspanel.Size = new System.Drawing.Size(99, 281);
            this.patternspanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 352);
            this.Controls.Add(this.nnStatePanel);
            this.Controls.Add(this.patternspanelholder);
            this.Controls.Add(this.runbtn);
            this.Controls.Add(this.addPatternbtn);
            this.Controls.Add(this.createNNbtn);
            this.Name = "Form1";
            this.Text = "Zafra Tamad Hopfield";
            this.patternspanelholder.ResumeLayout(false);
            this.nnStatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNNbtn;
        private System.Windows.Forms.Button addPatternbtn;
        private System.Windows.Forms.Button runbtn;
        private System.Windows.Forms.GroupBox patternspanelholder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox nnStatePanel;
        private ImageMagnifier.ImageMagnifier nnState;
        private System.Windows.Forms.Panel patternspanel;
    }
}

