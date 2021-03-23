using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public class Personaje
    {
        #region atributos
        private int posicionFrame;
        private int totalFrame;
        private Point posicion;
        private Size tamanio;
        private int velocidad;
        private string nombre;
        private string fileName;
        private int vida;
        private Image sprite;
        #endregion
        #region propiedades
        public int positionFrame
        {
            get { return this.posicionFrame; }
            set { this.posicionFrame = (0 <= value && value < totalFrame) ? value : this.posicionFrame; }
        }
        public int TotalFrame
        {
            get { return this.totalFrame; }
            set { this.totalFrame = value; }
        }
        public Image Sprite
        {
            get { return this.sprite; }
            set { this.sprite = value; } 
        }
        public int Vida
        { 
            get { return this.vida; }
            set { this.vida = (0 <= value && value <= 100) ? value : this.vida; }
            //set
            //{
            //    if (0 <= value && value <= 100)
            //    {
            //        this.vida = value;
            //    }
            //    else
            //    {
            //        this.vida = this.vida;
            //    }
            //}
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = (0 < value && value <= 10) ? value : this.velocidad; }
        }
        public Size Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }
        public Point Posicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }
        #endregion
        #region metodos
        //Constructor por defecto
        public Personaje()
        {
            this.Nombre = "Rojo";
            this.Vida = 100;
            this.Velocidad = 10;
            this.Posicion = new Point(0, 0);
            this.Tamanio = new Size(120, 120);
            this.totalFrame = 40;
            this.posicionFrame = 0;
            this.FileName = @"C:\\Users\\Admin\\Documents\\UMAD\\Clases de lenguajes de aplicación gral\\zelda.png";
            this.Sprite = Bitmap.FromFile(this.FileName);
        }
        //Constructor sobrecargado 
        public Personaje(string nombre,string fileName, int vida, int velocidad)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Velocidad = velocidad;
            this.Posicion = new Point(0, 0);
            this.Tamanio = new Size(100, 100);
            this.totalFrame = 40;
            this.posicionFrame = 0;
            this.FileName = fileName;
            this.Sprite = Bitmap.FromFile(this.FileName);

        }
        public Personaje(string nombre,string fileName, int vida, int velocidad, Point posicion, Size tamanio)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.velocidad = velocidad;
            this.posicion = posicion;
            this.tamanio = tamanio;
            this.totalFrame = 40;
            this.posicionFrame = 0;
            this.FileName = fileName;
            this.Sprite = Bitmap.FromFile(this.FileName);
        }
        public override string ToString()
        {
            return $"nombre de personaje:{this.Nombre}-\nvida:{this.Vida}-\nvelocidad:{this.Velocidad}-\nposicion:{this.Posicion}-\ntamaño:{this.Tamanio}";
        }
        public void AgregarVelocidad(int velocidad)
        {
            if (velocidad > 0 && this.Velocidad + velocidad <= 10)
            {
                this.Velocidad += velocidad;
            }
            else if (velocidad < 0 && this.Velocidad + velocidad > 0)
            {
                this.Velocidad += velocidad;
            }
        }
        public void Mover(char tecla)
        {
            if(tecla == 'A' || tecla == 'a')
            {
                this.Posicion = new Point (this.Posicion.X - velocidad,this.Posicion.Y);
            }
            if (tecla == 'D' || tecla == 'd')
            {
                this.Posicion = new Point(this.Posicion.X + velocidad, this.Posicion.Y);
            }
            if (tecla == 'W' || tecla == 'w')
            {
                this.Posicion = new Point(this.Posicion.X, this.Posicion.Y - velocidad);
            }
            if (tecla == 'S' || tecla == 's')
            {
                this.Posicion = new Point(this.Posicion.X, this.Posicion.Y + velocidad);
            }
        }
        public Image GetFrame(int index)
        {
            if (!(index >= 0 && index < 40))
            {
                index = 0;
            }
            Image frame = new Bitmap(tamanio.Width, tamanio.Height);
            using(Graphics g = Graphics.FromImage(frame))
            {
                g.DrawImage(Sprite, new Rectangle (0,0, tamanio.Width, tamanio.Height),
                    new Rectangle(index * tamanio.Width,0,tamanio.Width, tamanio.Height),GraphicsUnit.Pixel);
            }
            return frame; 
        }
        #endregion


    }
}
