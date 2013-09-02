using System;
using System.Collections.Generic;
using SignalR.Model;
using SignalR.Model.Repositories;

namespace SignalR
{
  public partial class Admin : System.Web.UI.Page
  {
    protected override void OnInit(EventArgs e)
    {
      base.OnInit(e);
      DataBind();
    }

    protected IEnumerable<Message> DataSource
    {
      get { return MessageRepository.GetAll(); }
    }

    protected void DeleteAllMessages(object sender, EventArgs e)
    {
      MessageRepository.DeleteAll();
      Response.Redirect(".");
    }
  }
}