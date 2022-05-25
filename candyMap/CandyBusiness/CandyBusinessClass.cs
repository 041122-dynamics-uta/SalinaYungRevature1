using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CandyModels;
using CandyRepository;

//talks to repository
namespace CandyBusiness
{
    public class CandyBusinessClass
    {
        //inject dependency into the class
        private CandyRepoClass _repo { get; set; }
        public CandyBusinessClass(CandyRepoClass r) 
        {
            this._repo = r;
        }
        //get all products      
        public List<Products> ProductsList()
        {
            List<Products> pl = _repo.ProductsList();
            return pl;
        }
        public List<Stores> StoresList()
        {
            List<Stores> sl = _repo.StoresList();
            return sl;
        }
        public List<Customers> CustomersList()
        {
            List<Customers> cl = _repo.CustomersList();
            return cl;
        }
        public List<Orders> OrdersList()
        {
            List<Orders> ol = _repo.OrdersList();
            return ol;
        }
        public List<Products> ProductsAtStore1List()
        {
            List<Products> pasl = _repo.ProductsAtStore1List();
            return pasl;
        }
//------------------------------------------------------------------------------------------------
        public Customers NewCustomer(string FirstName, string LastName, string Email, string Pass)
        {
            //pass new data to repo layer
            //query db- check if data already exists
            Customers c = _repo.NewCustomer(FirstName, LastName, Email, Pass);
            return c;
        }
        public Customers EmailPassComboExists(string Email, string Pass)
        {
            Customers nc = _repo.EmailPassComboExists(Email, Pass);
            return nc;
        }
    }
}