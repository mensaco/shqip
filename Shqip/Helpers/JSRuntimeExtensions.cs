using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Shqip.Helpers
{
    public static class JSRuntimeExtensions
    {
        public async static Task<string> GetFromLocalStorage(this IJSRuntime jSRuntime, string key)
        {
            return await jSRuntime.InvokeAsync<string>("window.JsRuntimeExtensions.GetFromLocalStorage", key);
        }

        public async static Task SetInLocalStorage(this IJSRuntime jSRuntime, string key, string content)
        {
            await jSRuntime.InvokeVoidAsync("window.JsRuntimeExtensions.SetInLocalStorage", key, content);
        }

        public async static Task RemoveFromLocalStorage(this IJSRuntime jSRuntime, string key)
        {
            await jSRuntime.InvokeVoidAsync("window.JsRuntimeExtensions.RemoveFromLocalStorage", key);
        }
    }
}
