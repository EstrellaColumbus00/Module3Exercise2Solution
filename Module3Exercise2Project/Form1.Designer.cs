using System;
using System.Drawing;
using System.Drawing.Text;

namespace Module3Exercise2Project
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
        private void InitializeComponent() // this is the part of the code we fixing 
        {
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button(); // changing this from button2 to btnBlue
            this.btnRight = new System.Windows.Forms.Button(); // changing this from button3 to btnRight
            this.btnLeft = new System.Windows.Forms.Button(); // changing this from button4 to btnLeft
            this.btnExit = new System.Windows.Forms.Button(); // chaning this from button5 to btnExit
            this.lblDisplay = new System.Windows.Forms.Label(); // changing this from label1 to lblDispaly
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(21, 16); //Aliged top with lable
            this.btnRed.Name = "btnRed"; // Changed: correcting name from button 1 to btnRed
            this.btnRed.Size = new System.Drawing.Size(93, 45);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "&D"; // Fixed: Hotkey for Red, text hidden by color 
            this.btnRed.ForeColor = System.Drawing.Color.Red; // FixeD:  Hide test visually 
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            //  renaming everything from button2 to btnBlue
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(376, 16); //Aligned top with label 
            this.btnBlue.Name = "btnBlue"; // Chagned:  renaming button2 to btnBlue
            this.btnBlue.Size = new System.Drawing.Size(93, 45);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "&B"; // Fixed: Hotkey for Blue, text hidden by color 
            this.btnBlue.ForeColor = System.Drawing.Color.Blue; // Fixed: Hide text visually
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRight
            // renamingimg everything from button3 to btnRight
            this.btnRight.Location = new System.Drawing.Point(376, 200); // Fixed: Alignment 
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(93, 45);
            this.btnRight.TabIndex = 3; // Tab Order
            this.btnRight.Text = "&R"; //  Fixed: hotkey for right 
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click); // Changed button name 
            // 
            // btnLeft
            // changing everything from button4 to btnleft
            this.btnLeft.Location = new System.Drawing.Point(21, 200); // Alighed bottom with label
            this.btnLeft.Name = "btnLeft"; // Changed:  button4 to btnLeft
            this.btnLeft.Size = new System.Drawing.Size(93, 45);
            this.btnLeft.TabIndex = 2; // Fixed: tab order
            this.btnLeft.Text = "&L"; // Fixed: Hotkey for Left 
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click); // Changed button name 
            // 
            // btnExit
            // changing everything from button5 to btnExit
            this.btnExit.Location = new System.Drawing.Point(133, 220); // Fixed:positioned below label
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 45); // Fixed: same widtd as label
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit"; // Changed: Hotkey for Escape
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click); // changed button name 
            // 
            // lblDisplay
            // chaning everything from label1 to lblDisplay
            this.lblDisplay.BackColor = System.Drawing.Color.Yellow;
            this.lblDisplay.ForeColor = System.Drawing.Color.Black; // Fixed: text color fixed 
            this.lblDisplay.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold); // Fixed: Font and size
            this.lblDisplay.Location = new System.Drawing.Point(133, 16);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(219, 184);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // Fixed: Centered text
            // 
            // Form1
            // renaming the names declarations to match the rest of the code 
            this.CancelButton = this.btnExit; // Fixed: Escape key triggers Exit 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.Controls.Add(this.lblDisplay);// Changed label name 
            this.Controls.Add(this.btnExit); // Changed button name 
            this.Controls.Add(this.btnLeft); // chagned button name 
            this.Controls.Add(this.btnRight); // changed button name 
            this.Controls.Add(this.btnBlue); // chagned button name 
            this.Controls.Add(this.btnRed); // changed button name 
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        // Updating Field Declaration - making sure the new name match 

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplay;
    }
}

