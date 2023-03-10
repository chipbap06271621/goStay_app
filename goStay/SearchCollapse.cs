using System.Globalization;

namespace goStay;

public partial class SearchCollapse : ContentPage
{
    public object m_LastSelectViewCell { get; private set; }

    public SearchCollapse()
    {
        InitializeComponent();
        ModifyEntry();

    }

    void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
    }

    partial void ChangedHandler(object sender, EventArgs e);


    void ModifyEntry()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.SetSelectAllOnFocus(true);
#elif IOS || MACCATALYST
            handler.PlatformView.EditingDidBegin += (s, e) =>
            {
                handler.PlatformView.PerformSelector(new ObjCRuntime.Selector("selectAll"), null, 0.0f);
            };
#elif WINDOWS
            handler.PlatformView.GotFocus += (s, e) =>
            {
                handler.PlatformView.SelectAll();
            };
#endif
        });
    }
    //private void OnTapped(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new SelectRoom());
    //}
}