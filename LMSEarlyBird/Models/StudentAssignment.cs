﻿using System.ComponentModel.DataAnnotations;

namespace LMSEarlyBird.Models
{
    public class StudentAssignment
    {
        [Key]
        public int Id { get; set; }
        public string StudentId { get; set; }
        public AppUser Student { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public int Score { get; set; }
        public bool Submitted { get; set; }
        public bool Graded { get; set; }
        public bool CreatedNotification { get; set; }
        public bool GradedNotification { get; set; }
        public string? Submission { get; set; }
        public DateTime? SubmissionTime { get; set; }
        public string? SubmissionComment { get; set; }
        public string? FileName { get; set; }
    }
}