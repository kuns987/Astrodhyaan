using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Astrodhyaan.Models
{
    public class AstrologyExpertItem : BindableObject
    {
        bool _isDetailVisible;

        public string Name { get; set; }
        public string Icon { get; set; }
        public Color Color { get; set; }

        public bool IsDetailVisible
        {
            get { return _isDetailVisible; }
            set
            {
                Task.Run(async () =>
                {
                    await Task.Delay(value ? 0 : 250);
                    _isDetailVisible = value;
                    OnPropertyChanged();
                });
            }
        }

        public List<AstrologerEntity> Astrologers { get; set; }
    }

    
}