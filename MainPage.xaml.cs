
using Microsoft.Maui.Controls.Internals;

namespace Maui_Example;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		string recipt = "";

		recipt += txtSWName.Text + "\n\n";

		// Bread Order
		recipt += SelectedBread();
        recipt += "\n";
        // Toppings
        foreach (string topping in SelectedToppings())
		{
			recipt += topping + "\n";
		}
        recipt += "\n";


        rtbOrder.Text = recipt;
	}

	private List<string> SelectedToppings()
	{
		List<string> temp = new List<string>();
		temp.Add("Toppings: ");
		if (ckMeat.IsChecked) temp.Add("Meat");
		if (ckCheese.IsChecked) temp.Add("Cheese");
		if (ckTomato.IsChecked) temp.Add("Tomato");
		if (ckLettuce.IsChecked) temp.Add("Lettuce");

		return temp;
    }

	private string SelectedBread()
	{
		string breadOrder = "Bread:\n";
		if(rbWheat.IsChecked)
		{
			breadOrder += "White\n";
		}
        else if (rbWheat.IsChecked)
        {
            breadOrder += "Wheat\n";
        }
        else if (rbRosemary.IsChecked)
        {
            breadOrder += "Rosemary\n";
        }
        else
        {
            breadOrder += "Glutten Free\n";
        }

		return breadOrder;
    }
}

