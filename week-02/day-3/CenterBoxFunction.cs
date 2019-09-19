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

            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            DrawSquare(foxDraw, 30);
        }

        public void DrawSquare(FoxDraw foxDraw, int size)
        {
            var startX = Width / 2 - size / 2;
            double startY = Height / 2 - size / 2;

            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawRectangle(startX, startY, size, size);
                startX += 40;
                startY += 40;
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}