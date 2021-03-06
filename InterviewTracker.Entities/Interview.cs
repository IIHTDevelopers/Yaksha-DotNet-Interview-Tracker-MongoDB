using MongoDB.Bson;
using Newtonsoft.Json;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InterviewTracker.Entities
{
    public class Interview
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string InterviewId { get; set; }
        [Required]
        [Display(Name = "Interview Name")]
        [BsonElement("InterviewName")]
        [MaxLength(50, ErrorMessage = "Interview Name Cannot exceed 50 Characters")]
        public string InterviewName { get; set; }
        [Required]
        [Display(Name = "Interviewer")]
        [JsonProperty("Interviewer")]
        [BsonElement("Interviewer")]
        public string Interviewer { get; set; }
        [Required]
        [Display(Name = "Interview For")]
        [JsonProperty("InterviewUser")]
        [BsonElement("InterviewUser")]
        public string InterviewUser { get; set; }
        [Required]
        [Display(Name = "User Skills")]
        public string UserSkills { get; set; }
        [Required]
        [Display(Name = "Interview Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InterviewDate { get; set; }
        [Required]
        [Display(Name = "Interview Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        public DateTime InterviewTime { get; set; }
        [Required]
        [Display(Name = "Interview Status")]
        public InterviewStatus? InterViewsStatus { get; set; }
        [Required]
        [Display(Name = "Techinical Status")]
        public TechnicalInterviewStatus? TInterViews { get; set; }
        public string Remark { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}
