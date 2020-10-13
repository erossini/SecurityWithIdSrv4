using PSC.TodoApiSdk;
using System.Collections.Generic;

namespace PSC.PortalWebApp.ViewModels
{
    public class TasksViewModel
    {
        public IList<TaskApiModel> TaskApiModels { get; set; }
    }
}
