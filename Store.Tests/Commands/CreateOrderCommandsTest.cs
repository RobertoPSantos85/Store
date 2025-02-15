using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Store.Tests.Queries
{
	[TestClass]
	public class CreateOrderCommandTest
	{
		[TestMethod]
		[TestCategory("Handlers")]
		public void Dado_um_command_invalido_o_pedido_nao_deve_ser_gerado()
		{
			var command = new CreateOrderCommand();
			command.Customer = "";
			command.ZipCode = "13411080";
			command.PromoCode = "12345678";
			command.Items.Add(new CreateOrderItemCommand(Guid.NewGuid(), 1));
			command.Items.Add(new CreateOrderItemCommand(Guid.NewGuid(), 1));
			command.Validate();

			Assert.AreEqual(command.Valid, false);
		}
			
	}
	
}