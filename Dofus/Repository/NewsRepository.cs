using Dofus.Data;
using Dofus.Models;
using Dofus.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dofus.Repository
{
    public class NewsRepository : INewsRepository
    {
        private readonly DofusContext _context;

        public NewsRepository(DofusContext context)
        {
            _context = context;
        }

        // Implementing GetAllNewsAsync method
        public async Task<IEnumerable<News>> GetAllNewsAsync()
        {
            return await _context.NewsItems.ToListAsync();
        }

        // Implementing GetNewsByIdAsync method
        public async Task<News> GetNewsByIdAsync(int id)
        {
            return await _context.NewsItems.FindAsync(id);
        }

        // Implementing AddNewsAsync method
        public async Task AddNewsAsync(News news)
        {
            _context.NewsItems.Add(news);
            await _context.SaveChangesAsync();
        }

        // Implementing UpdateNewsAsync method
        public async Task UpdateNewsAsync(News news)
        {
            _context.Entry(news).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Implementing DeleteNewsAsync method
        public async Task DeleteNewsAsync(int id)
        {
            var news = await _context.NewsItems.FindAsync(id);
            if (news != null)
            {
                _context.NewsItems.Remove(news);
                await _context.SaveChangesAsync();
            }
        }
    }
}
