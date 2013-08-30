using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using SignalR.Model;
using SignalR.Model.Repositories;

namespace SignalR.Controls
{
  public partial class DiscussionControl : System.Web.UI.UserControl
  {
    public string GroupId { get { return Request.QueryString["gid"] == null ? string.Empty : Request.QueryString["gid"].ToString(CultureInfo.InvariantCulture); } }

    protected override void OnInit(EventArgs e)
    {
      var sessionUserName = Session["UserName"];
      if (sessionUserName != null)
      {
        UserName.Value = sessionUserName.ToString();
      }
      else
      {
        Response.Redirect("/Home.aspx");
      }
      base.OnInit(e);
      DataBind();
    }

    protected IEnumerable<Message> GetMessages()
    {
      return string.IsNullOrEmpty(GroupId) ? Enumerable.Empty<Message>() : MessageRepository.GetByGroupId(GroupId);
    }
  }
}