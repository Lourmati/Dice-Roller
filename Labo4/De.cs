using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4
{
    public partial class De : Control
    {
        
        public enum Etat
        {
            Un,
            Deux,
            Trois,
        };

        [Description("Etat du dé"), DefaultValue(Etat.Un)]
        public Etat EtatDe
        {
            get;
            set;
        }


        public De() : this(Etat.Un)
        {
        }
        public De(Etat etatDe)
        {
            InitializeComponent();
            EtatDe = etatDe;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;

            g.DrawLine(Pens.Black, 0, 0, 0, 100);
            g.DrawLine(Pens.Black, 0, 100, 100, 100);
            g.DrawLine(Pens.Black, 0, 0, 100, 0);
            g.DrawLine(Pens.Black, 100, 0, 100, 100);

            this.BackColor = Color.White;

            if (EtatDe == Etat.Un)
            {
                g.FillEllipse(Brushes.Black, 40, 40, 20, 20);
            }

            if (EtatDe == Etat.Deux)
            {
                g.FillEllipse(Brushes.Black, 20, 20, 20, 20);
                g.FillEllipse(Brushes.Black, 60, 60, 20, 20);
            }

            if (EtatDe == Etat.Trois)
            {
                g.FillEllipse(Brushes.Black, 10, 10, 20, 20);
                g.FillEllipse(Brushes.Black, 40, 40, 20, 20);
                g.FillEllipse(Brushes.Black, 70, 70, 20, 20);
            }
        }

        public void LancerDe(int number)
        {
            switch (number)
            {
                case 1:
                    if (EtatDe != De.Etat.Un)
                    {
                        EtatDe = De.Etat.Un;
                        Refresh();
                    }
                    break;
                case 2:
                    if (EtatDe != De.Etat.Deux)
                    {
                        EtatDe = De.Etat.Deux;
                        Refresh();
                    }
                    break;
                case 3:
                    if (EtatDe != De.Etat.Trois)
                    {
                        EtatDe = De.Etat.Trois;
                        Refresh();
                    }
                    break;
            }
        }
    }
}
