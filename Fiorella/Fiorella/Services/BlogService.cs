using System;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Blog;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;

        public BlogService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BlogVM>> GetAllAsync()
        {
            IEnumerable<Blog> blogs= await _context.Blogs.ToListAsync();
            return blogs.Select(m => new BlogVM { Title = m.Title, Description = m.Description, Image = m.Image, CreatedDate = m.CreatedDate.ToString("MM.dd.yyyy") });
        }
    }
}

