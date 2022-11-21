namespace DeweyFun
{
    partial class LearnDewey
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
            this.Backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Red;
            this.Backbtn.Location = new System.Drawing.Point(3, 12);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(58, 23);
            this.Backbtn.TabIndex = 0;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // LearnDewey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeweyFun.Properties.Resources.learn;
            this.ClientSize = new System.Drawing.Size(541, 524);
            this.Controls.Add(this.Backbtn);
            this.Name = "LearnDewey";
            this.Text = "LearnDewey";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Backbtn;
    }
}