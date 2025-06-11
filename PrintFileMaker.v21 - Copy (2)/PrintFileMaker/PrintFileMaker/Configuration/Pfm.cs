using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Rutland.PrintFileMaker.Configuration
{
    public class Pfm : ConfigurationSection
    {
        [ConfigurationProperty("pfmSettings")]
        public PfmSettings PfmSettings
        {
            get
            {
                return this["pfmSettings"] as PfmSettings;
            }
            set
            {
                this["defaultPrintFileFolder"] = value;
            }
        }
    }
}
