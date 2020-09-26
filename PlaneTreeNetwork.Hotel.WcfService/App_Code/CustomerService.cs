using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Business.Concrete.Managers;
using PlaneTreeNetwork.Hotel.Business.DependencyResolvers.Ninject;
using PlaneTreeNetwork.Hotel.DataAccess.Concrete.EntityFramework;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerService
/// </summary>
public class CustomerService : ICustomerService
{
    public CustomerService()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    //---------------------------------------------------------------------------------//
    ICustomerService _customerService = InstanceFactory.GetInstance<ICustomerService>();
    //---------------------------------------------------------------------------------//


    public Customer Add(Customer customer)
    {
        return _customerService.Add(customer);
    }

    public List<Customer> GetAll()
    {
        return _customerService.GetAll();
    }

    public Customer GetById(int id)
    {
        return _customerService.GetById(id);
    }

    public void TransactionalOperation(Customer customer1, Customer customer2)
    {
        _customerService.TransactionalOperation(customer1, customer2);
    }

    public Customer Update(Customer customer)
    {
        return _customerService.Update(customer);
    }
}