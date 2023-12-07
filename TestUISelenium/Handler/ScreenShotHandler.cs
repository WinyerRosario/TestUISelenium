using OpenQA.Selenium;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace TestUISelenium.Handler
{
    public class ScreenShotHandler
    {
        private static string DirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static string TakeScreenshot(IWebDriver driver)
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            string imagePath = Path.Combine(DirectoryPath, "img" + milliseconds + ".png");
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();

            using (MemoryStream memoryStream = new MemoryStream(image.AsByteArray))
            {
                using (Bitmap bitmap = new Bitmap(memoryStream))
                {
                    bitmap.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }

            return imagePath;
        }
    }
}
