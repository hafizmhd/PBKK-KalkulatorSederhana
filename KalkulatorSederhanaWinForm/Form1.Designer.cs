namespace KalkulatorSederhanaWinForm
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
            this.nilai1Text = new System.Windows.Forms.TextBox();
            this.nilai2Text = new System.Windows.Forms.TextBox();
            this.hasilText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nilai1Text
            // 
            this.nilai1Text.Location = new System.Drawing.Point(131, 44);
            this.nilai1Text.Name = "nilai1Text";
            this.nilai1Text.Size = new System.Drawing.Size(167, 20);
            this.nilai1Text.TabIndex = 0;
            // 
            // nilai2Text
            // 
            this.nilai2Text.Location = new System.Drawing.Point(131, 84);
            this.nilai2Text.Name = "nilai2Text";
            this.nilai2Text.Size = new System.Drawing.Size(167, 20);
            this.nilai2Text.TabIndex = 1;
            // 
            // hasilText
            // 
            this.hasilText.Location = new System.Drawing.Point(131, 122);
            this.hasilText.Name = "hasilText";
            this.hasilText.Size = new System.Drawing.Size(167, 20);
            this.hasilText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nilai 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nilai 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasil";
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(36, 185);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(89, 38);
            this.plusButton.TabIndex = 6;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minButton
            // 
            this.minButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.Location = new System.Drawing.Point(36, 229);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(89, 38);
            this.minButton.TabIndex = 7;
            this.minButton.Text = "-";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(131, 185);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(89, 38);
            this.multiplicationButton.TabIndex = 8;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // divButton
            // 
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divButton.Location = new System.Drawing.Point(131, 229);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(89, 38);
            this.divButton.TabIndex = 9;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(226, 185);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 82);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 332);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasilText);
            this.Controls.Add(this.nilai2Text);
            this.Controls.Add(this.nilai1Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nilai1Text;
        private System.Windows.Forms.TextBox nilai2Text;
        private System.Windows.Forms.TextBox hasilText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button clearButton;
    }
}

