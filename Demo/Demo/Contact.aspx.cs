using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("neeraj");
            Response.Write("abcd");
            Response.Write("abcd1");
            Response.Write("abcd2");
            //--------new change
            Response.Write("My New Work");

            Response.Write("dsjflkdskfjdslk");
        }
        private string SEtMessage()
        {
            return "Get Completed";
        }
        private void PrintHelloWorld()
        {
            Response.Write("Hello World");
        }
    }
}