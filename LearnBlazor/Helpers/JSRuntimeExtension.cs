﻿using Microsoft.JSInterop;

namespace LearnBlazor.Helpers
{
    public static class JSRuntimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("showToastr", "success", message);
        }
        public static async Task ToastrEerror(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("showToastr", "error", message);
        }
    }
}
