using System;
using System.Collections;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Rutland.PrintFileMaker.Configuration
{
    public class PfmSettings : ConfigurationSection
    {
        [ConfigurationProperty("defaultPrintFileFolder")]
        public string DefaultPrintFileFolder
        {
            get
            {
                return (string)this["defaultPrintFileFolder"];
            }
            set
            {
                this["defaultPrintFileFolder"] = value;
            }
        }

        [ConfigurationProperty("defaultImageFileFolder")]
        public string DefaultImageFolder
        {
            get
            {
                return (string)this["defaultImageFileFolder"];
            }
            set
            {
                this["defaultImageFileFolder"] = value;
            }
        }

        [ConfigurationProperty("localImageFolder")]
        public string LocalImageFolder
        {
            get
            {
                return (string)this["localImageFolder"];
            }
            set
            {
                this["localImageFolder"] = value;
            }
        }

        [ConfigurationProperty("daysToKeepLocalImageFiles")]
        public int DaysToKeepLocalImageFiles
        {
            get
            {
                return (int)this["daysToKeepLocalImageFiles"];
            }
            set
            {
                this["daysToKeepLocalImageFiles"] = value;
            }
        }

        [ConfigurationProperty("defaultBlankImageFile")]
        public string DefaultBlankImageFile
        {
            get
            {
                return (string)this["defaultBlankImageFile"];
            }
            set
            {
                this["defaultBlankImageFile"] = value;
            }
        }

        public override bool IsReadOnly()
        {
            return false;
        }
    }
}
