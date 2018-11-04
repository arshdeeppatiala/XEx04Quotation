using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx04Quotation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblSalesPrice.Text = Session["salesprice"].ToString();
            lblDiscountAmount.Text = Session["discountamount"].ToString();
            lblTotalPrice.Text = Session["totalprice"].ToString();
        }

        protected void Btn_sendQuotation_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == null || txtName.Text == null)
            {
                Lbl_send.Text = "please enter email address and name";
            }
            else
            {
                Lbl_send.Text="Thank you for sending the Quotation!" +  
                    "click on return to go back";
            }
        }
    } }
