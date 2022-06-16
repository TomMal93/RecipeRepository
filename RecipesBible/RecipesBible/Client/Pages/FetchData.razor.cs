using Microsoft.AspNetCore.Components;
using RecipesBible.Shared;
using System.Net.Http.Json;

namespace RecipesBible.Client.Pages
{
    public partial class FetchData : ComponentBase
    {
        private WeatherForecast[]? forecasts;
        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
