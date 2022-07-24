using Microsoft.AspNetCore.Components;
using RecipesBible.Client.Service;

namespace RecipesBible.Client.Pages
{
    public partial class Counter : ComponentBase
    {
        [Inject]
        private ITestService tService { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            tService.Test();
        }
    }
}
