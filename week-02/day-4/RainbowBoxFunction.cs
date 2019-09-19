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

            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            RainbowSquares(foxDraw, Colors.Blue, 60);


        }

        public void RainbowSquares(FoxDraw foxdraw, Color color, int size )
        {
            List<Color> rainbow = new List<Color> { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };
            double startX = (Width / 2) - (size / 2);
            double startY = (Height / 2) - (size / 2);

            foxdraw.SetFillColor(color);
            foxdraw.DrawRectangle(startX, startY, size, size);

            for (int i = 0; i < 7; i++)
            {
                Random rnd = new Random();
                int rndX = rnd.Next(50, 450);
                int rndY = rnd.Next(50, 450);
                foxdraw.SetFillColor(rainbow[i]);
                foxdraw.DrawRectangle(rndX, rndY, size, size);
            }

            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}