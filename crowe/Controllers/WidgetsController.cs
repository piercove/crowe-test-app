using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using crowe.Application.Handlers;
using crowe.Application.Models;

namespace crowe.Controllers
{
    public class WidgetsController : ApiController
    {
        public WidgetHandler wh = new WidgetHandler();

        public IEnumerable<WidgetModel> GetAllWidgets()
        {
            var widgets = wh.GetWidgets();
            return widgets;
        }

        public IHttpActionResult GetWidget(string id)
        {
            var widget = wh.GetWidget(id);
            if (widget == null)
            {
                return NotFound();
            }
            return Ok(widget);
        }
    }
}
