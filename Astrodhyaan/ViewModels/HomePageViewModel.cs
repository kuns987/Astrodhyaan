using System;
using System.Collections.ObjectModel;
using Astrodhyaan.Models;
using Astrodhyaan.Services;
using Astrodhyaan.Helpers;
using Xamarin.Forms;

namespace Astrodhyaan.ViewModels
{
    public class HomePageViewModel : BindableObject
    {
        ObservableCollection<AstrologyExpertItem> _items;
        public ObservableCollection<AstrologerEntity> astrologers;
        public ObservableCollection<AstrologerEntity> userastrologers;
        public UserMasterEntity userdetail;
        public string rupee;
        public MobileHomeResponse home = new MobileHomeResponse();
        public HomePageViewModel()
        {
            APIHelper helper = new APIHelper();                                  
            home = helper.GetHomePage(101,1,1);
            astrologers = new ObservableCollection<AstrologerEntity>(home.astrologersList);
            userdetail = home.UserDetail;
            System.Globalization.RegionInfo objRegInfo = new System.Globalization.RegionInfo("en-IN");
            string syb = objRegInfo.CurrencySymbol;
            rupee = syb;
            LoadShoppingList();
        }
        public string Rupee
        {
            get { return rupee; }
            set
            {
                rupee = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<AstrologyExpertItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }
        
        public ObservableCollection<AstrologerEntity> Astrologers
        {
            get { return astrologers; }
            set
            {
                astrologers = value;
                OnPropertyChanged();
            }
        }
        public UserMasterEntity UserDetail
        {
            get { return userdetail; }
            set
            {
                userdetail = value;
                OnPropertyChanged();
            }
        }
        void LoadShoppingList()
        {
            var items = AstrologyExpertService.Instance.GetAstrologyExpertList(home.astrologersList);
            Items = new ObservableCollection<AstrologyExpertItem>(items);
        }
        private ObservableCollection<Place> GetPlaces()
        {
            return new ObservableCollection<Place>
            {
                new Place
                {
                    Name = "Amarnath Jha",
                    Caption = "Rs 36/Min "+System.Environment.NewLine+"Vedic Astrology, Numerology, Vaastu, Prashna Kundali",
                    Image = "amar.jpg",
                    Description = $"Vedic pandit and Astrologer Acharya Amarnath Jha is a well-experienced expert in Vedic Astrology. He Studied in ‘Sanyas Aashram’, ‘Mumbai’. He has completed Vedic studies with all the degrees of the professional astrologer in Sanskrit. Having 15 years of experience he is specialist in Vedic Astrology, Finance, Vastu, Medical Astrology and Health. He can also suggest gemstones and remedies improve the good results. You can be advised to find solutions to the problem of your life."
                },
                new Place
                {
                    Name = "Rakhi Sanjay Jha",
                    Caption = "Rs 32/Min "+System.Environment.NewLine+"Vedic Astrology, Numerology.",
                    Image = "rakhi.jpg",
                    Description = $"My name is Rakhi Sanjay Jha and I have 8 years of experience in the field of Astrology. I am a B. Ed graduate in Hindi from Rahul D. El. Ed College in Bhayander. My interests lie in Vedic Astrology and other sciences. Initially, I started by predicting for friends and family through astrological readings.My predictions have been accurate since the start and my remedies have also been very helpful to all.Astrology has been my passion since childhood as it awakens in me the desire to be able to see beyond what is externally visible. In the eight years of my practice, my knowledge of astrology has helped solve various problems in people’s life including relationships, money, health, diseases, etc."
                },
                new Place
                {
                    Name = "Acharya Jai Prakash Ojha",
                    Caption = "Rs 50/Min "+System.Environment.NewLine+"Vedic Astrology, Numerology, Vaastu, Prashna Kundali",
                    Image = "prakash.jpg",
                    Description = $"ACHARYA JAI PRAKASH OJHA JI is a reputed full-time astrologer and has been practicing Vedic Astrology, also known as (Parashari Jyotish) and other Astro-services like Gems, Numerology, Vaastu & Prashna kundali. Acharya Ji has pursued his studies from Lal Bahadur Shastri Deemed University, New Delhi, and other conventional media. Born and brought in a Brahmin family, he got benefited from the immense knowledge relayed to him by his father and grandfather who were renowned astrologers of their time. He has a vast knowledge of Vedic astrology (Parashari Jyotish) and his area of specialization is BUSINESS, CAREER, FINANCE, MARRIAGE, and LOVE LIFE & RELATIONS. He has an experience of more than 20 years and in this span of time, most of his predictions, suggestions and horoscope readings have been found accurate. He has been providing suggestions and guidance to innumerable clients from all over the country and globe. He is a firm believer of destiny and the effect of planets on it. He provides remedies based on personal details like Date of birth, time, and place of birth as he believes in the planetary movements at the time of one’s birth. According to him, “Our past karma reflects in the planetary positions at the time of our birth which plays a deciding role in our present life"
                }
            };
        }
        public class Place
        {
            public string Name { get; set; }
            public string Caption { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        } 
    }
}