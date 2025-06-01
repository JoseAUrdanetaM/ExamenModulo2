namespace ExamenModulo2
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne;

        public void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public void Score()
        {
            #region Player X
            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            #endregion

            #region Player O
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player O Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerO.Text);
                labelPlayerO.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            #endregion



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled= false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true; 
            button2.Enabled = true; 
            button3.Enabled = true; 
            button4.Enabled = true; 
            button5.Enabled = true; 
            button6.Enabled = true; 
            button7.Enabled = true; 
            button8.Enabled = true; 
            button9.Enabled = true; 



        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
