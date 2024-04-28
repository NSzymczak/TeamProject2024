using AnimalHotel.Core;
using AnimalHotel.Model;
using AnimalHotel.Page.AddAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel.Connection
{
    public class ConnectToDb
    {
        private AnimalHotelDb animalHotelDb;

        public ConnectToDb()
        {
            animalHotelDb = new AnimalHotelDb();
        }

        /// <summary>
        /// Returns all animals
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Animal>> GetAnimals()
        {
            return Task.FromResult(animalHotelDb.Animal ?? Enumerable.Empty<Animal>());
        }

        /// <summary>
        /// Returns all owners
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Owner>> GetOwners()
        {
            return Task.FromResult(animalHotelDb.Owner ?? Enumerable.Empty<Owner>());
        }

        /// <summary>
        /// Return all visits
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Visit>> GetVisits()
        {
            return Task.FromResult(animalHotelDb.Visits ?? Enumerable.Empty<Visit>());
        }

        /// <summary>
        /// Return all daily activity
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<DailyActivity>> GetDailyActivity()
        {
            return Task.FromResult(animalHotelDb.DailyActivity ?? Enumerable.Empty<DailyActivity>());
        }

        /// <summary>
        /// When owner exist in database edit him, if not add.
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public async Task<bool> AddOrEditOwner(Owner owner)
        {
            var cancellationToken = new CancellationToken();
            try
            {
                var prevOwner = animalHotelDb.Owner.Where(x => x.ID == owner.ID).FirstOrDefault();
                if (prevOwner is null)
                {
                    await animalHotelDb.Owner.AddAsync(owner, cancellationToken);
                }
                else
                {
                    prevOwner.Name = owner.Name;
                    prevOwner.Surname = owner.Surname;
                    prevOwner.Address = owner.Address;
                    prevOwner.Email = owner.Email;
                    prevOwner.PhoneNumber = owner.PhoneNumber;
                }

                await animalHotelDb.SaveChangesAsync(true, cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// When animal exist in database edit him, if not add.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public async Task<bool> AddOrEditAnimal(Animal animal)
        {
            try
            {
                var prevAnimal = animalHotelDb.Animal.Where(x => x.ID == animal.ID).FirstOrDefault();
                if (prevAnimal is null)
                {
                    await animalHotelDb.Animal.AddAsync(animal);
                }
                else
                {
                    prevAnimal.Name = animal.Name;
                    prevAnimal.Health = animal.Health;
                    prevAnimal.WalkRules = animal.WalkRules;
                    prevAnimal.FeedingRules = animal.FeedingRules;
                    prevAnimal.Details = animal.Details;
                }

                await animalHotelDb.SaveChangesAsync(true, new CancellationToken());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// When visit exist in database edit him, if not add.
        /// </summary>
        /// <param name="visit"></param>
        /// <returns></returns>
        public async Task<bool> AddOrEditVisit(Visit visit)
        {
            var cancellationToken = new CancellationToken();
            try
            {
                var prevVisit = animalHotelDb.Visits.Where(x => x.ID == visit.ID).FirstOrDefault();
                if (prevVisit is null)
                {
                    await animalHotelDb.Visits.AddAsync(visit, cancellationToken);
                }
                else
                {
                    prevVisit.EndDate = visit.EndDate;
                    prevVisit.BeginDate = visit.BeginDate;
                }
                await animalHotelDb.SaveChangesAsync(true, cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// When activity exist in database edit him, if not add.
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        public async Task<bool> AddOrEditDailyActivity(DailyActivity activity)
        {
            var cancellationToken = new CancellationToken();
            try
            {
                var prevActivity = animalHotelDb.DailyActivity.Where(x => x.ID == activity.ID).FirstOrDefault();
                if (prevActivity is null)
                {
                    await animalHotelDb.DailyActivity.AddAsync(activity, cancellationToken);
                }
                else
                {
                    prevActivity.Date = activity.Date;
                    prevActivity.Hour = activity.Hour;
                    prevActivity.Animal = activity.Animal;
                    prevActivity.AdditionalNotes = activity.AdditionalNotes;
                }
                await animalHotelDb.SaveChangesAsync(true, cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}