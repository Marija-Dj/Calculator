using System;

namespace Zadaca18
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonMi = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonDELL = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonPiMi = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 71);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NUM);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(94, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 71);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NUM);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 71);
            this.button4.TabIndex = 17;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NUM);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(94, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 71);
            this.button5.TabIndex = 16;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NUM);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(94, 199);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 71);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NUM);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(176, 199);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 71);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NUM);
            // 
            // buttonP
            // 
            this.buttonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonP.Location = new System.Drawing.Point(258, 353);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(76, 71);
            this.buttonP.TabIndex = 13;
            this.buttonP.Text = "+";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.Operation);
            // 
            // buttonMi
            // 
            this.buttonMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMi.Location = new System.Drawing.Point(258, 276);
            this.buttonMi.Name = "buttonMi";
            this.buttonMi.Size = new System.Drawing.Size(76, 71);
            this.buttonMi.TabIndex = 12;
            this.buttonMi.Text = "-";
            this.buttonMi.UseVisualStyleBackColor = true;
            this.buttonMi.Click += new System.EventHandler(this.Operation);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(176, 353);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(76, 71);
            this.button19.TabIndex = 11;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.NUM);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(176, 276);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 71);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NUM);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(94, 430);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 71);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NUM);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.Location = new System.Drawing.Point(94, 122);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(76, 71);
            this.buttonC.TabIndex = 8;
            this.buttonC.Text = "C\r\n";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZ.Location = new System.Drawing.Point(12, 430);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(76, 71);
            this.buttonZ.TabIndex = 7;
            this.buttonZ.Text = ".";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.NUM);
            // 
            // buttonDELL
            // 
            this.buttonDELL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDELL.Location = new System.Drawing.Point(176, 122);
            this.buttonDELL.Name = "buttonDELL";
            this.buttonDELL.Size = new System.Drawing.Size(76, 71);
            this.buttonDELL.TabIndex = 6;
            this.buttonDELL.Text = "DEL\r\n";
            this.buttonDELL.UseVisualStyleBackColor = true;
            this.buttonDELL.Click += new System.EventHandler(this.ButtonDELL_Click);
            // 
            // buttonE
            // 
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonE.Location = new System.Drawing.Point(258, 430);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(76, 71);
            this.buttonE.TabIndex = 5;
            this.buttonE.Text = "=";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.ButtonE_Click);
            // 
            // buttonM
            // 
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonM.Location = new System.Drawing.Point(258, 199);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(76, 71);
            this.buttonM.TabIndex = 4;
            this.buttonM.Text = "*";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.Operation);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonD.Location = new System.Drawing.Point(258, 122);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(76, 71);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "/";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.Operation);
            // 
            // buttonPiMi
            // 
            this.buttonPiMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPiMi.Location = new System.Drawing.Point(176, 430);
            this.buttonPiMi.Name = "buttonPiMi";
            this.buttonPiMi.Size = new System.Drawing.Size(76, 71);
            this.buttonPiMi.TabIndex = 2;
            this.buttonPiMi.Text = "+/-";
            this.buttonPiMi.UseVisualStyleBackColor = true;
            this.buttonPiMi.Click += new System.EventHandler(this.ButtonPiMi_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 71);
            this.button7.TabIndex = 19;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NUM);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCE.Location = new System.Drawing.Point(12, 122);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(76, 71);
            this.buttonCE.TabIndex = 20;
            this.buttonCE.Text = "CE\r\n";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonMi);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonDELL);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonPiMi);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonMi;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonDELL;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonPiMi;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonCE;
    }
}

