namespace normalCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.divid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(18, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 24);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(18, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 24);
            this.textBox2.TabIndex = 3;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(190, 64);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(35, 18);
            this.plus.TabIndex = 4;
            this.plus.Text = "plus";
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(190, 100);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(48, 18);
            this.minus.TabIndex = 5;
            this.minus.Text = "minus";
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(190, 138);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(57, 18);
            this.multiply.TabIndex = 6;
            this.multiply.Text = "multiply";
            // 
            // divid
            // 
            this.divid.AutoSize = true;
            this.divid.Location = new System.Drawing.Point(190, 174);
            this.divid.Name = "divid";
            this.divid.Size = new System.Drawing.Size(37, 18);
            this.divid.TabIndex = 7;
            this.divid.Text = "divid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divid);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.Label divid;
        private System.Windows.Forms.Button button1;
    }
}

