using System;

namespace SignalR.Controls
{
  public partial class BottomNavigationControl : System.Web.UI.UserControl
  {

    protected void NewDiscussion(object sender, EventArgs e)
    {
      Response.Redirect("/DiscussionBoard.aspx");
    }

    protected void ShowAllDiscussion(object sender, EventArgs e)
    {
      Response.Redirect("/MessageBoard.aspx");
    }

    protected void ChangeRadius(object sender, EventArgs e)
    {
      Response.Redirect("/Home.aspx");
    }
  }
}