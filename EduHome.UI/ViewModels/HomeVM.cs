using System;
using EDUHome.Core.Entities;

namespace EduHome.UI.ViewModels;

public class HomeVM
{
	public IEnumerable<Course> courses { get; set; }
    public IEnumerable<Notice> notices { get; set; }
    public IEnumerable<Choose> chooses{ get; set; }
    public IEnumerable<Testimonial> testimonials{ get; set; }
  
}

