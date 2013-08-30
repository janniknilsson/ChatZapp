using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using SignalR.Model;
using SignalR.Model.Repositories;

namespace SignalR.Controls
{
  public partial class MessageBoardControl : System.Web.UI.UserControl
  {
    public double Longitude
    {
      get
      {
        if (Session["Longitude"] != null)
          return Convert.ToDouble(Session["Longitude"].ToString());
        Response.Redirect("/");
        return double.NaN;
      }
    }
    public double Latitude
    {
      get
      {
        if (Session["Latitude"] != null)
          return Convert.ToDouble(Session["Latitude"].ToString());
        Response.Redirect("/");
        return double.NaN;
      }
    }

    public string UserName
    {
      get
      {
        if (Session["UserName"] != null)
          return Session["UserName"].ToString();
        Response.Redirect("/");
        return string.Empty;
      }
    }

    public int Radius
    {
      get
      {
        if (Session["Radius"] != null)
        {
          int radius;
          int.TryParse(Session["Radius"].ToString(), out radius);
          return radius;
        }
        Response.Redirect("/");
        return -1;
      }
    }

    protected override void OnInit(EventArgs e)
    {
      base.OnInit(e);
      DataBind();
    }

    protected IEnumerable<Message> GetMessageBoardDiscussions()
    {
      return MessageRepository.GetAllInRadius(Latitude, Longitude, Radius);
    }

    protected void ShowDiscussion(object sender, EventArgs e)
    {
      Response.Redirect(string.Concat("/DiscussionBoard.aspx?gid=", ((LinkButton)sender).CommandArgument));
    }

    protected string GetMessagesInDiscussion(string groupId)
    {
      return MessageRepository.GetNumberOfMessageInDiscussion(groupId);
    }
  }
}