using bht_demo.Models;
using System.Collections;
using System.Collections.Generic;

namespace bht_demo.ViewModels
{
    public class ServiceVM
    {
        public ServiceAndAbout ServiceAndAbout { get; set; }
        public IEnumerable<ContactUs> ContactUs { get; set; }
    }
}
