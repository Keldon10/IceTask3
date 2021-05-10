
using System;

namespace DelegatesG2
{
    partial class frmDonutsOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCoffes = new System.Windows.Forms.TextBox();
            this.txbDonuts = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblDonut = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(179, 72);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 23);
            this.txbName.TabIndex = 1;
            // 
            // txbCoffes
            // 
            this.txbCoffes.Location = new System.Drawing.Point(179, 112);
            this.txbCoffes.Name = "txbCoffes";
            this.txbCoffes.Size = new System.Drawing.Size(100, 23);
            this.txbCoffes.TabIndex = 2;
            // 
            // txbDonuts
            // 
            this.txbDonuts.Location = new System.Drawing.Point(179, 154);
            this.txbDonuts.Name = "txbDonuts";
            this.txbDonuts.Size = new System.Drawing.Size(100, 23);
            this.txbDonuts.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(106, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(106, 119);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(42, 15);
            this.lblCoffee.TabIndex = 5;
            this.lblCoffee.Text = "Coffee";
            // 
            // lblDonut
            // 
            this.lblDonut.AutoSize = true;
            this.lblDonut.Location = new System.Drawing.Point(106, 162);
            this.lblDonut.Name = "lblDonut";
            this.lblDonut.Size = new System.Drawing.Size(40, 15);
            this.lblDonut.TabIndex = 6;
            this.lblDonut.Text = "Donut";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            
            // frmDonutsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDonut);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbDonuts);
            this.Controls.Add(this.txbCoffes);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.button1);
            this.Name = "frmDonutsOrder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbCoffes;
        private System.Windows.Forms.TextBox txbDonuts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblDonut;
        private System.Windows.Forms.Button button2;
    }
}

