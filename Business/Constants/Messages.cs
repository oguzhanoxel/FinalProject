using Core.Entities.Concreate;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Dummy = "Dummy";
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Invaled product name";
        public static string MaintenanceTime = "System is under maintenance";
        public static string ProductListed = "Products listed";
        public static string ProductCountOfCategoryError = "The number of products should be less than 10";
        public static string ProductUpdated = "Product Updated";
        public static string ProductNameAlreadyExists = "Product name exists";
        public static string CategoryLimitExceded="Category limit exceded";
        public static string AuthorizationDenied="Access Denied";
        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Login Success";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access token created";
    }
}
