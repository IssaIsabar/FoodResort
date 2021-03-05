using FoodResort.Data;
using System.Collections.Generic;
using System.Linq;



public class NavigationService
{
    public Context _context;

    public NavigationService(Context context)
    {
        _context = context;
    }

    public List<Content> GetNav()
    {
        return _context.Content.ToList();
    }
}
