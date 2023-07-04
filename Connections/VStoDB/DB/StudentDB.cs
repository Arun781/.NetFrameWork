using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//for using identity column
//using System.ComponentModel.DataAnnotations.Schema;
namespace VStoDB.DB
{
    public partial class StudentDB
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage ="Please enter ID")]
        public int sID { get; set; }
        [Required (ErrorMessage ="Please enter Your name")]
        [StringLength (50)]
        public string sName { get; set; }
        [Required (ErrorMessage ="Please enter Your first name")]
        [StringLength (50)]
        public string sFirstName { get; set; }
        [Required(ErrorMessage = "Please enter Your last name")]
        [StringLength(50)]
        public string sLastName { get; set; }
        [Required(ErrorMessage = "You Must enter marks")]
        [Range (0, 100)]
        public decimal sMarks { get; set; }
    }
}
