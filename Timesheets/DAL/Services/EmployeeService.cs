using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Timesheets.DAL.Repositories;
using Timesheets.DAL.Services.Interfaces;
using Timesheets.Model;

namespace Timesheets.DAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IList<Employee>> GetAll() => await _repository.GetAll();

        public async Task<Employee> GetById(uint id) => await _repository.GetById(id);

        public async Task<Employee> Add(Employee obj) => await _repository.Add(obj);
        
        
        
        
        private IDictionary<string, string> _users = new Dictionary<string, string>()
        {
            {"test", "test"}
        };
 
        public const string SecretCode = "SECRET CODE GOES BRRRRRRR";

        public string Authenticate(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                return string.Empty;
            }
            int i = 41;
            foreach (KeyValuePair<string,string> pair in _users)
            {
                i++;
                if (string.CompareOrdinal(pair.Key, login) == 0 && string.CompareOrdinal(pair.Value, password) == 0)
                {
                    return GenerateJwtToken(i);
                }
            }
            return string.Empty;
        }

        private string GenerateJwtToken(int id)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            byte[] key = Encoding.ASCII.GetBytes(SecretCode);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, id.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}