using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Pendu
{
    public partial class Form1 : Form
    {
        private string motAChercher;
        private char [] motsAfficher;
        private int nombreErreur;
        private int nombreLettreJuste;
        private int avetissement;
        private int score;
        private Regex regex = new Regex(@"[^a-zA-Z]+", RegexOptions.Multiline);
        private Point penPosition;
        private Point newPenPosition;
        private Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
            nombreErreur = 0;
            penPosition = new Point(20, 250);
            newPenPosition = new Point(100, 250);
        }

        private void validMotChercher_Click(object sender, EventArgs e)
        {
            initGame();
        }

        private void buttonLettreTester_Click(object sender, EventArgs e)
        {
            game();
        }

        public void reset(Graphics g)
        {
            this.label2.Visible = false;
            this.lettreTester.Text = "";
            this.lettreTester.Visible = false;
            this.buttonLettreTester.Visible = false;
            //
            this.label1.Visible = true;
            this.motChercher.Visible = true;
            this.validMotChercher.Visible = true;
            //
            this.label3.Visible = false;
            this.textBoxAffiche.Visible = false;
            this.textBoxAffiche.Text = "";
            //
            score++;
            actualScore.Text = "Score: " + score;
            //
            penPosition = new Point(20, 250);
            newPenPosition = new Point(100, 250);
            //
            nombreLettreJuste = 0;
            nombreErreur = 0;
            //
            g.Clear(Color.White);
        }

        public void game()
        {
            string motsTextBox = "";
            string aVerifier = this.lettreTester.Text;
            bool isOk = false;
            char[] lettres = motAChercher.ToCharArray();
            if (aVerifier == null || aVerifier == "")
            {
                aVerifier = " ";
            }
            this.lettreTester.Text = "";
            for (int i = 0; i < lettres.Length; i++)
            {
                if (lettres[i].ToString().ToLower() == aVerifier.ToCharArray()[0].ToString().ToLower() && motsAfficher[i] != aVerifier.ToCharArray()[0])
                {
                    isOk = true;
                    nombreLettreJuste++;
                    motsAfficher[i] = Char.ToLower(aVerifier.ToCharArray()[0]);
                }
                else if (avetissement <= 0 && aVerifier.ToCharArray()[0] == ' ')
                {
                    avetissement = 1;
                    MessageBox.Show("Veuillez entrée une valeur. La prochaine fois ne rien mettre signifiras une erreur");
                    isOk = true;
                }
                else if (motsAfficher[i] == aVerifier.ToCharArray()[0])
                {
                    isOk = true;
                    MessageBox.Show("Vous avez déjà trouvez cette lettres");
                }
            }
            Graphics g = this.panel1.CreateGraphics();
            Pen crayon = new Pen(Color.Black, 3);
            for (int i = 0; i < motsAfficher.Length; i++)
            {
                motsTextBox += motsAfficher[i] + " ";
            }
            textBoxAffiche.Text = motsTextBox;
            if (!isOk)
            {
                nombreErreur++;
                switch (nombreErreur)
                {
                    case 1:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        penPosition = new Point(penPosition.X, newPenPosition.Y);
                        newPenPosition = new Point(penPosition.X, newPenPosition.Y - 150);
                        break;
                    case 2:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        penPosition = new Point(penPosition.X, newPenPosition.Y);
                        newPenPosition = new Point(newPenPosition.X + 80, penPosition.Y);
                        break;
                    case 3:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        penPosition = new Point(newPenPosition.X, penPosition.Y);
                        newPenPosition = new Point(newPenPosition.X, penPosition.Y + 20);
                        break;
                    case 4:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        penPosition = new Point(penPosition.X, newPenPosition.Y);
                        break;
                    case 5:
                        g.DrawEllipse(crayon, penPosition.X - 10, penPosition.Y, 20, 20);
                        penPosition = new Point(penPosition.X, penPosition.Y + 20);
                        newPenPosition = new Point(penPosition.X, newPenPosition.Y + 50);
                        break;
                    case 6:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        penPosition = new Point(penPosition.X - 10, penPosition.Y + 10);
                        newPenPosition = new Point(penPosition.X + 20, penPosition.Y);
                        break;
                    case 7:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        penPosition = new Point(newPenPosition.X - 10, penPosition.Y + 20);
                        newPenPosition = new Point(penPosition.X + 10, penPosition.Y + 20);
                        break;
                    case 8:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        penPosition = new Point(penPosition.X, penPosition.Y);
                        newPenPosition = new Point(penPosition.X - 10, penPosition.Y + 20);
                        break;
                    case 9:
                        g.DrawLine(crayon, penPosition, newPenPosition);
                        MessageBox.Show("Vous avez perdu le mots été: " + motAChercher);
                        reset(g);
                        break;
                }

            }
            else if (nombreLettreJuste == lettres.Length)
            {
                MessageBox.Show("Vous avez gagnez le mots été: " + motAChercher.ToLower());
                reset(g);
            }
        }

        public void initGame()
        {
            if ((this.motChercher.Text.Length <= 10) && (this.motChercher.Text.Length >= 3))
            {
                motAChercher = regex.Replace(this.motChercher.Text, "");
                if (motAChercher.Length >= 3)
                {
                    this.label2.Visible = true;
                    this.lettreTester.Visible = true;
                    this.buttonLettreTester.Visible = true;
                    //
                    this.label1.Visible = false;
                    this.motChercher.Visible = false;
                    this.motChercher.Text = "";
                    this.validMotChercher.Visible = false;
                    //
                    this.label3.Visible = true;
                    this.textBoxAffiche.Visible = true;
                    motsAfficher = motAChercher.ToCharArray();
                    for (int i = 0; i < motsAfficher.Length; i++)
                    {
                        motsAfficher[i] = '_';
                        textBoxAffiche.Text += motsAfficher[i] + " ";
                    }
                }
                else if (this.motAChercher.Length < 3)
                {
                    if (File.Exists("dictionnaire.db"))
                    {
                        MessageBox.Show("Vous venez d'activée le mods solo. Les mots serons tous en anglais. Ils ne pourons pas avoir moins de 3 charactère et plus de 10 charactère");
                        this.label2.Visible = true;
                        this.lettreTester.Visible = true;
                        this.buttonLettreTester.Visible = true;
                        //
                        this.label1.Visible = false;
                        this.motChercher.Visible = false;
                        this.motChercher.Text = "";
                        this.validMotChercher.Visible = false;
                        //
                        this.label3.Visible = true;
                        this.textBoxAffiche.Visible = true;
                        List<string> words = controller.read();
                        Random random = new Random();
                        motAChercher = words[random.Next(0, words.Count() - 1)];
                        char tiret = '-';
                        motsAfficher = motAChercher.ToCharArray();
                        for (int i = 0; i < motsAfficher.Length; i++)
                        {
                            if (motsAfficher[i].Equals(tiret))
                            {
                                motsAfficher[i] = '-';
                                textBoxAffiche.Text += motsAfficher[i] + " ";
                                nombreLettreJuste++;
                            }
                            else
                            {
                                motsAfficher[i] = '_';
                                textBoxAffiche.Text += motsAfficher[i] + " ";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le fichier dictionnaire.db est manquant allez à cette page pour le télécharger: https://plaglefleau.fr/download/dictionnaire.db", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        Application.Exit();
                    }
                }
            } else
            {
                MessageBox.Show("Le mots ne doit pas avoir moins de 3 charactère et plus de 10 charactère");
            }
        }

        private void lettreTester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                game();
            }
        }

        private void motChercher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                initGame();
            }
        }
    }
}