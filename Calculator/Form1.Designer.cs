
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtbx1 = new System.Windows.Forms.TextBox();
            this.txtbx3 = new System.Windows.Forms.TextBox();
            this.txtbx4 = new System.Windows.Forms.TextBox();
            this.txtbx5 = new System.Windows.Forms.TextBox();
            this.txtbx2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx8 = new System.Windows.Forms.TextBox();
            this.txtbx7 = new System.Windows.Forms.TextBox();
            this.txtbx6 = new System.Windows.Forms.TextBox();
            this.tbpo1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbpo3 = new System.Windows.Forms.TextBox();
            this.tbs3 = new System.Windows.Forms.TextBox();
            this.tbpo2 = new System.Windows.Forms.TextBox();
            this.tbs2 = new System.Windows.Forms.TextBox();
            this.tbs1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(49, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Сумма займа в рублях:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(69, 94);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(105, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Срок займа в днях:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Общая сумма выплаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Эффективная ставка ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сумма процентов";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(311, 168);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Посчитать";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtbx1
            // 
            this.txtbx1.Location = new System.Drawing.Point(206, 46);
            this.txtbx1.Name = "txtbx1";
            this.txtbx1.Size = new System.Drawing.Size(100, 20);
            this.txtbx1.TabIndex = 11;
            this.txtbx1.TextChanged += new System.EventHandler(this.txtbx1_TextChanged);
            this.txtbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx1_KeyPress);
            // 
            // txtbx3
            // 
            this.txtbx3.Location = new System.Drawing.Point(206, 209);
            this.txtbx3.Name = "txtbx3";
            this.txtbx3.Size = new System.Drawing.Size(100, 20);
            this.txtbx3.TabIndex = 12;
            this.txtbx3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx3_KeyPress);
            // 
            // txtbx4
            // 
            this.txtbx4.Location = new System.Drawing.Point(206, 256);
            this.txtbx4.Name = "txtbx4";
            this.txtbx4.Size = new System.Drawing.Size(100, 20);
            this.txtbx4.TabIndex = 13;
            this.txtbx4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx4_KeyPress);
            // 
            // txtbx5
            // 
            this.txtbx5.Location = new System.Drawing.Point(206, 313);
            this.txtbx5.Name = "txtbx5";
            this.txtbx5.Size = new System.Drawing.Size(100, 20);
            this.txtbx5.TabIndex = 14;
            this.txtbx5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx5_KeyPress);
            // 
            // txtbx2
            // 
            this.txtbx2.Location = new System.Drawing.Point(206, 91);
            this.txtbx2.Name = "txtbx2";
            this.txtbx2.Size = new System.Drawing.Size(100, 20);
            this.txtbx2.TabIndex = 15;
            this.txtbx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Процентная ставка с          по             день";
            // 
            // txtbx8
            // 
            this.txtbx8.Location = new System.Drawing.Point(560, 118);
            this.txtbx8.Name = "txtbx8";
            this.txtbx8.Size = new System.Drawing.Size(100, 20);
            this.txtbx8.TabIndex = 20;
            this.txtbx8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx8_KeyPress);
            // 
            // txtbx7
            // 
            this.txtbx7.Location = new System.Drawing.Point(560, 79);
            this.txtbx7.Name = "txtbx7";
            this.txtbx7.Size = new System.Drawing.Size(100, 20);
            this.txtbx7.TabIndex = 21;
            this.txtbx7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx7_KeyPress);
            // 
            // txtbx6
            // 
            this.txtbx6.Location = new System.Drawing.Point(560, 42);
            this.txtbx6.Name = "txtbx6";
            this.txtbx6.Size = new System.Drawing.Size(100, 20);
            this.txtbx6.TabIndex = 22;
            this.txtbx6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx6_KeyPress);
            // 
            // tbpo1
            // 
            this.tbpo1.Location = new System.Drawing.Point(492, 39);
            this.tbpo1.Name = "tbpo1";
            this.tbpo1.Size = new System.Drawing.Size(23, 20);
            this.tbpo1.TabIndex = 24;
            this.tbpo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpo1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Процентная ставка с          по             день";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Процентная ставка с          по             день";
            // 
            // tbpo3
            // 
            this.tbpo3.Location = new System.Drawing.Point(492, 115);
            this.tbpo3.Name = "tbpo3";
            this.tbpo3.Size = new System.Drawing.Size(23, 20);
            this.tbpo3.TabIndex = 27;
            this.tbpo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpo3_KeyPress);
            // 
            // tbs3
            // 
            this.tbs3.Location = new System.Drawing.Point(448, 115);
            this.tbs3.Name = "tbs3";
            this.tbs3.Size = new System.Drawing.Size(23, 20);
            this.tbs3.TabIndex = 28;
            this.tbs3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbs3_KeyPress);
            // 
            // tbpo2
            // 
            this.tbpo2.Location = new System.Drawing.Point(492, 75);
            this.tbpo2.Name = "tbpo2";
            this.tbpo2.Size = new System.Drawing.Size(23, 20);
            this.tbpo2.TabIndex = 29;
            this.tbpo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpo2_KeyPress);
            // 
            // tbs2
            // 
            this.tbs2.Location = new System.Drawing.Point(448, 75);
            this.tbs2.Name = "tbs2";
            this.tbs2.Size = new System.Drawing.Size(23, 20);
            this.tbs2.TabIndex = 30;
            this.tbs2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbs2_KeyPress);
            // 
            // tbs1
            // 
            this.tbs1.Location = new System.Drawing.Point(448, 39);
            this.tbs1.Name = "tbs1";
            this.tbs1.Size = new System.Drawing.Size(23, 20);
            this.tbs1.TabIndex = 31;
            this.tbs1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbs1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.tbs1);
            this.Controls.Add(this.tbs2);
            this.Controls.Add(this.tbpo2);
            this.Controls.Add(this.tbs3);
            this.Controls.Add(this.tbpo3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbpo1);
            this.Controls.Add(this.txtbx6);
            this.Controls.Add(this.txtbx7);
            this.Controls.Add(this.txtbx8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx2);
            this.Controls.Add(this.txtbx5);
            this.Controls.Add(this.txtbx4);
            this.Controls.Add(this.txtbx3);
            this.Controls.Add(this.txtbx1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtbx1;
        private System.Windows.Forms.TextBox txtbx3;
        private System.Windows.Forms.TextBox txtbx4;
        private System.Windows.Forms.TextBox txtbx5;
        private System.Windows.Forms.TextBox txtbx2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx8;
        private System.Windows.Forms.TextBox txtbx7;
        private System.Windows.Forms.TextBox txtbx6;
        private System.Windows.Forms.TextBox tbpo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbpo3;
        private System.Windows.Forms.TextBox tbs3;
        private System.Windows.Forms.TextBox tbpo2;
        private System.Windows.Forms.TextBox tbs2;
        private System.Windows.Forms.TextBox tbs1;
    }
}

