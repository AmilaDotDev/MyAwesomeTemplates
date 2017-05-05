using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyCompany.Data.Infrastructure;
using System;

namespace $rootnamespace$
{
	/// <summary>
	/// Configure $entityname$ Entity
	/// </summary>
	public class $safeitemname$<$entityname$> : IDbEntityConfiguration<$entityname$>
	{
		/// <summary>
		/// $entityname$ Configuration
		/// </summary>
		public override void Configure(EntityTypeBuilder<$entityname$> entity)
		{
			base.Configure(entity);
		}
	}
}