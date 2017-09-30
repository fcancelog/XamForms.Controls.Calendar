using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamForms.Controls
{
    public partial class Calendar
    {
        public static readonly BindableProperty SemanalEventsProperty =
            BindableProperty.Create(nameof(SemanalEvents), typeof(ICollection<SemanalEvent>), typeof(Calendar), new List<SemanalEvent>(),
                propertyChanged: (bindable, oldValue, newValue) => (bindable as Calendar).ChangeCalendar(CalandarChanges.MaxMin));

        public ICollection<SemanalEvent> SemanalEvents
        {
            get { return (ICollection<SemanalEvent>)GetValue(SemanalEventsProperty); }
            set { SetValue(SemanalEventsProperty, value); }
        }
    }
}
