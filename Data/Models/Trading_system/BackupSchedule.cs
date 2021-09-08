using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class BackupSchedule
    {
        public string DataBaseName { get; set; }
        public string BackupName { get; set; }
        public string BackupPath { get; set; }
        public string RestorePath { get; set; }
        public string BackupType { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }
        public int TimeBetweenBackup { get; set; }
    }
}
