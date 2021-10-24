using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace TicTacToeSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool jouer = false;
        private int joueur, pointsJ1 = 0, pointsJ2 = 0;         

        Bitmap[] j = { TicTacToeSharp.Properties.Resources.cercle, TicTacToeSharp.Properties.Resources.croix };

        private void pct_Click(object sender, EventArgs e)
        {
            PictureBox pct = (PictureBox)sender;
            if (!jouer)
            {
                pct.Image = j[0];
                pct.Enabled = false;
                jouer = !jouer;
                joueur = 1;
                lblJoueur.Text = tourJoueur(joueur + 1);
            }
            else
            {
                pct.Image = j[1];
                pct.Enabled = false;
                jouer = !jouer;
                joueur = 2;
                lblJoueur.Text = tourJoueur(joueur - 1);
            }
            gagnant();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            nouveau(true);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Etes-vous sûr?", "Quitter", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (message == DialogResult.OK)
                Application.Exit();
        }

        private string tourJoueur(int j)
        {
            if (j == 1)
                return "Au tour du joueur " + Convert.ToString(j) + " (cercle)";
            else if (j == 2)
                return "Au tour du joueur " + Convert.ToString(j) + " (croix)";
            return "";
        }

        void nouveau(bool resetPoints)
        {
            if (resetPoints)
            {
                lblJ1.Text = Convert.ToString(pointsJ1 = 0);
                lblJ2.Text = Convert.ToString(pointsJ2 = 0);
            }

            foreach (Control c in this.pnlJeu.Controls)
            {
                if (c is PictureBox box)
                {
                    box.Image = null;
                    box.Enabled = true;
                }
            }
        }

        private void gagnant()
        {
            string gagnant = "";
            bool gagner = false;
            bool egalite = false;

            if (check(0))
            {
                pointsJ1++;
                lblJ1.Text = Convert.ToString(pointsJ1);
                gagnant = "Le joueur O a gagné.";
                gagner = true;
            }
            else if (check(1))
            {
                pointsJ2++;
                lblJ2.Text = Convert.ToString(pointsJ2);
                gagnant = "Le joueur X a gagné.";
                gagner = true;
            }
            else if((pnlJeu.Controls.OfType<PictureBox>()).Where(pic=>pic.Enabled == false).Count() == 9 && !gagner)
            {
                egalite = true;
            }
            

            if (gagner)
            {
                DialogResult message = MessageBox.Show(gagnant, "Vous avez gagner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nouveau(false);
            }

            if (egalite)
            {
                DialogResult message = MessageBox.Show("Aucun joueur n'a gagné cette manche", "Egalité!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nouveau(false);
            }
        }
        private bool check(int joueur)
        {
            return ((x1y1.Image == j[joueur] && x2y1.Image == j[joueur] && x3y1.Image == j[joueur]) ||
                (x1y1.Image == j[joueur] && x1y2.Image == j[joueur] && x1y3.Image == j[joueur]) ||
                (x1y1.Image == j[joueur] && x2y2.Image == j[joueur] && x3y3.Image == j[joueur]) ||
                (x1y2.Image == j[joueur] && x2y2.Image == j[joueur] && x3y2.Image == j[joueur]) ||
                (x1y3.Image == j[joueur] && x2y3.Image == j[joueur] && x3y3.Image == j[joueur]) ||
                (x2y1.Image == j[joueur] && x2y2.Image == j[joueur] && x2y3.Image == j[joueur]) ||
                (x3y1.Image == j[joueur] && x3y2.Image == j[joueur] && x3y3.Image == j[joueur]) ||
                (x3y1.Image == j[joueur] && x2y2.Image == j[joueur] && x1y3.Image == j[joueur]));
        }

    }
}
