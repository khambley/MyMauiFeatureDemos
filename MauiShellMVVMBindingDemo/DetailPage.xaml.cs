using MauiShellMVVMBindingDemo.ViewModels;

namespace MauiShellMVVMBindingDemo;

public partial class DetailPage : ContentPage, IQueryAttributable
{

	public DetailPage()
	{
		InitializeComponent();
		BindingContext = new DetailViewModel();

	}

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		// Forward query attributes to the ViewModel
		(BindingContext as DetailViewModel)?.ApplyQueryAttributes(query);
	}
}
