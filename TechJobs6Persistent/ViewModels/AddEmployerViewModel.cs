using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
	public class AddEmployerViewModel
	{
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string? Name  { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string? Location { get; set; }


		public AddEmployerViewModel()
		{
			
		}
	}
}

