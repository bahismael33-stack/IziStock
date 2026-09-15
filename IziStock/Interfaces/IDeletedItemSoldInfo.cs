using IziStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IziStock.Interfaces
{
    interface IDeletedItemSoldInfo
    {
        /// <summary>
        /// returns an updated report
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ReportItemSold ItemSoldInfoWasDeleted(ItemSoldInfo model);
    }
}
