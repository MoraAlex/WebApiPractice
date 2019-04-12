using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamasPerron
{
    public partial class button_ficha1 : Form
    {

        static List<Button> fichas = new List<Button>();

        public button_ficha1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            activarDesactivarCasillas(A1);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            activarDesactivarCasillas(B1);
        }

        private void button_ficha1_Load(object sender, EventArgs e)
        {
            #region Add fichas
            fichas.Add(A1);
            fichas.Add(A2);
            fichas.Add(A3);
            fichas.Add(A4);
            fichas.Add(A5);
            fichas.Add(A6);
            fichas.Add(A7);
            fichas.Add(A8);
            fichas.Add(B1);
            fichas.Add(B2);
            fichas.Add(B3);
            fichas.Add(B4);
            fichas.Add(B5);
            fichas.Add(B6);
            fichas.Add(B7);
            fichas.Add(B8);
            fichas.Add(C1);
            fichas.Add(C2);
            fichas.Add(C3);
            fichas.Add(C4);
            fichas.Add(C5);
            fichas.Add(C6);
            fichas.Add(C7);
            fichas.Add(C8);
            fichas.Add(D1);
            fichas.Add(D2);
            fichas.Add(D3);
            fichas.Add(D4);
            fichas.Add(D5);
            fichas.Add(D6);
            fichas.Add(D7);
            fichas.Add(D8);
            fichas.Add(E1);
            fichas.Add(E2);
            fichas.Add(E3);
            fichas.Add(E4);
            fichas.Add(E5);
            fichas.Add(E6);
            fichas.Add(E7);
            fichas.Add(E8);
            fichas.Add(F1);
            fichas.Add(F2);
            fichas.Add(F3);
            fichas.Add(F4);
            fichas.Add(F5);
            fichas.Add(F6);
            fichas.Add(F7);
            fichas.Add(F8);
            fichas.Add(G1);
            fichas.Add(G2);
            fichas.Add(G3);
            fichas.Add(G4);
            fichas.Add(G5);
            fichas.Add(G6);
            fichas.Add(G7);
            fichas.Add(G8);
            fichas.Add(H1);
            fichas.Add(H2);
            fichas.Add(H3);
            fichas.Add(H4);
            fichas.Add(H5);
            fichas.Add(H6);
            fichas.Add(H7);
            fichas.Add(H8);
            #endregion



        }

        public void activarDesactivarCasillas(Button ficha)
        {
            foreach (Button f in fichas)
                f.Enabled = true;
            List<Point> posiciones = CasillasPosicionables(ficha.Location);
            //foreach(Point p in posiciones)
            //{
            //    foreach (Button f in fichas)
            //        if (p.Equals(f.Location))
            //            f.Enabled = true;
            //        else f.Enabled = false;
            //}
            fichas.All(f => posiciones.Contains(f.Location) ? f.Enabled = true : f.Enabled = false);
        }

        private List<Point> CasillasPosicionables(Point pointOrigin)
        {
            return new List<Point>()
            {
                new Point()
                {
                    X = pointOrigin.X + 29,
                    Y = pointOrigin.Y + 29,
                },
                new Point()
                {
                    X = pointOrigin.X + 29,
                    Y = pointOrigin.Y - 29,
                },
                new Point()
                {
                    X = pointOrigin.X - 29,
                    Y = pointOrigin.Y + 29,
                },
                new Point()
                {
                    X = pointOrigin.X - 29,
                    Y = pointOrigin.Y - 29,
                },
            };
        }

    }
}
