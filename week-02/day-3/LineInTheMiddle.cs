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
            canvas.Width = 400;
            canvas.Height = 400;
            

            DrawLine(foxDraw);

        }

        public static void DrawLine(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.DrawLine(0, 200, 200, 200);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(200, 0, 200, 200);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}