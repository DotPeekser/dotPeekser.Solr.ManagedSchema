﻿namespace Sitecore.Solr.ManagedSchema.Logging
{
    using Sitecore.Diagnostics;
    using Sitecore.Solr.ManagedSchema.Interfaces;

    public class ScLogger : IManagedSchemaLogger
    {
        public void Debug(string message, object owner)
        {
            Log.Debug(message, owner);
        }

        public void Warn(string message, object owner)
        {
            Log.Warn(message, owner);
        }

        public void Error(string message, object owner)
        {
            Log.Error(message, owner);
        }
    }
}
