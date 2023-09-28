using ToDoListBlazor.Pages.Components;



namespace ToDoListBlazor.Pages
{
	public class TodoItem
	{
		public int Id { get; set; }
		public string? TaskName { get; set; }
		public bool IsCompleted { get; set; }
	}
}
