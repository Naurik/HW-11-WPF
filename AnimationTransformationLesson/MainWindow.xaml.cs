using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimationTransformationLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = progressBar.Minimum;
            animation.To = progressBar.Maximum;
            animation.Completed += Animation_Completed;
            animation.Duration = new Duration(TimeSpan.FromSeconds(5));
            //animation.AutoReverse = true;


            Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(animation);
                Storyboard.SetTargetName(animation, progressBar.Name);
                Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));
                storyboard.Begin(this);
            

        }
        private void Animation_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Загрузка завершена");
        }
    }
}
