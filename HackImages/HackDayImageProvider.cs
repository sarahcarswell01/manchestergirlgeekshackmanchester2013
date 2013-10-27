using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using System.IO;
namespace manchestergirlgeekshackmanchester2013.HackImages
{

    /// <summary>
    /// Provides uploaded images of the hackday
    /// </summary>
    public class HackDayImageProvider
    {
        /// <summary>
        /// Images to display
        /// </summary>
        public StringCollection Images
        {
            get
            {
                EnsureImages();
                return InternalImages;
            }
        }
        /// <summary>
        /// Cache of images
        /// </summary>
        private StringCollection InternalImages { get; set; }
        /// <summary>
        /// Indicates the image contents should be calculated
        /// </summary>
        private bool CalculateImages { get; set; }
        /// <summary>
        /// Number of divs uploaded
        /// </summary>
        private int DivCount { get; set; }
        /// <summary>
        /// Sets a flag indicating that the images should be recalcalculated
        /// </summary>
        /// <remarks>
        /// Doesn't clear the cache as don't want too many hits on server
        /// </remarks>
        public void Clear()
        {
            CalculateImages = true;
        }
        /// <summary>
        /// Instantiates the class
        /// </summary>
        public HackDayImageProvider()
        {
            this.Clear();
        }
        /// <summary>
        /// Extracts the imate details
        /// </summary>
        private void EnsureImages()
        {
            string html;            // Html contents
            string[] divs;          // divs
            string divindex;        // current div index in string
            int divnumber;          // current div index in number
            int nPosText;           // poistion of text in string
            string[]  paragraphs;   // Paragraphs in divs
            string[] images;        // Images in paragraphs
            string divtext;         // text in div
            string srcimage;        // source image contents
            bool firstpass;         // true if first pass through div
            bool firstimage;        // true if first image through paragraphs
            //
            if (InternalImages == null || CalculateImages)
            {
                html = ReadHTML();
                divs = html.Split(new string[] { "<div id=\"liveblog-entry" }, StringSplitOptions.None);
                // first line of divs can be ignored
                divindex = divs[1].Substring(1, divs[1].IndexOf("\"") - 1);
                int.TryParse(divindex, out divnumber);
                //
                if (divnumber > DivCount || InternalImages == null)
                {
                    this.InternalImages = new StringCollection();
                    firstpass = true;
                    foreach (string div in divs)
                    {
                        if (firstpass)
                        {
                            firstpass = false;
                        }
                        else
                        {
                            nPosText = div.IndexOf("<div class=\"liveblog-entry-text");
                            if (nPosText > -1)
                            {
                                divtext = div.Substring(nPosText);
                            }
                            else
                            {
                                divtext = div;
                            }
                            nPosText = divtext.IndexOf("</div>");
                            if (nPosText > -1)
                            {
                                divtext = divtext.Substring(0, nPosText);
                            }
                            paragraphs = divtext.Split(new string[] { "<p>" }, StringSplitOptions.None);
                            foreach (string paragraph in paragraphs)
                            {
                                images = paragraph.Split(new string[] { "<img" }, StringSplitOptions.None);
                                firstimage = true;
                                foreach (string image in images)
                                {
                                    if (firstimage)
                                    {
                                        firstimage = false;
                                    }
                                    else
                                    {
                                        nPosText = image.IndexOf(" src=");
                                        if (nPosText > -1)
                                        {
                                            srcimage = image.Substring(nPosText + 6);
                                            nPosText = srcimage.IndexOf(" ");
                                            if (nPosText == -1)
                                            {
                                                nPosText = srcimage.IndexOf(">");
                                            }
                                            srcimage= srcimage.Substring(0, nPosText-1).Trim();
                                            if (!InternalImages.Contains(srcimage))
                                            {
                                                InternalImages.Add(srcimage);
                                            }
                                        }
                                }
                                }
                            }
                        }
                    }
                }
                //
            }
        }
        /// <summary>
        /// Reads the html for the specified url
        /// </summary>
        /// <returns>
        /// html from the specified url
        /// </returns>
        private string ReadHTML()
        {
            HttpWebRequest req;     // Request for url
            HttpWebResponse res;    // Response to request
            StreamReader sr;        // string reader
            String html;            // html to return
            //
            req=(HttpWebRequest)WebRequest.Create("http://deskand.co/hackmanchester/");
            res=(HttpWebResponse)req.GetResponse();
            sr = new StreamReader(res.GetResponseStream());
            html = sr.ReadToEnd();
            sr.Close();
            return html;
        }
    }
}
