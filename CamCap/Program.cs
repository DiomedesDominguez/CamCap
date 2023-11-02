using System;
using System.Drawing;
using System.Threading;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

class Program
{
    static void Main()
    {
        //Select the source and the compatible API
        using var capture = new VideoCapture(0, VideoCapture.API.DShow);

        //Set the picture resolution
        capture.Set(CapProp.FrameWidth, 3840);
        capture.Set(CapProp.FrameHeight, 2160);

        while (true)
        {
            var filename = $"{DateTime.Now:yyMMddHHmmss}.jpeg";//Set image file name
            var image = capture.QueryFrame(); //take a picture
            image.Save(filename); // save the picture
            Console.WriteLine($"File saved {filename}"); // Print in console the file name just for log
            Thread.Sleep(5000*60); // wait 5 minutes
        }
    }
}