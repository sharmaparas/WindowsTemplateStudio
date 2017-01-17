﻿using System;
using System.IO;

namespace Microsoft.Templates.Test
{
    public class GenerationTestsFixture : IDisposable
    {
        internal const string TestAppsPath = @"..\..\Tests\Apps\";
        internal const string TestPagesPath = @"..\..\Tests\Pages\";
        internal const string TemplatePath = @"..\..\..\Templates";

        public void Dispose()
        {
            if (Directory.Exists(TestAppsPath))
            {
                Directory.Delete(TestAppsPath, true);
            }
            if (Directory.Exists(TestPagesPath))
            {
                Directory.Delete(TestPagesPath, true);
            }
        }
    }
}