﻿using System;
using System.Collections.Generic;
using DL;
using Models;

namespace StoreBL
{
    public class BL : IBL
    {
        private IRepo _repo;
        //dependency injection
        public BL(IRepo repo)
        {
            _repo = repo;
        }
        public List<StoreFront> GetAllStoreFronts()
        {
            return _repo.GetAllStoreFronts();
        }
        public Customer AddCustomer(Customer newCustomer)
        {
            return _repo.AddCustomer(newCustomer);
        }

        public LineItem AddLineItem(LineItem newItem)
        {
            return _repo.AddLineItem(newItem);
        }

        public Order AddOrder(Order newOrder)
        {
            return _repo.AddOrder(newOrder);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public List<Inventory> GetAllInventories(int storeID)
        {
            return _repo.GetAllInventories(storeID);
        }

        public List<LineItem> GetAllLineItems(int input)
        {
            return _repo.GetAllLineItems(input);
        }

        public List<Order> GetAllOrders()
        {
            return _repo.GetAllOrders();
        }

        public Inventory UpdateStoreInventory(Inventory newInventory)
        {
            return _repo.UpdateStoreInventory(newInventory);
        }
    }
}
