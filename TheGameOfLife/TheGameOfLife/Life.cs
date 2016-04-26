using System;
using System.Drawing;
using GDIDrawer;

namespace AZielsdorf_Lab02
{
    class Life
    {
        public static bool debug = false;
        public static int cycleCount = 0;
        public static int genCount = 1000;
        public static byte[,] lifeArray;
        public static Color cellColour = Color.Orange;


        public static void InitalLife(CDrawer canvas)
        {
            lifeArray = new byte[canvas.m_ciWidth / canvas.Scale, canvas.m_ciHeight / canvas.Scale];
            CreateLife();
            DisplayLife(canvas);
        }

        public static void ClearLife(CDrawer canvas)
        {
            cycleCount = 0;
            Array.Clear(lifeArray, 0, lifeArray.Length);
            DisplayLife(canvas);
        }

        public static void CreateLife() //Creates a new array of life.
        {
            int x;
            int y;
            Random rand = new Random();

            for (int i = 0; i < genCount; i++)
            {
                do
                {
                    x = rand.Next(0, lifeArray.GetLength(0));
                    y = rand.Next(0, lifeArray.GetLength(1));
                }
                while (lifeArray[x, y] == 1);

                lifeArray[x, y] = 1;
            }
        }
        public static void DisplayLife(CDrawer canvas) //Displays life as is and renders it to screen.
        {
            canvas.Clear();
            for (int x = 0; x < lifeArray.GetLength(0); x++)
                for (int y = 0; y < lifeArray.GetLength(1); y++)
                {
                    if (lifeArray[x, y] == 1)
                        canvas.AddRectangle(x, y, 1, 1, cellColour);
                    if (debug)
                    {
                        if (y == 0) canvas.AddText(string.Format("{0}", x), 5, x, y, 1, 1, Color.Blue);
                        if (x == 0) canvas.AddText(string.Format("{0}", y), 5, x, y, 1, 1, Color.Blue);
                    }
                }
            canvas.Render();
        }
        public static void CycleLife(CDrawer canvas) //Cycles life in array.
        {
            DisplayLife(canvas);
            byte[,] cycledArray = new byte[lifeArray.GetLength(0), lifeArray.GetLength(1)];
            int neighbour = 0;
            int X = 0;
            int Y = 0;

            for (int y = 0; y < lifeArray.GetLength(1); y++)
            {
                for (int x = 0; x < lifeArray.GetLength(0); x++)
                {
                    neighbour = 0;
                    for (int b = -1; b <= 1; b++) // Checks each surronding cell
                        for (int a = -1; a <= 1; a++)
                        {
                            X = x + a; // X pos in relation to x
                            Y = y + b; // Y pos in relation to y

                            // Wrapping
                            X = X < 0 ? lifeArray.GetLength(0) - 1 : X; // if x is below 0, go to row max
                            Y = Y < 0 ? lifeArray.GetLength(1) - 1 : Y; // if y is below 0, go to column max
                            X = X > lifeArray.GetLength(0) - 1 ? 0 : X; // if x is above row max, go to 0
                            Y = Y > lifeArray.GetLength(1) - 1 ? 0 : Y; // if y is above column max, go to 0

                            if (lifeArray[X, Y] == 1) // If cell in relation is alive
                                if (a + b != 0 || a - b != 0) // And not the main p.o.i.
                                    neighbour++; //Counts number of neighbours
                        }
                    switch (neighbour)
                    {
                        case 2: //Cell persists only if already alive
                            if (lifeArray[x, y] == 1)
                                cycledArray[x, y] = 1;
                            break;
                        case 3: //Cell persists / spawns if dead
                            cycledArray[x, y] = 1;
                            break;
                        default: //Every other case, cell dies.
                            cycledArray[x, y] = 0;
                            break;
                    }
                }
            }
            cycleCount++;

            lifeArray = cycledArray;
        }

        public static void canvas_MouseLeftClick(Point click, CDrawer canvas)
        {
            click.X /= canvas.Scale;
            click.Y /= canvas.Scale;
            if (lifeArray[click.X, click.Y] == 0)
            {
                lifeArray[click.X, click.Y] = 1;
                canvas.AddRectangle(click.X, click.Y, 1, 1, Color.White, 1, cellColour);
            }
            else if (lifeArray[click.X, click.Y] == 1)
            {
                lifeArray[click.X, click.Y] = 0;
                canvas.AddRectangle(click.X, click.Y, 1, 1, Color.Black, 1, Color.Black);
            }
            canvas.Render();
        }
    }
}
