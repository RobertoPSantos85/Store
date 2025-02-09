using System;
using System.Colections.Generic;
using Store.Domain.Commands;

namespace Store.Domain.Utils
{
    public static IEnumerable<Guid> Extract(IList<CreateOrderItemCommand> items)
    {
        var guids = new List<Guid>();
        foreach (var item in items)
            guids.Add(item.Product);

        return guids;
    }
}