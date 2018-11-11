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
        int numberQuestion = 1;
        double score = 0;
        MySqlCommand command = new MySqlCommand();

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

        public void showQuestion()
        {
            command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = " + numberQuestion, conMy);
            radioBtnVariant1.Text = command.ExecuteScalar().ToString();
            numberQuestion++;
            command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = " + numberQuestion, conMy);
            radioBtnVariant2.Text = command.ExecuteScalar().ToString();
            numberQuestion++;
            command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = " + numberQuestion, conMy);
            radioBtnVariant3.Text = command.ExecuteScalar().ToString();
            numberQuestion++;
            command = new MySqlCommand("SELECT Question FROM questions WHERE idQuestions = " + numberQuestion, conMy);
            radioBtnVariant4.Text = command.ExecuteScalar().ToString();
            numberQuestion++;
            questionsScore();
            updateRadioBtn();
        }

        private void numberQuestions()
        {
            con = new BDConnection("question", "127.0.0.1", "3306", "root", "");
            con.OpenConnection();
            conMy = con.returnCell();
            switch (number)
            {
                case 1:
                    showQuestion();
                    return;
                case 2:
                    showQuestion();
                    return;
                case 3:
                    showQuestion();
                    return;
                case 4:
                    showQuestion();
                    return;
                case 5:
                    showQuestion();
                    return;
                case 6:
                    showQuestion();
                    return;
                case 7:
                    showQuestion();
                    return;
                case 8:
                    showQuestion();
                    return;
                case 9:
                    showQuestion();
                    return;
                case 10:
                    showQuestion();
                    return;
                case 11:
                    showQuestion();
                    return;
                case 12:
                    showQuestion();
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
