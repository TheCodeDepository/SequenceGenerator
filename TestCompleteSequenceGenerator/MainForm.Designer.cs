namespace TestCompleteSequenceGenerator
{
    partial class MainForm
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
            this.StringTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IcrementAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PathTb = new System.Windows.Forms.TextBox();
            this.PathBtn = new System.Windows.Forms.Button();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.Replacetb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IcrementAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // StringTb
            // 
            this.StringTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StringTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StringTb.Location = new System.Drawing.Point(12, 28);
            this.StringTb.Multiline = true;
            this.StringTb.Name = "StringTb";
            this.StringTb.Size = new System.Drawing.Size(460, 75);
            this.StringTb.TabIndex = 1;
            this.StringTb.TextChanged += new System.EventHandler(this.StringTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "String:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Increments";
            // 
            // IcrementAmount
            // 
            this.IcrementAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IcrementAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IcrementAmount.Location = new System.Drawing.Point(12, 134);
            this.IcrementAmount.Name = "IcrementAmount";
            this.IcrementAmount.Size = new System.Drawing.Size(100, 23);
            this.IcrementAmount.TabIndex = 6;
            this.IcrementAmount.ValueChanged += new System.EventHandler(this.IcrementAmount_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Path";
            // 
            // PathTb
            // 
            this.PathTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PathTb.Location = new System.Drawing.Point(12, 185);
            this.PathTb.Name = "PathTb";
            this.PathTb.ReadOnly = true;
            this.PathTb.Size = new System.Drawing.Size(419, 20);
            this.PathTb.TabIndex = 8;
            this.PathTb.TextChanged += new System.EventHandler(this.PathTb_TextChanged);
            // 
            // PathBtn
            // 
            this.PathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PathBtn.Location = new System.Drawing.Point(437, 185);
            this.PathBtn.Name = "PathBtn";
            this.PathBtn.Size = new System.Drawing.Size(35, 20);
            this.PathBtn.TabIndex = 9;
            this.PathBtn.Text = "...";
            this.PathBtn.UseVisualStyleBackColor = true;
            this.PathBtn.Click += new System.EventHandler(this.PathBtn_Click);
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessBtn.Location = new System.Drawing.Point(12, 222);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 10;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // Replacetb
            // 
            this.Replacetb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Replacetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Replacetb.Location = new System.Drawing.Point(157, 134);
            this.Replacetb.Name = "Replacetb";
            this.Replacetb.Size = new System.Drawing.Size(100, 23);
            this.Replacetb.TabIndex = 11;
            this.Replacetb.Text = "{i}";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Replacement Code";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Replacetb);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.PathBtn);
            this.Controls.Add(this.PathTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IcrementAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StringTb);
            this.Name = "MainForm";
            this.Text = "Sequence Generator";
            ((System.ComponentModel.ISupportInitialize)(this.IcrementAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IcrementAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PathTb;
        private System.Windows.Forms.Button PathBtn;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.TextBox Replacetb;
        private System.Windows.Forms.Label label4;
    }
}

