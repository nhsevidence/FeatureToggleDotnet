using System.Collections.Generic;

namespace FeatureToggleDotnet.Models
{
    public class TodoViewModel
    {
        public IEnumerable<TodoItem> Items { get; set; }
    }
}