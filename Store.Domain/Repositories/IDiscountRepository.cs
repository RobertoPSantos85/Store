using System;
using Store.Domain.Entities;

namespace Store.Domain.Repositories.Interfaces
{
    public interface IDiscounRepository
    {
        Discount Get(string code);
    }
}