using System;
using System.Collections.Generic;

namespace BO.Entity
{
    /// <summary>
    /// Client is a user of FoodBook
    /// </summary>
    public class Client
    {
        /// <summary>
        /// int. Identifier
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// Default Constructor for API serialisation
        /// </summary>
        public Client() { }
        /// <summary>
        /// Utilitary constructor full properties
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <param name="isAdmin"></param>
        public Client(int? id, string name, string phoneNumber, string password, bool isAdmin)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Password = password;
            IsAdmin = isAdmin;
        }
        /// <summary>
        /// Override Equals Methode for Client
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   Id == client.Id &&
                   Name == client.Name &&
                   PhoneNumber == client.PhoneNumber &&
                   Password == client.Password &&
                   IsAdmin == client.IsAdmin;
        }
        /// <summary>
        /// Override GetHasCode Methode for Client
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hashCode = 1595133216;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + IsAdmin.GetHashCode();
            return hashCode;
        }

        
    }
}
