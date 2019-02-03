using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JustABackup.PluginRepository.Database.Entities
{
    public class PluginVersion
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Version { get; set; }

        [Required]
        public DateTime Uploaded { get; set; }

        [Required]
        public string SourceURL { get; set; }

        [Required]
        public Owner Owner { get; set; }

        public string License { get; set; }

        public string LicenseURL { get; set; }

        public List<PluginVersionDependency> Dependencies { get; set; }

        public PluginVersion()
        {
            this.Dependencies = new List<PluginVersionDependency>();
        }
    }
}
