using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.IO;
using Rutland.PrintFileMaker.Configuration;

namespace Rutland.PrintFileMaker
{
    public class ImageFileManager
    {
        public string LocalImgFolder { get; set; }
        private int daysToKeepLocalImagFiles;

        public ImageFileManager(PfmSettings settings)
        {
            LocalImgFolder = settings.LocalImageFolder;

            //if local img directory is not set in app settings, use <app dir>/Images
            if (string.IsNullOrEmpty(LocalImgFolder)) 
            {
                LocalImgFolder = Path.Combine(Directory.GetCurrentDirectory(), "Images");
                settings.LocalImageFolder = LocalImgFolder;
            }

            daysToKeepLocalImagFiles = settings.DaysToKeepLocalImageFiles;
            DeleteLocal();
        }

        public string GetLocalDefaultImage(string imgFile)
        {
            FileInfo file = new FileInfo(imgFile);

            return Path.Combine(LocalImgFolder, file.Name);
        }
        
        
        public void ResetDirectory()
        {
            DeleteLocal();
        }
        
        public void CopyToLocal(List<FilePicker> imgFiles)
        {
            //if local image folder is not there, create it
            if (!Directory.Exists(LocalImgFolder))
            {
                Directory.CreateDirectory(LocalImgFolder);
            }           

            foreach (var img in imgFiles)
            {
                if (!string.IsNullOrEmpty(img.SelectedFile))
                {
                    if (!File.Exists(img.SelectedFile))
                    {
                        throw new Exception(string.Format("File not found: {0}", img.SelectedFile));
                    }
                    FileInfo file = new FileInfo(img.SelectedFile);

                    File.Copy(img.SelectedFile, Path.Combine(LocalImgFolder, file.Name), true);
                }
            }
        }

        public void CopyToLocal(string imgFile)
        {
            //if local image folder not there, create it
            if (!Directory.Exists(LocalImgFolder))
            {
                Directory.CreateDirectory(LocalImgFolder);
            }

            if (!string.IsNullOrEmpty(imgFile))
            {
                if (!File.Exists(imgFile))
                {
                    throw new Exception(string.Format("File not found: {0}", imgFile));
                }
                FileInfo file = new FileInfo(imgFile);
                string newFilePath = Path.Combine(LocalImgFolder, file.Name);

                File.Copy(imgFile, newFilePath, true);

                File.SetCreationTime(newFilePath, DateTime.Now);                
            }
            
        }

        public void DeleteLocal()
        {
            if (!Directory.Exists(LocalImgFolder))
            {
                return;
            }
            string[] files = Directory.GetFiles(LocalImgFolder);

            foreach (var file in files)
            {         
                //get file age
                TimeSpan age = DateTime.Now.Subtract(File.GetCreationTime(file));
                                
                
                if (age.Days > daysToKeepLocalImagFiles)
                {
                    File.Delete(file);
                }
            }
        }
    }
}
