﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace Updater
{
    public class ProjectUpdater
    {
        private string currentApplicatioName;
        private int currentApplicationVersion;
        private string githubProjectUrl = "https://api.github.com/repos/sidf/{0}/releases";
        private const string userAgent = "User-Agent:Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";

        public ProjectUpdater(Form currentApplicationInstance)
        {
            currentApplicatioName = currentApplicationInstance.ProductName;
            githubProjectUrl = string.Format(githubProjectUrl, currentApplicatioName);
            currentApplicationVersion = VersionStringToNumber(currentApplicationInstance.ProductVersion);
        }

        private string FetchReleasesList()
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.Headers.Add(userAgent);
                    return client.DownloadString(githubProjectUrl);
                }
                catch (WebException ex)
                {
                    // url down/not internet connection/etc
                }
                return null;
            }
        }

        private int GetLatestReleaseVersion(dynamic parsedLastReleaseData)
        {
            return VersionStringToNumber(parsedLastReleaseData["name"]);
        }

        private string GetLatestReleaseUrl(dynamic parsedLastReleaseData)
        {
            return parsedLastReleaseData["assets"][0]["browser_download_url"];
        }

        private dynamic ParsedLastReleaseData(string releasesJson)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                dynamic parsedReleases = serializer.DeserializeObject(releasesJson);
                return parsedReleases[0];
            }
            catch
            {
                // string can't be parsed
            }

            return null;
        }

        public bool InstallAnyUpdates()
        {
            var releasesJson = FetchReleasesList();

            if (releasesJson != null)
            {
                dynamic parsedLastReleaseData = ParsedLastReleaseData(releasesJson);

                if (parsedLastReleaseData == null)
                {
                    return false;
                }

                if (GetLatestReleaseVersion(parsedLastReleaseData) <= currentApplicationVersion)
                {
                    return false;
                }

                var downloadPath = DownloadRelease(GetLatestReleaseUrl(parsedLastReleaseData));

                if (downloadPath == null)
                {
                    return false;
                }

                ApplyUpdate();
            }

            return false;
        }

        private void ApplyUpdate()
        {
            throw new NotImplementedException();
        }

        private string DownloadRelease(string releaseUrl)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add(userAgent);

                string downloadedFileName = Path.GetFileName(releaseUrl); ;

                try
                {
                    client.DownloadFile(releaseUrl, downloadedFileName);
                    return downloadedFileName;
                }
                catch (WebException ex)
                {
                    // no internet connection / dead url /etc
                }
                return null;
            }
        }

        private static int VersionStringToNumber(string applicationVersion)
        {
            return Convert.ToInt32(string.Join("", applicationVersion.Where(character => char.IsDigit(character))));
        }
    }
}
