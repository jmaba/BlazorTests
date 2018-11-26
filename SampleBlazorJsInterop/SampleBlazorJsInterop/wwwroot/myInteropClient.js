window.exampleJsFunctions = {

    showPrompt: function (text) {
        return prompt(text, 'Type your name here...:');
    },

    displayWelcome: function (welcomeMessage) {
        document.getElementById('welcome').innerText = welcomeMessage;
    },

    returnArrayAsyncJs: function () {
        DotNet.invokeMethodAsync('SampleBlazorJsInterop', 'ReturnArrayAsync')
            .then(data => {
                console.log(data);
                var res = JSON.stringify(data);
                document.getElementById('arrayElements').innerText = res;
            });
    },
}