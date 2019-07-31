using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Xamarin.Forms;

namespace MobileApp
{
    class ContributorDataAccessClass
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public ObservableCollection<ContributorModel> Contributors { get; set; }

        public ContributorDataAccessClass()
        {
            database = DependencyService.Get<IDatabaseConnection>().DbConnection();
            database.CreateTable<ContributorModel>();
            this.Contributors = new ObservableCollection<ContributorModel>(database.Table<ContributorModel>());
            AddNewContributor();
            DeleteContributor();
            
        }
        public void AddNewContributor()
        {
            this.Contributors.Add(new ContributorModel
            {
                Name = "Name...",
                PhysicalAddress = "Address...",
                Email = "Email...",
                PhoneNumber = "Phone...",
            });
        }

        public void DeleteContributor()
        {
            this.Contributors.Remove(new ContributorModel
            {
                Name = "Name...",
                PhysicalAddress = "Address...",
                Email = "Email...",
                PhoneNumber = "Phone...",
            });
        }

        


        public ContributorModel GetContributor(int id)
        {
            lock (collisionLock)
            {
                return database.Table<ContributorModel>().FirstOrDefault(contributor => contributor.Id == id);

            }
        }

        public int SaveContributor(ContributorModel contributorInstane)
        {
            lock (collisionLock)
            {
                if (contributorInstane.Id != 0)
                {
                    database.Update(contributorInstane);
                    return contributorInstane.Id;
                }
                else
                {
                    database.Insert(contributorInstane);
                    return contributorInstane.Id;
                }
            }
        }

        public int DeleteContributor(ContributorModel contributorInstance)
        {
            var id = contributorInstance.Id;
            if (id != 0)
            {
                lock (collisionLock)
                {
                    database.Delete<ContributorModel>(id);
                }
            }
            this.Contributors.Remove(contributorInstance);
            return id;
        }
    }
 }
