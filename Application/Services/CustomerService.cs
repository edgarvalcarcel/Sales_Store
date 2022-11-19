using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Interfaces;
//using Application.ViewModels;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class CustomerService : ICustomerService
    {
        public IUserRepository _userRepository;
        public CustomerService(IUserRepository userRepository)
        {
            _userRepository= userRepository;
        }

        //public CustomerViewModel GetCustomerById(int Id)
        //{
        //    var CustomerView = _userRepository.GetAuthorById(Id);
        //    return new CustomerViewModel()
        //    {
        //        Id = (int)CustomerView.Id,
        //        Name = CustomerView.Name,
        //        SurName = CustomerView.SurName
        //    };
        //} 
    }
}
