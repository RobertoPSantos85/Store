using System;
using System.Collections.Generic;
using Store.Domain.Commands.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;
namespace Store.Domain.Commands
{
    public class CreteOrderItemCommand:Notifiable, ICommand
    {
        public CreteOrderItemCommand()
        {

        }

        public CreateOrderItemCommand(Guid product, int quantity)
        {
           Product = product;
           Quantity = quantity;
        }

        public Guid Product { get; set; }
        public int Quantity { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasLen(Product.ToString(), 32, "Product", "Produto inv�lido.")
                .IsGreaterThan(Quantity, 0, "Quantity", "Quantidade inv�lida."));
        }
    }
}
