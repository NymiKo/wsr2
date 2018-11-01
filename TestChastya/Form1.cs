using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestChastya
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        MySqlConnection conMy;
        BDConnection con;
        int number = 1;
        double score = 0;

        public Form1()
        {
            InitializeComponent();
            if(panelVopros.Visible == true)
            {
                con = new BDConnection("Students", "127.0.0.1", "3306", "root", "");
                con.OpenConnection();

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            panelVopros.Visible = true;
            this.Width = 843;
            this.Height = 323;
            numberQuestions();
            number++;
        }

        private void numberQuestions()
        {
            con = new BDConnection("question", "127.0.0.1", "3306", "root", "");
            con.OpenConnection();
            conMy = con.returnCell();
            switch (number)
            {
                case 1:
                    MySqlCommand command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 1", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 2", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 3", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 4", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 2:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 5", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 6", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 7", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 8", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 3:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 9", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 10", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 11", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 12", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 4:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 13", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 14", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 15", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 16", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 5:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 17", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 18", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 19", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 20", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 6:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 21", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 22", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 23", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 24", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 7:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 25", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 26", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 27", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 28", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 8:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 29", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 30", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 31", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 32", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 9:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 33", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 34", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 35", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 36", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 10:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 37", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 38", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 39", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 40", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 11:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 41", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 42", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 43", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 44", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
                case 12:
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 45", conMy);
                    radioBtnVariant1.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 46", conMy);
                    radioBtnVariant2.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 47", conMy);
                    radioBtnVariant3.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = 48", conMy);
                    radioBtnVariant4.Text = command.ExecuteScalar().ToString();
                    questionsScore();
                    updateRadioBtn();
                    return;
            }
            con.CloseConnection();
        }

        private void questionsScore()
        {
            if (radioBtnVariant1.Checked == true) score += 0;
            if (radioBtnVariant2.Checked == true) score++;
            if (radioBtnVariant3.Checked == true) score += 2;
            if (radioBtnVariant4.Checked == true) score += 3;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numberQuestions();
            number++;
            if (number == 13)
            {
                panelEnd.Visible = true;
                panelVopros.Visible = false;
                this.Width = 420;
                this.Height = 298;
                score = score / 36 * 100;
                if (score >= 0 && score <= 20) labelScore.Text = "Ваш результат: " + Math.Round(score).ToString() + " - низкий показатель уровня счастья";
                else if (score >= 21 && score <= 40) labelScore.Text = "Ваш результат: " + Math.Round(score).ToString() + " - пониженный показатель уровня счастья";
                else if (score >= 41 && score <= 60) labelScore.Text = "Ваш результат: " + Math.Round(score).ToString() + " - средний показатель уровня счастья";
                else if (score >= 61 && score <= 80) labelScore.Text = "Ваш результат: " + Math.Round(score).ToString() + " - повышенный показатель уровня счастья";
                else if (score >= 81 && score <= 100) labelScore.Text = "Ваш результат: " + Math.Round(score).ToString() + " - высокий показатель уровня счастья";
                number = 0;
                score = 0;
            }
        }

        private void updateRadioBtn()
        {
            radioBtnVariant1.Checked = false;
            radioBtnVariant2.Checked = false;
            radioBtnVariant3.Checked = false;
            radioBtnVariant4.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturnStart_Click(object sender, EventArgs e)
        {
            panelStart.Visible = true;
            panelEnd.Visible = false;
            this.Width = 339;
            this.Height = 253;
        }
    }
}
