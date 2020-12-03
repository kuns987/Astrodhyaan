using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrodhyaan
{

    public class MasterNavigationMasterMenuItem
    {
        public MasterNavigationMasterMenuItem()
        {
            TargetType = typeof(MasterNavigationMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgName { get; set; }

        public Type TargetType { get; set; }
    }
}