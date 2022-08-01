namespace FizzBuzz_Kata
{
    partial class FizzBuzzKata
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fizzBuzzLabel = new System.Windows.Forms.Label();
            this.fizzBuzzButton = new System.Windows.Forms.Button();
            this.mainTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fizzBuzzLabel
            // 
            this.fizzBuzzLabel.AutoSize = true;
            this.fizzBuzzLabel.Location = new System.Drawing.Point(109, 9);
            this.fizzBuzzLabel.Name = "fizzBuzzLabel";
            this.fizzBuzzLabel.Size = new System.Drawing.Size(76, 15);
            this.fizzBuzzLabel.TabIndex = 0;
            this.fizzBuzzLabel.Text = "FizzBuzz Kata";
            // 
            // fizzBuzzButton
            // 
            this.fizzBuzzButton.Location = new System.Drawing.Point(12, 274);
            this.fizzBuzzButton.Name = "fizzBuzzButton";
            this.fizzBuzzButton.Size = new System.Drawing.Size(271, 69);
            this.fizzBuzzButton.TabIndex = 1;
            this.fizzBuzzButton.Text = "Start";
            this.fizzBuzzButton.UseVisualStyleBackColor = true;
            this.fizzBuzzButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainTextbox
            // 
            this.mainTextbox.Location = new System.Drawing.Point(12, 41);
            this.mainTextbox.Multiline = true;
            this.mainTextbox.Name = "mainTextbox";
            this.mainTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextbox.Size = new System.Drawing.Size(271, 214);
            this.mainTextbox.TabIndex = 2;
            // 
            // FizzBuzzKata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 356);
            this.Controls.Add(this.mainTextbox);
            this.Controls.Add(this.fizzBuzzButton);
            this.Controls.Add(this.fizzBuzzLabel);
            this.Name = "FizzBuzzKata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FizzBuzz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fizzBuzzLabel;
        private Button fizzBuzzButton;
        private TextBox mainTextbox;
    }
}