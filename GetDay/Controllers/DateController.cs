using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetDay.Models;

namespace GetDay.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
        public ActionResult Index(string date, string name)
        {
            string strVal = date;
            List<DateDetails> list = new List<DateDetails>();
            if (name == null) name = "NA";
             list = getVal(date,name);
            return View(list);
        }
        public List<DateDetails> getVal(string val, string val2)
        {
            List<DateDetails> list = new List<DateDetails>();
            string[] arr1 = val.Split('/');
            string strday = arr1[1];
            string strmonth = arr1[0];
            int stryear =Convert.ToInt16(arr1[2]);

            DateDetails Obj = new DateDetails();

            for (int i = 2018; i >= stryear; i--)
            {
                Obj = new DateDetails();
                Obj.Name =val2;
                Obj.DOB = strday+"/"+ strmonth + "/"+ Convert.ToString(i);
                DateTime dateValue = new DateTime(i, Convert.ToInt16(strmonth), Convert.ToInt16(strday));//new DateTime(2008, 6, 11);
                Obj.Day = Convert.ToString(dateValue.ToString("dddd"));// "Monday";
                list.Add(Obj);
            }
           
            return list;
        }
    }
}