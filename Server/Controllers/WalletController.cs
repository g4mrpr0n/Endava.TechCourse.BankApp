using Endava.TechCourse.BankApp.Domain.Models;
using Endava.TechCourse.BankApp.Infrastructure.Persistence;
using Endava.TechCourse.BankApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Endava.TechCourse.BankApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WalletController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public async Task<List<Wallet>> GetWallets()
        {
            return await _context.Wallets
                .Include(wallet => wallet.Currency)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Wallet?> GetWalletById(Guid id)
        {
            return await _context.Wallets
                .Include(wallet => wallet.Currency)
                .FirstOrDefaultAsync(wallet => wallet.Id == id);
        }

        [HttpPost]
        public IActionResult CreateWallet(CreateWalletDTO createWalletDto)
        {
            var wallet = new Wallet
            {
                Type = createWalletDto.Type,
                Amount = createWalletDto.Amount,
                Currency = new Currency
                {
                    Name = createWalletDto.Currency.Name,
                    CurrencyCode = createWalletDto.Currency.CurrencyCode,
                    ChangeRate = createWalletDto.Currency.ChangeRate
                }
            };

            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return Ok();
        }
    }
}