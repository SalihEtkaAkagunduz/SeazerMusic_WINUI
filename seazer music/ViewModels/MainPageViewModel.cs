using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using seazer_music.Class; // Models.BasicList için

namespace seazer_music.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        // Uygulama süresince paylaşılan static liste
        private static ObservableCollection<BasicList> _cachedListMods;

        public ObservableCollection<BasicList> BasicListMods
        {
            get => _cachedListMods;
            private set
            {
                _cachedListMods = value;
                OnPropertyChanged();
            }
        }
        private static ObservableCollection<BasicList> _cachedListTurkishHits;

        public ObservableCollection<BasicList> BasicListTurkishHits
        {
            get => _cachedListTurkishHits;
            private set
            {
                _cachedListTurkishHits = value;
                OnPropertyChanged();
            }
        }
        private static ObservableCollection<BasicList> _cachedListTurkishSad;

        public ObservableCollection<BasicList> BasicListTurkishSad
        {
            get => _cachedListTurkishSad;
            private set
            {
                _cachedListTurkishSad = value;
                OnPropertyChanged();
            }
        }
        private static ObservableCollection<BasicList> _cachedListYoutubePopular;

        public ObservableCollection<BasicList> BasicListYoutubePopular
        {
            get => _cachedListYoutubePopular;
            private set
            {
                _cachedListYoutubePopular = value;
                OnPropertyChanged();
            }
        }
        private static ObservableCollection<MediumList> _cachedSpecialNewLists;

        public ObservableCollection<MediumList> MediumSpecialNewLists
        {
            get => _cachedSpecialNewLists;
            private set
            {
                _cachedSpecialNewLists = value;
                OnPropertyChanged();
            }
        }
        private static ObservableCollection<FooterList> _cachedFooterLists;

        public ObservableCollection<FooterList> ClassicalFooterList
        {
            get => _cachedFooterLists;
            private set
            {
                _cachedFooterLists = value;
                OnPropertyChanged();
            }
        }


        private static ObservableCollection<VideoList> _cachedpopulerclips;

        public ObservableCollection<VideoList> ClassicPopulerVideos
        {
            get => _cachedpopulerclips;
            private set
            {
                _cachedpopulerclips = value;
                OnPropertyChanged();
            }
        }
        public MainPageViewModel()
        {
            if (_cachedListMods == null)
            {
                LoadData();
            }
            else
            {
                MediumSpecialNewLists = _cachedSpecialNewLists;
                BasicListTurkishHits = _cachedListTurkishHits;
                BasicListTurkishSad = _cachedListTurkishSad;
                BasicListMods = _cachedListMods;
                BasicListYoutubePopular = _cachedListYoutubePopular;
                ClassicPopulerVideos = _cachedpopulerclips;
                ClassicalFooterList = _cachedFooterLists;
            }
        }
        private void LoadData()
        {
            var data = Crud.MainPageCrud.GetMods(); // List<BasicList>
            BasicListMods = new ObservableCollection<BasicList>(data);
            var data2 = Crud.MainPageCrud.GetHitMusic(); // List<BasicList>
            BasicListTurkishHits = new ObservableCollection<BasicList>(data2);
            var data3 = Crud.MainPageCrud.GetSadTurkishMusic(); // List<BasicList>
            BasicListTurkishSad = new ObservableCollection<BasicList>(data3);
            var data4 = Crud.MainPageCrud.GetPopularYoutubeLists(); // List<BasicList>
            BasicListYoutubePopular = new ObservableCollection<BasicList>(data4);
            var data5 = Crud.MainPageCrud.GetSpecialNewLists(); // List<BasicList>
            MediumSpecialNewLists = new ObservableCollection<MediumList>(data5);
            var data6 = Crud.MainPageCrud.GetpopularClips(); // List<BasicList>
            ClassicPopulerVideos = new ObservableCollection<VideoList>(data6); 
            var data7 = Crud.MainPageCrud.GetFooterList(); // List<BasicList>
            ClassicalFooterList = new ObservableCollection<FooterList>(data7);
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
 