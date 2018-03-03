namespace P19.TheaThePhotographer
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int takenPics = int.Parse(Console.ReadLine());
            int filterTimeSeconds = int.Parse(Console.ReadLine());
            int goodPicsPercent = int.Parse(Console.ReadLine());
            int timeUploadingFilteredPics = int.Parse(Console.ReadLine());

            double persentage = goodPicsPercent / 100.0;
            int usefulPics = (int)Math.Ceiling(takenPics * persentage);

            long timeForFiltering = takenPics * (long)filterTimeSeconds;
            long timeForUploading = usefulPics * (long)timeUploadingFilteredPics;

            Console.WriteLine(TimeSpan.FromSeconds(timeForFiltering+timeForUploading)
                .ToString(new string('d', 1)+ @"\:hh\:mm\:ss"));

        }
    }
}
