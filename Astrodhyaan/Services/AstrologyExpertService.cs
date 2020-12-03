using System.Collections.Generic;
using Astrodhyaan.Models;
using Xamarin.Forms;

namespace Astrodhyaan.Services
{
    public class AstrologyExpertService
    {
        static AstrologyExpertService _instance;

        public static AstrologyExpertService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AstrologyExpertService();
                return _instance;
            }
        }

        public List<AstrologyExpertItem> GetAstrologyExpertList(List<AstrologerEntity> AstrologersList)
        {
            return new List<AstrologyExpertItem>
            {
                new AstrologyExpertItem { Name = "Love Life Experts", Icon = "love.png", Color = Color.DeepPink,
                    Astrologers = AstrologersList },
                new AstrologyExpertItem { Name = "Marriage Experts", Icon = "marriage.png", Color = Color.Orange,
                     Astrologers = AstrologersList },
                new AstrologyExpertItem { Name = "Career Experts", Icon = "career.png", Color = Color.YellowGreen,
                     Astrologers = AstrologersList },
                new AstrologyExpertItem { Name = "Business Experts", Icon = "business.png", Color = Color.Purple,
                     Astrologers = AstrologersList },
                new AstrologyExpertItem { Name = "Money & Investment Experts", Icon = "investment.png", Color = Color.Green,
                     Astrologers = AstrologersList },
            };
        }
    }
}