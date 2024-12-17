using ELIXIRDEPOT.DATA.CORE.INTERFACES.BORROWED_INTERFACE;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.FUEL_REGISTER_INTERFACE;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.IMPORT_INTERFACE;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.INVENTORY_INTERFACE;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.Orders_Interface;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.REPORTS_INTERFACE;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.SETUP_INTERFACE;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.USER_INTERFACE;
using ELIXIRDEPOT.DATA.CORE.INTERFACES.WAREHOUSE_INTERFACE;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIRDEPOT.DATA.CORE.ICONFIGURATION
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        IRoleRepository Roles { get; }

        IModuleRepository Modules { get; }

        IUomRepository Uoms { get; }

        IMaterialRepository Materials { get; }

        ISupplierRepository Suppliers { get; }

        ICustomerRepository Customers { get; }

        ILotRepository Lots { get; }

        IReasonRepository Reasons { get; }

        ICompanyRepository Companies { get; }


        ILocationRepository Locations { get; }

        IPoSummaryRepository Imports { get; }

        IWarehouseReceiveRepository Receives { get; }

        IOrdering Orders { get; }

        IMiscellaneous miscellaneous { get; }

        IBorrowedItem Borrowed { get; }

        IMRPInventory Inventory { get; }

        ITransactType TransactType { get; }

        IReports Reports { get; }

        IFuelRegisterRepository FuelRegister { get; }


        Task CompleteAsync();


    }
}
