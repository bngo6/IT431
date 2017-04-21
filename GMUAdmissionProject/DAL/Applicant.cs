using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GMUAdmissionProject.DAL
{
    public class Applicant
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Must be in the format of xxx-yy-zzzz")]
        [Display(Name = "Social Security Number")]
        public string SSN { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Required]
        [StringLength(60)]
        public string City { get; set; }

        [Required]
        [StringLength(60)]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string Zipcode { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Highschool Name")]
        public string HSName { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Highschool City")]
        public string HSCity { get; set; }

        [Required]
        [Display(Name = "Graduation Date")]
        [DataType(DataType.Date)]
        public string GradDate { get; set; }

        [Required]
        [Range(0, 4)]
        public double GPA { get; set; }

        [Required]
        [Display(Name = "Math Score")]
        [Range(0, 800)]
        public double MthScore { get; set; }

        [Required]
        [Display(Name = "Verbal Score")]
        [Range(0, 800)]
        public double VerbScore { get; set; }

        [Required]
        [Display(Name = "Area of Interest")]
        public string AreaOfInterest { get; set; }

        [Required]
        [Display(Name = "Student Type")]
        public string StuType { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        public string EnrollDate { get; set; }

        [Required]
        [Display(Name = "Enrollment Year")]
        public string EnrollYear { get; set; }

        [Required]
        [Display(Name = "Submission Date")]
        [DataType(DataType.Date)]
        public string SubDate { get; set; }

        [Display(Name = "Admission Decision")]
        public string AdDecision { get; set; }
        
    }
}