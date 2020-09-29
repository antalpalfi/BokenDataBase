using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BokenDataBase
{
    public partial class AddBoeks : Form
    {
        public AddBoeks()
        {
            InitializeComponent();
        }

        private void AddBoeks_Load(object sender, EventArgs e)
        {
            using(BoekenDatabaseEntities ctx = new BoekenDatabaseEntities())
            {
                var autersList = ctx.Auteurs.Select(au => au).ToList();
                cmbAuters.DisplayMember = "Voornaam";
                cmbAuters.ValueMember = "Id";
                cmbAuters.DataSource = autersList;

                var genresList = ctx.Genres.Select(ge => ge).ToList();
                cmbGenres.DisplayMember = "Genre1";
                cmbGenres.ValueMember = "Id";
                cmbGenres.DataSource = genresList;

                var uitgevList = ctx.Uitgeverijens.Select(uit => uit).ToList();
                cmbUitgeverij.DisplayMember = "Naam";
                cmbUitgeverij.ValueMember = "Id";
                cmbUitgeverij.DataSource = uitgevList;
            }
        }

        private void btnAddBoek_Click(object sender, EventArgs e)
        {
            using(BoekenDatabaseEntities ctx = new BoekenDatabaseEntities())
            {
                ctx.Boeks.Add(new Boek()
                {
                    Titel = txtTitel.Text,
                    AntalPaginas = Convert.ToInt32(numPaginas.Value),
                    Score = Convert.ToInt32(numScore.Value),
                    Publicatie = dtPublicatie.Value.ToString("dd-MM-yyyy"),
                    UitgeverId = Convert.ToInt32(cmbUitgeverij.ValueMember)
                }) ;
                ctx.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnNewAuteurs_Click(object sender, EventArgs e)
        {
            using(BoekenDatabaseEntities ctx = new BoekenDatabaseEntities())
            {
               
                ctx.Auteurs.Add(new Auteur()
                {
                    Voornaam = txtVoornaam.Text,
                    Achternaam = txtAchternaam.Text
                });
                ctx.SaveChanges();
                var autersList = ctx.Auteurs.Select(au => au).ToList();
                cmbAuters.DisplayMember = "Voornaam";
                cmbAuters.ValueMember = "Id";
                cmbAuters.DataSource = autersList;
                txtAchternaam.Text = " ";
                txtVoornaam.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BoekenDatabaseEntities ctx = new BoekenDatabaseEntities())
            {
                ctx.Genres.Add(new Genre()
                {
                    Genre1 = txtGenres.Text
                });
                ctx.SaveChanges();
                var genresList = ctx.Genres.Select(ge => ge).ToList();
                cmbGenres.DisplayMember = "Genre1";
                cmbGenres.ValueMember = "Id";
                cmbGenres.DataSource = genresList;
                txtGenres.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(BoekenDatabaseEntities ctx = new BoekenDatabaseEntities())
            {
                ctx.Uitgeverijens.Add(new Uitgeverijen()
                {
                    Naam = txtUitg.Text
                });
                ctx.SaveChanges();
                var uitgevList = ctx.Uitgeverijens.Select(uit => uit).ToList();
                cmbUitgeverij.DisplayMember = "Naam";
                cmbUitgeverij.ValueMember = "Id";
                cmbUitgeverij.DataSource = uitgevList;
                txtUitg.Text = " ";
            }
        }
    }
}
