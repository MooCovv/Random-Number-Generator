namespace Random_Number_Generator
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
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.populateButton = new System.Windows.Forms.Button();
            this.valueBox1 = new System.Windows.Forms.TextBox();
            this.valueBox2 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(12, 25);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(169, 264);
            this.numberListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value 2";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(208, 206);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // populateButton
            // 
            this.populateButton.Location = new System.Drawing.Point(208, 150);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(75, 23);
            this.populateButton.TabIndex = 4;
            this.populateButton.Text = "Populate";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.populateButton_Click);
            // 
            // valueBox1
            // 
            this.valueBox1.Location = new System.Drawing.Point(249, 40);
            this.valueBox1.Name = "valueBox1";
            this.valueBox1.Size = new System.Drawing.Size(45, 20);
            this.valueBox1.TabIndex = 5;
            // 
            // valueBox2
            // 
            this.valueBox2.Location = new System.Drawing.Point(249, 96);
            this.valueBox2.Name = "valueBox2";
            this.valueBox2.Size = new System.Drawing.Size(45, 20);
            this.valueBox2.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 303);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.valueBox2);
            this.Controls.Add(this.valueBox1);
            this.Controls.Add(this.populateButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberListBox);
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button populateButton;
        private System.Windows.Forms.TextBox valueBox1;
        private System.Windows.Forms.TextBox valueBox2;
        private System.Windows.Forms.Button exitButton;
    }
}

