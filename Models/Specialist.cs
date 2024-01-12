﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WPR;

namespace WPR
{
    [Table("Specialists")]
    public class Specialist : OurUser

    {
        public int LocationId {get; set;}
        [ForeignKey(nameof(LocationId))]
        public Location Location { get; set; }

        
        public string ToolsUsing { get; set; }
        public MessagePrefence MessagePreference { get; set; }
        public ICollection<DoesResearch> doesResearches {get;}
        public IEnumerable<Disability> Disabilities { get; set; }
        [StringLength(1024, MinimumLength = 2)]
        public string DisabilityNote {  get; set; }
        [Required]
        public bool ApproachCommercialParties { get; set; }
        public string TrackingID { get; set; }
        public int GuardianID{get; set;}
        [ForeignKey(nameof(GuardianID))]
        public Guardian Guardian { get; set; }
        

        public Specialist(){
            this.Role = "Specialist";
        }
    }

    public enum MessagePrefence
    {
        Phone,
        Portal
    } 
}