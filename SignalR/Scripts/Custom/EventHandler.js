$(document).ready(function () {
  $("form1").submit(function () { return false; });

  $("#message").bind('keyup', function (event) {
    if (event.keyCode == 13) {
      event.preventDefault();
      $("#sendmessage").click();
      return false;
    }
  });
});