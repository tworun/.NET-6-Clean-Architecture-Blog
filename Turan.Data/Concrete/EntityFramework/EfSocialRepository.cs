﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turan.Data.Concrete.EntityFramework.Contexts;
using Turan.Entities.Concrete;
using Turan.Shared.Data.Concrete.EntityFramework;

namespace Turan.Data.Concrete.EntityFramework
{
	public class EfSocialRepository : EfEntityRepositoryBase<Social, MsDbContext>
	{
		public EfSocialRepository(MsDbContext context) : base(context)
		{
		}
	}
}
