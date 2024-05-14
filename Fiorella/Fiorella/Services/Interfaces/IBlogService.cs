using System;
using Fiorella.Models;
using Fiorella.ViewModels.Blog;

namespace Fiorella.Services.Interfaces
{
	public interface IBlogService
	{
		Task<IEnumerable<BlogVM>> GetAllAsync();
	}
}

