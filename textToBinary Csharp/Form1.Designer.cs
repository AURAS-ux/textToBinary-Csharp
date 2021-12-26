namespace textToBinary_Csharp
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
            this.Title = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResLab = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(276, 46);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(198, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Text to Binary";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(147, 175);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(207, 22);
            this.InputText.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(150, 294);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 16);
            this.Result.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get the text in binary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResLab
            // 
            this.ResLab.AutoSize = true;
            this.ResLab.Location = new System.Drawing.Point(53, 235);
            this.ResLab.Name = "ResLab";
            this.ResLab.Size = new System.Drawing.Size(48, 16);
            this.ResLab.TabIndex = 6;
            this.ResLab.Text = "Result:";
            this.ResLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(153, 235);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(500, 96);
            this.ResultBox.TabIndex = 7;
            this.ResultBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ResLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Desktop App C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResLab;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.Button button2;
    }
}

