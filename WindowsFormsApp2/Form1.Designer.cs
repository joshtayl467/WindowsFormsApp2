namespace WindowsFormsApp2
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
            this.countdownlabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countdownlabel
            // 
            this.countdownlabel.AutoSize = true;
            this.countdownlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.countdownlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownlabel.Location = new System.Drawing.Point(316, 135);
            this.countdownlabel.Name = "countdownlabel";
            this.countdownlabel.Size = new System.Drawing.Size(122, 52);
            this.countdownlabel.TabIndex = 1;
            this.countdownlabel.Text = "Hello";
            this.countdownlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(315, 303);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(123, 57);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.countdownlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countdownlabel;
        private System.Windows.Forms.Button startbutton;
    }
}

