
namespace Bank
{
    partial class newacc
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
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.Namen = new CustomControls.RJControls.RJTextBox();
            this.rjRadioButton1 = new CustomControls.RJControls.RJRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pin1 = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pin2 = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(77, 120);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Erstellen";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Namen
            // 
            this.Namen.BackColor = System.Drawing.SystemColors.Window;
            this.Namen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Namen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Namen.BorderRadius = 0;
            this.Namen.BorderSize = 2;
            this.Namen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Namen.Location = new System.Drawing.Point(77, 60);
            this.Namen.Margin = new System.Windows.Forms.Padding(4);
            this.Namen.Multiline = false;
            this.Namen.Name = "Namen";
            this.Namen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Namen.PasswordChar = false;
            this.Namen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Namen.PlaceholderText = "";
            this.Namen.Size = new System.Drawing.Size(250, 31);
            this.Namen.TabIndex = 1;
            this.Namen.Texts = "";
            this.Namen.UnderlinedStyle = false;
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.AutoSize = true;
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton1.Location = new System.Drawing.Point(335, 167);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(107, 21);
            this.rjRadioButton1.TabIndex = 2;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.Text = "Pins anzeigen?";
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            this.rjRadioButton1.CheckedChanged += new System.EventHandler(this.rjRadioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PIN:";
            // 
            // pin1
            // 
            this.pin1.BackColor = System.Drawing.SystemColors.Window;
            this.pin1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pin1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pin1.BorderRadius = 0;
            this.pin1.BorderSize = 2;
            this.pin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pin1.Location = new System.Drawing.Point(335, 60);
            this.pin1.Margin = new System.Windows.Forms.Padding(4);
            this.pin1.Multiline = false;
            this.pin1.Name = "pin1";
            this.pin1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pin1.PasswordChar = true;
            this.pin1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pin1.PlaceholderText = "";
            this.pin1.Size = new System.Drawing.Size(250, 31);
            this.pin1.TabIndex = 4;
            this.pin1.Texts = "";
            this.pin1.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "PIN bestätigen:";
            // 
            // pin2
            // 
            this.pin2.BackColor = System.Drawing.SystemColors.Window;
            this.pin2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pin2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.pin2.BorderRadius = 0;
            this.pin2.BorderSize = 2;
            this.pin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pin2.Location = new System.Drawing.Point(335, 120);
            this.pin2.Margin = new System.Windows.Forms.Padding(4);
            this.pin2.Multiline = false;
            this.pin2.Name = "pin2";
            this.pin2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pin2.PasswordChar = true;
            this.pin2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pin2.PlaceholderText = "";
            this.pin2.Size = new System.Drawing.Size(250, 31);
            this.pin2.TabIndex = 6;
            this.pin2.Texts = "";
            this.pin2.UnderlinedStyle = false;
            // 
            // newacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pin2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjRadioButton1);
            this.Controls.Add(this.Namen);
            this.Controls.Add(this.rjButton1);
            this.Name = "newacc";
            this.Text = "newacc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox Namen;
        private CustomControls.RJControls.RJRadioButton rjRadioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox pin1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox pin2;
    }
}