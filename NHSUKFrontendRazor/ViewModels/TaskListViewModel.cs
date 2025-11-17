namespace NHSUKFrontendRazor.ViewModels
{
    public class TaskListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListViewModel"/> class.
        /// </summary>
        /// <param name="listItems">A collection of task list items.</param>
        public TaskListViewModel(
            IEnumerable<TaskListItemViewModel> listItems)
        {
            ListItems = listItems;
        }

        /// <summary>
        /// Gets or sets the collection of task list items.
        /// </summary>
        public IEnumerable<TaskListItemViewModel> ListItems { get; set; }
    }
}
