using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crowe.Application.Models;
using crowe.Data;

namespace crowe.Application.Handlers
{
    public class WidgetHandler
    {
        public IEnumerable<WidgetModel> GetWidgets()
        {
            var widgets = new FakeWidgetData().widgets;
            if (widgets != null)
            {
                var list = new List<WidgetModel>();
                foreach (var widget in widgets)
                {
                    list.Add(new WidgetModel() { GuidId = widget.GuidId, Name = widget.Name });
                }
                return list;
            }

            return new List<WidgetModel>();
        }

        public WidgetModel GetWidget(string id)
        {
            var widgets = new FakeWidgetData().widgets;
            var widget = widgets.FirstOrDefault((w) => w.GuidId == id);
            if (widget != null)
            {
                return new WidgetModel() { GuidId = widget.GuidId, Name = widget.Name };
            }

            return new WidgetModel();
        }
    }
}
