using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Prism.Commands;
using Prism.Mvvm;
using WpfApp1.Model;


namespace WpfApp1.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private Model.Model model = new Model.Model();
        private ComboBoxItem selectedComboBoxItem;
        private object selectedFugire;
        public ComboBoxItem SelectedComboBoxItem
        {
            get
            {
                return selectedComboBoxItem;
            }
            set
            {
                selectedComboBoxItem = value;
                RaisePropertyChanged(nameof(SelectedComboBoxItem));
            }
        }

        public object SelectedFigure
        {
            get { return selectedFugire; }
            set
            {
                selectedFugire = value;
                RaisePropertyChanged(nameof(SelectedFigure));
            }
        }

        public ReadOnlyObservableCollection<Figure> Figures => model.Figures;
        public MainViewModel()
        {
            model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            ChangeComboBoxCommand = new DelegateCommand<object[]>(s => ChangeComboBox(s));
            DrawCommand = new DelegateCommand<object[]>(s => Draw(s));
        }

        public DelegateCommand<object[]> ChangeComboBoxCommand { get; }
        public DelegateCommand<object[]> DrawCommand { get; }
        public DelegateCommand<object[]> SelectedFigureCommand { get; }


        private void SelectedFigureFunc(object[] items)
        {

        }

        /// <summary>
        /// Функция смены значения в комбобоксе
        /// </summary>
        /// <param name="items">массив параметров</param>
        private void ChangeComboBox(object[] items)
        {
            (items[4] as Canvas).Children.Clear();
            if (selectedComboBoxItem.Content.ToString()  == "Круг")
            {
                (items[1] as TextBlock).Text = "Радиус";
                (items[2] as TextBlock).Text = "ОТСУТСТВУЕТ";
                (items[3] as TextBox).IsEnabled = false;
            }
            else if (selectedComboBoxItem.Content.ToString() == "Эллипс")
            {
                (items[1] as TextBlock).Text = "Радиус малый";
                (items[2] as TextBlock).Text = "Радиус большой";
                (items[3] as TextBox).IsEnabled = true;
            }
            else if (selectedComboBoxItem.Content.ToString() == "Квадрат")
            {
                (items[1] as TextBlock).Text = "Длина";
                (items[2] as TextBlock).Text = "ОТСУТСТВУЕТ";
                (items[3] as TextBox).IsEnabled = false;
            }
            else if (selectedComboBoxItem.Content.ToString() == "Прямоугольник")
            {
                (items[1] as TextBlock).Text = "Ширина";
                (items[2] as TextBlock).Text = "Длина";
                (items[3] as TextBox).IsEnabled = true;
            }
        }
        
        /// <summary>
        /// Функция рисования фигуры
        /// </summary>
        /// <param name="s">массив параметров</param>
        private void Draw(object[] s)
        {
            try
            {

            (s[0] as Canvas).Children.Clear();
            double width = double.Parse(s[1].ToString());
            double height = 0;
            if (string.IsNullOrEmpty(s[2].ToString()))
                height = width;
            else
                height = double.Parse(s[2].ToString());
            (s[0] as Canvas).Children.Add(model.DrawFigure(width, height, (s[3] as ComboBoxItem).Content.ToString(), "Green"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}