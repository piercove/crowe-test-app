using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crowe.Data
{
    public class FakeWidgetData
    {
        // Normally we would code against a Stored Proc or use an ORM to map to the database
        public WidgetDataModel[] widgets = new WidgetDataModel[]
       {
            new WidgetDataModel
            {
                GuidId = "8e8e95b1-ed9e-4a03-b416-1e808c138052",
                Name = "Hello World"
            },
            new WidgetDataModel
            {
                GuidId = "bed09fd4-a977-47b7-88aa-27d32881e50d",
                Name = "Hello Yourself"
            }
       };
    }
}
