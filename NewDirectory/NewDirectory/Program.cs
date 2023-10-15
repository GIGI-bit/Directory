using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using Directories;

string folderName = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/Images";
if (!Directory.Exists(folderName))
{
    Directory.CreateDirectory(folderName);
}

string fileName = "numberCounter.txt";
string filePath = Path.Combine(folderName, fileName);
FileStream folder = new FileStream(filePath, FileMode.OpenOrCreate);
if (!File.Exists(filePath))
{
    File.Create(filePath);
}
folder.Dispose();



while (true)
{
    Console.WriteLine("Click Enter Button");
    var button = Console.ReadKey();
    if (button.Key == ConsoleKey.Enter)
    {
       Bitmap image = new Bitmap(2200, 1200);
        Size size = new Size(image.Width, image.Height);

        using Graphics graphics = Graphics.FromImage(image);
        graphics.CopyFromScreen(0, 0, 0,0, size);
        string imageName = "ScreenShot" + Counter.Count(filePath).ToString();
        string imagePath= Path.Combine(folderName, imageName);
        image.Save(imagePath);

    }

}
