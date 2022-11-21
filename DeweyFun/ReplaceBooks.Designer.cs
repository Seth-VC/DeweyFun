namespace DeweyFun
{
    partial class ReplaceBooks
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
            this.GenerateRandomNumberButton = new System.Windows.Forms.Button();
            this.numberList = new System.Windows.Forms.ListView();
            this.checkResultsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sendBTN = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BackButton = new System.Windows.Forms.Button();
            this.InformationButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateRandomNumberButton
            // 
            this.GenerateRandomNumberButton.BackColor = System.Drawing.Color.Cyan;
            this.GenerateRandomNumberButton.Location = new System.Drawing.Point(469, 9);
            this.GenerateRandomNumberButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GenerateRandomNumberButton.Name = "GenerateRandomNumberButton";
            this.GenerateRandomNumberButton.Size = new System.Drawing.Size(73, 30);
            this.GenerateRandomNumberButton.TabIndex = 0;
            this.GenerateRandomNumberButton.Text = "Generate";
            this.GenerateRandomNumberButton.UseVisualStyleBackColor = false;
            this.GenerateRandomNumberButton.Click += new System.EventHandler(this.GenerateRandomNumberButton_Click);
            // 
            // numberList
            // 
            this.numberList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numberList.Location = new System.Drawing.Point(13, 62);
            this.numberList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(232, 294);
            this.numberList.TabIndex = 1;
            this.numberList.UseCompatibleStateImageBehavior = false;
            // 
            // checkResultsButton
            // 
            this.checkResultsButton.BackColor = System.Drawing.Color.Lime;
            this.checkResultsButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkResultsButton.Location = new System.Drawing.Point(306, 199);
            this.checkResultsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkResultsButton.Name = "checkResultsButton";
            this.checkResultsButton.Size = new System.Drawing.Size(92, 82);
            this.checkResultsButton.TabIndex = 2;
            this.checkResultsButton.Text = "Submit answer";
            this.checkResultsButton.UseVisualStyleBackColor = false;
            this.checkResultsButton.Click += new System.EventHandler(this.checkResultsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(214, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Sorting, Arrange in ascending order!";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView1.Location = new System.Drawing.Point(460, 62);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(247, 294);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // sendBTN
            // 
            this.sendBTN.BackColor = System.Drawing.Color.Fuchsia;
            this.sendBTN.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendBTN.Location = new System.Drawing.Point(267, 62);
            this.sendBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(167, 39);
            this.sendBTN.TabIndex = 5;
            this.sendBTN.Text = "Send Call across";
            this.sendBTN.UseVisualStyleBackColor = false;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(63, 392);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(586, 27);
            this.progressBar1.TabIndex = 6;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.Location = new System.Drawing.Point(13, 6);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(57, 24);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.BackColor = System.Drawing.Color.Yellow;
            this.InformationButton.Location = new System.Drawing.Point(619, 11);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(88, 27);
            this.InformationButton.TabIndex = 9;
            this.InformationButton.Text = "How to Guide";
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.Fuchsia;
            this.UndoButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UndoButton.Location = new System.Drawing.Point(267, 128);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(167, 39);
            this.UndoButton.TabIndex = 10;
            this.UndoButton.Text = "Send call back";
            this.UndoButton.UseVisualStyleBackColor = false;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sendBTN);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkResultsButton);
            this.Controls.Add(this.numberList);
            this.Controls.Add(this.GenerateRandomNumberButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReplaceBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplaceBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateRandomNumberButton;
        private System.Windows.Forms.ListView numberList;
        private System.Windows.Forms.Button checkResultsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Button UndoButton;
    }
}