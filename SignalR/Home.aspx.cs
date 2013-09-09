using System;

namespace SignalR
{
  public partial class Home1 : System.Web.UI.Page
  {
    protected void SaveNameAndRadius(object sender, EventArgs e)
    {
      Session["UserName"] = TxtName.Text;
      Session["Radius"] = TxtRadius.Text;
      Session["Latitude"] = Latitude.Value;
      Session["Longitude"] = Longitude.Value;
      Response.Redirect("/MessageBoard.aspx");
    }
  }
}