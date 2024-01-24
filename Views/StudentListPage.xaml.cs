using SQLiteDemo.ViewModels;

namespace SQLiteDemo.Views;

public partial class StudentListPage : ContentPage
{
    private StudentListPageViewModel _viewMode;
    public StudentListPage(StudentListPageViewModel viewModel)
	{
		InitializeComponent();
        _viewMode = viewModel;
        this.BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewMode.GetStudentListCommand.Execute(null);
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Trabajo realizado por: ", "Cristian Inchiglema", "Cancelar");

    }
}