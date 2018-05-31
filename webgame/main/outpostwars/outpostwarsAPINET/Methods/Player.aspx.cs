using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace outpostwarsAPINET.Methods
{
    public partial class Player : System.Web.UI.Page
    {
        public string content;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (API.isPlayer) { 
                Response.ContentType = "application/json";
                string json = "{\"name\":\"Player\"}";
                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";

                Response.Write(json);
                Response.End();
            }
            else if (API.isAdmin)
            {
                Response.ContentType = "application/json";
                string json = "{\"name\":\"Player\"}";
                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";

                Response.Write(json);
                Response.End();
            }
            else
            {
                Response.ContentType = "application/json";
                string json = "{\"Error\":\"not logged in\"}";
                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";

                Response.Write(json);
                Response.End();
            }
        }   
    }
}