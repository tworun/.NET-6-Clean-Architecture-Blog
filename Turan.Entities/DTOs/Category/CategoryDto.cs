﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Entities.Concrete;
using Turan.Shared.Entities.Abstract;

namespace Turan.Entities.DTOs
{
	public class CategoryDto : IDto
	{
		public int Id { get; set; }
		public DateTime CreatedTime { get; set; }
		public DateTime? ModifiedTime { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public ICollection<Concrete.Article> Articles { get; set; }
	}
}
