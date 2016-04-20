using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Campchon
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Util
    {
        #region string

        /// <summary>
        /// 
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="startText"></param>
        /// <param name="endText"></param>
        /// <returns></returns>
        public static string Substring(this string origin, string startText, string endText)
        {
            return
                origin.Substring(origin.IndexOf(startText) + startText.Length,
                    origin.IndexOf(endText, origin.IndexOf(startText)) - origin.IndexOf(startText) - startText.Length)
                    .Trim();
        }

        public static string Substring(this string origin, string startText)
        {
            return origin.Substring(origin.IndexOf(startText) + startText.Length,
                origin.Length - origin.IndexOf(startText) - startText.Length);
        }
        #endregion

        #region logging

        public static void ErrorLog(MethodBase method, Exception ex, string data = "")
        {
            Debug.WriteLine("{0} {4} \n\r {5}.{3}\t {1} - {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ex.Message, ex.StackTrace, method.Name, data, method.DeclaringType.FullName);
        }


        public static void Logging(RichTextBox box, string log)
        {
            AppendText(box, Color.DarkRed, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            AppendText(box, Color.Black, string.Format(" - {0}\r\n", log));
        }

        public static void Logging(RichTextBox box, string log, Color color)
        {
            AppendText(box, Color.DarkRed, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            AppendText(box, color, string.Format(" - {0}\r\n", log));
        }

        public static void Logging(RichTextBox box, string log, string log1, Color color)
        {
            AppendText(box, Color.DarkRed, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            AppendText(box, Color.Black, string.Format(" - {0}", log));
            AppendText(box, color, string.Format(" - {0}\r\n", log1));
        }

        public static void Logging(RichTextBox box, string log, string error)
        {
            AppendText(box, Color.DarkRed, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            AppendText(box, Color.Black, string.Format(" - {0}", log));
            AppendText(box, Color.Red, string.Format(" - {0}\r\n", error));
        }

        private static void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear

            Application.DoEvents();
        }
        
        #endregion
    }
}
