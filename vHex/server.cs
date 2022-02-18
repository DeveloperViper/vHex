using System;
using System.Collections.Generic;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace vHex
{
	public class server : BaseScript
	{
		[Command("hex")]
		public void Hex(int source, List<object> args, string raw)
		{
			Player player = Players[source];
			var steam = GetPlayerIdentifier(source.ToString(), 0);

			TriggerClientEvent(player, "chat:addMessage", new
			{
				color = new[] { 255, 0, 0 },
				multiline = true,
				args = new[] {steam}
			});

		}

	}
}
