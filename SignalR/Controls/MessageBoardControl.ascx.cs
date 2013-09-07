using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI.WebControls;
using SignalR.Infrastructure;
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
          //return FormatCoordinateService.Format(Session["Longitude"].ToString());
          return Double.Parse(Session["Longitude"].ToString().Replace('.',','), new CultureInfo("en-US"));
        Response.Redirect("/");
        return double.NaN;
      }
    }
    public double Latitude
    {
      get
      {
        if (Session["Latitude"] != null)
          //return FormatCoordinateService.Format(Session["Latitude"].ToString());
          return Double.Parse(Session["Latitude"].ToString().Replace('.', ','), new CultureInfo("en-US"));
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
      var allMsg = MessageRepository.GetAllInRadius(Latitude,Longitude, Radius);
      return allMsg;
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