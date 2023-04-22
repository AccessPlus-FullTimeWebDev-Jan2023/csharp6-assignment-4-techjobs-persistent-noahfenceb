using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobs6Persistent.ViewModels;

    public class AddJobViewModel
{
	
	public string Name { get; set; }
	public int EmployerId { get; set; }
	public List<SelectListItem>? Employers { get; set; }
    public AddJobViewModel()
		{

		}

	}


