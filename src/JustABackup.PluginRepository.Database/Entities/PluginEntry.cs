using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JustABackup.PluginRepository.Database.Entities
{
    public class PluginEntry
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Identifier { get; set; }

        [Required]
        public PluginVersion LatestVersion { get; set; }

        public List<PluginVersion> Versions { get; set; }

        public PluginEntry()
        {
            this.Versions = new List<PluginVersion>();
        }
    }
}
