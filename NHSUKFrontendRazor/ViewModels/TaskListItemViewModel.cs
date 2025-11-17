namespace NHSUKFrontendRazor.ViewModels
{
    public class TaskListItemViewModel
    {
        /// <summary>
        /// Creates a new instance of the <see cref="TaskListItemViewModel"/> class.
        /// STATE: Choose between "Completed", "Incomplete" and "Cannot start yet".
        /// STATESTYLE: The style should match the state. (e.g. "TaskStateStyle.INCOMPLETE" for "Incomplete", "TaskStateStyle.COMPLETED" for "Completed", "TaskStateStyle.UNSTARTED" for "Cannot start yet")
        /// </summary>
        /// <param name="id">The unique identifier for the task.</param>
        /// <param name="name">The name of the task.</param>
        /// <param name="aspController">The asp-controller associated with the task's action.</param>
        /// <param name="aspAction">The asp-action action associated with the task's action.</param>
        /// <param name="aspRouteData">An asp-all-data-route dictionary containing route data for the task's action.</param>
        /// <param name="state">Choose between "Completed", "Incomplete" and "Cannot start yet".</param>
        /// <param name="stateStyle">The style should match the state. (e.g. "TaskStateStyle.INCOMPLETE" for "Incomplete", "TaskStateStyle.COMPLETED" for "Completed", "TaskStateStyle.UNSTARTED" for "Cannot start yet")</param>
        /// <param name="hintText">Additional text providing hints about the task.</param>
        public TaskListItemViewModel(
            string id,
            string name,
            string aspController,
            string aspAction,
            Dictionary<string, string> aspRouteData,
            string state,
            TaskStateStyle stateStyle,
            string hintText)
        {
            Id = id;
            Name = name;
            AspController = aspController;
            AspAction = aspAction;
            AspRouteData = aspRouteData;
            State = state;
            StateStyle = stateStyle;
            HintText = hintText;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the task.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the task.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the asp-controller of the link.
        /// </summary>
        public string AspController { get; set; }

        /// <summary>
        /// Gets or sets the as-action of the link.
        /// </summary>
        public string AspAction { get; set; }

        /// <summary>
        /// Gets or sets the asp-all-route-data of the link.
        /// </summary>
        public Dictionary<string, string> AspRouteData { get; set; }

        /// <summary>
        /// Gets or sets the current state of the task.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the style that matches the state of the task.
        /// </summary>
        public TaskStateStyle StateStyle { get; set; }

        /// <summary>
        /// Gets or sets additional text providing hints about the task.
        /// </summary>
        public string HintText { get; set; }
    }


    public enum TaskStateStyle
    {
        COMPLETED,
        INCOMPLETE,
        UNSTARTED
    }
}
