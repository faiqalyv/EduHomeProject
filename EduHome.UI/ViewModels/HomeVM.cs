using System;
using EDUHome.Core.Entities;

namespace EduHome.UI.ViewModels;

public class HomeVM
{
	public IEnumerable<Course> courses { get; set; }
    public IEnumerable<Notice> notices { get; set; }
}

