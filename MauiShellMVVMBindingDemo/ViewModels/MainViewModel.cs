using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiShellMVVMBindingDemo.Models;

namespace MauiShellMVVMBindingDemo.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		private Item item;

		public MainViewModel()
		{
			Item = new Item();
		}

		[RelayCommand]
		private async Task NavigateToDetailPageAsync()
		{
			// Pass the updated item as a query parameter
			var navParameter = new Dictionary<string, object>
			{
				{"Item", Item }
			};

			await Shell.Current.GoToAsync("DetailPage", navParameter);
		}
	}
}

