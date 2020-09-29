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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            using(BoekenDatabaseEntities ctx = new BoekenDatabaseEntities())
            {
                var joinUitgever = ctx.Boeks.Join(
                   ctx.Uitgeverijens,
                   p => p.UitgeverId,
                   pb => pb.Id,
                   (p, pb) => new { p, pb });

                var joinBokenGenres = ctx.Boeks.Join(
                    ctx.BoekenGenres,
                    bo => bo.Id,
                    bogn => bogn.BoekId,
                    (bo, bogn) => new { bo, bogn }).Join
                    (ctx.Genres,
                    bogn2 => bogn2.bogn.GenreId,
                    ge=> ge.Id,
                    (bogn2,ge) => new { bogn2, ge });

                var query = ctx.Boeks.Select(x => x).ToList();
                lbBoeks.DisplayMember = "Titel";
                lbBoeks.ValueMember = "Id";
                lbBoeks.DataSource = query;

               
            }
        }

        private void lbBoeks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBoek = lbBoeks.SelectedItem as Boek;

            using (BoekenDatabaseEntities ctx = new BoekenDatabaseEntities())
            {
                var joinUitgever = ctx.Boeks.Join(
                   ctx.Uitgeverijens,
                   p => p.UitgeverId,
                   pb => pb.Id,
                   (p, pb) => new { p, pb });

                var joinBokenGenres = ctx.Boeks.Join(
                    ctx.BoekenGenres,
                    bo => bo.Id,
                    bogn => bogn.BoekId,
                    (bo, bogn) => new { bo, bogn }).Join
                    (ctx.Genres,
                    bogn2 => bogn2.bogn.GenreId,
                    ge => ge.Id,
                    (bogn2, ge) => new { bogn2, ge });

                var joinAuters = ctx.Boeks.Join(
                    ctx.BoekenAuteurs,
                    bok => bok.Id,
                    boka => boka.BoekId,
                    (bok, boka) => new { bok, boka }).Join(
                    ctx.Auteurs,
                    boka2 => boka2.boka.AuteurId,
                    au => au.Id,
                    (boka2, au) => new { boka2, au });

                lblBoeksInfo.Text = "AantalPaginas: " + selectedBoek.AntalPaginas.ToString() + "\n" +
                    "Score: " + selectedBoek.Score.ToString() + "\n" +
                    "Publicatie: " + selectedBoek.Publicatie + "\n" +
                    "Uitgever: " + joinUitgever.Where(x => x.p.Id == selectedBoek.Id).FirstOrDefault().pb.Naam + "\n" +
                    "Genres: " + joinBokenGenres.Where(x => x.bogn2.bogn.BoekId == selectedBoek.Id).FirstOrDefault().ge.Genre1 + "\n" +
                    "Auteur: " + joinAuters.Where(x => x.boka2.boka.BoekId == selectedBoek.Id).FirstOrDefault().au.Voornaam +" "+
                    joinAuters.Where(x => x.boka2.boka.BoekId == selectedBoek.Id).FirstOrDefault().au.Achternaam;


            }
            
        }

        private void btntoevoegen_Click(object sender, EventArgs e)
        {
            AddBoeks addBoeks = new AddBoeks();
            if (addBoeks.ShowDialog()==DialogResult.OK)
            {

            }
        }
    }
}
