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

            var dict = new Dictionary<Color, List<int>>()
            {
                { Colors.Beige, new List<int> () { 150, 100, 250, 100} },
                { Colors.Brown, new List<int>() { 250, 100, 250, 200 } },
                { Colors.Green, new List<int>() { 250, 200, 150, 200 } },
                { Colors.Black, new List<int>() { 150, 200, 150, 100 } },

                { Colors.Violet, new List<int> () { 170, 80, 270, 80} },
                { Colors.Tan, new List<int>() { 270, 80, 270, 180 } },
                { Colors.CadetBlue, new List<int>() { 270, 180, 170, 180 } },
                { Colors.DarkGoldenrod, new List<int>() { 170, 180, 170, 80 } },

                { Colors.RosyBrown, new List<int>() { 150, 100, 170, 80 } },
                { Colors.Salmon, new List<int>() { 250, 100, 270, 80 } },
                { Colors.Silver, new List<int>() { 250, 200, 270, 180 } },
                { Colors.Olive, new List<int>() { 150, 200, 170, 180 } }
            };

            foreach (var item in dict)
            {
                foxDraw.SetStrokeColor(item.Key);
                foxDraw.DrawLine(item.Value[0], item.Value[1], item.Value[2], item.Value[3]);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}