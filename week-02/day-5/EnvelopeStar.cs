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
        public static void Strokes(FoxDraw foxdraw)
        {
            // Divide the canva for 4 fields
            // Calculate starting points and movement 
            // Put everything in 1 function
            int middle = 250;
            int midX = 250;
            int maxY = 500;
            int border = 0;
            foxdraw.SetStrokeThicknes(1);
            foxdraw.SetStrokeColor(Colors.LightGreen);
            for (int i = 0; i < 13; i++)
            {
                foxdraw.DrawLine(250, border, middle + 20, 250);
                foxdraw.DrawLine(250, border, midX - 20, 250);
                foxdraw.DrawLine(250, maxY, midX -20, 250);
                foxdraw.DrawLine(250, maxY, middle + 20, 250);
                middle += 20;
                border += 20;
                midX -= 20;
                maxY -= 20;
            }   
        }
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            Strokes(foxDraw);
        } 
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
