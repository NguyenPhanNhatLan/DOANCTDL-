using System.Linq.Expressions;
using System.Windows.Forms;
using System;

namespace BasicCaculation
{
    partial class CaculateForm
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
            this.btnLeftParenthesis = new System.Windows.Forms.Button();
            this.btnRightParenthesis = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMutil = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btncham_thap_phan = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.thanh_hien_thi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnLeftParenthesis
            // 
            this.btnLeftParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnLeftParenthesis.Location = new System.Drawing.Point(12, 90);
            this.btnLeftParenthesis.Name = "btnLeftParenthesis";
            this.btnLeftParenthesis.Size = new System.Drawing.Size(93, 66);
            this.btnLeftParenthesis.TabIndex = 2;
            this.btnLeftParenthesis.Text = "(";
            this.btnLeftParenthesis.UseVisualStyleBackColor = true;
            this.btnLeftParenthesis.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btnRightParenthesis
            // 
            this.btnRightParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnRightParenthesis.Location = new System.Drawing.Point(111, 90);
            this.btnRightParenthesis.Name = "btnRightParenthesis";
            this.btnRightParenthesis.Size = new System.Drawing.Size(93, 66);
            this.btnRightParenthesis.TabIndex = 3;
            this.btnRightParenthesis.Text = ")";
            this.btnRightParenthesis.UseVisualStyleBackColor = true;
            this.btnRightParenthesis.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(210, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 66);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.XoaTatCa);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(309, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 66);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.XoaGiaTri);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnDiv.Location = new System.Drawing.Point(309, 162);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(93, 66);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btnMutil
            // 
            this.btnMutil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnMutil.Location = new System.Drawing.Point(309, 234);
            this.btnMutil.Name = "btnMutil";
            this.btnMutil.Size = new System.Drawing.Size(93, 73);
            this.btnMutil.TabIndex = 13;
            this.btnMutil.Text = "×";
            this.btnMutil.UseVisualStyleBackColor = true;
            this.btnMutil.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(210, 162);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 66);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(111, 162);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(93, 66);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(12, 162);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(93, 66);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSub.Location = new System.Drawing.Point(309, 313);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(93, 73);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(210, 234);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 73);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(112, 234);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 73);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(13, 234);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(93, 73);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSum.Location = new System.Drawing.Point(309, 392);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(93, 73);
            this.btnSum.TabIndex = 21;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(210, 313);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 73);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(111, 313);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 73);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(12, 313);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 73);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnEqual.Location = new System.Drawing.Point(210, 392);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(93, 73);
            this.btnEqual.TabIndex = 25;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.Bang);
            // 
            // btncham_thap_phan
            // 
            this.btncham_thap_phan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btncham_thap_phan.Location = new System.Drawing.Point(112, 392);
            this.btncham_thap_phan.Name = "btncham_thap_phan";
            this.btncham_thap_phan.Size = new System.Drawing.Size(93, 73);
            this.btncham_thap_phan.TabIndex = 24;
            this.btncham_thap_phan.Text = ".";
            this.btncham_thap_phan.UseVisualStyleBackColor = true;
            this.btncham_thap_phan.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(13, 392);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(93, 73);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NhapGiaTri);
            // 
            // thanh_hien_thi
            // 
            this.thanh_hien_thi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.thanh_hien_thi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.thanh_hien_thi.Location = new System.Drawing.Point(13, 12);
            this.thanh_hien_thi.Name = "thanh_hien_thi";
            this.thanh_hien_thi.Size = new System.Drawing.Size(389, 65);
            this.thanh_hien_thi.TabIndex = 26;
            this.thanh_hien_thi.Text = "\n0";
            this.thanh_hien_thi.TextChanged += new System.EventHandler(this.thanh_hien_thi_TextChanged);
            // 
            // CaculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 476);
            this.Controls.Add(this.thanh_hien_thi);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btncham_thap_phan);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMutil);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRightParenthesis);
            this.Controls.Add(this.btnLeftParenthesis);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CaculateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CaculateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLeftParenthesis;
        private System.Windows.Forms.Button btnRightParenthesis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMutil;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btncham_thap_phan;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.RichTextBox thanh_hien_thi;
    }
}

