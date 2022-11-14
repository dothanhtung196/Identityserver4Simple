using API.Models;
using Client.Services;
using IdentityModel.Client;
using Microsoft.AspNetCore.Components;

namespace Client.Pages
{
    public partial class CoffeeShop
    {
        private List<CoffeeShopModel> Shops = new();
        [Inject] private HttpClient httpClient { get; set; }
        [Inject] private IConfiguration configuration { get; set; }
        [Inject] private ITokenService tokenService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var tokenResponse = await tokenService.GetToken("CoffeeAPI.read");
            httpClient.SetBearerToken(tokenResponse.AccessToken);

            var result = await httpClient.GetAsync($"{configuration["ApiUrl"]}/api/CoffeeShop");

            if (result.IsSuccessStatusCode)
            {
                Shops = await result.Content.ReadFromJsonAsync<List<CoffeeShopModel>>();
            }
        }
    }
}
