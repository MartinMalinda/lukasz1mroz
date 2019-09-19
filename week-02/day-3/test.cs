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
            {
#if DEBUG
                this.AttachDevTools();
#endif
                var canvas = this.Get<Canvas>("canvas");
                var foxDraw = new FoxDraw(canvas);


                for (int i = 0; i < 5; i++)
                {
                    DrawFace(foxDraw, i*100, 50, Colors.Bisque);
                }
                

            }
        }

        public void DrawFace(FoxDraw foxDraw, int x, int y, Color color)
        {


            this.Height

            foxDraw.SetStrokeThicknes(2);
            foxDraw.SetFillColor(Colors.White);

            //draw head
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(x, y, 90, 110);


            // draw eye
            DrawEye(foxDraw, x + 10, y + 10);
            DrawEye(foxDraw, x + 50, y + 10);

            // draw mouth
            DrawMouth(foxDraw, x + 10, y + 70);

            // nose
            DrawNose(foxDraw, x + 40, y + 50);
        }

        public void DrawEye(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetFillColor(Colors.White);
            foxDraw.DrawRectangle(x, y, 30, 40);
        }

        public void DrawMouth(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetFillColor(Colors.Black);
            foxDraw.DrawRectangle(x, y, 70, 20);
        }

        public void DrawNose(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetFillColor(Colors.White);
            foxDraw.DrawRectangle(x, y, 10, 10);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}