using FeatureToggleDotnet.Models;

namespace FeatureToggleDotnet.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            var todoItem = new TodoItem {Description = "Buy Milk", Done = false}; 
            context.TodoItems.Add(todoItem);
            context.SaveChanges();
        }
    }
}