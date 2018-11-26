using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleBlazorJsInterop
{
    public class MyInteroptExtentionClass
    {
        public static Task<string> Prompt(string text)
        {
            // showPrompt is implemented in wwwroot/exampleJsInterop.js
            return JSRuntime.Current.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                text);
        }

        public static Task<string> Display(string welcomeMessage)
        {
            // displayWelcome is implemented in wwwroot/exampleJsInterop.js
            return JSRuntime.Current.InvokeAsync<string>(
                "exampleJsFunctions.displayWelcome",
                welcomeMessage);
        }
    }
}
