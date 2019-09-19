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

            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.

            DrawThree(foxDraw, 200, 300);
        }

        public void DrawThree(FoxDraw foxDraw, int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                foxDraw.SetStrokeColor(Colors.Black);
                foxDraw.DrawLine(x, y, 250, 250);
                x += 50;
                y += 50;
            }
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}