using System.Drawing;
using System.Runtime.Remoting.Messaging;

namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string op="";
        private double result=0;
        
        /// <summary>
        /// Nettoyage des ssources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnvirgule = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPuissance = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Orange;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn7.Location = new System.Drawing.Point(-1, 111);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 52);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Orange;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn8.Location = new System.Drawing.Point(57, 111);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 52);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Orange;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn9.Location = new System.Drawing.Point(114, 111);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 52);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDivision.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDivision.Location = new System.Drawing.Point(171, 111);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(62, 52);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btn_Operation);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.Location = new System.Drawing.Point(171, 157);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(62, 52);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btn_Operation);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Orange;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn6.Location = new System.Drawing.Point(114, 157);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 52);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Orange;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn5.Location = new System.Drawing.Point(57, 157);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 52);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Orange;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn4.Location = new System.Drawing.Point(-1, 157);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 52);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlus.Location = new System.Drawing.Point(171, 206);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 52);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btn_Operation);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Orange;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn3.Location = new System.Drawing.Point(114, 206);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 52);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Orange;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn2.Location = new System.Drawing.Point(57, 206);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 52);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Orange;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.Location = new System.Drawing.Point(-1, 206);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 52);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEqual.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEqual.Location = new System.Drawing.Point(171, 251);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(62, 52);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btn_Equal);
            // 
            // btnvirgule
            // 
            this.btnvirgule.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnvirgule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvirgule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvirgule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnvirgule.Location = new System.Drawing.Point(114, 251);
            this.btnvirgule.Name = "btnvirgule";
            this.btnvirgule.Size = new System.Drawing.Size(62, 52);
            this.btnvirgule.TabIndex = 14;
            this.btnvirgule.Text = ",";
            this.btnvirgule.UseVisualStyleBackColor = false;
            this.btnvirgule.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn0.Location = new System.Drawing.Point(57, 251);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 52);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduit.Location = new System.Drawing.Point(171, 61);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(62, 52);
            this.btnProduit.TabIndex = 12;
            this.btnProduit.Text = "x";
            this.btnProduit.UseVisualStyleBackColor = false;
            this.btnProduit.Click += new System.EventHandler(this.btn_Operation);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Info;
            this.textBox.Enabled = false;
            this.textBox.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(-1, 1);
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(234, 36);
            this.textBox.TabIndex = 16;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC.Location = new System.Drawing.Point(57, 61);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(62, 52);
            this.btnC.TabIndex = 20;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btn_C_CE);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCE.Location = new System.Drawing.Point(114, 61);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(62, 52);
            this.btnCE.TabIndex = 19;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btn_C_CE);
            // 
            // btnPuissance
            // 
            this.btnPuissance.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPuissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuissance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPuissance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPuissance.Location = new System.Drawing.Point(-1, 61);
            this.btnPuissance.Name = "btnPuissance";
            this.btnPuissance.Size = new System.Drawing.Size(62, 52);
            this.btnPuissance.TabIndex = 18;
            this.btnPuissance.Text = "^";
            this.btnPuissance.UseVisualStyleBackColor = false;
            this.btnPuissance.Click += new System.EventHandler(this.btn_Operation);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlusMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusMinus.Location = new System.Drawing.Point(-1, 251);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(62, 52);
            this.btnPlusMinus.TabIndex = 17;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btn_plus_minus);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-1, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 33);
            this.textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(235, 306);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPuissance);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnvirgule);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnProduit);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnvirgule;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPuissance;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.TextBox textBox1;
    }
}

