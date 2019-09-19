using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;


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

            DrawRow(foxDraw);


        }

        public void DrawRow(FoxDraw foxdraw)
        {
            int x = 15;
            int y = 15;
            int size = 15;

            for (int i = 0; i < 7; i++)
            {
                x += size;
                y += size;
                size += 10;

                foxdraw.SetFillColor(Colors.DarkViolet);
                foxdraw.SetStrokeThicknes(1);
                foxdraw.SetStrokeColor(Colors.Black);
                foxdraw.DrawRectangle(x, y, size, size);   
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}