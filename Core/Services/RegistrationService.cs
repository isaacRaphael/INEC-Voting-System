using Core.Contracts;
using Core.DTOs;
using Core.Persistence;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IVoterRepository _voterRepo;
        public RegistrationService(IVoterRepository voterRepository)
        {
            _voterRepo = voterRepository;
        }

        public async Task<Voter> RegisterNewVoter(VoterRegDTO model)
        {
            
            Voter newVoter = new Voter()
            {
                FirstName = model.FirstName,
                DateOfBirth = model.DateOfBirth,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                PollingUnit = new PollingUnit("ABS"),
                Gender = model.Gender
            };
            try
            {
                var x = await  _voterRepo.AddAsync(newVoter);
                return x;
            } catch(Exception)
            {

            }
            return null;
        }
    }
}
