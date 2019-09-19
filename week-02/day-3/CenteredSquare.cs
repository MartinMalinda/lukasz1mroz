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

            // Draw a green 10x10 square to the canvas' center.

            DrawSquare(foxDraw);

        }
        public void DrawSquare(FoxDraw foxDraw)
        {

            double startX = (Width / 2) - 5;
            double startY = (Height / 2) - 5;

            foxDraw.SetFillColor(Colors.LightSeaGreen);
            foxDraw.DrawRectangle(startX, startY, 20, 20);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}