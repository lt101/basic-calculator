using CalculatorLibrary;
namespace WinFormsUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void compute_Click(object sender, EventArgs e)
    {
        float result = Calculator.Compute(firstValueText.Text, secondValueText.Text, operationType.Text);
        string message;
        if (result == -1)
        {
            message = "Error: please check the values and operation.";
        }
        else
        {
            message = $"The result is: {result}";
        }
        MessageBox.Show(message);
    }
}