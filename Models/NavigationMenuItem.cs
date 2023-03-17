using System.Collections.Generic;

namespace TAC.Models
{
    public class NavigationMenuItem : NavigationItem
    {
        public IEnumerable<NavigationMenuItem> Children { get; private set; }
        public NavigationMenuItem(string title, string url, IEnumerable<NavigationMenuItem> children) : base(title, url, false)
        {
            Children = children == null ? new List<NavigationMenuItem>() : children;
        }
    }
}