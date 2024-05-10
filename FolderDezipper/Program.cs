using System;
using System.IO;
using System.IO.Compression;


string folderPath = @"";

string[] zipFiles = Directory.GetFiles(folderPath, "*.zip");


foreach (string zipFile in zipFiles)
{
string fileName = Path.GetFileNameWithoutExtension(zipFile);
string destinationFolder = Path.Combine(folderPath, fileName);


try
{
    if (!Directory.Exists(destinationFolder))
        Directory.CreateDirectory(destinationFolder);

    ZipFile.ExtractToDirectory(zipFile, destinationFolder);
    Console.WriteLine($"Extracted {zipFile} to {destinationFolder}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error extracting {zipFile}: {ex.Message}");
}
}

Console.WriteLine("Extraction complete.");

