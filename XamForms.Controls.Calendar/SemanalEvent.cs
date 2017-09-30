using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamForms.Controls
{
    public class SemanalEvent : SpecialDate
    {
        public SemanalEvent()
        {
            BackgroundColor = Color.HotPink;
            TextColor = Color.White;
        }

        public DayOfWeek DayOfWeek { get; set; }
    }
}
