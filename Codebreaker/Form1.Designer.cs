namespace Codebreaker
{
    partial class Form1
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
            this.current_pin = new System.Windows.Forms.Label();
            this.nextPin = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // current_pin
            // 
            this.current_pin.AutoSize = true;
            this.current_pin.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.current_pin.Location = new System.Drawing.Point(325, 80);
            this.current_pin.Name = "current_pin";
            this.current_pin.Size = new System.Drawing.Size(89, 40);
            this.current_pin.TabIndex = 0;
            this.current_pin.Text = "1111";
            // 
            // nextPin
            // 
            this.nextPin.Location = new System.Drawing.Point(325, 146);
            this.nextPin.Name = "nextPin";
            this.nextPin.Size = new System.Drawing.Size(126, 49);
            this.nextPin.TabIndex = 1;
            this.nextPin.Text = "next";
            this.nextPin.UseVisualStyleBackColor = true;
            this.nextPin.Click += new System.EventHandler(this.nextPin_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(143, 444);
            this.listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.nextPin);
            this.Controls.Add(this.current_pin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label current_pin;
        private Button nextPin;
        private ListBox listBox;
    }
}