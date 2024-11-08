using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace MauiHandlersDemo;
class MyBorderlessEntry : Entry
{

}
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        // Removes underline on Entry control on Android
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if __ANDROID__
            if (view is MyBorderlessEntry)
            {
                handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
            }            
#endif
        });

        MainPage = new AppShell();

	}
}

