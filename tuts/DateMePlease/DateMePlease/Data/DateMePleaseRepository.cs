using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateMePlease.Entities;

namespace DateMePlease.Data
{
    public class DateMePleaseRepository : IDateMePleaseRepository
    {
        private DateMePleaseContext _context;

        public DateMePleaseRepository(DateMePleaseContext context)
        {
            _context = context;
        }
        public List<InterestType> GetInterestTypes()
        {
            return _context.InterestTypes.OrderBy(i => i.Name).ToList();
        }

        public Profile GetProfile(string memberName)
        {
            var lowerMemberName = memberName.ToLowerInvariant();
            return _context.Profile
                           .Include("Demographics")
                           .Include("Interests.InterestType")
                           .Include("Photos")
                           .Include("Member")
                           .Where(m => m.Member.MemberName.ToLower() == lowerMemberName).FirstOrDefault();
        }

        public Profile GetProfileByUserName(string username)
        {
            var lowerUserName = username.ToLowerInvariant();
            return _context.Profile
                           .Include("Demographics")
                           .Include("Interests.InterestType")
                           .Include("Photos")
                           .Include("Member")
                           .Where(m => m.Member.Username.ToLower() == lowerUserName).FirstOrDefault();
        }

        public List<Profile> GetRandomProfiles(int numberToReturn)
        {
            return _context.Profile.Include("Photo")
                                   .Include("Member")
                                   .OrderBy(p => Guid.NewGuid())
                                   .Take(numberToReturn)
                                   .ToList();
        }

        public bool SaveAll()
        {
            try
            {
                return (!_context.ChangeTracker.HasChanges()) || _context.SaveChanges() > 0; // only return if at least one row was changed
            }
            catch (Exception ex)
            {
                // todo add loggin
                return false;
                throw;
            }
        }
    }
}
