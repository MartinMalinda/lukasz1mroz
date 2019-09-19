using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using GreenFox;
using System;
using System.Collections.Generic;
using System.Timers;


namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            canvas.Width = 500;
            canvas.Width = 500;

            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            DrawSquare(foxDraw, 20, 20);

        }

        public void DrawSquare(FoxDraw foxDraw, int x, int y)
        {

            for (int i = 0; i < 4; i++)
            {
                foxDraw.SetFillColor(Colors.LightSeaGreen);
                foxDraw.DrawRectangle(x, y, 50, 50);
                x += 70;
                y += 70;

            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}