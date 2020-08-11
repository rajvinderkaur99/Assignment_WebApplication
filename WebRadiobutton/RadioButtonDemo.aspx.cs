using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRadiobutton
{
    public partial class RadioButtonDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel5.Enabled = false;
            Panel3.Enabled = false;
            //HyperLink4.Enabled = false;
            //HyperLink5.Enabled = false;
            //HyperLink6.Enabled = false;
            //HyperLink7.Enabled = false;
            //HyperLink8.Enabled = false;
            //HyperLink9.Enabled = false;

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Panel5.Enabled = true;
            Panel3.Enabled = false;
           
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Panel5.Enabled = false;
            Panel3.Enabled = true;
        }
    }
}