using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class gamescreen : Form
    {
        // Define grid sizes
        int gridSizeX;
        int gridSizeY;
        int score = 0;
        int reward;

        bool isCircleTicked = false, isSquareTicked = false, isTriangleTicked = false, isRedColorTicked = false, isGreenColorTicked = false, isBlueColorTicked = false;

        private Panel[,] drawingPanels;
        Panel selectedPanel = new Panel();
        string[,] gameboardpanels;
        const int tileSize = 42;
        bool selectedFlag = false;
        int selectedX, selectedY;
        string selectedType;
        int latestHighScore;
        int allPeopleHighestScore;

        public gamescreen()
        {
            InitializeComponent();
            
            // Get grid size, shape and color options from DB
            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query = "SELECT US.xSize, US.ySize, US.squareShapeTicked, US.triangleShapeTicked, US.circleShapeTicked, US.redColorTicked, US.greenColorTicked, US.blueColorTicked, US.highestScore " +
                "FROM Users AS U, UserSettings AS US " +
                "WHERE U.UID = US.UID AND @uid = US.UID;";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@uid", SqlDbType.Int, 100).Value = Form1.UID;
            cmd.CommandText = query;
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                gridSizeX = Int32.Parse(rdr["xSize"].ToString());
                gridSizeY = Int32.Parse(rdr["ySize"].ToString());
                latestHighScore = Int32.Parse(rdr["highestScore"].ToString());

                if (Int32.Parse(rdr["squareShapeTicked"].ToString()) == 1) isSquareTicked = true;
                if (Int32.Parse(rdr["triangleShapeTicked"].ToString()) == 1) isTriangleTicked = true;
                if (Int32.Parse(rdr["circleShapeTicked"].ToString()) == 1) isCircleTicked = true;

                if (Int32.Parse(rdr["redColorTicked"].ToString()) == 1) isRedColorTicked = true;
                if (Int32.Parse(rdr["greenColorTicked"].ToString()) == 1) isGreenColorTicked = true;
                if (Int32.Parse(rdr["blueColorTicked"].ToString()) == 1) isBlueColorTicked = true;

            }
            cnn.Close();

            SqlConnection cnn2 = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query2 = "SELECT MAX(highestScore) " +
                "FROM UserSettings;";
            SqlCommand cmd2 = new SqlCommand(query2, cnn2);
            cmd2.CommandText = query2;
            cnn2.Open();
            allPeopleHighestScore = Int32.Parse(cmd2.ExecuteScalar().ToString());
            lbHighest.Text += allPeopleHighestScore.ToString();
            cnn2.Close();

            if (gridSizeX == 15 && gridSizeY == 15) reward = 1;
            if (gridSizeX == 9 && gridSizeY == 9) reward = 3;
            if (gridSizeX == 6 && gridSizeY == 6) reward = 5;
            else reward = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkmatch(gridSizeX, gridSizeY);
            drawgrid(tileSize,gridSizeX,gridSizeY);
        }

        private void gamescreen_Load(object sender, EventArgs e)
        {
            // initialize the game grid
            gameboardpanels = new string[gridSizeX, gridSizeY];
            drawingPanels = new Panel[gridSizeX, gridSizeY];

            // double for loop to handle all rows and columns
            for (var n = 0; n < gridSizeX; n++)
            {
                for (var m = 0; m < gridSizeY; m++)
                {
                    gameboardpanels[n, m] = "empty";
                    drawingPanels[n, m] = new Panel {Size = new Size(tileSize, tileSize), BackgroundImage = Properties.Resources.empty, Name = n + " " + m};
                    this.selectedPanel = drawingPanels[n, m];
                    selectedPanel.Click += drawingPanels_Click;
                }
            }

            generateThreeObjects(gridSizeX, gridSizeY);
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            LeaderBoard lb = new LeaderBoard();
            lb.ShowDialog();
        }

        private void generateThreeObjects(int gridSizeX, int gridSizeY)
        {
            
            // Get unique locations for each 3 objects and put them into string array
            Random rng = new Random();
            string randoma = "";

            string[] shapes = new string[5];
            int shapescount = 0;
            string[] colors = new string[5];
            int colorcount = 0;

            // SHAPES
            if (!isCircleTicked && !isSquareTicked && !isTriangleTicked || isCircleTicked && isSquareTicked && isTriangleTicked)
            {
                shapes[0] = "Circle";
                shapes[1] = "Square";
                shapes[2] = "Triangle";
                shapescount = 3;
            }

            if (isCircleTicked && !isSquareTicked && !isTriangleTicked)
            {
                shapes[0] = "Circle";
                shapescount = 1;
            }

            if (!isCircleTicked && isSquareTicked && !isTriangleTicked)
            {
                shapes[0] = "Square";
                shapescount = 1;
            }

            if (!isCircleTicked && !isSquareTicked && isTriangleTicked)
            {
                shapes[0] = "Triangle";
                shapescount = 1;
            }

            if (isCircleTicked && isSquareTicked && !isTriangleTicked)
            {
                shapes[0] = "Circle";
                shapes[1] = "Square";
                shapescount = 2;
            }

            if (isCircleTicked && !isSquareTicked && isTriangleTicked)
            {
                shapes[0] = "Circle";
                shapes[1] = "Triangle";
                shapescount = 2;
            }

            if (!isCircleTicked && isSquareTicked && isTriangleTicked)
            {
                shapes[0] = "Square";
                shapes[1] = "Triangle";
                shapescount = 2;
            }

            // COLORS
            if (!isRedColorTicked && !isGreenColorTicked && !isBlueColorTicked || isRedColorTicked && isGreenColorTicked && isBlueColorTicked)
            {
                colors[0] = "red";
                colors[1] = "green";
                colors[2] = "blue";
                colorcount = 3;
            }

            if (isRedColorTicked && !isGreenColorTicked && !isBlueColorTicked)
            {
                colors[0] = "red";
                colorcount = 1;
            }

            if (!isRedColorTicked && isGreenColorTicked && !isBlueColorTicked)
            {
                colors[0] = "green";
                colorcount = 1;
            }

            if (!isRedColorTicked && !isGreenColorTicked && isBlueColorTicked)
            {
                colors[0] = "blue";
                colorcount = 1;
            }

            if (isRedColorTicked && isGreenColorTicked && !isBlueColorTicked)
            {
                colors[0] = "red";
                colors[1] = "green";
                colorcount = 2;
            }

            if (isRedColorTicked && !isGreenColorTicked && isBlueColorTicked)
            {
                colors[0] = "red";
                colors[1] = "blue";
                colorcount = 2;
            }

            if (!isRedColorTicked && isGreenColorTicked && isBlueColorTicked)
            {
                colors[0] = "green";
                colors[1] = "blue";
                colorcount = 2;
            }
            int emptycount = getemptycount(gridSizeX, gridSizeY);

            if (emptycount < 3)
            {
                for (int i = 0; i < emptycount; i++)
                {
                    int rngShape = rng.Next(0, shapescount);
                    int rngColor = rng.Next(0, colorcount);
                    randoma = colors[rngColor] + shapes[rngShape];



                    int a_x = rng.Next(0, gridSizeX);
                    int a_y = rng.Next(0, gridSizeY);

                    while (gameboardpanels[a_x, a_y] != "empty")
                    {
                        a_x = rng.Next(0, gridSizeX);
                        a_y = rng.Next(0, gridSizeY);
                    }

                    gameboardpanels[a_x, a_y] = randoma;
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int rngShape = rng.Next(0, shapescount);
                    int rngColor = rng.Next(0, colorcount);
                    randoma = colors[rngColor] + shapes[rngShape];



                    int a_x = rng.Next(0, gridSizeX);
                    int a_y = rng.Next(0, gridSizeY);

                    while (gameboardpanels[a_x, a_y] != "empty")
                    {
                        a_x = rng.Next(0, gridSizeX);
                        a_y = rng.Next(0, gridSizeY);
                    }

                    gameboardpanels[a_x, a_y] = randoma;
                }
            }

            drawgrid(tileSize, gridSizeX, gridSizeY);
        }

        private void startbttn_Click(object sender, EventArgs e)
        {
        }
        private void drawingPanels_Click(object sender, EventArgs e)
        {
            Panel thisPanel = sender as Panel;
            string[] tokens = thisPanel.Name.Split(' ');
            int n = Int32.Parse(tokens[0]), m = Int32.Parse(tokens[1]);

            // first click
            if (selectedFlag == false && gameboardpanels[n, m] != "empty")
            {
                selectedType = gameboardpanels[n, m];
                gameboardpanels[n, m] += "Selected";
                selectedFlag = true;
                selectedX = n;
                selectedY = m;
            }
            // second click
            else if (selectedFlag == true)
            {
                // if the selected destination square is empty, move it, otherwise don't
                if (gameboardpanels[n, m] == "empty")
                {
                    gameboardpanels[selectedX, selectedY] = "empty";
                    gameboardpanels[n, m] = selectedType;
                    selectedFlag = false;
                    generateThreeObjects(gridSizeX, gridSizeY);
                }
                else if (gameboardpanels[n, m] == "blueCircleSelected" || gameboardpanels[n, m] == "blueSquareSelected" || gameboardpanels[n, m] == "blueTriangleSelected" || gameboardpanels[n, m] == "greenCircleSelected" || gameboardpanels[n, m] == "greenSquareSelected" || gameboardpanels[n, m] == "greenTriangleSelected" || gameboardpanels[n, m] == "redCircleSelected" || gameboardpanels[n, m] == "redSquareSelected" || gameboardpanels[n, m] == "redTriangleSelected")
                {
                    string temp="" ;
                    temp = (gameboardpanels[n, m].Remove(gameboardpanels[n, m].Length - 8));
                    gameboardpanels[n, m] = temp;
                    selectedFlag = false;
                }

                int emptyCount = getemptycount(gridSizeX, gridSizeY);

                // GAME OVER SCREEN
                if (emptyCount == 0)
                {
                    MessageBox.Show("GAME OVER!");
                    if (score > latestHighScore)
                    {
                        SqlConnection cnn2 = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
                        string query2 = "UPDATE UserSettings " +
                            "SET highestScore = @score " +
                            "WHERE UID = @uid";
                        SqlCommand cmd2 = new SqlCommand(query2, cnn2);
                        cmd2.Parameters.Add("@score", SqlDbType.Int, 100).Value = score;
                        cmd2.Parameters.Add("@uid", SqlDbType.Int, 100).Value = Form1.UID;
                        cnn2.Open();
                        cmd2.CommandText = query2;
                        cmd2.ExecuteNonQuery();
                        cnn2.Close();
                    }
                }

            }

            drawgrid(tileSize, gridSizeX, gridSizeY);
            checkmatch(gridSizeX,gridSizeY);
            drawgrid(tileSize, gridSizeX, gridSizeY);

        }

        private void drawgrid(int tileSize, int gridSizeX, int gridSizeY)
        {
            for (var n = 0; n < gridSizeX; n++)
            {
                for (var m = 0; m < gridSizeY; m++)
                {
                    if (gameboardpanels[n, m] == "empty") drawingPanels[n, m].BackgroundImage = Properties.Resources.empty;
                    if (gameboardpanels[n, m] == "blueCircle") drawingPanels[n, m].BackgroundImage = Properties.Resources.blueCircle;
                    if (gameboardpanels[n, m] == "blueSquare") drawingPanels[n, m].BackgroundImage = Properties.Resources.blueSquare;
                    if (gameboardpanels[n, m] == "blueTriangle") drawingPanels[n, m].BackgroundImage = Properties.Resources.blueTriangle;
                    if (gameboardpanels[n, m] == "greenCircle") drawingPanels[n, m].BackgroundImage = Properties.Resources.greenCircle;
                    if (gameboardpanels[n, m] == "greenSquare") drawingPanels[n, m].BackgroundImage = Properties.Resources.greenSquare;
                    if (gameboardpanels[n, m] == "greenTriangle") drawingPanels[n, m].BackgroundImage = Properties.Resources.greenTriangle;
                    if (gameboardpanels[n, m] == "redCircle") drawingPanels[n, m].BackgroundImage = Properties.Resources.redCircle;
                    if (gameboardpanels[n, m] == "redSquare") drawingPanels[n, m].BackgroundImage = Properties.Resources.redSquare;
                    if (gameboardpanels[n, m] == "redTriangle") drawingPanels[n, m].BackgroundImage = Properties.Resources.redTriangle;
                    if (gameboardpanels[n, m] == "blueCircleSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.blueCircle_Selected;
                    if (gameboardpanels[n, m] == "blueSquareSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.blueSquare_Selected;
                    if (gameboardpanels[n, m] == "blueTriangleSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.blueTriangle_Selected;
                    if (gameboardpanels[n, m] == "greenCircleSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.greenCircle_Selected;
                    if (gameboardpanels[n, m] == "greenSquareSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.greenSquare_Selected;
                    if (gameboardpanels[n, m] == "greenTriangleSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.greenTriangle_Selected;
                    if (gameboardpanels[n, m] == "redCircleSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.redCircle_Selected;
                    if (gameboardpanels[n, m] == "redSquareSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.redSquare_Selected;
                    if (gameboardpanels[n, m] == "redTriangleSelected") drawingPanels[n, m].BackgroundImage = Properties.Resources.redTriangle_Selected;

                    int px = this.ClientSize.Width / 2 - (tileSize * gridSizeX / 2);
                    int py = this.ClientSize.Height / 2 - (tileSize * gridSizeY / 2);
                    drawingPanels[n, m].Location = new Point(px + tileSize * n, py + tileSize * m);
                    Controls.Add(drawingPanels[n, m]);
                }
            }
            lblScore.Text = "Score: " + score;

        }
        private void checkmatch(int gridSizeX, int gridSizeY)
        {
            string thisblock = "";
            for (var n = 0; n < gridSizeX; n++)
            {
                for (var m = 0; m < gridSizeY; m++)
                {
                    thisblock=gameboardpanels[n, m];
                    //checkright
                    if (n + 4 < gridSizeX)
                    {
                        if(thisblock ==gameboardpanels[n+1, m] && thisblock != "empty")
                        {
                           if (thisblock ==gameboardpanels[n+2, m])
                            {
                                if(thisblock==gameboardpanels[n+3, m])
                                {
                                    if(thisblock ==gameboardpanels[n+4, m])
                                    {
                                        gameboardpanels[n + 4, m] = "empty";
                                        gameboardpanels[n + 3, m] = "empty";
                                        gameboardpanels[n + 2, m] = "empty";
                                        gameboardpanels[n + 1, m] = "empty";
                                        gameboardpanels[n, m] = "empty";
                                        score += reward;
                                    }
                                }
                            }
                        }
                    }
                    //checkbottom
                    if (m + 4 < gridSizeX)
                    {
                        if (thisblock == gameboardpanels[n, m+1] && thisblock != "empty")
                        {
                            if (thisblock == gameboardpanels[n, m+2])
                            {
                                if (thisblock == gameboardpanels[n, m+3])
                                {
                                    if (thisblock == gameboardpanels[n, m+4])
                                    {
                                        gameboardpanels[n, m + 4] = "empty";
                                        gameboardpanels[n, m + 3] = "empty";
                                        gameboardpanels[n, m + 2] = "empty";
                                        gameboardpanels[n, m + 1] = "empty";
                                        gameboardpanels[n, m] = "empty";
                                        score += reward;
                                    }
                                }
                            }
                        }
                    }



                }
            }
        }
        private int getemptycount(int gridSizeX, int gridSizeY)
        {
            int emptycount=0;
            for(int i=0; i<gridSizeX; i++)
            {
                for(int j=0; j<gridSizeY; j++)
                {
                    if(gameboardpanels[i,j] == "empty") emptycount++;
                }
            }
            
            return emptycount;
        }
    }
}
