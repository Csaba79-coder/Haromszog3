
namespace Haromszog3
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
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLetrehoz = new System.Windows.Forms.Button();
            this.btnOldalak = new System.Windows.Forms.Button();
            this.btnEgyenloszaru = new System.Windows.Forms.Button();
            this.btnSzabalyos = new System.Windows.Forms.Button();
            this.btnKerulet = new System.Windows.Forms.Button();
            this.btnTerulet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(12, 29);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 20);
            this.tba.TabIndex = 0;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(129, 29);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 20);
            this.tbb.TabIndex = 1;
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(249, 29);
            this.tbc.Name = "tbc";
            this.tbc.Size = new System.Drawing.Size(100, 20);
            this.tbc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a oldal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b oldal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "c oldal:";
            // 
            // btnLetrehoz
            // 
            this.btnLetrehoz.Location = new System.Drawing.Point(383, 26);
            this.btnLetrehoz.Name = "btnLetrehoz";
            this.btnLetrehoz.Size = new System.Drawing.Size(195, 23);
            this.btnLetrehoz.TabIndex = 6;
            this.btnLetrehoz.Text = "Háromszög létrehozása";
            this.btnLetrehoz.UseVisualStyleBackColor = true;
            this.btnLetrehoz.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOldalak
            // 
            this.btnOldalak.Location = new System.Drawing.Point(12, 94);
            this.btnOldalak.Name = "btnOldalak";
            this.btnOldalak.Size = new System.Drawing.Size(111, 23);
            this.btnOldalak.TabIndex = 7;
            this.btnOldalak.Text = "Háromszög oldalai";
            this.btnOldalak.UseVisualStyleBackColor = true;
            this.btnOldalak.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEgyenloszaru
            // 
            this.btnEgyenloszaru.Location = new System.Drawing.Point(12, 123);
            this.btnEgyenloszaru.Name = "btnEgyenloszaru";
            this.btnEgyenloszaru.Size = new System.Drawing.Size(111, 23);
            this.btnEgyenloszaru.TabIndex = 8;
            this.btnEgyenloszaru.Text = "Egyenlőszárú";
            this.btnEgyenloszaru.UseVisualStyleBackColor = true;
            this.btnEgyenloszaru.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSzabalyos
            // 
            this.btnSzabalyos.Location = new System.Drawing.Point(12, 152);
            this.btnSzabalyos.Name = "btnSzabalyos";
            this.btnSzabalyos.Size = new System.Drawing.Size(111, 23);
            this.btnSzabalyos.TabIndex = 9;
            this.btnSzabalyos.Text = "Szabályos";
            this.btnSzabalyos.UseVisualStyleBackColor = true;
            this.btnSzabalyos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnKerulet
            // 
            this.btnKerulet.Location = new System.Drawing.Point(12, 181);
            this.btnKerulet.Name = "btnKerulet";
            this.btnKerulet.Size = new System.Drawing.Size(111, 23);
            this.btnKerulet.TabIndex = 10;
            this.btnKerulet.Text = "Kerület";
            this.btnKerulet.UseVisualStyleBackColor = true;
            this.btnKerulet.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnTerulet
            // 
            this.btnTerulet.Location = new System.Drawing.Point(12, 210);
            this.btnTerulet.Name = "btnTerulet";
            this.btnTerulet.Size = new System.Drawing.Size(111, 23);
            this.btnTerulet.TabIndex = 11;
            this.btnTerulet.Text = "Terület";
            this.btnTerulet.UseVisualStyleBackColor = true;
            this.btnTerulet.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTerulet);
            this.Controls.Add(this.btnKerulet);
            this.Controls.Add(this.btnSzabalyos);
            this.Controls.Add(this.btnEgyenloszaru);
            this.Controls.Add(this.btnOldalak);
            this.Controls.Add(this.btnLetrehoz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLetrehoz;
        private System.Windows.Forms.Button btnOldalak;
        private System.Windows.Forms.Button btnEgyenloszaru;
        private System.Windows.Forms.Button btnSzabalyos;
        private System.Windows.Forms.Button btnKerulet;
        private System.Windows.Forms.Button btnTerulet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

