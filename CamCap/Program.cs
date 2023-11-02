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
        using var capture = new VideoCapture(0, VideoCapture.API.DShow);
        while (true)
        {
            var filename = $"captura_{DateTime.Now:yyMMddHHmmss}.jpeg";
            var image = capture.QueryFrame(); //take a picture
            image.Save(filename);
            Thread.Sleep(5000*60); // wait 5 minutes
        }
    }
}