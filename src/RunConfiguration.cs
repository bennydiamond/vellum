﻿namespace Vellum
{
    public struct RunConfiguration
    {
        public string BdsBinPath;
        public string WorldName;
        public BackupConfig Backups;
        public RenderConfig Renders;
        public bool QuietMode;
        public bool HideStdout;
        public bool BusyCommands;
        public bool CheckForUpdates;
    }

    public struct BackupConfig
    {
        public bool EnableBackups;
        public double BackupInterval;
        public string ArchivePath;
        public int BackupsToKeep;
        public bool StopBeforeBackup;
        public uint NotifyBeforeStop;
        public bool BackupOnStartup;
        public string PreExec;
        public string PostExec;
    }

    public struct RenderConfig
    {
        public bool EnableRenders;
        public string PapyrusBinPath;
        public string PapyrusOutputPath;
        public double RenderInterval;
        public string PapyrusGlobalArgs;
        public string[] PapyrusTasks;

    }
}
