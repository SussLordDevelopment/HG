using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
namespace HG.Projectiles
{
	public class HealthStream : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 14;
			projectile.aiStyle = 60;
			projectile.alpha = 255;
			projectile.penetrate = -1;
			projectile.extraUpdates = 2;
			projectile.ignoreWater = true;
		}
		public override void AI()
		{
			Dust dust81;
			int num2475;
			int num1761 = 175;
			Color newColor3 = new Color(255, 45, 0, 100);
			for (int num1760 = 0; num1760 < 6; num1760 = num2475 + 1)
			{
				Vector2 vector289 = projectile.velocity * (float)num1760 / 6f;
				int num1757 = 6;
				int num1756 = Dust.NewDust(projectile.position + Vector2.One * 6f, projectile.width - num1757 * 2, projectile.height - num1757 * 2, 4, 0f, 0f, num1761, newColor3, 1.2f);
				if (Main.rand.Next(2) == 0)
				{
					dust81 = Main.dust[num1756];
					dust81.alpha += 25;
				}
				if (Main.rand.Next(2) == 0)
				{
					dust81 = Main.dust[num1756];
					dust81.alpha += 25;
				}
				if (Main.rand.Next(2) == 0)
				{
					dust81 = Main.dust[num1756];
					dust81.alpha += 25;
				}
				Main.dust[num1756].noGravity = true;
				dust81 = Main.dust[num1756];
				dust81.velocity *= 0.3f;
				dust81 = Main.dust[num1756];
				dust81.velocity += projectile.velocity * 0.5f;
				Main.dust[num1756].position = projectile.Center;
				Dust expr_1801A_cp_0 = Main.dust[num1756];
				expr_1801A_cp_0.position.X = expr_1801A_cp_0.position.X - vector289.X;
				Dust expr_1803E_cp_0 = Main.dust[num1756];
				expr_1803E_cp_0.position.Y = expr_1803E_cp_0.position.Y - vector289.Y;
				dust81 = Main.dust[num1756];
				dust81.velocity *= 0.2f;
				num2475 = num1760;
			}
			if (Main.rand.Next(4) == 0)
			{
				int num1759 = 6;
				int num1758 = Dust.NewDust(projectile.position + Vector2.One * 6f, projectile.width - num1759 * 2, projectile.height - num1759 * 2, 4, 0f, 0f, num1761, newColor3, 1.2f);
				dust81 = Main.dust[num1758];
				dust81.velocity *= 0.5f;
				dust81 = Main.dust[num1758];
				dust81.velocity += projectile.velocity * 0.5f;
			}
			{
					Rectangle rectangle4 = new Rectangle((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height);
					for (int num1770 = 0; num1770 < 255; num1770 = num2475 + 1)
					{
						if (num1770 != projectile.owner && Main.player[num1770].active && !Main.player[num1770].dead)
						{
							Rectangle value158 = new Rectangle((int)Main.player[num1770].position.X, (int)Main.player[num1770].position.Y, Main.player[num1770].width, Main.player[num1770].height);
							if (rectangle4.Intersects(value158))
							{

							if (Main.player[num1770].statLife < Main.player[num1770].statLifeMax)
							{

								Main.player[num1770].statLife += 15;
							}
							}
						}
						num2475 = num1770;
					}
				}
			}
		}
	}
