using AppStore.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStore.Views
{
    /// <summary>
    /// Defines the <see cref="TodayView" />
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodayView : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodayView"/> class.
        /// </summary>
        public TodayView()
        {
            InitializeComponent();

            List<Today> todayData = new List<Today>
            {
                new Today { Category = "お気に入り", Explain = "今週おすすめの\nゲーム５選", ImageUrl = "game1.jpeg" },
                new Today { Category = "おすすめ", Explain = "今日の\nApp", ImageUrl = "game2.jfif" },
                new Today { Category = "おすすめ", Explain = "今日の\nゲーム", ImageUrl = "game3.jfif" },
                new Today { Category = "おすすめ", Explain = "今週のApple Arcade\nトップゲーム", ImageUrl = "game4.jfif" }
            };

            _today.ItemsSource = todayData;
        }
    }
}
