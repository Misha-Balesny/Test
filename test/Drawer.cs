using System.Collections.ObjectModel;

namespace test
{
    internal class Drawer
    {
        public static void Draw(ObservableCollection<LineModel> lines, UserModel user)
        {
            System.Windows.Media.Brush color = null;
            lines.Clear();
            DrawAxis(lines);
            int day = 0;
            foreach (var item in user.DayInfo)
            {
                if (item.Steps == user.Best) { color = System.Windows.Media.Brushes.Green; }
                if (item.Steps == user.Worst) { color = System.Windows.Media.Brushes.Red; }
                if (item.Steps != user.Worst && item.Steps != user.Best) { color = System.Windows.Media.Brushes.Blue; }
                day++;
                lines.Add(new LineModel()
                {
                    X1 = day*12+20,
                    X2 = day*12+20,
                    Y1 = 350,
                    Y2 = 350-(item.Steps/1000)*3,                    
                    Color = color,
                    Thickness = 5,
                });
            }
        }

        public static void DrawAxis(ObservableCollection<LineModel> Lines) 
        {
            Lines.Add(new LineModel()
            {
                X1 = 10,
                X2 = 10,
                Y1 = 10,
                Y2 = 350,
                Color = System.Windows.Media.Brushes.Black,
                Thickness = 2,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 350,
                Y2 = 350,
                Color = System.Windows.Media.Brushes.Black,
                Thickness = 2,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 320,
                Y2 = 320,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 290,
                Y2 = 290,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 260,
                Y2 = 260,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 230,
                Y2 = 230,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 200,
                Y2 = 200,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 170,
                Y2 = 170,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 140,
                Y2 = 140,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 110,
                Y2 = 110,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 80,
                Y2 = 80,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 50,
                Y2 = 50,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
            Lines.Add(new LineModel()
            {
                X1 = 400,
                X2 = 10,
                Y1 = 20,
                Y2 = 20,
                Color = System.Windows.Media.Brushes.DimGray,
                Thickness = 1,
            });
        }
    }
}
