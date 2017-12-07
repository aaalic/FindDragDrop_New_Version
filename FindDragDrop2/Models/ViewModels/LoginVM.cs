using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindDragDrop2.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        [DataType(DataType.Password)] //stjärnor istället för tecken
        public string Password { get; set; }
    }
}
