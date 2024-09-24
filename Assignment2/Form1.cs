using System.Diagnostics.Eventing.Reader;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        enum CarColor { Red, Blue, Black, White }
        private CarColor? selectedColor = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void carslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            if (carsListBox.SelectedIndex == -1)
            {
                purchaseSummary.ForeColor = Color.Red;
                purchaseSummary.Text = "You need to select a model car from the list.";
                return;
            }

            string selectedCar = carsListBox.SelectedItem.ToString();

            if (!int.TryParse(yearTextBox.Text, out int selectedYear))
            {
                purchaseSummary.ForeColor = Color.Red;
                purchaseSummary.Text = "You need to enter a valid year of the car.";
                return;
            }

            if (selectedColor == null)
            {
                purchaseSummary.ForeColor = Color.Red;
                purchaseSummary.Text = "There was an error, you need to select a color for the car.";
                return;
            }


            string colorText = selectedColor.ToString();

            switch (selectedColor)
            {
                case CarColor.Red:
                    colorText = "Red";
                    break;
                case CarColor.Blue:
                    colorText = "Blue";
                    break;
                case CarColor.Black:
                    colorText = "Black";
                    break;
                case CarColor.White:
                    colorText = "White";
                    break;
            }

            List<string> selectedFeatures = new List<string>();

            if (acCheckBox.Checked)
            {
                selectedFeatures.Add("AC");
            }
            if (syriusRadioCheckBox.Checked)
            {
                selectedFeatures.Add("Syrius Radio");
            }
            if (powerWindowsCheckBox.Checked)
            {
                selectedFeatures.Add("Power Windows");
            }
            if (laneAssistCheckBox.Checked)
            {
                selectedFeatures.Add("Lane Assist");
            }

            string features = selectedFeatures.Count > 0 ? string.Join(", ", selectedFeatures) : "No additional features";

            purchaseSummary.ForeColor = Color.Black;
            purchaseSummary.Text = $"You have purchased a {colorText} {selectedYear} {selectedCar} with the following features: {features}";



        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                selectedColor = CarColor.Red;
            }

        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRadioButton.Checked)
            {
                selectedColor = CarColor.Blue;
            }
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blackRadioButton.Checked)
            {
                selectedColor = CarColor.Black;
            }
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteRadioButton.Checked)
            {
                selectedColor = CarColor.White;
            }
        }
    }
}
