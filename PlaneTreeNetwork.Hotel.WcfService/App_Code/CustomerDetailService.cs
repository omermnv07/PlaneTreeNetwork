using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Business.DependencyResolvers.Ninject;
using PlaneTreeNetwork.Hotel.Business.ServiceContract.Wcf;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerDetailService
/// </summary>
public class CustomerDetailService:ICustomerDetailService
{
    ICustomerService _customerService = InstanceFactory.GetInstance<ICustomerService>();
    public List<Customer> GetAll()
    {
        return _customerService.GetAll();
    }
}