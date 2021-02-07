namespace ZafraTamadHopfield
{
    partial class Form2
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
            this.scramblebtn = new System.Windows.Forms.Button();
            this.scramblelevelbox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.scramblelevelbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scramble Level";
            // 
            // scramblebtn
            // 
            this.scramblebtn.Location = new System.Drawing.Point(87, 79);
            this.scramblebtn.Name = "scramblebtn";
            this.scramblebtn.Size = new System.Drawing.Size(75, 23);
            this.scramblebtn.TabIndex = 2;
            this.scramblebtn.Text = "Scramble!";
            this.scramblebtn.UseVisualStyleBackColor = true;
            this.scramblebtn.Click += new System.EventHandler(this.scramblebtn_Click);
            // 
            // scramblelevelbox
            // 
            this.scramblelevelbox.Location = new System.Drawing.Point(87, 53);
            this.scramblelevelbox.Name = "scramblelevelbox";
            this.scramblelevelbox.Size = new System.Drawing.Size(77, 20);
            this.scramblelevelbox.TabIndex = 3;
            this.scramblelevelbox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 127);
            this.Controls.Add(this.scramblelevelbox);
            this.Controls.Add(this.scramblebtn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Scrambler";
            ((System.ComponentModel.ISupportInitialize)(this.scramblelevelbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scramblebtn;
        private System.Windows.Forms.NumericUpDown scramblelevelbox;
    }
}