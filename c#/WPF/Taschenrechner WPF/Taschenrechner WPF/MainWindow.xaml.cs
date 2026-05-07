using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner_WPF;

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Threading;
public partial class MainWindow : Window
{
    private double firstNumber;
    private string currentOperator;
    double result;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button btn = sender as Button;
        Display.Text += btn.Content.ToString();
    }

    private void Operator_Click(object sender, RoutedEventArgs e)
    {
        Button btn = sender as Button;
        firstNumber = double.Parse(Display.Text);
        currentOperator = btn.Content.ToString();
        Display.Clear();
    }

    private void Equals_Click(object sender, RoutedEventArgs e)
    {
        double secondNumber = double.Parse(Display.Text);
        switch (currentOperator)
        
        {
            case "+": result = firstNumber + secondNumber; break;
            case "-": result = firstNumber - secondNumber; break;
            case "*": result = firstNumber * secondNumber; break;
            case "/": result = firstNumber / secondNumber; break;
        }

        Display.Text = result.ToString();

    }

    private void Clear_Click(object sender, RoutedEventArgs e)
    {
        Display.Clear();
        firstNumber = 0;
        currentOperator = "";
        result = 0;
    }
    

}