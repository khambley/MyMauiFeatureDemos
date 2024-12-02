using System;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiShellMVVMBindingDemo.Models;

namespace MauiShellMVVMBindingDemo.ViewModels
{

	public partial class DetailViewModel : ObservableObject
	{
        [ObservableProperty]
        private Item item;

        public DetailViewModel()
		{
			Item = new Item();
		}

		public void ApplyQueryAttributes(IDictionary<string, object> query)
		{
			if (query.ContainsKey("Item"))
			{
				Item = query["Item"] as Item;
			}
		}
	}
}

