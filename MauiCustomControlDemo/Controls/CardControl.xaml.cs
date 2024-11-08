namespace MauiCustomControlDemo.Controls;

public partial class CardControl : ContentView
{
	public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControl));

	public CardControl()
	{
		InitializeComponent();
	}

	public string Title
	{
		get => GetValue(TitleProperty) as string;
		set => SetValue(TitleProperty, value);
	}
}
