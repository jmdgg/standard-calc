namespace StandardCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSqrt = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnMult = new Button();
            btnMod = new Button();
            btnSqr = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSgnChg = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEq = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDel = new Button();
            btnClr = new Button();
            btnDiv = new Button();
            disp = new TextBox();
            boxHis = new ListBox();
            btnHide = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnSqrt, 3, 2);
            tableLayoutPanel1.Controls.Add(btn3, 2, 2);
            tableLayoutPanel1.Controls.Add(btn2, 1, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 0);
            tableLayoutPanel1.Controls.Add(btn8, 1, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSub, 4, 1);
            tableLayoutPanel1.Controls.Add(btnAdd, 4, 2);
            tableLayoutPanel1.Controls.Add(btnMult, 4, 0);
            tableLayoutPanel1.Controls.Add(btnMod, 3, 0);
            tableLayoutPanel1.Controls.Add(btnSqr, 3, 1);
            tableLayoutPanel1.Location = new Point(12, 238);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Size = new Size(446, 284);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.AliceBlue;
            btnSqrt.FlatAppearance.BorderSize = 0;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSqrt.ForeColor = SystemColors.ActiveCaptionText;
            btnSqrt.Location = new Point(270, 195);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(83, 86);
            btnSqrt.TabIndex = 15;
            btnSqrt.Text = "√𝑥";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.AliceBlue;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(181, 195);
            btn3.Name = "btn3";
            btn3.Size = new Size(83, 86);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.AliceBlue;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(92, 195);
            btn2.Name = "btn2";
            btn2.Size = new Size(83, 86);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.AliceBlue;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(3, 195);
            btn1.Name = "btn1";
            btn1.Size = new Size(83, 86);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.AliceBlue;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(181, 99);
            btn6.Name = "btn6";
            btn6.Size = new Size(83, 90);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.AliceBlue;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(92, 99);
            btn5.Name = "btn5";
            btn5.Size = new Size(83, 90);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.AliceBlue;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(3, 99);
            btn4.Name = "btn4";
            btn4.Size = new Size(83, 90);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.AliceBlue;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(181, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(83, 90);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.AliceBlue;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(92, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(83, 90);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.AliceBlue;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(3, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(83, 90);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.AliceBlue;
            btnSub.FlatAppearance.BorderSize = 0;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSub.ForeColor = SystemColors.ActiveCaptionText;
            btnSub.Location = new Point(359, 99);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(84, 90);
            btnSub.TabIndex = 9;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.AliceBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(359, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 86);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.AliceBlue;
            btnMult.FlatAppearance.BorderSize = 0;
            btnMult.FlatStyle = FlatStyle.Flat;
            btnMult.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMult.ForeColor = SystemColors.ActiveCaptionText;
            btnMult.Location = new Point(359, 3);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(84, 90);
            btnMult.TabIndex = 5;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.AliceBlue;
            btnMod.FlatAppearance.BorderSize = 0;
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMod.ForeColor = SystemColors.ActiveCaptionText;
            btnMod.Location = new Point(270, 3);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(83, 90);
            btnMod.TabIndex = 5;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click;
            // 
            // btnSqr
            // 
            btnSqr.BackColor = Color.AliceBlue;
            btnSqr.FlatAppearance.BorderSize = 0;
            btnSqr.FlatStyle = FlatStyle.Flat;
            btnSqr.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSqr.ForeColor = SystemColors.ActiveCaptionText;
            btnSqr.Location = new Point(270, 99);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(83, 90);
            btnSqr.TabIndex = 14;
            btnSqr.Text = "𝑥²";
            btnSqr.UseVisualStyleBackColor = false;
            btnSqr.Click += btnSqr_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Silver;
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnSgnChg, 2, 0);
            tableLayoutPanel2.Controls.Add(btn0, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDot, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEq, 3, 0);
            tableLayoutPanel2.Location = new Point(12, 528);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(446, 86);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // btnSgnChg
            // 
            btnSgnChg.BackColor = Color.AliceBlue;
            btnSgnChg.FlatAppearance.BorderSize = 0;
            btnSgnChg.FlatStyle = FlatStyle.Flat;
            btnSgnChg.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSgnChg.ForeColor = SystemColors.ActiveCaptionText;
            btnSgnChg.Location = new Point(225, 3);
            btnSgnChg.Name = "btnSgnChg";
            btnSgnChg.Size = new Size(105, 80);
            btnSgnChg.TabIndex = 3;
            btnSgnChg.Text = "+/-";
            btnSgnChg.UseVisualStyleBackColor = false;
            btnSgnChg.Click += btnSgnChg_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.AliceBlue;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ActiveCaptionText;
            btn0.Location = new Point(114, 3);
            btn0.Name = "btn0";
            btn0.Size = new Size(105, 80);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.AliceBlue;
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.ForeColor = SystemColors.ActiveCaptionText;
            btnDot.Location = new Point(3, 3);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(105, 80);
            btnDot.TabIndex = 1;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnEq
            // 
            btnEq.BackColor = Color.AliceBlue;
            btnEq.FlatAppearance.BorderSize = 0;
            btnEq.FlatStyle = FlatStyle.Flat;
            btnEq.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEq.ForeColor = SystemColors.ActiveCaptionText;
            btnEq.Location = new Point(336, 3);
            btnEq.Name = "btnEq";
            btnEq.Size = new Size(107, 80);
            btnEq.TabIndex = 2;
            btnEq.Text = "=";
            btnEq.UseVisualStyleBackColor = false;
            btnEq.Click += btnEq_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Silver;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnDel, 1, 0);
            tableLayoutPanel3.Controls.Add(btnClr, 0, 0);
            tableLayoutPanel3.Controls.Add(btnDiv, 2, 0);
            tableLayoutPanel3.Location = new Point(12, 152);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(446, 80);
            tableLayoutPanel3.TabIndex = 2;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.AliceBlue;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ActiveCaptionText;
            btnDel.Location = new Point(151, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(142, 74);
            btnDel.TabIndex = 3;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnClr
            // 
            btnClr.BackColor = Color.AliceBlue;
            btnClr.FlatAppearance.BorderSize = 0;
            btnClr.FlatStyle = FlatStyle.Flat;
            btnClr.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClr.ForeColor = SystemColors.ActiveCaptionText;
            btnClr.Location = new Point(3, 3);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(142, 74);
            btnClr.TabIndex = 2;
            btnClr.Text = "AC";
            btnClr.UseVisualStyleBackColor = false;
            btnClr.Click += btnClr_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.AliceBlue;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.ForeColor = SystemColors.ActiveCaptionText;
            btnDiv.Location = new Point(299, 3);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(144, 74);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // disp
            // 
            disp.Enabled = false;
            disp.Font = new Font("Seven Segment", 64F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disp.Location = new Point(12, 39);
            disp.MaxLength = 15;
            disp.Name = "disp";
            disp.Size = new Size(448, 96);
            disp.TabIndex = 3;
            // 
            // boxHis
            // 
            boxHis.Font = new Font("Seven Segment", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxHis.FormattingEnabled = true;
            boxHis.ItemHeight = 34;
            boxHis.Location = new Point(476, 41);
            boxHis.Name = "boxHis";
            boxHis.Size = new Size(302, 548);
            boxHis.TabIndex = 4;
            boxHis.SelectedIndexChanged += boxHis_SelectedIndexChanged;
            // 
            // btnHide
            // 
            btnHide.ForeColor = SystemColors.ActiveCaptionText;
            btnHide.Location = new Point(385, 10);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(75, 23);
            btnHide.TabIndex = 5;
            btnHide.Text = "btnHide";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(795, 626);
            Controls.Add(btnHide);
            Controls.Add(boxHis);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(disp);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calkubeta";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn0;
        private TextBox disp;
        private Button btnDot;
        private Button btnEq;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMult;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDel;
        private Button btnClr;
        private Button btnSgnChg;
        private Button btnMod;
        private Button btnDiv;
        private Button btnSqr;
        private Button btnSqrt;
        private ListBox boxHis;
        private Button btnHide;
    }
}
