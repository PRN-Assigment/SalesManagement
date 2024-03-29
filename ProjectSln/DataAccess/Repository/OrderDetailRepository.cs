﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObject.BusinessObject;
using DataAccess.IRepository;
namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private MemberManagementContext context = new MemberManagementContext();

        public void Delete(int id)
        {
            TblOrderDetail target = GetRowByID(id);
            context.TblOrderDetails.Remove(target);
            context.SaveChanges();
        }

        public List<TblOrderDetail> GetList()
        {
            return context.TblOrderDetails.ToList();
        }

        public List<TblOrderDetail> getListByID(int orderID)
        {           
            return context.TblOrderDetails.Where(m => m.OrderId == orderID).ToList(); ;
        }

        public TblOrderDetail GetRowByID(int id)
        {
            TblOrderDetail order = new TblOrderDetail();
            order = context.TblOrderDetails.FirstOrDefault(x => x.OrderId == id);
            return order;
        }

        public TblOrderDetail getRow(int odID)
        {
            TblOrderDetail orders = context.TblOrderDetails.Where(m => m.OrderId == odID).FirstOrDefault();
            return orders;
        }

        public void Insert(TblOrderDetail od)
        {
            if (od != null)
            {
                var list = GetList();
                if(list.Count > 0)
                {
                    var last = list[list.Count - 1];
                    od.OrderId = last.OrderId + 1;
                } else
                {
                    od.OrderId = 1;
                }
                
                context.TblOrderDetails.Add(od);
                context.SaveChanges();
            }
        }

        public void Update(TblOrderDetail od)
        {
            int id = od.OrderId;
            TblOrderDetail newDetail = getRow(id);
            if(newDetail != null)
            {
                newDetail.OrderId = od.OrderId;
                newDetail.ProductId = od.ProductId;
                newDetail.UnitPrice = od.UnitPrice;
                newDetail.Quantity = od.Quantity;
                newDetail.Discount = od.Discount;
                context.SaveChanges();
            }
        }

        TblOrderDetail IOrderDetailRepository.getRow(int oddID)
        {
            throw new NotImplementedException();
        }
    }
}
