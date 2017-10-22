using System;
using System.IO;

namespace MvcApplication
{
    public class Base64Service
    {
        public static string ImageToBase64(string imageTitle)   
        {  
            string path = "data/img/";  
            using(System.Drawing.Image image = System.Drawing.Image.FromFile(path+imageTitle))  
            {  
                using(MemoryStream m = new MemoryStream())  
                {  
                    image.Save(m, image.RawFormat);  
                    byte[] imageBytes = m.ToArray();  
                    var base64String = Convert.ToBase64String(imageBytes);  
                    return base64String;  
                }  
            }  
        }   
    }
}