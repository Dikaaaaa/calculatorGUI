namespace calculatorGUI
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
            this.textDisplay1 = new System.Windows.Forms.TextBox();
            this.textDisplay2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnHasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDisplay1
            // 
            this.textDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.textDisplay1.Location = new System.Drawing.Point(37, 27);
            this.textDisplay1.Multiline = true;
            this.textDisplay1.Name = "textDisplay1";
            this.textDisplay1.Size = new System.Drawing.Size(618, 59);
            this.textDisplay1.TabIndex = 0;
            this.textDisplay1.Text = "0";
            this.textDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisplay1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textDisplay2
            // 
            this.textDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textDisplay2.Location = new System.Drawing.Point(37, 27);
            this.textDisplay2.Multiline = true;
            this.textDisplay2.Name = "textDisplay2";
            this.textDisplay2.Size = new System.Drawing.Size(56, 33);
            this.textDisplay2.TabIndex = 1;
            this.textDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(37, 104);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(128, 50);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(171, 104);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(128, 50);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(305, 104);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(128, 50);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(37, 160);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(128, 50);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(171, 160);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(128, 50);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(305, 160);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(128, 50);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(37, 216);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(128, 50);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(171, 216);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(128, 50);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(305, 216);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(128, 50);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(37, 272);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(262, 50);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(439, 216);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(125, 50);
            this.btnKali.TabIndex = 12;
            this.btnKali.Text = "x";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(305, 272);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(128, 50);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(439, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(216, 50);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(439, 160);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(125, 50);
            this.btnBagi.TabIndex = 15;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(439, 272);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(125, 50);
            this.btnKurang.TabIndex = 16;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnHasil
            // 
            this.btnHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHasil.Location = new System.Drawing.Point(570, 160);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(85, 162);
            this.btnHasil.TabIndex = 17;
            this.btnHasil.Text = "=";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textDisplay2);
            this.Controls.Add(this.textDisplay1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDisplay1;
        private System.Windows.Forms.TextBox textDisplay2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnHasil;
    }
}

