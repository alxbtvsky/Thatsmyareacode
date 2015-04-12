using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace thatsmyareacode.Models
{
    public class Zinger
    {
        public int ZingerID { get; set; }
        public string ZingerMessage { get; set; }
        public string ZingerImage { get; set; }
        public string ZingerUserName { get; set; }
        public string Genre { get; set; }
        public string AreaCode { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public bool Favorite { get; set; }
        [Display(Name = "Time Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TimeCreated { get; set; }

    }

    public class ZingerDBContext : DbContext
    {
        public DbSet<Zinger> Zingers { get; set; }
    }
}