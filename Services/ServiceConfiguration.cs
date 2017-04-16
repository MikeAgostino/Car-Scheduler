using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Services
{
    public class ServiceConfiguration
    {
        public static void Configure()
        {
            //Total Service Configuration
            RegisterMappings();
        }

        /// <summary>
        /// Maps all of the DTOs to the objects in the Data layer
        /// </summary>
        public static void RegisterMappings()
        {
            var profileType = typeof(Profile);

            var profiles = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => profileType.IsAssignableFrom(t)
                            && t.GetConstructor(Type.EmptyTypes) != null)
                    .Select(Activator.CreateInstance)
                    .Cast<Profile>().ToList();

            Mapper.Initialize(a => profiles.ForEach(a.AddProfile));

            Mapper.AssertConfigurationIsValid();
        }
    }
}