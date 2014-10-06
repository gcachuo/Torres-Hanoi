﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorresHanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region VARIABLES
        //Medidas de tiempo
        int hora = 0, minuto = 0, segundo = 0;
        //Muestra en texto de tiempo transcurrido
        string showsegundo = "00", showminuto = "00", showhora = "00";
        //Sonidos
        // sonido de planeación
        private SoundPlayer startSound;
        private SoundPlayer playingSound;
        //TORRES
        private List<PictureBox> ListaTorre1;
        private List<PictureBox> ListaTorre2;
        private List<PictureBox> ListaTorre3;
        //TAMAÑO DE TORRE
        private Size sizeTower;
        private Size sizeDisco;
        private int xLocation;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            startSound = new SoundPlayer("sonidos/watch_the_game.wav");
            startSound.Play();
            FormaBoton();
        }
        private void FormaBoton()
        {
            btnJugar.Region = new Region(Graficos.FormaBoton(new Point(5, 5), new Size(btnJugar.Width - 10, btnJugar.Height - 10)));
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            pnlTorre1.Controls.Clear();
            pnlTorre2.Controls.Clear();
            pnlTorre3.Controls.Clear();
            startSound.Stop();
            playingSound = new SoundPlayer("sonidos/tetrisB.wav");
            playingSound.Play();
            GenerarDiscos();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (segundo == 59)
                {
                    if (minuto == 59)
                    { minuto = 0; hora = hora + 1; }
                    else
                    { segundo = 0; minuto = minuto + 1; }
                }
                else
                { segundo = segundo + 1; }
                if (segundo > -1 & segundo < 10)
                { showsegundo = "0" + segundo; }
                else
                { showsegundo = Convert.ToString(segundo); }
                if (minuto > -1 & minuto < 10)
                { showminuto = "0" + minuto; }
                else
                { showminuto = Convert.ToString(minuto); }
                if (hora > -1 & hora < 10)
                {
                    showhora = "0" + hora;
                }
                else
                { showhora = Convert.ToString(hora); }
                lblTiempo.Text = showhora + ":" + showminuto + ":" + showsegundo;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GenerarDiscos()
        {
            sizeTower = new Size(pnlTorre1.Width, pnlTorre1.Height);
            int altoDisco = sizeTower.Height/int.Parse(nmrDiscos.Text);
            if (altoDisco < 20)
            {
                MessageBox.Show("La pantalla es muy pequeña para la cantidad de discos que desea");
            }
            else
            {
                int discos = int.Parse(nmrDiscos.Text);
                Point[] puntos=GeneraPuntos(discos);
                int anchoPanel = sizeTower.Width;
                //Discos de primer columna
                for (int i = 1; i <=discos; i++)
                {
                    anchoPanel = anchoPanel - 7*2;
                    pnlTorre1.Controls.Add(creaDiscoLleno(puntos[i-1], new Size(anchoPanel,20)));
                }
              LLenarPanelesVacio();
            }
        }

        private void LLenarPanelesVacio()
        {
              int discos = int.Parse(nmrDiscos.Text);
                Point[] puntos=GeneraPuntos(discos);
                int anchoPanel = sizeTower.Width;
              //Discos de segunda y tercera columna
                for (int i = 1; i <= discos; i++)
                {
                    anchoPanel = anchoPanel - 7 * 2;
                    pnlTorre2.Controls.Add(creaDiscoVacio(puntos[i - 1], new Size(anchoPanel, 20)));
                    pnlTorre3.Controls.Add(creaDiscoVacio(puntos[i - 1], new Size(anchoPanel, 20)));
                }
        }
        private Point[] GeneraPuntos(int discos)
        {
            Point[] puntos=new Point[discos];
            int altoPanel = sizeTower.Height;
            for (int i = 0; i < discos; i++)
            {
                altoPanel =altoPanel- 20;
                puntos[i] = new Point((i+1)*7, altoPanel);
            }
            return puntos;
        }
        PictureBox creaDiscoVacio(Point punto, Size tam)
        {
            PictureBox pb = new PictureBox();
            pb.Location = punto;
            pb.Width = tam.Width;
            pb.Height = tam.Height;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.MouseUp += imgDestino_MouseUp;
            pb.MouseDown += imgDestino_MouseDown;
            pb.MouseHover += imgr_MouseHover;
            pb.MouseMove += imgDestino_MouseMove;
            return pb;
        }
        PictureBox creaDiscoLleno(Point punto, Size tam)
        {
            PictureBox pb = new PictureBox();
            pb.Location = punto;
            pb.Width = tam.Width;
            pb.Height = tam.Height;
            pb.BorderStyle = BorderStyle.Fixed3D;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = Image.FromFile("imagenes/lightwood.jpg");
            pb.MouseUp += imgDestino_MouseUp;
            pb.MouseDown += imgDestino_MouseDown;
            pb.MouseHover += imgr_MouseHover;
            pb.MouseMove += imgDestino_MouseMove;
            return pb;
        }
        PictureBox creaDiscoNuevo(Point punto, Size tam, Bitmap image)
        {
            PictureBox pb = new PictureBox();
            pb.Location = punto;
            pb.Width = tam.Width;
            pb.Height = tam.Height;
            pb.BorderStyle = BorderStyle.Fixed3D;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = Image.FromFile("imagenes/lightwood.jpg");
            pb.MouseUp += imgDestino_MouseUp;
            pb.MouseDown += imgDestino_MouseDown;
            pb.MouseHover += imgr_MouseHover;
            pb.MouseMove += imgDestino_MouseMove;
            return pb;
        }
        public Byte[] ConvertirImagen(Image imagen)
        {
            byte[] resultado = null;
            //Objeto para realizar el respaldo de la imagen memoria
            MemoryStream memoria = new MemoryStream();
            //Almacena en memoria la imagen en el formato original
            //Formato de la imagen puede ser :Raw Format, ImageFormat
            //1.- imagen.Save(memoria, imagen.RawFormat);
            imagen.Save(memoria, ImageFormat.Png);
            //Obtener los datos en bytes de la imagen 
            resultado = memoria.GetBuffer();
            memoria.Close();
            return resultado;
        }
              public Image ObtenerImagen(Byte[] imgDatos)
        {
            Image imgGeneral = null;
            MemoryStream memoria = new MemoryStream();
            memoria.Write(imgDatos, 0, imgDatos.GetUpperBound(0) + 1);
            imgGeneral = Image.FromStream(memoria);
            return imgGeneral;
        }
        
        byte[] imgCopiar;//Almacenar datos de la imagen
        Point puntoActual;
        private PictureBox imgTemporal;
        #region ACCIONES DE DISCO
        private void imgDestino_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox imagen = (PictureBox)sender;//Imagen del objeto
   
            Point punto = new Point(e.X, e.Y);//Punto donde se dio click
            Size tam = imagen.ClientRectangle.Size;//Tamaño de img
            puntoActual = imagen.Location;//Localizacion de imagen
            imgCopiar = ConvertirImagen(imagen.Image);//Copia en bytes de la imagen a mover o copiar

            //Creando nueva imagen
            imgTemporal = creaDiscoNuevo(puntoActual, tam, (Bitmap)imagen.Image);
            this.Controls.Add(imgTemporal);
            imagen.Location = new Point(puntoActual.X + punto.X, puntoActual.Y + punto.Y);
            imagen.BringToFront();
        }

        private void imgDestino_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PictureBox imagen = (PictureBox)sender;
                imagen.Location = new Point(imagen.Location.X + e.X, imagen.Location.Y + e.Y);
            }
        }

        private void imgDestino_MouseUp(object sender, MouseEventArgs e)
        {
            imgTemporal = null;
            PictureBox imagen = (PictureBox)sender;
            imagen.Location = puntoActual;
            imagen.Image = null;
            sizeDisco=new Size(imagen.Width, imagen.Height);
        }

        private void imgr_MouseHover(object sender, EventArgs e)
        {
            if (imgCopiar != null)
            {
                PictureBox imagen = (PictureBox)sender;
                imagen.Image = ObtenerImagen(imgCopiar);
                imagen.Height = sizeDisco.Height;
                imagen.Width = sizeDisco.Width;
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                imgCopiar = null;
                imgTemporal = null;
            }
        }
        #endregion

    }
}
