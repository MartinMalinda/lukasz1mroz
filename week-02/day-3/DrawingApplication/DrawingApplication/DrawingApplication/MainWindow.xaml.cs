using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;


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

            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            // Create dictionary with list as corner points
            // Draw 4 triangles except 1 line

            // Didn't see the point of taking additional arguments
            linesToTheMiddle(foxDraw);

        }

        public void linesToTheMiddle(FoxDraw foxdraw)
        {
            double middle = Width / 2;
            var corners = new Dictionary<Char, List<int>>()
            {
                {'A', new List<int> () {0, 0} },
                {'B', new List<int> () {500, 0} },
                {'C', new List<int> () {500, 500} },
                {'D', new List<int> () {0, 500} },
            };

            for (int i = 0; i < 25; i++)
            {
                foxdraw.DrawLine(corners['A'][0], corners['A'][1], middle, middle);
                foxdraw.DrawLine(corners['B'][0], corners['B'][1], middle, middle);
                foxdraw.DrawLine(corners['C'][0], corners['C'][1], middle, middle);
                foxdraw.DrawLine(corners['D'][0], corners['D'][1], middle, middle);
                corners['A'][0] += 20;
                corners['B'][1] += 20;
                corners['C'][0] -= 20;
                corners['D'][1] -= 20;
            }
        }   

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}