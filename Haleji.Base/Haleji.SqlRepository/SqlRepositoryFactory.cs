﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Haleji.BusinessObjects;
using Haleji.RepositoryBase;

namespace Haleji.SqlRepository
{
    public class SqlRepositoryFactory : RepositoryFactoryBase, IRepositoryFactory
    {
        public ILocationRepository LocationRepository
        {
            get
            {
                if (_locationRepository == null)
                    _locationRepository = new SqlLocationRepository();

                return _locationRepository;
            }
        }

        public IDepartmentRepository DepartmentRepository
        {
            get
            {
                if (_departmentRepository == null)
                    _departmentRepository = new SqlDepartmentRepository();

                return _departmentRepository;
            }
        }

        public IItemRepository ItemRepository {
            get {
                if (_itemRepository == null)
                    _itemRepository = new SqlItemRepository();

                return _itemRepository;
            }
        }

        public IMovementRepository MovementRepository
        {
            get
            {
                if (_movementRepository == null)
                    _movementRepository = new SqlMovementRepository();

                return _movementRepository;
            }
        }

        public IPersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new SqlPersonRepository();

                return _personRepository;
            }
        }

        public IPurchaseRepository PurchaseRepository
        {
            get
            {
                if (_purchaseRepository == null)
                    _purchaseRepository = new SqlPurchaseRepository();

                return _purchaseRepository;
            }
        }

        public IStockRepository StockRepository => throw new NotImplementedException();
        public IItemDetailsRepository ItemDetailsRepository
        {
            get
            {
                if (_itemdetailsRepository == null)
                    _itemdetailsRepository = new SqlItemDetailsRepository();

                return _itemdetailsRepository;
            }
        }
        public IPurchaseDetailsRepository PurchaseDetailsRepository
        {
            get
            {
                if (_purchasedetailsRepository == null)
                    _purchasedetailsRepository = new SqlPurchaseDetailsRepository();

                return _purchasedetailsRepository;
            }

        }

        public IVendorRepository VendorRepository
        {
            get
            {
                if (_vendorRepository == null)
                    _vendorRepository = new SqlVendorRepository();

                return _vendorRepository;
            }
        }
    }
}
