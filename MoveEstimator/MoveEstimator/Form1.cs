namespace MoveEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare Variables 
            int hoursWorked, milesDriven, costEstimate = 0;


            //Read Input and Store In Variables 
            hoursWorked = int.Parse(hrsTxt.Text);
            milesDriven = int.Parse(milesTxt.Text);

            //Do Calculation
            costEstimate = 200 + hoursWorked * 150 + milesDriven * 2;

            //Display Result

            costTxt.Text = costEstimate.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hrsTxt.Text = "";
            milesTxt.Text = "";
            costTxt.Text = "";
        }
    }
}
