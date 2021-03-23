using System;
using System.Drawing;
using System.Windows.Forms;

namespace Juego
{
    public partial class frmJuego : Form
    {
        int velocidad;
        int positionFrame; 
        Personaje link;
        Personaje Enemigo;
        //Personaje azul;
        //Personaje amarillo;
        //Personaje blanco;
        //Personaje negro;       
        public frmJuego()
        {
            InitializeComponent();
            velocidad = 10;
            positionFrame = 0;
            //rojo = new Personaje();
           
            //rojo.Velocidad = 2;
            //rojo.AgregarVelocidad(-1);
            
            //azul = new Personaje("azul", 100, 10);
            //amarillo = new Personaje("amarillo", 50, 5);
            //blanco = new Personaje("blanco", 75, 2);
            //negro = new Personaje("negro", 20, 10, new Point(10, 10), new Size(50, 50));
            //MessageBox.Show(negro.ToString());
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X - velocidad, pctPlayer.Location.Y);
            }

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X + pctPlayer.Size.Width + velocidad < grpLevel.Width)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X + velocidad, pctPlayer.Location.Y);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pctPlayer.Location.Y + pctPlayer.Size.Height + 40 + velocidad < grpLevel.Height)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y + (int)nudVelocidadPlayer.Value);
            }
            
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if(pctPlayer.Location.Y - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y - velocidad);
            }
                
        }


        private void nudIncrementoPlayer_ValueChanged(object sender, EventArgs e)
        {
            // FORMAS DE CAMBIAR A ENTERO ESTE VALUE.
            // velocidad = int.Parse(nudVelocidadPlayer.Value.ToString());
            // velocidad = Convert.ToInt32(nudVelocidadPlayer.Value.ToString());
            // velocidad = (int)nudVelocidadPlayer.Value;
            velocidad = (int)nudVelocidadPlayer.Value;
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            link = new Personaje("link", @"C:\\Users\\Admin\\Documents\\UMAD\\Clases de lenguajes de aplicación gral\\zelda.png", 100, 10, new Point (0,0), new Size (120,120));
            pctPlayer.Location = link.Posicion;
            pctPlayer.Size = link.Tamanio;
            pctPlayer.Image = link.GetFrame(0);
            Enemigo = new Personaje("link", @"C:\\Users\\Admin\\Documents\\UMAD\\Clases de lenguajes de aplicación gral\\zelda.png", 100, 10, new Point(0, 0), new Size(120, 120));
            
        }

        private void tcrVelocidad_Scroll(object sender, EventArgs e)
        {
            velocidad = (int)trcVelocidad.Value + 1;
        }

        private void pctPlayer_Click(object sender, EventArgs e)
        {

        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            link.Mover(e.KeyChar);
            pctPlayer.Location = link.Posicion;
            if (pctPlayer.Bounds.IntersectsWith(pctEnemy.Bounds))
            {
                MessageBox.Show("Kabooom!!");
            }
        }
        private void izquierda()
        {
          
        }

        private void grpLevel_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (link.positionFrame < 40)
            {
                pctPlayer.Image = link.GetFrame(positionFrame);
                positionFrame++;
            }
            else
            {
                positionFrame = 0;
            }
        }

        private void tmrEnemy_Tick(object sender, EventArgs e)
        {
            if (positionFrame < 40)
            {
                pctEnemy.Image = link.GetFrame(positionFrame);
                positionFrame++;
            }
            else
            {
                positionFrame = 0;
            }
        }
    }
}
