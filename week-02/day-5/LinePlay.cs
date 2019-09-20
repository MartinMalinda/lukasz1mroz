using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;


namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public static void Strokes(FoxDraw foxdraw, int x, int y)
        {
            foxdraw.SetStrokeThicknes(1);

            for (int i = 0; i < 250; i++)
            {
                foxdraw.SetStrokeColor(Colors.DarkViolet);
                foxdraw.DrawLine(500, x, y, 0);
                foxdraw.SetStrokeColor(Colors.LightGreen);
                foxdraw.DrawLine(x, 500, 0, y);

                x += 20;
                y += 20;
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

            Strokes(foxDraw, 20, 20);

        } 

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}