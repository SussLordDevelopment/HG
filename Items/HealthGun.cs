using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HG.Items
{
	public class HealthGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Health Gun");
			Tooltip.SetDefault("Squirts a stream of health.");
		}

		


		public override void SetDefaults()
		{
			item.damage = 50;
			
			item.width = 42;
			item.height = 26;
			item.CloneDefaults(ItemID.SlimeGun);
			item.shoot = mod.ProjectileType("HealthStream");
			item.magic = true;
			item.mana = 5;
			

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeGun, 1);
			recipe.AddIngredient(ItemID.GreaterHealingPotion, 30);
			recipe.AddIngredient(ItemID.PinkGel, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		


	}
}