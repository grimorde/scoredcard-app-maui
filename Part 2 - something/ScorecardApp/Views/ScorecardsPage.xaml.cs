namespace ScorecardApp.Views;

public partial class ScorecardsPage : ContentPage
{
	public ScorecardsPage(ScorecardsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
