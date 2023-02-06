using BankAPI.Data;
using BankAPI.Data.BankModels;
using BankAPI.Data.DTOs;
using Microsoft.EntityFrameworkCore;
using TestBankAPI.Data.DTOs;

namespace TestBankAPI.Services;

public class LoginServices
{ 
    private readonly BankContext _context;

    public LoginServices(BankContext context)
    {
      _context = context;
    }

   public async Task<Administrador?> GetAdmin(AdminDto admin)
   {
    return await _context.Administradors.SingleOrDefaultAsync(x => x.Email == admin.Email && x.Pwd == admin.Pwd);
   }
}