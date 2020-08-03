﻿using System.Collections.Generic;
using Statiq.Common;
using Statiq.Core;

namespace Statiq.Web.Pipelines
{
    public class Assets : Pipeline
    {
        public Assets()
        {
            Isolated = true;

            ProcessModules = new ModuleList
            {
                new CopyFiles(Config.FromSetting<IEnumerable<string>>(WebKeys.AssetFiles))
            };
        }
    }
}
