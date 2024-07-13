using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaintDrawX
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += MainApp_Paint;
            this.BackColor = Color.White;
            this.Size = new Size(400, 600);
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }


        private void MainApp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(this.BackColor);

            // base coordinate
            int centerX = this.ClientSize.Width / 2;
            int startY = this.ClientSize.Height / 4;

            // sword dimension
            int bladeLength = this.ClientSize.Height / 2;
            int bladeWidth = 10;  
            int guardWidth = 60; 
            int guardHeight = 20;
            int handleHeight = 80;
            int handleWidth = 20;

            // blade
            Pen bladePen = new Pen(Color.Silver, bladeWidth);
            g.DrawLine(bladePen, centerX, startY, centerX, startY + bladeLength);

            // cross-guard
            Brush guardBrush = new SolidBrush(Color.Gold);
            g.FillRectangle(guardBrush, centerX - guardWidth / 2, startY + bladeLength - guardHeight / 2, guardWidth, guardHeight);

            // handle
            Brush handleBrush = new SolidBrush(Color.DarkSlateGray);
            g.FillRectangle(handleBrush, centerX - handleWidth / 2, startY + bladeLength + guardHeight / 2, handleWidth, handleHeight);

            // ornament
            int jewelSize = 10;
            Brush jewelBrush = new SolidBrush(Color.DeepSkyBlue);
            g.FillEllipse(jewelBrush, centerX - jewelSize / 2, startY + bladeLength - jewelSize / 2, jewelSize, jewelSize);

            // decorative pommel
            Brush pommelBrush = new SolidBrush(Color.Gold);
            int pommelHeight = 20;
            g.FillEllipse(pommelBrush, centerX - handleWidth / 2, startY + bladeLength + handleHeight + guardHeight / 2, handleWidth, pommelHeight);
        }

    }
}
