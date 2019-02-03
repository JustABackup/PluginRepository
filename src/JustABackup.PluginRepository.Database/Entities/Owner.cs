using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JustABackup.PluginRepository.Database.Entities
{
    public class Owner
    {
        [Key]
        [Required]
        public int ID { get; set; }
        
        [Required]
        public string GitHubID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
