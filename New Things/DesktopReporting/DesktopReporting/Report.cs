using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DesktopReporting
{
    class Report
    {
        public Dictionary<DateTime, Image> screenshots = new Dictionary<DateTime, Image>();
        DateTime time = new DateTime();

        public void insert(Image image)
        {
            screenshots.Add(time.Date, image);
        }

    }
}
