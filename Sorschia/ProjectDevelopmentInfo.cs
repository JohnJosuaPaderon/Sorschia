using System;
using System.Linq;

namespace Sorschia
{
    public sealed class ProjectDevelopmentInfo
    {
        static ProjectDevelopmentInfo()
        {
            InfoList = new ProjectDevelopmentInfo[]
            {
                new ProjectDevelopmentInfo(
                    "2.0.10",
                    new string[] { "John Josua R. Paderon" },
                    new DateTime(2018, 03, 12),
                    "Sorschia"),
                new ProjectDevelopmentInfo(
                    "2.1.0-rc1",
                    new string[] { "John Josua R. Paderon" },
                    new DateTime(2018, 3, 15),
                    "Sorschia V.1"),
                new ProjectDevelopmentInfo(
                    "2.2.0",
                    new string[] { "John Josua R. Paderon" },
                    new DateTime(2018, 4, 3),
                    "Sorschia V.1")
            };

            Current = InfoList.Last();
        }

        public static ProjectDevelopmentInfo[] InfoList { get; }
        public static ProjectDevelopmentInfo Current { get; }

        private ProjectDevelopmentInfo(string version, string[] authors, DateTime releaseDate, string title)
        {
            Version = version;
            Authors = authors;
            ReleaseDate = releaseDate;
            Title = title;
        }

        public string Version { get; }
        public string[] Authors { get; }
        public DateTime ReleaseDate { get; }
        public string Title { get; }
    }
}
