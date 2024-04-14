namespace HomeRunLeaders.View;

public partial class MainPage : ContentPage
{
	public MainPage(LeadersViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}