using Microsoft.AspNetCore.Components;

namespace Client.Shared
{
    public partial class RedirectToLogin
    {
        [Inject] public NavigationManager navigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            navigationManager.NavigateTo($"/login?redirectUri={Uri.EscapeDataString(navigationManager.Uri)}", true);
        }
    }
}
