using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Projectiles
{
	public class SandstormJavelinProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sandstorm Javelin");
			Main.projFrames[projectile.type] = 1;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(507);
			aiType = 507;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			if(Main.rand.Next(2)==0) {
				Item.NewItem(projectile.position, 32, 32, ItemType<Items.Weapons.Throwables.SandstormJavelin>());
			}
			return true;
		}
	}
}