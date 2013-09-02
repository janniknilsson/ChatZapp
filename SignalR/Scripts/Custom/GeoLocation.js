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

  $("#message").focus();

  $.connection.hub.start().done(function () {
    $('#sendmessage').click(function () {
      $('#error').val(BrowserDetect.browser);
      chat.server.send($('#UserName').val(), $('#message').val(), $('#discussionId').val(), $('#Latitude').val(), $('#Longitude').val(), BrowserDetect.browser + " " + BrowserDetect.version + " on " + BrowserDetect.OS );
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
  $('#sLatitude').html(formatCoordonates(position.coords.latitude));
  $('#sLongitude').html(formatCoordonates(position.coords.longitude));
  $('#Latitude').val(formatCoordonates(position.coords.latitude));
  $('#Longitude').val(formatCoordonates(position.coords.longitude));
}

function formatCoordonates(coordonate) {
  var cleanCoordonate = coordonate.toString().replace(".", "").substr(0, 10);
  var firstPart = cleanCoordonate.substr(0, 2);
  var secondPart = cleanCoordonate.substr(3, coordonate.length);
  return firstPart + "." + secondPart;
}


