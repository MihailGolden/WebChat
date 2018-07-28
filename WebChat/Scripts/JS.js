// Pressing the enter button presses the button Enter
$('#txtUserName').keyup(function (event) {
    if (event.keyCode === 13) {
        $('#btnLogin').click();
    }
});

// Pressing the enter button presses the button Send
$('#message').keyup(function (event) {
    if (event.keyCode === 13) {
        $('#sendmessage').click();
    }
});