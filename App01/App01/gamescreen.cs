using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class gamescreen : Form
    {
        public gamescreen()
        {
            InitializeComponent();
        }

        private Panel[,] gameboardpanels;
        const int gridSize = 9;
        const int tileSize = 42;

        private void gamescreen_Load(object sender, EventArgs e)
        {
            // initialize the game grid
            gameboardpanels = new Panel[gridSize, gridSize];

            // double for loop to handle all rows and columns
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n, tileSize * m),
                        BackgroundImage = Properties.Resources.empty
                    };
                    gameboardpanels[n, m] = newPanel;
                }
            }
        }

        private void startbttn_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int a = rng.Next((gridSize * gridSize) + 1);
            int b = rng.Next((gridSize * gridSize) + 1);
            while (b == a)
            {
                b = rng.Next((gridSize * gridSize) + 1);
            }
            int c = rng.Next((gridSize * gridSize) + 1);
            while (c == a || c == b)
            {
                c = rng.Next((gridSize * gridSize) + 1);
            }
            int a_x = a / gridSize;
            int b_x = b / gridSize;
            int c_x = c / gridSize;
            int a_y = a % gridSize;
            int b_y = b % gridSize;
            int c_y = c % gridSize;

            var randompanela = new Panel
            {
                Size = new Size(tileSize, tileSize),
            };
            var randompanelb = new Panel
            {
                Size = new Size(tileSize, tileSize),
            };
            var randompanelc = new Panel
            {
                Size = new Size(tileSize, tileSize),
            };
            int rngcolorshape = rng.Next(0, 9);
            if (rngcolorshape == 0) randompanela.BackgroundImage = Properties.Resources.blueCircle;
            if (rngcolorshape == 1) randompanela.BackgroundImage = Properties.Resources.blueSquare;
            if (rngcolorshape == 2) randompanela.BackgroundImage = Properties.Resources.blueTriangle;
            if (rngcolorshape == 3) randompanela.BackgroundImage = Properties.Resources.greenCircle;
            if (rngcolorshape == 4) randompanela.BackgroundImage = Properties.Resources.greenSquare;
            if (rngcolorshape == 5) randompanela.BackgroundImage = Properties.Resources.greenTriangle;
            if (rngcolorshape == 6) randompanela.BackgroundImage = Properties.Resources.redCircle;
            if (rngcolorshape == 7) randompanela.BackgroundImage = Properties.Resources.redSquare;
            if (rngcolorshape == 8) randompanela.BackgroundImage = Properties.Resources.redTriangle;
            gameboardpanels[a_x, a_y] = randompanela;

            rngcolorshape = rng.Next(0, 9);
            if (rngcolorshape == 0) randompanelb.BackgroundImage = Properties.Resources.blueCircle;
            if (rngcolorshape == 1) randompanelb.BackgroundImage = Properties.Resources.blueSquare;
            if (rngcolorshape == 2) randompanelb.BackgroundImage = Properties.Resources.blueTriangle;
            if (rngcolorshape == 3) randompanelb.BackgroundImage = Properties.Resources.greenCircle;
            if (rngcolorshape == 4) randompanelb.BackgroundImage = Properties.Resources.greenSquare;
            if (rngcolorshape == 5) randompanelb.BackgroundImage = Properties.Resources.greenTriangle;
            if (rngcolorshape == 6) randompanelb.BackgroundImage = Properties.Resources.redCircle;
            if (rngcolorshape == 7) randompanelb.BackgroundImage = Properties.Resources.redSquare;
            if (rngcolorshape == 8) randompanelb.BackgroundImage = Properties.Resources.redTriangle;
            gameboardpanels[b_x, b_y] = randompanelb;

            rngcolorshape = rng.Next(0, 9);
            if (rngcolorshape == 0) randompanelc.BackgroundImage = Properties.Resources.blueCircle;
            if (rngcolorshape == 1) randompanelc.BackgroundImage = Properties.Resources.blueSquare;
            if (rngcolorshape == 2) randompanelc.BackgroundImage = Properties.Resources.blueTriangle;
            if (rngcolorshape == 3) randompanelc.BackgroundImage = Properties.Resources.greenCircle;
            if (rngcolorshape == 4) randompanelc.BackgroundImage = Properties.Resources.greenSquare;
            if (rngcolorshape == 5) randompanelc.BackgroundImage = Properties.Resources.greenTriangle;
            if (rngcolorshape == 6) randompanelc.BackgroundImage = Properties.Resources.redCircle;
            if (rngcolorshape == 7) randompanelc.BackgroundImage = Properties.Resources.redSquare;
            if (rngcolorshape == 8) randompanelc.BackgroundImage = Properties.Resources.redTriangle;
            gameboardpanels[c_x, c_y] = randompanelc;

            drawgrid(tileSize, gridSize);
        }
        private void drawgrid(int tileSize, int gridSize)
        {
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    gameboardpanels[n, m].Location = new Point(tileSize * n, tileSize * m);

                    Controls.Add(gameboardpanels[n, m]);
                }
            }
        }
    }
}
