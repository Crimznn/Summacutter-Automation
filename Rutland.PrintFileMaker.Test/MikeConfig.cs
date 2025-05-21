using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Rutland.PrintFileMaker.Test.Configuration
{
    public class MikeConfig : ConfigurationSection
    {
        [ConfigurationProperty("quoteOfTheDay", DefaultValue = "It is what it is.", IsRequired = false)]
        public string QuoteOfTheDay
        {
            get
            {
                return this["quoteOfTheDay"] as string;
            }
        }

        [ConfigurationProperty("yourAge", IsRequired = true)]
        public int YourAge
        {
            get
            {
                return (int)this["yourAge"];
            }
        }

    }
}
