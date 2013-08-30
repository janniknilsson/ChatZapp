$(document).ready(function () {
  getLocation();

  var chat = $.connection.chatHub;

  chat.client.broadcastMessage = function (name, message, discussionId) {
    var encodedName = $('<div />').text(name).html();
    var encodedMsg = $('<div />').text(message).html();

    if ($('#discussionId').val() == discussionId) {
      $('#message_' + discussionId).append('<li><strong>' + encodedName
          + '</strong>:&nbsp;&nbsp;' + encodedMsg + '</li>');
    }
  };

  //$('#displayname').val(prompt('Enter your name:', ''));

  //$('#displayname').val($('#UserName').val());
  $("#message").focus();

  $.connection.hub.start().done(function () {
    $('#sendmessage').click(function () {
      chat.server.send($('#UserName').val(), $('#message').val(), $('#discussionId').val(), $('#Latitude').val(), $('#Longitude').val());
      $('#message').val('').focus();
    });
  });
});

function getLocation() {
  if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(showPosition);
  } else {
    alert("Geolocation is not supported by this browser.");
  }
}

function showPosition(position) {
  $('#Latitude').val(position.coords.latitude);
  $('#Longitude').val(position.coords.longitude);
}


