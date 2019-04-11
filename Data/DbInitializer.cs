using FeatureToggleDotnet.Models;

namespace FeatureToggleDotnet.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            context.TodoItems.Add(new TodoItem {Description = "Buy Milk", Done = true});
            context.TodoItems.Add(new TodoItem {Description = "Buy Cheese", Done = true});
            context.TodoItems.Add(new TodoItem {Description = "Buy Chocolate Cake", Done = true});
            context.SaveChanges();
        }
    }
}