using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServerDemo
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://www.testing.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "Add 2 Intergers", EnableSession = true, Description = "This method ADDS 2 Numbers.", CacheDuration = 20)]
        public int Add(int FirstInteger, int SecondInteger)
        {
            return FirstInteger + SecondInteger;
        }

        [WebMethod(MessageName = "Add 3 Intergers", EnableSession = true)]
        public int Add(int FirstInteger, int SecondInteger, int ThirdInteger)
        {
            return FirstInteger + SecondInteger + ThirdInteger;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations() 
        {
            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }
            string strRecentCalculations = FirstInteger.ToString() + " + " + SecondInteger.ToString() + " = " + (FirstInteger + SecondInteger).ToString();
            return FirstInteger + SecondInteger;
        }



        [WebMethod]
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorSoapClient client = new CalculatorService.CalculatorSoapClient();

            int result = client.Add(Convert.ToInt32(FirstInteger), Convert.ToInt32(SecondInteger));

            lblResult = result.ToString();
            gvCalculations.DataSource = client.GetCalculations();
            gvCalculations.DatBind();
            gvCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}
