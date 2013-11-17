using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLParser
{
    [Serializable]
    public class ApplicationConfiguration
    {
        public string DefaultVisualizerName;

        public Guid DefaultVisualizerGuid;

        public string DefaultEtwProfileName;

        public const int maxRecentFileEntries = 10;
        public List<string> RecentFileList = new List<string>();

        public const int maxRecentFilterEntries = 10;
        public List<string> RecentFilterList = new List<string>();

        public uint MessageBufferSizeMB = 200;
        public uint DropPercentage = 5;

        public bool ShowBuild = false;

        public string LastOpenSavedLocation;

        public bool ShowDateAndTime = true;
        public string TziId = string.Empty;

        public string DefaultLogFileReaderModule = string.Empty;
    }
}
