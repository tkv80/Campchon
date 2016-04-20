using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Campchon.Manager
{
    internal static class HttpManager
    {

        /// <summary>
        /// 해당 사이트 예약 가능 여부
        /// </summary>
        /// <param name="date"></param>
        /// <param name="idx"></param>
        /// <param name="site"></param>
        /// <returns></returns>
        public static bool PossibleReservation(int idx, DateTime date)
        {
            try
            {
                var httpWRequest =
                    (HttpWebRequest)
                        WebRequest.Create(
                            string.Format(
                                "http://www.campchon.com/reservation/basic.php?CAMP_NO={0}&c={0}",
                                idx));
                httpWRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; WOW64; Trident/6.0)";
                httpWRequest.KeepAlive = true;
                httpWRequest.Method = "Get";
                httpWRequest.Referer =
                    string.Format(
                        "http://www.campchon.com/reservation/?c={0}", idx);

                var theResponse = (HttpWebResponse) httpWRequest.GetResponse();
                var sr = new StreamReader(theResponse.GetResponseStream());

                var resultHtml = sr.ReadToEnd();

                if (resultHtml.IndexOf(string.Format("<p class=\"day\">{0}</p>", date.Day)) == -1)
                {
                    return false;
                }

                resultHtml = resultHtml.Substring(string.Format("<p class=\"day\">{0}</p>", date.Day), "</ul>");

                if (resultHtml.Contains("<li class=\"off\">"))
                {
                    return true;
                }

            }
            catch (Exception)
            {
                
            }
            return false;
        }
    }
}