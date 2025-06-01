namespace ExamenModulo2
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
            panel1 = new Panel();
            panel5 = new Panel();
            buttonExit = new Button();
            buttonReset = new Button();
            buttonNewGame = new Button();
            panel4 = new Panel();
            labelPlayerX = new TextBox();
            labelPlayerO = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 411);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(buttonExit);
            panel5.Controls.Add(buttonReset);
            panel5.Controls.Add(buttonNewGame);
            panel5.Location = new Point(475, 221);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 158);
            panel5.TabIndex = 7;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(150, 83);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(129, 59);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += Exit_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(13, 83);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(129, 59);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += Reset_Click;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(13, 18);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(266, 59);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += NewGame_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(labelPlayerX);
            panel4.Controls.Add(labelPlayerO);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(475, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 162);
            panel4.TabIndex = 6;
            // 
            // labelPlayerX
            // 
            labelPlayerX.Location = new Point(141, 34);
            labelPlayerX.Name = "labelPlayerX";
            labelPlayerX.ReadOnly = true;
            labelPlayerX.Size = new Size(127, 27);
            labelPlayerX.TabIndex = 3;
            labelPlayerX.Text = "0";
            labelPlayerX.TextChanged += labelPlayerX_TextChanged_1;
            // 
            // labelPlayerO
            // 
            labelPlayerO.Location = new Point(141, 94);
            labelPlayerO.Name = "labelPlayerO";
            labelPlayerO.ReadOnly = true;
            labelPlayerO.Size = new Size(127, 27);
            labelPlayerO.TabIndex = 2;
            labelPlayerO.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 35);
            label1.TabIndex = 0;
            label1.Text = "Player X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 1;
            label2.Text = "Player O";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(26, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 346);
            panel3.TabIndex = 5;
            // 
            // button7
            // 
            button7.Location = new Point(24, 234);
            button7.Name = "button7";
            button7.Size = new Size(108, 85);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(148, 234);
            button8.Name = "button8";
            button8.Size = new Size(108, 85);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(274, 234);
            button9.Name = "button9";
            button9.Size = new Size(108, 85);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 130);
            button4.Name = "button4";
            button4.Size = new Size(108, 85);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(148, 130);
            button5.Name = "button5";
            button5.Size = new Size(108, 85);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(274, 130);
            button6.Name = "button6";
            button6.Size = new Size(108, 85);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 27);
            button2.Name = "button2";
            button2.Size = new Size(108, 85);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 27);
            button1.Name = "button1";
            button1.Size = new Size(108, 85);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(274, 27);
            button3.Name = "button3";
            button3.Size = new Size(108, 85);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 89);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(41, 16);
            label3.Name = "label3";
            label3.Size = new Size(728, 50);
            label3.TabIndex = 1;
            label3.Text = "JUEGO TIC TAC TOC - WINDOWS FORMS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(825, 544);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttonNewGame;
        private TextBox labelPlayerX;
        private TextBox labelPlayerO;
    }
}
