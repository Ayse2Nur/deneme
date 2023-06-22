
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.txt_accu = new System.Windows.Forms.TextBox();
            this.mytextBox1 = new Calculator.MytextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(256, 306);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(37, 23);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(212, 277);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(37, 23);
            this.four.TabIndex = 2;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(299, 306);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(37, 23);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(256, 277);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(37, 23);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(299, 277);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(37, 23);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(212, 248);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(37, 23);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(256, 248);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(37, 23);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(298, 248);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(37, 23);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(256, 335);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(37, 36);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(212, 219);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(37, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(342, 306);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(37, 23);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(342, 335);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(37, 36);
            this.result.TabIndex = 12;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(342, 277);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(37, 23);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(342, 248);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(37, 23);
            this.multiplication.TabIndex = 14;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(342, 219);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(37, 23);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // txt_accu
            // 
            this.txt_accu.Location = new System.Drawing.Point(212, 181);
            this.txt_accu.Name = "txt_accu";
            this.txt_accu.Size = new System.Drawing.Size(167, 22);
            this.txt_accu.TabIndex = 16;
            // 
            // mytextBox1
            // 
            this.mytextBox1.ForeColor = System.Drawing.Color.Green;
            this.mytextBox1.Location = new System.Drawing.Point(499, 180);
            this.mytextBox1.Name = "mytextBox1";
            this.mytextBox1.Size = new System.Drawing.Size(144, 22);
            this.mytextBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 670);
            this.Controls.Add(this.mytextBox1);
            this.Controls.Add(this.txt_accu);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.two);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button divide;
        public System.Windows.Forms.TextBox txt_accu;
        private MytextBox mytextBox1;
    }
}

