namespace Bilgi_yarismasi
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldogrusayisi = new System.Windows.Forms.Label();
            this.lblyanlissayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcevap = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 151);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(32, 278);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(143, 39);
            this.btnA.TabIndex = 1;
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(246, 278);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(125, 39);
            this.btnB.TabIndex = 2;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(32, 377);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(143, 43);
            this.btnC.TabIndex = 3;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(246, 377);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(125, 43);
            this.btnD.TabIndex = 4;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doğru sayısı:";
            // 
            // lbldogrusayisi
            // 
            this.lbldogrusayisi.AutoSize = true;
            this.lbldogrusayisi.Location = new System.Drawing.Point(161, 455);
            this.lbldogrusayisi.Name = "lbldogrusayisi";
            this.lbldogrusayisi.Size = new System.Drawing.Size(20, 23);
            this.lbldogrusayisi.TabIndex = 6;
            this.lbldogrusayisi.Text = "0";
            // 
            // lblyanlissayisi
            // 
            this.lblyanlissayisi.AutoSize = true;
            this.lblyanlissayisi.Location = new System.Drawing.Point(161, 500);
            this.lblyanlissayisi.Name = "lblyanlissayisi";
            this.lblyanlissayisi.Size = new System.Drawing.Size(20, 23);
            this.lblyanlissayisi.TabIndex = 8;
            this.lblyanlissayisi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yanlış Sayısı:";
            // 
            // btnsonraki
            // 
            this.btnsonraki.Location = new System.Drawing.Point(460, 130);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(125, 43);
            this.btnsonraki.TabIndex = 9;
            this.btnsonraki.Text = "Sonraki Soru";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Location = new System.Drawing.Point(134, 32);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(0, 23);
            this.lblsoruno.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soru No:";
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Location = new System.Drawing.Point(416, 602);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(60, 23);
            this.lblcevap.TabIndex = 13;
            this.lblcevap.Text = "label3";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Location = new System.Drawing.Point(416, 551);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(60, 23);
            this.lbldogru.TabIndex = 12;
            this.lbldogru.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 529);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.lblyanlissayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldogrusayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldogrusayisi;
        private System.Windows.Forms.Label lblyanlissayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcevap;
        private System.Windows.Forms.Label lbldogru;
    }
}

