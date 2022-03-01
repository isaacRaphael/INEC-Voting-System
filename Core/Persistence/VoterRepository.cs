using Core.Contracts;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Persistence
{
    public class VoterRepository : IVoterRepository
        
    {
 
        private readonly Database _database;
        public VoterRepository(Database database)
        {
            _database = database;

        }

        public Voter Add(Voter entity)
        {
            _database.VoterTable.Add(entity);
            return new Voter(entity.Id, entity.Registration_No)
            {
                HasVoted = entity.HasVoted,
                CreatedOn = entity.CreatedOn,
                ModifiedOn = entity.ModifiedOn,
                DateOfBirth = entity.DateOfBirth,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                MiddleName = entity.MiddleName,
                PollingUnit = entity.PollingUnit
            }; 
        }

        public async Task<Voter> AddAsync(Voter entity)
        {
            _database.VoterTable.Add(entity);

            await Task.Delay(1000);
            return new Voter(entity.Id, entity.Registration_No)
            {
                HasVoted = entity.HasVoted,
                CreatedOn = entity.CreatedOn,
                ModifiedOn = entity.ModifiedOn,
                DateOfBirth = entity.DateOfBirth,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                MiddleName = entity.MiddleName,
                PollingUnit = entity.PollingUnit
            };
        }

        public bool Delete(Voter entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Voter entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Voter> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Voter>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Voter GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Voter> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Voter entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Voter entity)
        {
            throw new NotImplementedException();
        }
    }
}
