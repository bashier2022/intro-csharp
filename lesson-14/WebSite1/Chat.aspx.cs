using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ChatItems"] != null)
        {
            ListBoxChatMessages.Items.Clear();
            var items = (ListItemCollection)Session["ChatItems"];
            foreach (ListItem item in items)
            {
                ListBoxChatMessages.Items.Add(item);
            }
        }
    }

    protected void OnSend_Click(object sender, EventArgs e)
    {      
        ListBoxChatMessages.Items.Add(tbChatMessage.Text);
        Session["ChatItems"] = ListBoxChatMessages.Items;

        //Application["ChatItems"] = ListBoxChatMessages.Items;
        tbChatMessage.Text = "";
    }
}