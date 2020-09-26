using PlaneTreeNetwork.Core.CrossCuttingConcerns.Validation.FluentValidation;
using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Business.ValidationRules.FluentValidation;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneTreeNetwork.Core.Aspects.Postsharp;
using System.Transactions;
using PlaneTreeNetwork.Core.Aspects.Postsharp.ValidationAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.TransactionAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.CacheAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.LogAspects;
using PlaneTreeNetwork.Core.CrossCuttingConcerns.Caching.Microsoft;
using PlaneTreeNetwork.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using PlaneTreeNetwork.Core.Aspects.Postsharp.ExceptionAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.AuthorizationAspects;
using PlaneTreeNetwork.Core.Utilities.Mappings;
using AutoMapper;

namespace PlaneTreeNetwork.Hotel.Business.Concrete.Managers
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private readonly IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal,IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }


        [ExceptionLogAspect(typeof(DatabaseLogger))]
        [FluentValidationAspect(typeof(CustomerValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Customer Add(Customer customer)
        {
            return _customerDal.Add(customer);
        }



        [FluentValidationAspect(typeof(CustomerValidatior))]
        public Customer Update(Customer customer)
        {
            return _customerDal.Update(customer);
        }


        [CacheAspect(typeof(MemoryCacheManager))]
        [SecuredOperation(Roles="Editor,Admin")] //Authorized !!!
        public List<Customer> GetAll()
        {
            //return _customerDal.GetList().Select(p=> new Customer {
            //    CustomerId=p.CustomerId,
            //    CustomerLastName=p.CustomerLastName,
            //    CustomerName=p.CustomerName,
            //    CustomerYearOfBirth=p.CustomerYearOfBirth,
            //    UserId=p.UserId
            //}).ToList();
            //Mapperli durum altta.

            var customers = _mapper.Map<List<Customer>>(_customerDal.GetList());//AutoMapperHelper.MapToSameTypeList(_customerDal.GetList());
            return customers;
        }


        public Customer GetById(int id)
        {
            return _customerDal.Get(x => x.CustomerId == id);
        }


        [TransactionScopeAspect] // alttaki kodu try catch'e alıyor ve başlangıç bitişe göre kuralar veriyor vay be...
        [FluentValidationAspect(typeof(CustomerValidatior))]
        public void TransactionalOperation(Customer customer1, Customer customer2)
        {
            _customerDal.Add(customer1);
            _customerDal.Update(customer2);
        }
    }
}
