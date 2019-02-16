using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using AspNetWebFormEmpty;
using System.Runtime.Serialization.Json;

namespace AspNetWebFormEmpty
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {


        public String DayOfWeek(int i)
        {
            string dayOfWeek = "";

            if (i == 0)
            {
                dayOfWeek = "Sunday";
            }

            if (i == 1)
            {
                dayOfWeek = "Monday";
            }

            if (i == 2)
            {
                dayOfWeek = "Tuesday";
            }

            if (i == 3)
            {
                dayOfWeek = "Wednesday";
            }

            if (i == 4)
            {
                dayOfWeek = "Thursday";
            }

            if (i == 5)
            {
                dayOfWeek = "Friday";
            }

            if (i == 6)
            {
                dayOfWeek = "Saturday";
            }

            return dayOfWeek;

        }

        public struct RemoteClientData
        {
            public String dayOfWeek { get; set; }
            public bool isUrlProvided { get; set; }
            public DateTime mydateTime { get; set; }
        }


        [WebMethod]
        //[System.Web.Script.Services.ScriptMethod(UseHttpGet =  true)]
        public RemoteClientData[] GetRemoteClientData(string optionalstr) // returns xml
        {
            int number = 7;
            RemoteClientData[] clients = null;

            clients = new RemoteClientData[number];

            for (int i = 0; i < number; i++)
            {
                clients[i].dayOfWeek = DayOfWeek(i);

                if (optionalstr != "")
                {
                    clients[i].isUrlProvided = true;
                }

                if (i == 0)
                {
                    clients[i].mydateTime = new DateTime(
                        DateTime.Now.TimeOfDay.Ticks, clients[i].mydateTime.Kind);
                }
                else
                {
                    clients[i].mydateTime = DateTime.Parse(DateTime.Now.AddDays(Convert.ToDouble(i)).ToShortDateString());
                }


            }

            //JavaScriptSerializer js = new JavaScriptSerializer();
            //Context.Response.Write(js.Serialize(clients));

             return clients;
        }
       

        [WebMethod]
        public void GetClientData()
        {
            int number = 7;
            RemoteClientData[] clients = null;

            clients = new RemoteClientData[number];

            for (int i = 0; i < number; i++)
            {
                clients[i].dayOfWeek = DayOfWeek(i);

                if (i == 0)
                {
                    //clients[i].mydateTime = new DateTime(DateTime.Now.TimeOfDay.Ticks, clients[i].mydateTime.Kind);
                    clients[i].mydateTime = default(DateTime).Add(clients[i].mydateTime.TimeOfDay);
                }
                else
                {
                    // clients[i].mydateTime = DateTime.Parse(DateTime.Now.AddDays(Convert.ToDouble(i)).ToShortDateString());
                    clients[i].mydateTime = DateTime.Now.AddDays(Convert.ToDouble(i));

                }

                 
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(clients));

        
        }


        [WebMethod]
        [System.Web.Script.Services.ScriptMethod(UseHttpGet = true)]
        public void GetClientDataWithGetMethod()
        {
            int number = 7;
            RemoteClientData[] clients = null;

            clients = new RemoteClientData[number];

            for (int i = 0; i < number; i++)
            {
                clients[i].dayOfWeek = DayOfWeek(i);

                if (i == 0)
                {
                    
                    clients[i].mydateTime = default(DateTime).Add(clients[i].mydateTime.TimeOfDay);
                }
                else
                {
                    
                    clients[i].mydateTime = DateTime.Now.AddDays(Convert.ToDouble(i));

                }


            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(clients));


        }

    }
}
