using PSC.TodoApiSdk;
using System.Collections.Generic;

namespace PSC.ExternalWebApp.ViewModels
{
    public class TasksViewModel
    {
        public IList<TaskApiModel> TaskApiModels { get; set; }
    }
}
