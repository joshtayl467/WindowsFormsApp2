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
            this.secretbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countdownlabel
            // 
            this.countdownlabel.BackColor = System.Drawing.Color.Transparent;
            this.countdownlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.countdownlabel.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.countdownlabel.Location = new System.Drawing.Point(42, 91);
            this.countdownlabel.Name = "countdownlabel";
            this.countdownlabel.Size = new System.Drawing.Size(677, 244);
            this.countdownlabel.TabIndex = 1;
            this.countdownlabel.Text = " ";
            this.countdownlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.White;
            this.startbutton.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.Color.Black;
            this.startbutton.Location = new System.Drawing.Point(315, 180);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(123, 57);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // secretbutton
            // 
            this.secretbutton.BackColor = System.Drawing.Color.Black;
            this.secretbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.secretbutton.FlatAppearance.BorderSize = 0;
            this.secretbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.secretbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secretbutton.ForeColor = System.Drawing.Color.Transparent;
            this.secretbutton.Location = new System.Drawing.Point(595, 91);
            this.secretbutton.Name = "secretbutton";
            this.secretbutton.Size = new System.Drawing.Size(48, 44);
            this.secretbutton.TabIndex = 3;
            this.secretbutton.Text = " ";
            this.secretbutton.UseVisualStyleBackColor = false;
            this.secretbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secretbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.countdownlabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label countdownlabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button secretbutton;
    }
}

