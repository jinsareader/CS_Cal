namespace Chap06_04
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
            display = new Label();
            buttonResult = new Button();
            panel1 = new TableLayoutPanel();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonDivide = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonMultiply = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonMinus = new Button();
            button13 = new Button();
            buttonZero = new Button();
            buttonDot = new Button();
            buttonPlus = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(598, 44);
            display.TabIndex = 0;
            display.Text = "0";
            display.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonResult
            // 
            buttonResult.Dock = DockStyle.Bottom;
            buttonResult.Font = new Font("맑은 고딕", 20F);
            buttonResult.Location = new Point(0, 440);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(598, 51);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.ColumnCount = 4;
            panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panel1.Controls.Add(buttonSeven, 0, 0);
            panel1.Controls.Add(buttonEight, 1, 0);
            panel1.Controls.Add(buttonNine, 2, 0);
            panel1.Controls.Add(buttonDivide, 3, 0);
            panel1.Controls.Add(buttonFour, 0, 1);
            panel1.Controls.Add(buttonFive, 1, 1);
            panel1.Controls.Add(buttonSix, 2, 1);
            panel1.Controls.Add(buttonMultiply, 3, 1);
            panel1.Controls.Add(buttonOne, 0, 2);
            panel1.Controls.Add(buttonTwo, 1, 2);
            panel1.Controls.Add(buttonThree, 2, 2);
            panel1.Controls.Add(buttonMinus, 3, 2);
            panel1.Controls.Add(button13, 0, 3);
            panel1.Controls.Add(buttonZero, 1, 3);
            panel1.Controls.Add(buttonDot, 2, 3);
            panel1.Controls.Add(buttonPlus, 3, 3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.RowCount = 4;
            panel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panel1.Size = new Size(598, 396);
            panel1.TabIndex = 3;
            // 
            // buttonSeven
            // 
            buttonSeven.Dock = DockStyle.Fill;
            buttonSeven.Font = new Font("맑은 고딕", 20F);
            buttonSeven.Location = new Point(3, 3);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(143, 93);
            buttonSeven.TabIndex = 0;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonOne_Click;
            // 
            // buttonEight
            // 
            buttonEight.Dock = DockStyle.Fill;
            buttonEight.Font = new Font("맑은 고딕", 20F);
            buttonEight.Location = new Point(152, 3);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(143, 93);
            buttonEight.TabIndex = 1;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonOne_Click;
            // 
            // buttonNine
            // 
            buttonNine.Dock = DockStyle.Fill;
            buttonNine.Font = new Font("맑은 고딕", 20F);
            buttonNine.Location = new Point(301, 3);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(143, 93);
            buttonNine.TabIndex = 2;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonOne_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.Font = new Font("맑은 고딕", 20F);
            buttonDivide.Location = new Point(450, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(145, 93);
            buttonDivide.TabIndex = 3;
            buttonDivide.Text = " / ";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonPlus_Click;
            // 
            // buttonFour
            // 
            buttonFour.Dock = DockStyle.Fill;
            buttonFour.Font = new Font("맑은 고딕", 20F);
            buttonFour.Location = new Point(3, 102);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(143, 93);
            buttonFour.TabIndex = 4;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonOne_Click;
            // 
            // buttonFive
            // 
            buttonFive.Dock = DockStyle.Fill;
            buttonFive.Font = new Font("맑은 고딕", 20F);
            buttonFive.Location = new Point(152, 102);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(143, 93);
            buttonFive.TabIndex = 5;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonOne_Click;
            // 
            // buttonSix
            // 
            buttonSix.Dock = DockStyle.Fill;
            buttonSix.Font = new Font("맑은 고딕", 20F);
            buttonSix.Location = new Point(301, 102);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(143, 93);
            buttonSix.TabIndex = 6;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonOne_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.Font = new Font("맑은 고딕", 20F);
            buttonMultiply.Location = new Point(450, 102);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(145, 93);
            buttonMultiply.TabIndex = 7;
            buttonMultiply.Text = " * ";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonPlus_Click;
            // 
            // buttonOne
            // 
            buttonOne.Dock = DockStyle.Fill;
            buttonOne.Font = new Font("맑은 고딕", 20F);
            buttonOne.Location = new Point(3, 201);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(143, 93);
            buttonOne.TabIndex = 8;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Dock = DockStyle.Fill;
            buttonTwo.Font = new Font("맑은 고딕", 20F);
            buttonTwo.Location = new Point(152, 201);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(143, 93);
            buttonTwo.TabIndex = 9;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonOne_Click;
            // 
            // buttonThree
            // 
            buttonThree.Dock = DockStyle.Fill;
            buttonThree.Font = new Font("맑은 고딕", 20F);
            buttonThree.Location = new Point(301, 201);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(143, 93);
            buttonThree.TabIndex = 10;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonOne_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.Font = new Font("맑은 고딕", 20F);
            buttonMinus.Location = new Point(450, 201);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(145, 93);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = " - ";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonPlus_Click;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Font = new Font("맑은 고딕", 20F);
            button13.Location = new Point(3, 300);
            button13.Name = "button13";
            button13.Size = new Size(143, 93);
            button13.TabIndex = 12;
            button13.Text = "AC";
            button13.UseVisualStyleBackColor = true;
            // 
            // buttonZero
            // 
            buttonZero.Dock = DockStyle.Fill;
            buttonZero.Font = new Font("맑은 고딕", 20F);
            buttonZero.Location = new Point(152, 300);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(143, 93);
            buttonZero.TabIndex = 13;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonOne_Click;
            // 
            // buttonDot
            // 
            buttonDot.Dock = DockStyle.Fill;
            buttonDot.Font = new Font("맑은 고딕", 20F);
            buttonDot.Location = new Point(301, 300);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(143, 93);
            buttonDot.TabIndex = 14;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Dock = DockStyle.Fill;
            buttonPlus.Font = new Font("맑은 고딕", 20F);
            buttonPlus.Location = new Point(450, 300);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(145, 93);
            buttonPlus.TabIndex = 15;
            buttonPlus.Text = " + ";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 491);
            Controls.Add(panel1);
            Controls.Add(buttonResult);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label display;
        private Button buttonResult;
        private TableLayoutPanel panel1;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonDivide;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonMultiply;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonMinus;
        private Button button13;
        private Button buttonZero;
        private Button buttonDot;
        private Button buttonPlus;
    }
}
