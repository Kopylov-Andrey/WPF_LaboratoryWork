using System.Windows;
using System.Windows.Controls;


namespace Laboratory_Work2._3_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck deck = new Deck();
        Image[] positions = new Image[54];
        int backIndex = 0;
        int frontIndex = 0;

        public MainWindow()
        {
            Deck deck = new Deck();
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    InitBackImage(i, j, positions[backIndex]);
                }
            }
            backIndex = 0;
        }

       
       
        private void InitFrontImage(int i, int j, Image card)
        {
            frontIndex = (frontIndex > 54) ? frontIndex = 1 : frontIndex;
            card = deck.GetCard(frontIndex).GetImage(true);
            OutputImage(card, i, j);
            frontIndex++;
        }

        
        private void InitBackImage(int i, int j ,Image card)
        {
            card = deck.GetCard(backIndex).GetImage(false);
            OutputImage(card, i, j);
            backIndex++;
        }


        private void OutputImage(Image card, int i, int j)
        {
            card.Margin = new Thickness(10, 1, 10, 1);
            MainGrid.Children.Add(card);
            Grid.SetColumn(card, i);
            Grid.SetRow(card, j);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    InitFrontImage(i, j, positions[frontIndex]);
                }
            }
            frontIndex = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            deck.Shuffle();
            MainGrid.Children.Clear();
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    positions[index] = deck.GetCard(index).GetImage(true);

                    MainGrid.Children.Add(positions[index]);
                    Grid.SetColumn(positions[index], i);
                    Grid.SetRow(positions[index], j);
                    index++;
                }
            }

        }
    }
}
