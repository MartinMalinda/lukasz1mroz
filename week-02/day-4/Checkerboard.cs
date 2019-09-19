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

            // Make the checkerboard pattern 

            checkerboard(foxDraw, 50);

        }

        public void checkerboard(FoxDraw foxdraw, int size)
        {
            foxdraw.SetBackgroundColor(Colors.White);
            foxdraw.SetFillColor(Colors.Black);

            int x = 0;
            int y = 0;

            for (int i = 0; i < Width / size; i++) // Iterating through Y axis
            {

                y = i % 2 != 0 ? size : 0;
                
                for (int j = 0; j < (Height / size)/2; j++) // Iterating through X axis
                    {
                        foxdraw.DrawRectangle(x, y, size, size);
                        y += (size * 2); // Drawing every second black
                    }

            x += size; // Moving with column

            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}