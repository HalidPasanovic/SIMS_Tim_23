// File:    SecretaryService.cs
// Author:  halid
// Created: Saturday, 16 April 2022 01:46:35
// Purpose: Definition of Class SecretaryService

using Model;
using System;
using System.Collections.Generic;
using Repository;

namespace Service
{
   public class SecretaryService : ICrud<Secretary>
   {
      private static SecretaryService instance = null;
      
      public void Create(Secretary newSecretary)
      {
         throw new NotImplementedException();
      }
      
      public void Update(Secretary secretary)
      {
         throw new NotImplementedException();
      }
      
      public void Delete(int id)
      {
         throw new NotImplementedException();
      }
      
      public Secretary Read(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<Secretary> GetAll()
      {
            return SecretaryRepository.Instance.GetAll();
      }
      public SecretaryService()
      {

      }

      public static SecretaryService Instance
      {
          get
          {
              if (instance == null)
              {
                  instance = new SecretaryService();
              }
              return instance;
          }
      }
    }
}